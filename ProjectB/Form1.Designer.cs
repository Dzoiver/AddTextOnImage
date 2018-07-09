namespace ProjectB
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Add_image = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Add_text = new System.Windows.Forms.Button();
            this.Xbox = new System.Windows.Forms.TextBox();
            this.Ybox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Textcontent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Fontcolor = new System.Windows.Forms.ComboBox();
            this.Fontname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Add_image
            // 
            this.Add_image.Location = new System.Drawing.Point(480, 12);
            this.Add_image.Name = "Add_image";
            this.Add_image.Size = new System.Drawing.Size(146, 23);
            this.Add_image.TabIndex = 0;
            this.Add_image.Text = "Добавить изображение";
            this.Add_image.UseVisualStyleBackColor = true;
            this.Add_image.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Add_text
            // 
            this.Add_text.Location = new System.Drawing.Point(480, 357);
            this.Add_text.Name = "Add_text";
            this.Add_text.Size = new System.Drawing.Size(146, 23);
            this.Add_text.TabIndex = 2;
            this.Add_text.Text = "Добавить надпись";
            this.Add_text.UseVisualStyleBackColor = true;
            this.Add_text.Click += new System.EventHandler(this.Add_text_Click);
            // 
            // Xbox
            // 
            this.Xbox.Location = new System.Drawing.Point(557, 305);
            this.Xbox.Name = "Xbox";
            this.Xbox.Size = new System.Drawing.Size(69, 20);
            this.Xbox.TabIndex = 3;
            this.Xbox.Text = "0";
            // 
            // Ybox
            // 
            this.Ybox.Location = new System.Drawing.Point(557, 331);
            this.Ybox.Name = "Ybox";
            this.Ybox.Size = new System.Drawing.Size(69, 20);
            this.Ybox.TabIndex = 4;
            this.Ybox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Координаты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "y";
            // 
            // Textcontent
            // 
            this.Textcontent.Location = new System.Drawing.Point(480, 232);
            this.Textcontent.Multiline = true;
            this.Textcontent.Name = "Textcontent";
            this.Textcontent.Size = new System.Drawing.Size(146, 54);
            this.Textcontent.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Текст надписи";
            // 
            // Fontcolor
            // 
            this.Fontcolor.FormattingEnabled = true;
            this.Fontcolor.Items.AddRange(new object[] {
            "Black"});
            this.Fontcolor.Location = new System.Drawing.Point(505, 192);
            this.Fontcolor.Name = "Fontcolor";
            this.Fontcolor.Size = new System.Drawing.Size(121, 21);
            this.Fontcolor.TabIndex = 10;
            this.Fontcolor.Text = "Black";
            // 
            // Fontname
            // 
            this.Fontname.FormattingEnabled = true;
            this.Fontname.Items.AddRange(new object[] {
            "TimesNewRoman"});
            this.Fontname.Location = new System.Drawing.Point(505, 102);
            this.Fontname.Name = "Fontname";
            this.Fontname.Size = new System.Drawing.Size(121, 21);
            this.Fontname.TabIndex = 11;
            this.Fontname.Text = "TimesNewRoman";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Цвет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Шрифт";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(505, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(580, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Размер";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 393);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fontname);
            this.Controls.Add(this.Fontcolor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Textcontent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ybox);
            this.Controls.Add(this.Xbox);
            this.Controls.Add(this.Add_text);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Add_image);
            this.Name = "Form1";
            this.Text = "Редактор изображений";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Add_image;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Add_text;
        private System.Windows.Forms.TextBox Xbox;
        private System.Windows.Forms.TextBox Ybox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Textcontent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Fontcolor;
        private System.Windows.Forms.ComboBox Fontname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
    }
}

