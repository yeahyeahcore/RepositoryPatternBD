using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _18
{
    public partial class DiagramForm : Form
    {

        DataTable dt;
        public DiagramForm(DataTable dt)
        {
            this.dt = dt;

            InitializeComponent();
            InitializeDiagram();
        }

        void InitializeDiagram()
        {
            switch(dt.TableName)
            {
                case "sm":
                    CreateChart1(dt.TableName, "Birthday");
                    CreateChart2(dt.TableName, "Birthday");
                    break;
                case "tr":
                    CreateChart1(dt.TableName, "Rating");
                    CreateChart2(dt.TableName, "Rating");
                    break;
            }
            
            chart1.DataBind();
        }

        void CreateChart1(string tableName, string series)
        {
            string title = tableName == "sm" ? "Спортсмены" : "Тренера";

            chart1.Series.Clear();

            chart1.BackColor = Color.White;
            chart1.BackSecondaryColor = Color.WhiteSmoke;
            chart1.BackGradientStyle = GradientStyle.DiagonalRight;

            chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            chart1.BorderlineColor = Color.Gray;
            chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            chart1.ChartAreas[0].BackColor = Color.Wheat;

            chart1.Titles.Add(title);
            chart1.Titles[0].Font = new Font("Utopia", 16);

            chart1.Series.Add(new Series(series)
            {
                ChartType = SeriesChartType.Pie
            });

            chart1.Series[series].XValueMember = series;
            chart1.Series[series].YValueMembers = series;
            chart1.DataSource = dt;
        }

        void CreateChart2(string tableName, string series)
        {
            string title = tableName == "sm" ? "Спортсмены" : "Тренера";
            
            chart2.Series.Clear();
            // Форматировать диаграмму
            chart2.BackColor = Color.Gray;
            chart2.BackSecondaryColor = Color.WhiteSmoke;
            chart2.BackGradientStyle = GradientStyle.DiagonalRight;

            chart2.BorderlineDashStyle = ChartDashStyle.Solid;
            chart2.BorderlineColor = Color.Gray;
            chart2.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            // Форматировать область диаграммы
            chart2.ChartAreas[0].BackColor = Color.Wheat;

            // Добавить и форматировать заголовок
            chart2.Titles.Add(title);
            chart2.Titles[0].Font = new Font("Utopia", 16);

            chart2.Series.Add(new Series(series)
            {
                ChartType = SeriesChartType.Line
            });

            chart2.Series[series].XValueMember = series;
            chart2.Series[series].YValueMembers = series;
            chart2.DataSource = dt;

        }
    }
}
