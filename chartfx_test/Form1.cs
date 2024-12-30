using ChartFX.WinForms;
using System.Data;
using System.Windows.Forms;

namespace chartfx_test
{
    public partial class Form1 : Form
    {
        private static DataTable GetDataTable()
        {
            DataTable table = new DataTable("Scores");

            // 定義欄位
            table.Columns.Add("group", typeof(string));
            table.Columns.Add("value", typeof(int));
            table.Columns.Add("value2", typeof(int));

            // 插入資料
            table.Rows.Add("AAA", 555, 20);
            table.Rows.Add("BBB", 590, null);
            table.Rows.Add("CCC", 575, null);
            table.Rows.Add("DDD", null, null);
            table.Rows.Add("EEE", 580, 55);
            return table;
        }

        public Form1()
        {
            InitializeComponent();

            var dt = GetDataTable();
            chart1.DataSource = dt;
            chart1.Gallery = Gallery.Lines;

            chart1.Data.InterpolateHidden = true;

            SeriesAttributes series1 = chart1.Series[1];
            series1.AxisY = chart1.AxisY2;
        }
    }
}
