using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace _18
{
    public partial class MenuSport : Form
    {

        DataBaseHandler DBHandler;
        DataTable dt;
        List<SportsMan> sportsMens;
        List<Trener> treners;
        string outputFile = AppDomain.CurrentDomain.BaseDirectory + "report.xlsx";

        string selectedTable { get; set; }
        string conn = "Host=25.40.105.149;Username=admin;Password=admin;Database=dblesson";

        public MenuSport()
        {
            InitializeComponent();
            Connect();
        }

        int getID()
        {
            int i = dataGrid.SelectedCells[0].RowIndex;
            DataGridViewCellCollection cellColl = dataGrid.Rows[i].Cells;
            int id = Convert.ToInt32(cellColl[0].Value);
            return id;
        }

        void Connect()
        {
            DBHandler = new DataBaseHandler(conn);

            DBHandler.Select("SELECT * FROM SportsMan ORDER BY Id");
            dt = DBHandler.GetTable();
            DBHandler.sportsMans = getSportsmenList();

            DBHandler.Select("SELECT * FROM Trener ORDER BY Id");
            dt = DBHandler.GetTable();
            DBHandler.treners = getTrenerList();
        }

        void InitializeSMGrid()
        {
            dataGrid.AutoGenerateColumns = true;
            DBHandler.Select("SELECT * FROM SportsMan ORDER BY Id");
            dt = DBHandler.GetTable();
            dataGrid.DataSource = dt;
            dt.TableName = "sm";
        }

        void InitializeTRGrid()
        {
            dataGrid.AutoGenerateColumns = true;
            DBHandler.Select("SELECT * FROM Trener ORDER BY Id");
            dt = DBHandler.GetTable();
            dataGrid.DataSource = dt;
            dt.TableName = "tr";
        }

        List<SportsMan> getSportsmenList()
        {
            sportsMens = new List<SportsMan>();
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
            return sportsMens;
        }

        List<Trener> getTrenerList()
        {
            treners = new List<Trener>();
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
            return treners;
        }

        void openForm(string method, string tableName)
        {
            AddChangeSMForm smForm;
            AddChangeTrForm trForm;

            if (tableName == "Sportsman")
            {
                switch (method)
                {
                    case "Insert":
                        smForm = new AddChangeSMForm(method, DBHandler, getID());
                        smForm.ShowDialog();
                        InitializeSMGrid();
                        break;
                    case "Update":
                        smForm = new AddChangeSMForm(method, DBHandler, getID());
                        smForm.ShowDialog();
                        InitializeSMGrid();
                        break;
                }
            }

            if (tableName == "Trener")
            {
                switch (method)
                {
                    case "Insert":
                        trForm = new AddChangeTrForm(method, DBHandler, getID());
                        trForm.ShowDialog();
                        InitializeTRGrid();
                        break;
                    case "Update":
                        trForm = new AddChangeTrForm(method, DBHandler, getID());
                        trForm.ShowDialog();
                        InitializeTRGrid();
                        break;
                }
            }
        }

        private void stripButton1_Click(object sender, EventArgs e)
        {
            InitializeSMGrid();
            selectedTable = "Sportsman";
        }

        private void stripButton2_Click(object sender, EventArgs e)
        {
            InitializeTRGrid();
            selectedTable = "Trener";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            openForm("Insert", selectedTable);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            openForm("Update", selectedTable);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DBHandler.Remove($"Delete from Trener where id = {getID()}");
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            DBHandler.GetQuery($"SELECT COUNT(*) FROM {selectedTable}");
            MessageBox.Show($"{DBHandler.GetQuery()}");
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (selectedTable == null) { MessageBox.Show("Выберите таблицу"); return; }

            OptionsForm optionsForm = new OptionsForm(selectedTable);
            optionsForm.ShowDialog();

            Options options = optionsForm.GetOptions() as Options;

            BDQueryResult query = new BDQueryResult(dt, DBHandler);

            if (options == null) { return; }

            switch (options.Mode)
            {
                //case "Lockup":
                //    query.ExecuteLockup(selectedTable, options.KeyFields, options.KeyValue);
                //    query.ShowDialog();
                //    break;

                case "Locate":
                    query.ExecuteLocate(selectedTable, options.KeyFields, options.KeyValue);
                    query.ShowDialog();
                    break;

                case "Spetific":
                    query.ExecuteSpetific(options.KeyValue, selectedTable);
                    query.ShowDialog();
                    break;
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ReportExcel report = new ReportExcel();
            DataSet ds = new DataSet("table");
            ds.Tables.Clear();
            ds.Tables.Add(dt);
            report.ExportToExcel(ds, outputFile);
        }

        private void diagramButton_Click(object sender, EventArgs e)
        {
            if (selectedTable == null || dt == null) { MessageBox.Show("Выберите таблицу"); return; }
            DiagramForm form = new DiagramForm(dt);
            form.ShowDialog();
        }
    }
}