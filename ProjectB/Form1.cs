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
        }

        int Coorx { get { return Convert.ToInt32(Xbox.Text); } } // Получение значения из текстбокса х координат
        int Coory { get { return Convert.ToInt32(Ybox.Text); } } // Получение значения из текстбокса y координат
        string Print_text { get { return Textcontent.Text; } } // Получение значения из текстбокса содержимого надписи

        Graphics g; // Создание элемента графики
        Image image; // Создание изображения
        SolidBrush sb;
        Font font;
        //var font = new Font(Fonttype, Fontsize, FontStyle.Regular, GraphicsUnit.Pixel); // Создаем шрифт
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
            }
        }

        private void Add_text_Click(object sender, EventArgs e) // Событие при нажатии кнопки Добавить надпись
        {
            DrawTextOnImage();
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
                try
                {
                    string[] allfiles = Directory.GetFiles(fold.SelectedPath, "*.png", SearchOption.AllDirectories);
                    foreach (string folderfile in allfiles)
                    {
                        image = Image.FromFile(folderfile); // Выбранный файл помещается в image

                        DrawTextOnImage(); // Рисуется текст на картинке
                        if (!Directory.Exists(fold.SelectedPath + "\\textedImages")) // Проверка существования папки
                        {
                            Directory.CreateDirectory(fold.SelectedPath + "\\textedImages"); // Создание папки если она не существовала
                        }

                        image.Save(fold.SelectedPath + "\\textedImages\\" + Path.GetFileName(folderfile)); // Сохранение файлов в папку textedImages

                    }
                }
                catch { MessageBox.Show("Файлы уже существуют. Удалите содержимое папки textedImages, чтобы создать новые.","Ошибка"); }

            }

        }
        void DrawTextOnImage()
        {
            g = Graphics.FromImage(image); // Присваиваем экземпляру графики изображение
            //var font = new Font(Fonttype, Fontsize, FontStyle.Regular, GraphicsUnit.Pixel); // Создаем шрифт
            try
            {
                g.DrawString(Print_text, font, sb, new Point(Coorx, Coory)); // 
            }
            catch
            {
                MessageBox.Show("Укажите шрифт и цвет", "Не определены значения");
            }
            pictureBox1.Image = image;
        }

        private void Setfont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            font = fontDialog1.Font;
        }

        private void Setcolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            sb = new SolidBrush(colorDialog1.Color);
        }
    }
}
