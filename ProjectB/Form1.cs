using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArrangeCombo();
        }

        int Coorx { get { return Convert.ToInt32(Xbox.Text); } } // Получение значения из текстбокса х координат
        int Coory { get { return Convert.ToInt32(Ybox.Text); } } // Получение значения из текстбокса y координат
        int Fontsize { get { return Convert.ToInt32(comboBox1.Text); } }
        string Print_text { get { return Textcontent.Text; } } // Получение значения из текстбокса содержимого надписи
        string Fonttype { get { return Fontname.Text; } } // Получение значения из комбобокса Шрифт
        string FontColor { get { return Fontcolor.Text; } } // Получение значения из комбобокса 

        Graphics g; // Создание элемента графики
        Image image; // Создание изображения

        private void AddImage_Click(object sender, EventArgs e) // Событие при нажатии кнопки Добавить изображение
        {
            OpenFileDialog dlg = new OpenFileDialog(); // Открытие диаологового окна
            dlg.Filter = ("png files (*.png)|*.png"); // Фильтр для выбора файлов
            if (dlg.ShowDialog() == DialogResult.OK) // Проверка на успешное открытие диалога
            {
                image = Image.FromFile(dlg.FileName); // Выбранный файл помещается в image
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = image; // Отрисовка image на picturebox1 
                Add_text.Enabled = true;
                Saveimage.Enabled = true;
                Saveall.Enabled = true;
            }
        }

        private void Add_text_Click(object sender, EventArgs e) // Событие при нажатии кнопки Добавить надпись
        {
            g = Graphics.FromImage(image); // Присваиваем экземпляру графики изображение
            var font = new Font(Fonttype, Fontsize, FontStyle.Regular, GraphicsUnit.Pixel); // Создаем шрифт
            g.DrawString(Print_text, font, Brushes.Black, new Point(Coorx, Coory)); // 
            pictureBox1.Image = image;
        }

        private void ArrangeCombo()
        {
            for (int i = 2; i < 20; i+=2)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 20; i < 50; i += 6)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 50; i < 111; i += 15)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void Saveimage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdlg = new SaveFileDialog();
            sdlg.Filter = ("png files (*.png)|*.png");
            if (sdlg.ShowDialog() == DialogResult.OK)
            {
                image.Save(sdlg.FileName);
            }
        }

        private void Saveall_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fold = new FolderBrowserDialog();
            if (fold.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(fold.SelectedPath);
                string[] directories = Directory.GetDirectories(fold.SelectedPath);
                    foreach (string folderfile in files)
                    {
                        image = Image.FromFile(folderfile); // Выбранный файл помещается в image
                        g = Graphics.FromImage(image); // Присваиваем экземпляру графики изображение
                        var font = new Font(Fonttype, Fontsize, FontStyle.Regular, GraphicsUnit.Pixel); // Создаем шрифт
                        g.DrawString(Print_text, font, Brushes.Black, new Point(Coorx, Coory)); // 
                        if (!Directory.Exists(fold.SelectedPath + "\\textedImages"))
                        {
                            Directory.CreateDirectory(fold.SelectedPath + "\\textedImages");
                        }
                        image.Save(fold.SelectedPath + "\\textedImages\\" + Path.GetFileName(folderfile));

                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fold = new FolderBrowserDialog();
            if (fold.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(fold.SelectedPath);
                string newstring = Path.Combine(files[0], "subfolder");
                MessageBox.Show(newstring);
            }
        }
    }
}
