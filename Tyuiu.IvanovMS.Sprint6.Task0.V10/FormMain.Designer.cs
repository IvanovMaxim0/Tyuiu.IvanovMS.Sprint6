namespace Tyuiu.IvanovMS.Sprint6.Task0.V10
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textOutPut = new TextBox();
            text2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textOutPut
            // 
            textOutPut.Location = new Point(635, 351);
            textOutPut.Margin = new Padding(3, 4, 3, 4);
            textOutPut.Name = "textOutPut";
            textOutPut.Size = new Size(114, 27);
            textOutPut.TabIndex = 0;
            textOutPut.TextChanged += textOutPut_TextChanged;
            // 
            // text2
            // 
            text2.Location = new Point(71, 351);
            text2.Margin = new Padding(3, 4, 3, 4);
            text2.Name = "text2";
            text2.Size = new Size(114, 27);
            text2.TabIndex = 1;
            text2.TextChanged += text2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(816, 351);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(666, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 150);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(text2);
            Controls.Add(textOutPut);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textOutPut;
        private TextBox text2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
