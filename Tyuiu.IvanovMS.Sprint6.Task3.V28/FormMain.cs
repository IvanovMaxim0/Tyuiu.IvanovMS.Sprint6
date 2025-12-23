using System.Security.Cryptography.X509Certificates;
using Tyuiu.IvanovMS.Sprint6.Task3.V28.Lib;
namespace Tyuiu.IvanovMS.Sprint6.Task3.V28
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -9, 8, 9, 16, -18 },
                                  { -13, -11, -20, -15, 9 },
                                  { 18, 13, -12, -15, -11 },
                                  { 10, -2, 19, -4, -10 },
                                  { 6, -20, -4, 13, -14} };

        public FormMain()
        { 
            InitializeComponent();
        }
        private void buttonDone_IMS_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);

            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;

            dataGridViewRes_IMS.ColumnCount = columns;
            dataGridViewRes_IMS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewRes_IMS.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewRes_IMS.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_IMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТБ-25-1 Иванов Максим Сергеевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void groupBoxTask_IMS_Enter(object sender, EventArgs e)
        {
            //
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_IMS.ColumnCount = columns;
            dataGridViewMatrix_IMS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_IMS.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_IMS.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void dataGridViewRes_IMS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}
