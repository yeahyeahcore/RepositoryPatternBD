using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18
{
    public partial class OptionsForm : Form
    {
        List<string> tableSM;
        List<string> tableTR;

        Options options;

        public object GetOptions()
        { return options; }

        public OptionsForm(string table)
        {
            InitializeComponent();
            InitializeTableList(table);
        }

        object[] returnTableSM()
        {
            tableSM = new List<string>();
            tableSM.Add("FName");
            tableSM.Add("LName");
            tableSM.Add("PName");
            tableSM.Add("Sex");
            tableSM.Add("City");
            return tableSM.ToArray();
        }

        object[] returnTableTR()
        {
            tableTR = new List<string>();
            tableTR.Add("FName");
            tableTR.Add("LName");
            tableTR.Add("PName");
            tableTR.Add("Sex");
            tableTR.Add("City");
            return tableTR.ToArray();
        }

        void InitializeTableList(string table)
        {
            switch(table)
            {
                case "Sportsman":
                    tableListBox.Items.AddRange(returnTableSM());
                    break;
                case "Trener":
                    tableListBox.Items.AddRange(returnTableTR());
                    break;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (modeBox.SelectedItem.ToString() == null)
            { MessageBox.Show("Выберите режим поиска"); return; }

            options = new Options();
            string mode = modeBox.SelectedItem.ToString();
            options.Mode = mode;

            switch(mode)
            {
                case "Lockup":
                    options.SetLockup(tableListBox.SelectedItem.ToString(), valueTextBox.Text);
                    break;
                case "Locate":
                    options.SetLocate(tableListBox.SelectedItem.ToString(), valueTextBox.Text);
                    break;
                case "Spetific":
                    options.SetSpetific(valueTextBox.Text);
                    break;
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    class Options
    {
        public string KeyFields { get; private set; }
        public string KeyValue { get; private set; }
        public string Mode { get; set; }

        public void SetLockup(string field, string value)
        {
            if (IsNull(value))
            { MessageBox.Show("Введите значение"); return; }

            KeyFields = field;
            KeyValue = value;
        }

        public void SetLocate(string field, string value)
        {
            if (IsNull(value))
            { MessageBox.Show("Введите значение"); return; }
            if (IsNull(field))
            { MessageBox.Show("Выберите поля"); return; }

            KeyFields = field;
            KeyValue = value; 
        }

        public void SetSpetific(string value)
        {
            if (IsNull(value))
            { MessageBox.Show("Введите значение"); return; }

            KeyValue = value;
        }

        bool IsNull(string value)
        { bool b = value == null ? true : false; return b; }
    }
}
