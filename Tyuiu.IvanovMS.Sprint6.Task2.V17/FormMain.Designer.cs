namespace Tyuiu.IvanovMS.Sprint6.Task2.V17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));

            groupBoxTask_IMS = new GroupBox();
            pictureBox1 = new PictureBox();
            labelTask_IMS = new Label();
            groupBoxInPutVarStep = new GroupBox();
            labelStopStep_IMS = new Label();
            labelStartEnd_IMS = new Label();
            textBoxInPutStartStep_IMS = new TextBox();
            textBoxInPutStopStep_IMS = new TextBox();
            buttonDoHelp_IMS = new Button();
            buttonDoResult_IMS = new Button();
            dataGridViewFunction_IMS = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Function = new DataGridViewTextBoxColumn();
            groupBoxOutPutResult_IMS = new GroupBox();
            groupBoxTask_IMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxInPutVarStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_IMS).BeginInit();
            groupBoxOutPutResult_IMS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_IMS
            // 
            groupBoxTask_IMS.Controls.Add(pictureBox1);
            groupBoxTask_IMS.Controls.Add(labelTask_IMS);
            groupBoxTask_IMS.Location = new Point(12, 12);
            groupBoxTask_IMS.Name = "groupBoxTask_IMS";
            groupBoxTask_IMS.Size = new Size(464, 277);
            groupBoxTask_IMS.TabIndex = 1;
            groupBoxTask_IMS.TabStop = false;
            groupBoxTask_IMS.Text = " Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 38);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTask_IMS
            // 
            labelTask_IMS.AutoSize = true;
            labelTask_IMS.Location = new Point(6, 19);
            labelTask_IMS.Name = "labelTask_IMS";
            labelTask_IMS.Size = new Size(382, 150);
            labelTask_IMS.TabIndex = 0;
            labelTask_IMS.Text = resources.GetString("labelTask_IMS.Text");
            // 
            // groupBoxInPutVarStep
            // 
            groupBoxInPutVarStep.Controls.Add(labelStopStep_IMS);
            groupBoxInPutVarStep.Controls.Add(labelStartEnd_IMS);
            groupBoxInPutVarStep.Controls.Add(textBoxInPutStartStep_IMS);
            groupBoxInPutVarStep.Controls.Add(textBoxInPutStopStep_IMS);
            groupBoxInPutVarStep.Location = new Point(12, 295);
            groupBoxInPutVarStep.Name = "groupBoxInPutVarStep";
            groupBoxInPutVarStep.Size = new Size(243, 64);
            groupBoxInPutVarStep.TabIndex = 2;
            groupBoxInPutVarStep.TabStop = false;
            groupBoxInPutVarStep.Text = "Ввод данных";
            // 
            // labelStopStep_IMS
            // 
            labelStopStep_IMS.AutoSize = true;
            labelStopStep_IMS.Location = new Point(143, 19);
            labelStopStep_IMS.Name = "labelStopStep_IMS";
            labelStopStep_IMS.Size = new Size(75, 15);
            labelStopStep_IMS.TabIndex = 4;
            labelStopStep_IMS.Text = "Конец шага:";
            // 
            // labelStartEnd_IMS
            // 
            labelStartEnd_IMS.AutoSize = true;
            labelStartEnd_IMS.Location = new Point(24, 19);
            labelStartEnd_IMS.Name = "labelStartEnd_IMS";
            labelStartEnd_IMS.Size = new Size(72, 15);
            labelStartEnd_IMS.TabIndex = 3;
            labelStartEnd_IMS.Text = "Старт шага:";
            // 
            // textBoxInPutStartStep_IMS
            // 
            textBoxInPutStartStep_IMS.Location = new Point(6, 35);
            textBoxInPutStartStep_IMS.Name = "textBoxInPutStartStep_IMS";
            textBoxInPutStartStep_IMS.Size = new Size(110, 23);
            textBoxInPutStartStep_IMS.TabIndex = 2;
            textBoxInPutStartStep_IMS.KeyPress += textBoxInPutVarX_KeyPress;
            // 
            // textBoxInPutStopStep_IMS
            // 
            textBoxInPutStopStep_IMS.Location = new Point(127, 35);
            textBoxInPutStopStep_IMS.Name = "textBoxInPutStopStep_IMS";
            textBoxInPutStopStep_IMS.Size = new Size(110, 23);
            textBoxInPutStopStep_IMS.TabIndex = 1;
            textBoxInPutStopStep_IMS.KeyPress += textBoxInPutVarX_KeyPress;
            // 
            // buttonDoHelp_IMS
            // 
            buttonDoHelp_IMS.BackColor = Color.DodgerBlue;
            buttonDoHelp_IMS.Location = new Point(261, 302);
            buttonDoHelp_IMS.Name = "buttonDoHelp_IMS";
            buttonDoHelp_IMS.Size = new Size(95, 57);
            buttonDoHelp_IMS.TabIndex = 3;
            buttonDoHelp_IMS.Text = "Справка";
            buttonDoHelp_IMS.UseVisualStyleBackColor = false;
            buttonDoHelp_IMS.Click += buttonHelp_Click;
            // 
            // buttonDoResult_IMS
            // 
            buttonDoResult_IMS.BackColor = Color.Green;
            buttonDoResult_IMS.Location = new Point(358, 302);
            buttonDoResult_IMS.Name = "buttonDoResult_IMS";
            buttonDoResult_IMS.Size = new Size(118, 57);
            buttonDoResult_IMS.TabIndex = 4;
            buttonDoResult_IMS.Text = "Выполнить";
            buttonDoResult_IMS.UseVisualStyleBackColor = false;
            buttonDoResult_IMS.Click += buttonDone_Click;
            buttonDoResult_IMS.MouseDown += buttonDone_MouseDown;
            buttonDoResult_IMS.MouseEnter += buttonDone_MouseEnter;
            buttonDoResult_IMS.MouseLeave += buttonDone_MouseLeave;
            // 
            // dataGridViewFunction_IMS
            // 
            dataGridViewFunction_IMS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_IMS.Columns.AddRange(new DataGridViewColumn[] { X, Function });
            dataGridViewFunction_IMS.Location = new Point(21, 37);
            dataGridViewFunction_IMS.Name = "dataGridViewFunction_IMS";
            dataGridViewFunction_IMS.RowHeadersVisible = false;
            dataGridViewFunction_IMS.Size = new Size(121, 240);
            dataGridViewFunction_IMS.TabIndex = 5;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // Function
            // 
            Function.HeaderText = "F(X)";
            Function.Name = "Function";
            Function.Width = 50;
            // 
            // groupBoxOutPutResult_IMS
            // 
            groupBoxOutPutResult_IMS.Controls.Add(dataGridViewFunction_IMS);
            groupBoxOutPutResult_IMS.Location = new Point(482, 12);
            groupBoxOutPutResult_IMS.Name = "groupBoxOutPutResult_IMS";
            groupBoxOutPutResult_IMS.Size = new Size(698, 347);
            groupBoxOutPutResult_IMS.TabIndex = 6;
            groupBoxOutPutResult_IMS.TabStop = false;
            groupBoxOutPutResult_IMS.Text = "Вывод данных";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 366);
            Controls.Add(buttonDoResult_IMS);
            Controls.Add(buttonDoHelp_IMS);
            Controls.Add(groupBoxInPutVarStep);
            Controls.Add(groupBoxTask_IMS);
            Controls.Add(groupBoxOutPutResult_IMS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 17 |  Иванов М. С. ";
            groupBoxTask_IMS.ResumeLayout(false);
            groupBoxTask_IMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxInPutVarStep.ResumeLayout(false);
            groupBoxInPutVarStep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_IMS).EndInit();
            groupBoxOutPutResult_IMS.ResumeLayout(false);
            ResumeLayout(false);
        }

        

        private GroupBox groupBoxTask_IMS;
        private Label labelTask_IMS;
        private PictureBox pictureBox1;
        private GroupBox groupBoxInPutVarStep;
        private Label labelStopStep_IMS;
        private Label labelStartEnd_IMS;
        private TextBox textBoxInPutStartStep_IMS;
        private TextBox textBoxInPutStopStep_IMS;
        private Button buttonDoHelp_IMS;
        private Button buttonDoResult_IMS;
        private DataGridView dataGridViewFunction_IMS;
        private GroupBox groupBoxOutPutResult_IMS;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Function;
    }
}

