using System.Drawing.Drawing2D;
using Tyuiu.BerezovskiyAS.Sprint6.Task3.V16.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint6.Task3.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = { { 14, 1, -3, 1, 10},
                             { 7, -3, 5, -4, 0 },
                             { -10, -19, -18, -9, 19 },
                             { -2, -2, -16, 2, -17 },
                             { -16, 9, 5, -10, 16 } };
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewTask_BLG.ColumnCount = columns;
            dataGridViewTask_BLG.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewTask_BLG.Columns[i].Width = 100;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewTask_BLG.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
        private void buttonDone_BLG_Click(object sender, EventArgs e)
        {
            int countRows = 5;
            int countColumns = 5;
            int[,] resultArray = new int[countRows, countColumns];
            resultArray = ds.Calculate(matrix);
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            dataGridViewResult_BLG.ColumnCount = columns;
            dataGridViewResult_BLG.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_BLG.Columns[i].Width = 65;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_BLG.Rows[i].Cells[j].Value = Convert.ToString(resultArray[i, j]);
                }
            }

        }
        private void buttonHelp_BLG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("???? 3 ???????? ??????? ?????? ??????-25-1 ??????? ??????? ??????????", "?????????");
        }

    }
}
