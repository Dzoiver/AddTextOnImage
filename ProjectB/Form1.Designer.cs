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
            this.Saveimage = new System.Windows.Forms.Button();
            this.Saveall = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Setfont = new System.Windows.Forms.Button();
            this.Setcolor = new System.Windows.Forms.Button();
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
            this.Add_text.Enabled = false;
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
            this.Textcontent.Text = "Безруков Кирилл";
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
            // Saveimage
            // 
            this.Saveimage.Enabled = false;
            this.Saveimage.Location = new System.Drawing.Point(483, 41);
            this.Saveimage.Name = "Saveimage";
            this.Saveimage.Size = new System.Drawing.Size(140, 23);
            this.Saveimage.TabIndex = 16;
            this.Saveimage.Text = "Сохранить изображение";
            this.Saveimage.UseVisualStyleBackColor = true;
            this.Saveimage.Click += new System.EventHandler(this.Saveimage_Click);
            // 
            // Saveall
            // 
            this.Saveall.Location = new System.Drawing.Point(483, 70);
            this.Saveall.Name = "Saveall";
            this.Saveall.Size = new System.Drawing.Size(140, 23);
            this.Saveall.TabIndex = 17;
            this.Saveall.Text = "Применить ко всем в";
            this.Saveall.UseVisualStyleBackColor = true;
            this.Saveall.Click += new System.EventHandler(this.Saveall_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            // 
            // Setfont
            // 
            this.Setfont.Location = new System.Drawing.Point(557, 181);
            this.Setfont.Name = "Setfont";
            this.Setfont.Size = new System.Drawing.Size(69, 23);
            this.Setfont.TabIndex = 19;
            this.Setfont.Text = "Шрифт";
            this.Setfont.UseVisualStyleBackColor = true;
            this.Setfont.Click += new System.EventHandler(this.Setfont_Click);
            // 
            // Setcolor
            // 
            this.Setcolor.Location = new System.Drawing.Point(557, 148);
            this.Setcolor.Name = "Setcolor";
            this.Setcolor.Size = new System.Drawing.Size(69, 23);
            this.Setcolor.TabIndex = 20;
            this.Setcolor.Text = "Цвет";
            this.Setcolor.UseVisualStyleBackColor = true;
            this.Setcolor.Click += new System.EventHandler(this.Setcolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 393);
            this.Controls.Add(this.Setcolor);
            this.Controls.Add(this.Setfont);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Saveall);
            this.Controls.Add(this.Saveimage);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(666, 432);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(666, 432);
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
        private System.Windows.Forms.Button Saveimage;
        private System.Windows.Forms.Button Saveall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Setfont;
        private System.Windows.Forms.Button Setcolor;
    }
}

