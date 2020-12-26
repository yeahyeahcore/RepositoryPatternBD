using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _18
{
    public partial class AddChangeSMForm : Form
    {
        DataBaseHandler db;
        SportsMan sm;
        string cmd;
        int id;
        string mode;

        bool IsEmpy()
        {
            bool empty = false;
            foreach (Control c in Controls)
            {
                if (Trener_IdBox.SelectedItem == null) { return true; }
                else if (c is TextBox)
                {
                    if (c.Text == "") { return true; }
                    else { return false; }
                }
            }
            return empty;
        }

        public AddChangeSMForm(string mode, object db, int id)
        {
            this.db = db as DataBaseHandler;
            this.id = id;
            this.mode = mode;

            InitializeComponent();
            if (mode == "Update")
            { InitializeForm(); }

            for (int i = 0; i < this.db.treners.Count; i++)
                Trener_IdBox.Items.Add(this.db.treners[i].LName);
        }

        private void InitializeStruct()
        {
            sm = new SportsMan();
            int id = 0;

            for (int i = 0; i < this.db.treners.Count; i++)
                if (Trener_IdBox.SelectedItem.ToString() == this.db.treners[i].LName)
                    id = this.db.treners[i].Id;

            sm.Trener_Id = id;
            sm.FName = Regex.Replace(FNameBox.Text, @"\s+", "");
            sm.LName = Regex.Replace(LNameBox.Text, @"\s+", "");
            sm.PName = Regex.Replace(PNameBox.Text, @"\s+", "");
            sm.Sex = Regex.Replace(SexBox.Text, @"\s+", "");
            sm.BirthDay = Convert.ToInt16(BirthDayBox.Text);
            sm.City = Regex.Replace(CityBox.Text, @"\s+", "");
        }

        private void InitializeForm()
        {
            for (int i = 0; i < this.db.sportsMans.Count; i++)
                if (this.db.sportsMans[i].Id == this.id)
                {
                    FNameBox.Text = Regex.Replace(this.db.sportsMans[i].FName, @"\s+", "");
                    LNameBox.Text = Regex.Replace(this.db.sportsMans[i].LName, @"\s+", "");
                    PNameBox.Text = Regex.Replace(this.db.sportsMans[i].PName, @"\s+", "");
                    SexBox.Text = Regex.Replace(this.db.sportsMans[i].Sex, @"\s+", "");
                    BirthDayBox.Text = Regex.Replace(this.db.sportsMans[i].BirthDay.ToString(), @"\s+", "");
                    CityBox.Text = Regex.Replace(this.db.sportsMans[i].City, @"\s+", "");
                }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsEmpy())
            { MessageBox.Show("Заполните недостающие элементы"); return; }
            InitializeStruct();

            switch (mode)
            {
                case "Insert":
                    this.cmd = "Insert into SportsMan " +
                           "(trener_id, fname, lname, pname, sex, birthday, city) " +
                           $"values ('{sm.Trener_Id}', '{sm.FName}', '{sm.LName}', '{sm.PName}', '{sm.Sex}', '{sm.BirthDay}', '{sm.City}')";
                    db.Insert(this.cmd);
                    break;

                case "Update":
                    this.cmd = "Update SportsMan Set " +
                        "(trener_id, fname, lname, pname, sex, birthday, city) = " +
                        $"('{sm.Trener_Id}', '{sm.FName}', '{sm.LName}', '{sm.PName}', '{sm.Sex}', '{sm.BirthDay}', '{sm.City}') " +
                        $"where id = {id}";
                    db.Update(cmd);
                    break;
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BirthDayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}

