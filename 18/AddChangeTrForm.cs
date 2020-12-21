using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _18
{
    public partial class AddChangeTrForm : Form
    {
        DataBaseHandler db;
        Trener tr;
        string cmd;
        int id;
        string mode;

        public AddChangeTrForm(string mode, object db, int id)
        {
            this.mode = mode;
            this.db = db as DataBaseHandler;
            this.id = id;

            InitializeComponent();
            InitializeForm();

            for (int i = 1; i <= 10; i++)
                RatingBox.Items.Add(i);
        }

        bool IsEmpy()
        {
            bool empty = false;
            foreach (Control c in Controls)
            {
                if (RatingBox.SelectedItem == null) { return true; }
                else if (c is TextBox)
                {
                    if (c.Text == "") { return true; }
                    else { return false; }
                }
            }
            return empty;
        }

        private void InitializeForm()
        {
            for (int i = 0; i < this.db.treners.Count; i++)
                if (this.db.treners[i].Id == this.id)
                {
                    FNameBox.Text = Regex.Replace(this.db.treners[i].FName, @"\s+", "");
                    LNameBox.Text = Regex.Replace(this.db.treners[i].LName, @"\s+", "");
                    PNameBox.Text = Regex.Replace(this.db.treners[i].PName, @"\s+", "");
                    SexBox.Text = Regex.Replace(this.db.treners[i].Sex, @"\s+", "");
                    BirthDayBox.Text = Regex.Replace(this.db.treners[i].BirthDay.ToString(), @"\s+", "");
                    CityBox.Text = Regex.Replace(this.db.treners[i].City, @"\s+", "");
                    RatingBox.Text = Regex.Replace(this.db.treners[i].Rating.ToString(), @"\s+", "");
                }
        }

        private void InitializeStruct()
        {
            tr = new Trener();
            tr.Rating = Convert.ToInt16(RatingBox.SelectedItem);
            tr.FName = FNameBox.Text;
            tr.LName = LNameBox.Text;
            tr.PName = PNameBox.Text;
            tr.Sex = SexBox.Text;
            tr.BirthDay = Convert.ToInt16(BirthDayBox.Text);
            tr.City = CityBox.Text;
        }

        private void BirthDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
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
                    this.cmd = "Insert into Trener " +
                        "(fname, lname, pname, sex, birthday, city, rating) " +
                        $"values ('{tr.FName}', '{tr.LName}', '{tr.PName}', '{tr.Sex}', '{tr.BirthDay}', '{tr.City}', '{tr.Rating}')";
                    db.Insert(cmd);
                    break;

                case "Update":
                    this.cmd = "Update Trener Set" +
                        "(fname, lname, pname, sex, birthday, city, rating) = " +
                        $"('{tr.FName}', '{tr.LName}', '{tr.PName}', '{tr.Sex}', '{tr.BirthDay}', '{tr.City}', '{tr.Rating}') " +
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
    }
}
