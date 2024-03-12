namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 111);
            label1.Name = "label1";
            label1.Size = new Size(36, 21);
            label1.TabIndex = 0;
            label1.Text = "TC:";
            label1.Click += label1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(78, 106);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 26);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(78, 148);
            maskedTextBox2.Mask = "00000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 26);
            maskedTextBox2.TabIndex = 2;
            maskedTextBox2.UseSystemPasswordChar = true;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 151);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 82);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(375, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 26);
            label3.Name = "label3";
            label3.Size = new Size(239, 21);
            label3.TabIndex = 8;
            label3.Text = "ONLİNE DERS GİRİŞ PANELİ";
            // 
            // panel3
            // 
            panel3.Location = new Point(20, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Location = new Point(1, 329);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 46);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Location = new Point(78, 273);
            button1.Name = "button1";
            button1.Size = new Size(102, 37);
            button1.TabIndex = 6;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(78, 229);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(170, 25);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Şifremi unuttum ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 374);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Font = new Font("Sitka Small", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "LOGİN PANELİ ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button button1;
        private Label label3;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
    }
}
