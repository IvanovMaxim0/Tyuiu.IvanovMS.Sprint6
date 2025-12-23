using Tyuiu.IvanovMS.Sprint6.Task7.V14.Lib;
namespace Tyuiu.IvanovMS.Sprint6.Task7.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        static int columns;
        static int rows;
        public static int[,] ReadFile(string path)
        {
            string FileData = File.ReadAllText(path);
            FileData = FileData.Replace('\n', '\r');

            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line[j]);
                }
            }
            return array;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOpenFile_IMS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_IMS.ShowDialog();
            openFilePath = openFileDialogTask_IMS.FileName;
            int[,] array = new int[rows, columns];

            array = ReadFile(openFilePath);

            dataGridViewInput_IMS.RowCount = rows;
            dataGridViewInput_IMS.ColumnCount = columns;
            dataGridViewOutput_IMS.RowCount = rows;
            dataGridViewOutput_IMS.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_IMS.Columns[i].Width = 25;
                dataGridViewOutput_IMS.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput_IMS.Rows[i].Cells[j].Value = array[i, j];
                }
            }
            array = ds.GetMatrix(openFilePath);
            buttonDone_IMS.Enabled = true;
        }

        private void buttonDone_IMS_Click(object sender, EventArgs e)
        {
            int[,] res = new int[rows, columns];
            res = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutput_IMS.Rows[i].Cells[j].Value = res[i, j];
                }
            }
            buttonSave_IMS.Enabled = true;
        }

        private void buttonAbout_IMS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog_IMS.FileName = "OutputTask7.csv";
            saveFileDialog_IMS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_IMS.ShowDialog();

            string path = saveFileDialog_IMS.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            if (fileexists)
            {
                fileinfo.Delete();
            }
            int rows = dataGridViewOutput_IMS.RowCount;
            int columns = dataGridViewOutput_IMS.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != (columns - 1))
                    {
                        str += dataGridViewOutput_IMS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutput_IMS.Rows[i].Cells[j].Value;
                    }

                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_IMS_MouseEnter(object sender, EventArgs e)
        {
            toolTip1_IMS.ToolTipTitle = "Открыть файл";
        }

        private void toolTip1_IMS_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonDone_IMS_MouseEnter(object sender, EventArgs e)
        {
            toolTip1_IMS.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_IMS_MouseEnter(object sender, EventArgs e)
        {
            toolTip1_IMS.ToolTipTitle = "Сохранить";
        }

        private void buttonAbout_IMS_MouseEnter(object sender, EventArgs e)
        {
            toolTip1_IMS.ToolTipTitle = "Справка";
        }
    }
}
