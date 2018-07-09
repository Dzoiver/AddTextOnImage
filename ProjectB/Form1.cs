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

        int Coorx            { get  {return Convert.ToInt32(Xbox.Text);} } // Получение значения из текстбокса х координат
        int Coory            { get  {return Convert.ToInt32(Ybox.Text);} } // Получение значения из текстбокса y координат
        string Print_text    { get  {return Textcontent.Text;} } // Получение значения из текстбокса содержимого надписи
        string Fonttype          { get  {return "Brushes." + Fontname.Text;} } // Получение значения из комбобокса Шрифт
        string FontColor     { get  {return Fontcolor.Text;} } // Получение значения из комбобокса 

        Graphics g; // Создание элемента графики
        Image image; // Создание изображения
        private void AddImage_Click(object sender, EventArgs e) // Событие при нажатии кнопки Добавить изображение
        {
            OpenFileDialog dlg = new OpenFileDialog(); // Открытие диаологового окна
            dlg.Filter = ("png files (*.png)|*.png"); // Фильтр для выбора файлов
            if (dlg.ShowDialog() == DialogResult.OK) // Проверка на успешное открытие диалога
            {
                image = Image.FromFile(dlg.FileName); // Выбранный файл помещается в image
                pictureBox1.Image = image; // Отрисовка image на picturebox1 
            }
        }

        private void Add_text_Click(object sender, EventArgs e) // Событие при нажатии кнопки Добавить надпись
        {
            g = Graphics.FromImage(image); // Присваиваем экземпляру графики изображение
            var font = new Font(Fonttype, 25, FontStyle.Regular, GraphicsUnit.Pixel); // Создаем шрифт
            g.DrawString(Print_text, font, Brushes.Black, new Point(Coorx, Coory)); // 
            pictureBox1.Image = image;
        }
    }
}
