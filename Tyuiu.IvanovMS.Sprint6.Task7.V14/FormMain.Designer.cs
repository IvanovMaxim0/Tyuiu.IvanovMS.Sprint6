namespace Tyuiu.IvanovMS.Sprint6.Task7.V14
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_IMS = new Panel();
            buttonSave_IMS = new Button();
            buttonAbout_IMS = new Button();
            buttonDone_IMS = new Button();
            buttonOpenFile_IMS = new Button();
            panelCondition_IMS = new Panel();
            groupBoxCondition_IMS = new GroupBox();
            labelCondition_IMS = new Label();
            splitContainerInputOutput_IMS = new SplitContainer();
            groupBoxInput_IMS = new GroupBox();
            dataGridViewInput_IMS = new DataGridView();
            groupBoxOutput_IMS = new GroupBox();
            dataGridViewOutput_IMS = new DataGridView();
            openFileDialogTask_IMS = new OpenFileDialog();
            toolTip1_IMS = new ToolTip(components);
            saveFileDialog_IMS = new SaveFileDialog();
            panelButtons_IMS.SuspendLayout();
            panelCondition_IMS.SuspendLayout();
            groupBoxCondition_IMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerInputOutput_IMS).BeginInit();
            splitContainerInputOutput_IMS.Panel1.SuspendLayout();
            splitContainerInputOutput_IMS.Panel2.SuspendLayout();
            splitContainerInputOutput_IMS.SuspendLayout();
            groupBoxInput_IMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_IMS).BeginInit();
            groupBoxOutput_IMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_IMS).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_IMS
            // 
            panelButtons_IMS.Controls.Add(buttonSave_IMS);
            panelButtons_IMS.Controls.Add(buttonAbout_IMS);
            panelButtons_IMS.Controls.Add(buttonDone_IMS);
            panelButtons_IMS.Controls.Add(buttonOpenFile_IMS);
            panelButtons_IMS.Dock = DockStyle.Top;
            panelButtons_IMS.Location = new Point(0, 0);
            panelButtons_IMS.Name = "panelButtons_IMS";
            panelButtons_IMS.Size = new Size(800, 62);
            panelButtons_IMS.TabIndex = 0;
            // 
            // buttonSave_IMS
            // 
            buttonSave_IMS.Enabled = false;
            buttonSave_IMS.FlatStyle = FlatStyle.Flat;
            buttonSave_IMS.Image = (Image)resources.GetObject("buttonSave_IMS.Image");
            buttonSave_IMS.Location = new Point(154, 3);
            buttonSave_IMS.Name = "buttonSave_IMS";
            buttonSave_IMS.Size = new Size(50, 50);
            buttonSave_IMS.TabIndex = 2;
            toolTip1_IMS.SetToolTip(buttonSave_IMS, "Сохранить в файл\r\nСохранить обработанные данные в файл CSV");
            buttonSave_IMS.UseVisualStyleBackColor = true;
            //buttonSave_IMS.Click += button1_Click;
            //buttonSave_IMS.MouseEnter += buttonSave_IMS_MouseEnter;
            // 
            // buttonAbout_IMS
            // 
            buttonAbout_IMS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_IMS.FlatStyle = FlatStyle.Flat;
            //buttonAbout_IMS.Image = Properties.Resources.Help;
            buttonAbout_IMS.Location = new Point(738, 3);
            buttonAbout_IMS.Name = "buttonAbout_IMS";
            buttonAbout_IMS.Size = new Size(50, 50);
            buttonAbout_IMS.TabIndex = 1;
            toolTip1_IMS.SetToolTip(buttonAbout_IMS, "Справка\r\nСведения о программе");
            buttonAbout_IMS.UseVisualStyleBackColor = true;
            //buttonAbout_IMS.Click += buttonAbout_IMS_Click;
            //buttonAbout_IMS.MouseEnter += buttonAbout_IMS_MouseEnter;
            // 
            // buttonDone_IMS
            // 
            buttonDone_IMS.Enabled = false;
            buttonDone_IMS.FlatStyle = FlatStyle.Flat;
            //buttonDone_IMS.Image = Properties.Resources.Done;
            buttonDone_IMS.Location = new Point(83, 3);
            buttonDone_IMS.Name = "buttonDone_IMS";
            buttonDone_IMS.Size = new Size(50, 50);
            buttonDone_IMS.TabIndex = 0;
            toolTip1_IMS.SetToolTip(buttonDone_IMS, "Запустить выполнение программы");
            buttonDone_IMS.UseVisualStyleBackColor = true;
            //buttonDone_IMS.Click += buttonDone_IMS_Click;
            //buttonDone_IMS.MouseEnter += buttonDone_IMS_MouseEnter;
            // 
            // buttonOpenFile_IMS
            // 
            buttonOpenFile_IMS.FlatStyle = FlatStyle.Flat;
            //buttonOpenFile_IMS.Image = Properties.Resources.Download2;
            buttonOpenFile_IMS.Location = new Point(12, 3);
            buttonOpenFile_IMS.Name = "buttonOpenFile_IMS";
            buttonOpenFile_IMS.Size = new Size(50, 50);
            buttonOpenFile_IMS.TabIndex = 0;
            toolTip1_IMS.SetToolTip(buttonOpenFile_IMS, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_IMS.UseVisualStyleBackColor = true;
            //buttonOpenFile_IMS.Click += buttonOpenFile_IMS_Click;
            //buttonOpenFile_IMS.MouseEnter += buttonOpenFile_IMS_MouseEnter;
            // 
            // panelCondition_IMS
            // 
            panelCondition_IMS.Controls.Add(groupBoxCondition_IMS);
            panelCondition_IMS.Dock = DockStyle.Top;
            panelCondition_IMS.Location = new Point(0, 62);
            panelCondition_IMS.Name = "panelCondition_IMS";
            panelCondition_IMS.Size = new Size(800, 66);
            panelCondition_IMS.TabIndex = 1;
            // 
            // groupBoxCondition_IMS
            // 
            groupBoxCondition_IMS.Controls.Add(labelCondition_IMS);
            groupBoxCondition_IMS.Dock = DockStyle.Fill;
            groupBoxCondition_IMS.Location = new Point(0, 0);
            groupBoxCondition_IMS.Name = "groupBoxCondition_IMS";
            groupBoxCondition_IMS.Size = new Size(800, 66);
            groupBoxCondition_IMS.TabIndex = 0;
            groupBoxCondition_IMS.TabStop = false;
            groupBoxCondition_IMS.Text = "Условие";
            // 
            // labelCondition_IMS
            // 
            labelCondition_IMS.Dock = DockStyle.Fill;
            labelCondition_IMS.Location = new Point(3, 19);
            labelCondition_IMS.Name = "labelCondition_IMS";
            labelCondition_IMS.Size = new Size(794, 44);
            labelCondition_IMS.TabIndex = 0;
            labelCondition_IMS.Text = resources.GetString("labelCondition_IMS.Text");
            // 
            // splitContainerInputOutput_IMS
            // 
            splitContainerInputOutput_IMS.Dock = DockStyle.Fill;
            splitContainerInputOutput_IMS.Location = new Point(0, 128);
            splitContainerInputOutput_IMS.Name = "splitContainerInputOutput_IMS";
            // 
            // splitContainerInputOutput_IMS.Panel1
            // 
            splitContainerInputOutput_IMS.Panel1.Controls.Add(groupBoxInput_IMS);
            //splitContainerInputOutput_IMS.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainerInputOutput_IMS.Panel2
            // 
            splitContainerInputOutput_IMS.Panel2.Controls.Add(groupBoxOutput_IMS);
            splitContainerInputOutput_IMS.Size = new Size(800, 322);
            splitContainerInputOutput_IMS.SplitterDistance = 362;
            splitContainerInputOutput_IMS.TabIndex = 2;
            // 
            // groupBoxInput_IMS
            // 
            groupBoxInput_IMS.Controls.Add(dataGridViewInput_IMS);
            groupBoxInput_IMS.Dock = DockStyle.Fill;
            groupBoxInput_IMS.Location = new Point(0, 0);
            groupBoxInput_IMS.Name = "groupBoxInput_IMS";
            groupBoxInput_IMS.Size = new Size(362, 322);
            groupBoxInput_IMS.TabIndex = 0;
            groupBoxInput_IMS.TabStop = false;
            groupBoxInput_IMS.Text = "Ввод ";
            // 
            // dataGridViewInput_IMS
            // 
            dataGridViewInput_IMS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewInput_IMS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_IMS.ColumnHeadersVisible = false;
            dataGridViewInput_IMS.Dock = DockStyle.Fill;
            dataGridViewInput_IMS.Location = new Point(3, 19);
            dataGridViewInput_IMS.Name = "dataGridViewInput_IMS";
            dataGridViewInput_IMS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewInput_IMS.RowHeadersVisible = false;
            dataGridViewInput_IMS.Size = new Size(356, 300);
            dataGridViewInput_IMS.TabIndex = 0;
            // 
            // groupBoxOutput_IMS
            // 
            groupBoxOutput_IMS.Controls.Add(dataGridViewOutput_IMS);
            groupBoxOutput_IMS.Dock = DockStyle.Fill;
            groupBoxOutput_IMS.Location = new Point(0, 0);
            groupBoxOutput_IMS.Name = "groupBoxOutput_IMS";
            groupBoxOutput_IMS.Size = new Size(434, 322);
            groupBoxOutput_IMS.TabIndex = 0;
            groupBoxOutput_IMS.TabStop = false;
            groupBoxOutput_IMS.Text = "Вывод";
            // 
            // dataGridViewOutput_IMS
            // 
            dataGridViewOutput_IMS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_IMS.ColumnHeadersVisible = false;
            dataGridViewOutput_IMS.Dock = DockStyle.Fill;
            dataGridViewOutput_IMS.Location = new Point(3, 19);
            dataGridViewOutput_IMS.Name = "dataGridViewOutput_IMS";
            dataGridViewOutput_IMS.RowHeadersVisible = false;
            dataGridViewOutput_IMS.Size = new Size(428, 300);
            dataGridViewOutput_IMS.TabIndex = 0;
            // 
            // openFileDialogTask_IMS
            // 
            openFileDialogTask_IMS.FileName = "InPutDataFileTask7V14";
            openFileDialogTask_IMS.InitialDirectory = "C:\\DataSprint6\\InPutDataFileTask6V27";
            // 
            // toolTip1_IMS
            // 
            toolTip1_IMS.IsBalloon = true;
            toolTip1_IMS.ToolTipIcon = ToolTipIcon.Info;
            toolTip1_IMS.ToolTipTitle = "Подсказка";
            //toolTip1_IMS.Popup += toolTip1_IMS_Popup;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainerInputOutput_IMS);
            Controls.Add(panelCondition_IMS);
            Controls.Add(panelButtons_IMS);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 14 | Иванов М. С.";
            WindowState = FormWindowState.Maximized;
            panelButtons_IMS.ResumeLayout(false);
            panelCondition_IMS.ResumeLayout(false);
            groupBoxCondition_IMS.ResumeLayout(false);
            splitContainerInputOutput_IMS.Panel1.ResumeLayout(false);
            splitContainerInputOutput_IMS.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerInputOutput_IMS).EndInit();
            splitContainerInputOutput_IMS.ResumeLayout(false);
            groupBoxInput_IMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_IMS).EndInit();
            groupBoxOutput_IMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_IMS).EndInit();
            ResumeLayout(false);
        }


        private Panel panelButtons_IMS;
        private Panel panelCondition_IMS;
        private Button button2;
        private Button buttonOpenFile_IMS;
        private SplitContainer splitContainerInputOutput_IMS;
        private GroupBox groupBoxCondition_IMS;
        private Label labelCondition_IMS;
        private GroupBox groupBoxInput_IMS;
        private GroupBox groupBoxOutput_IMS;
        private Button buttonDone_IMS;
        private ToolTip toolTip1_IMS;
        private OpenFileDialog openFileDialogTask_IMS;
        private Button buttonAbout_IMS;
        private DataGridView dataGridViewInput_IMS;
        private DataGridView dataGridViewOutput_IMS;
        private Button buttonSave_IMS;
        private SaveFileDialog saveFileDialog_IMS;
    }
}
