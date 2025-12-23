using Tyuiu.IvanovMS.Sprint6.Task3.V28.Lib;
namespace Tyuiu.IvanovMS.Sprint6.Task3.V28
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_IMS = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRes_IMS = new System.Windows.Forms.GroupBox();
            this.labelRes_IMS = new System.Windows.Forms.Label();
            this.buttonHelp_IMS = new System.Windows.Forms.Button();
            this.buttonDone_IMS = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_IMS = new System.Windows.Forms.DataGridView();
            this.dataGridViewRes_IMS = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_IMS.SuspendLayout();
            this.groupBoxRes_IMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_IMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_IMS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_IMS
            // 
            this.groupBoxTask_IMS.Controls.Add(this.dataGridViewMatrix_IMS);
            this.groupBoxTask_IMS.Controls.Add(this.label1);
            this.groupBoxTask_IMS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_IMS.Name = "groupBoxTask_IMS";
            this.groupBoxTask_IMS.Size = new System.Drawing.Size(650, 349);
            this.groupBoxTask_IMS.TabIndex = 0;
            this.groupBoxTask_IMS.TabStop = false;
            this.groupBoxTask_IMS.Text = "Условие";
            this.groupBoxTask_IMS.Enter += new System.EventHandler(this.groupBoxTask_IMS_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 136);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBoxRes_IMS
            // 
            this.groupBoxRes_IMS.Controls.Add(this.dataGridViewRes_IMS);
            this.groupBoxRes_IMS.Controls.Add(this.labelRes_IMS);
            this.groupBoxRes_IMS.Location = new System.Drawing.Point(669, 13);
            this.groupBoxRes_IMS.Name = "groupBoxRes_IMS";
            this.groupBoxRes_IMS.Size = new System.Drawing.Size(258, 310);
            this.groupBoxRes_IMS.TabIndex = 1;
            this.groupBoxRes_IMS.TabStop = false;
            this.groupBoxRes_IMS.Text = "Вывод данных";
            // 
            // labelRes_IMS
            // 
            this.labelRes_IMS.AutoSize = true;
            this.labelRes_IMS.Location = new System.Drawing.Point(6, 23);
            this.labelRes_IMS.Name = "labelRes_IMS";
            this.labelRes_IMS.Size = new System.Drawing.Size(80, 17);
            this.labelRes_IMS.TabIndex = 1;
            this.labelRes_IMS.Text = "Результат:";
            // 
            // buttonHelp_IMS
            // 
            this.buttonHelp_IMS.Location = new System.Drawing.Point(770, 329);
            this.buttonHelp_IMS.Name = "buttonHelp_IMS";
            this.buttonHelp_IMS.Size = new System.Drawing.Size(42, 33);
            this.buttonHelp_IMS.TabIndex = 2;
            this.buttonHelp_IMS.Text = "?";
            this.buttonHelp_IMS.UseVisualStyleBackColor = true;
            this.buttonHelp_IMS.Click += new System.EventHandler(this.buttonHelp_IMS_Click);
            // 
            // buttonDone_IMS
            // 
            this.buttonDone_IMS.Location = new System.Drawing.Point(818, 329);
            this.buttonDone_IMS.Name = "buttonDone_IMS";
            this.buttonDone_IMS.Size = new System.Drawing.Size(109, 33);
            this.buttonDone_IMS.TabIndex = 3;
            this.buttonDone_IMS.Text = "Выполнить ";
            this.buttonDone_IMS.UseVisualStyleBackColor = true;
            this.buttonDone_IMS.Click += new System.EventHandler(this.buttonDone_IMS_Click);
            // 
            // dataGridViewMatrix_IMS
            // 
            this.dataGridViewMatrix_IMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_IMS.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_IMS.Location = new System.Drawing.Point(376, 22);
            this.dataGridViewMatrix_IMS.Name = "dataGridViewMatrix_IMS";
            this.dataGridViewMatrix_IMS.RowHeadersVisible = false;
            this.dataGridViewMatrix_IMS.RowHeadersWidth = 51;
            this.dataGridViewMatrix_IMS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMatrix_IMS.RowTemplate.Height = 24;
            this.dataGridViewMatrix_IMS.Size = new System.Drawing.Size(254, 223);
            this.dataGridViewMatrix_IMS.TabIndex = 1;
            // 
            // dataGridViewRes_IMS
            // 
            this.dataGridViewRes_IMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_IMS.ColumnHeadersVisible = false;
            this.dataGridViewRes_IMS.Location = new System.Drawing.Point(9, 44);
            this.dataGridViewRes_IMS.Name = "dataGridViewRes_IMS";
            this.dataGridViewRes_IMS.RowHeadersVisible = false;
            this.dataGridViewRes_IMS.RowHeadersWidth = 51;
            this.dataGridViewRes_IMS.RowTemplate.Height = 24;
            this.dataGridViewRes_IMS.Size = new System.Drawing.Size(240, 234);
            this.dataGridViewRes_IMS.TabIndex = 2;
            this.dataGridViewRes_IMS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRes_IMS_CellContentClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 374);
            this.Controls.Add(this.buttonDone_IMS);
            this.Controls.Add(this.buttonHelp_IMS);
            this.Controls.Add(this.groupBoxRes_IMS);
            this.Controls.Add(this.groupBoxTask_IMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 28 |  Иванов М. С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_IMS.ResumeLayout(false);
            this.groupBoxTask_IMS.PerformLayout();
            this.groupBoxRes_IMS.ResumeLayout(false);
            this.groupBoxRes_IMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_IMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_IMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_IMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRes_IMS;
        private System.Windows.Forms.Label labelRes_IMS;
        private System.Windows.Forms.Button buttonHelp_IMS;
        private System.Windows.Forms.Button buttonDone_IMS;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_IMS;
        private System.Windows.Forms.DataGridView dataGridViewRes_IMS;
    }
}
