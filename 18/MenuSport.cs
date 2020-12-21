using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;

namespace _18
{
    public partial class MenuSport : Form
    {

        DataBaseHandler DBHandler;
        DataTable dt;
        List<SportsMan> sportsMens = new List<SportsMan>();
        List<Trener> treners = new List<Trener>();

        string conn = "Host=25.40.105.149;Username=admin;Password=admin;Database=dblesson";

        public MenuSport()
        {
            InitializeComponent();
            Connect();
        }

        int getSportsManID()
        {
            int i = SportsManGrid.SelectedCells[0].RowIndex;
            DataGridViewCellCollection cellColl = SportsManGrid.Rows[i].Cells;
            int id = Convert.ToInt32(cellColl[0].Value);
            return id;
        }

        int getTrenerID()
        {
            int i = TrenerGrid.SelectedCells[0].RowIndex;
            DataGridViewCellCollection cellColl = TrenerGrid.Rows[i].Cells;
            int id = Convert.ToInt32(cellColl[0].Value);
            return id;
        }

        void Connect()
        {
            DBHandler = new DataBaseHandler(conn);

            SportsManGrid.AutoGenerateColumns = true;
            TrenerGrid.AutoGenerateColumns = true;

            DBHandler.Select("SELECT * FROM SportsMan ORDER BY Id");
            dt = DBHandler.GetTable();
            SportsManGrid.DataSource = dt;

            sportsMens = (from DataRow row in dt.Rows
                            select new SportsMan()
                            {
                                Id = Convert.ToInt16(row["id"]),
                                Trener_Id = Convert.ToInt16(row["Trener_Id"]),
                                FName = Convert.ToString(row["FName"]),
                                LName = Convert.ToString(row["LName"]),
                                PName = Convert.ToString(row["PName"]),
                                Sex = Convert.ToString(row["Sex"]),
                                BirthDay = Convert.ToInt16(row["BirthDay"]),
                                City = Convert.ToString(row["City"]),
                            }).ToList();
            
            DBHandler.sportsMans = sportsMens;

            DBHandler.Select("SELECT * FROM Trener ORDER BY Id");
            dt = DBHandler.GetTable();
            TrenerGrid.DataSource = dt;

            treners = (from DataRow row in dt.Rows
                        select new Trener()
                        {
                            Id = Convert.ToInt16(row["Id"]),
                            FName = Convert.ToString(row["FName"]),
                            LName = Convert.ToString(row["LName"]),
                            PName = Convert.ToString(row["PName"]),
                            Sex = Convert.ToString(row["Sex"]),
                            BirthDay = Convert.ToInt16(row["BirthDay"]),
                            City = Convert.ToString(row["City"]),
                            Rating = Convert.ToInt16(row["Rating"]),
                        }).ToList();
            
            DBHandler.treners = treners;
        }

        private void AddTrButton_Click(object sender, EventArgs e)
        {
            AddChangeTrForm form = new AddChangeTrForm("Insert", DBHandler, getTrenerID());
            form.ShowDialog();
            Connect();
        }

        private void AddSMButton_Click(object sender, EventArgs e)
        {
            AddChangeSMForm form = new AddChangeSMForm("Insert", DBHandler, getSportsManID());
            form.ShowDialog();
            Connect();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string cmd = $"Delete from SportsMan where id = {getSportsManID()}";
            DBHandler.Remove(cmd);
            Connect();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            AddChangeTrForm form = new AddChangeTrForm("Update", DBHandler, getTrenerID());
            form.ShowDialog();
            Connect();
        }

        private void ChangeSM_Click(object sender, EventArgs e)
        {
            AddChangeSMForm form = new AddChangeSMForm("Update", DBHandler, getSportsManID());
            form.ShowDialog();
            Connect();
        }

        private void RemoveTR_Click(object sender, EventArgs e)
        {
            string cmd = $"Delete from Trener where id = {getTrenerID()}";
            DBHandler.Remove(cmd);
            Connect();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            DBHandler.GetQuery("SELECT COUNT(*) FROM SportsMan");
            MessageBox.Show($"{DBHandler.GetQuery()}");
        }

        private void trCountButton_Click(object sender, EventArgs e)
        {
            DBHandler.GetQuery("SELECT COUNT(*) FROM Trener");
            MessageBox.Show($"{DBHandler.GetQuery()}");
        }

        private void SelectNotAllSMButton_Click(object sender, EventArgs e)
        {
            if(cityBox.Text == "")
            { MessageBox.Show("Введите город"); return; }

            SMBDQueryResult form = new SMBDQueryResult(dt, DBHandler, Regex.Replace(cityBox.Text, @"\s+", ""));
            form.ShowDialog();
        }
    }
}