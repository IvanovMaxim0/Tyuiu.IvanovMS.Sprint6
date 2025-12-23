namespace Tyuiu.IvanovMS.Sprint6.Task5.V16
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonLoad_IMS;
        private System.Windows.Forms.Button buttonHelp_IMS;
        private System.Windows.Forms.Button buttonSave_IMS;
        private System.Windows.Forms.Button buttonOpenFolder_IMS;
        private System.Windows.Forms.TextBox textBoxData_IMS;
        private System.Windows.Forms.TextBox textBoxStats_IMS;
        private System.Windows.Forms.TextBox textBoxInfo_IMS;
        private System.Windows.Forms.Label labelFileStatus_IMS;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelStats;

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
            this.buttonLoad_IMS = new System.Windows.Forms.Button();
            this.buttonHelp_IMS = new System.Windows.Forms.Button();
            this.buttonSave_IMS = new System.Windows.Forms.Button();
            this.buttonOpenFolder_IMS = new System.Windows.Forms.Button();
            this.textBoxData_IMS = new System.Windows.Forms.TextBox();
            this.textBoxStats_IMS = new System.Windows.Forms.TextBox();
            this.textBoxInfo_IMS = new System.Windows.Forms.TextBox();
            this.labelFileStatus_IMS = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelStats = new System.Windows.Forms.Label();

            // buttonLoad_IMS
            this.buttonLoad_IMS.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonLoad_IMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonLoad_IMS.ForeColor = System.Drawing.Color.White;
            this.buttonLoad_IMS.Location = new System.Drawing.Point(12, 12);
            this.buttonLoad_IMS.Name = "buttonLoad_IMS";
            this.buttonLoad_IMS.Size = new System.Drawing.Size(120, 40);
            this.buttonLoad_IMS.TabIndex = 0;
            this.buttonLoad_IMS.Text = "📂 Загрузить";
            this.buttonLoad_IMS.UseVisualStyleBackColor = false;
            this.buttonLoad_IMS.Click += new System.EventHandler(this.buttonLoad_IMS_Click);

            // buttonHelp_IMS
            this.buttonHelp_IMS.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonHelp_IMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonHelp_IMS.Location = new System.Drawing.Point(138, 12);
            this.buttonHelp_IMS.Name = "buttonHelp_IMS";
            this.buttonHelp_IMS.Size = new System.Drawing.Size(120, 40);
            this.buttonHelp_IMS.TabIndex = 1;
            this.buttonHelp_IMS.Text = "❓ Справка";
            this.buttonHelp_IMS.UseVisualStyleBackColor = false;
            this.buttonHelp_IMS.Click += new System.EventHandler(this.buttonHelp_IMS_Click);

            // buttonSave_IMS
            this.buttonSave_IMS.BackColor = System.Drawing.Color.Gold;
            this.buttonSave_IMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonSave_IMS.Location = new System.Drawing.Point(264, 12);
            this.buttonSave_IMS.Name = "buttonSave_IMS";
            this.buttonSave_IMS.Size = new System.Drawing.Size(120, 40);
            this.buttonSave_IMS.TabIndex = 2;
            this.buttonSave_IMS.Text = "💾 Сохранить";
            this.buttonSave_IMS.UseVisualStyleBackColor = false;
            this.buttonSave_IMS.Click += new System.EventHandler(this.buttonSave_IMS_Click);

            // buttonOpenFolder_IMS
            this.buttonOpenFolder_IMS.BackColor = System.Drawing.Color.Orange; this.buttonOpenFolder_IMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonOpenFolder_IMS.Location = new System.Drawing.Point(390, 12);
            this.buttonOpenFolder_IMS.Name = "buttonOpenFolder_IMS";
            this.buttonOpenFolder_IMS.Size = new System.Drawing.Size(120, 40);
            this.buttonOpenFolder_IMS.TabIndex = 3;
            this.buttonOpenFolder_IMS.Text = "📁 Папка";
            this.buttonOpenFolder_IMS.UseVisualStyleBackColor = false;
            this.buttonOpenFolder_IMS.Click += new System.EventHandler(this.buttonOpenFolder_IMS_Click);

            // labelFileStatus_IMS
            this.labelFileStatus_IMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelFileStatus_IMS.Location = new System.Drawing.Point(12, 65);
            this.labelFileStatus_IMS.Name = "labelFileStatus_IMS";
            this.labelFileStatus_IMS.Size = new System.Drawing.Size(498, 20);
            this.labelFileStatus_IMS.TabIndex = 4;
            this.labelFileStatus_IMS.Text = "Проверка файла...";

            // textBoxInfo_IMS
            this.textBoxInfo_IMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxInfo_IMS.Location = new System.Drawing.Point(12, 90);
            this.textBoxInfo_IMS.Multiline = true;
            this.textBoxInfo_IMS.Name = "textBoxInfo_IMS";
            this.textBoxInfo_IMS.ReadOnly = true;
            this.textBoxInfo_IMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo_IMS.Size = new System.Drawing.Size(498, 80);
            this.textBoxInfo_IMS.TabIndex = 5;

            // labelData
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelData.Location = new System.Drawing.Point(12, 180);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(81, 17);
            this.labelData.TabIndex = 6;
            this.labelData.Text = "📋 Данные";

            // textBoxData_IMS
            this.textBoxData_IMS.Font = new System.Drawing.Font("Courier New", 9F);
            this.textBoxData_IMS.Location = new System.Drawing.Point(12, 200);
            this.textBoxData_IMS.Multiline = true;
            this.textBoxData_IMS.Name = "textBoxData_IMS";
            this.textBoxData_IMS.ReadOnly = true;
            this.textBoxData_IMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData_IMS.Size = new System.Drawing.Size(240, 349);
            this.textBoxData_IMS.TabIndex = 7;

            // labelStats
            this.labelStats.AutoSize = true;
            this.labelStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelStats.Location = new System.Drawing.Point(258, 180);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(99, 17);
            this.labelStats.TabIndex = 8;
            this.labelStats.Text = "📊 Статистика";

            // textBoxStats_IMS
            this.textBoxStats_IMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxStats_IMS.Location = new System.Drawing.Point(258, 200);
            this.textBoxStats_IMS.Multiline = true;
            this.textBoxStats_IMS.Name = "textBoxStats_IMS";
            this.textBoxStats_IMS.ReadOnly = true;
            this.textBoxStats_IMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStats_IMS.Size = new System.Drawing.Size(252, 349);
            this.textBoxStats_IMS.TabIndex = 9;

            // FormMain
            this.ClientSize = new System.Drawing.Size(524, 561);
            this.Controls.Add(this.textBoxStats_IMS);
            this.Controls.Add(this.labelStats);
            this.Controls.Add(this.textBoxData_IMS);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textBoxInfo_IMS);
            this.Controls.Add(this.labelFileStatus_IMS);
            this.Controls.Add(this.buttonOpenFolder_IMS);
            this.Controls.Add(this.buttonSave_IMS);
            this.Controls.Add(this.buttonHelp_IMS);
            this.Controls.Add(this.buttonLoad_IMS);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 16 | Иванов М.С.";
        }
    }
}
