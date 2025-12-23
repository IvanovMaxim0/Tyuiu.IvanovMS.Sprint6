namespace Tyuiu.IvanovMS.Sprint6.Task7.V14
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_IMS = new PictureBox();
            labelInformation_IMS = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_IMS).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_IMS
            // 

            pictureBoxAvatar_IMS.Location = new Point(12, 29);
            pictureBoxAvatar_IMS.Name = "pictureBoxAvatar_IMS";
            pictureBoxAvatar_IMS.Size = new Size(208, 342);
            pictureBoxAvatar_IMS.TabIndex = 0;
            pictureBoxAvatar_IMS.TabStop = false;
            // 
            // labelInformation_IMS
            // 
            labelInformation_IMS.Font = new Font("Segoe UI", 14F);
            labelInformation_IMS.Location = new Point(226, 29);
            labelInformation_IMS.Name = "labelInformation_IMS";
            labelInformation_IMS.Size = new Size(342, 342);
            labelInformation_IMS.TabIndex = 1;
            labelInformation_IMS.Text = resources.GetString("labelInformation_IMS.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 396);
            Controls.Add(labelInformation_IMS);
            Controls.Add(pictureBoxAvatar_IMS);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_IMS).EndInit();
            ResumeLayout(false);
        }


        private PictureBox pictureBoxAvatar_IMS;
        private Label labelInformation_IMS;
    }
}