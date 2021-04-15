using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing.Imaging;

namespace SlideShowFury_Framework
{
    public partial class Editor : Form
    {
        LinkedList<Bitmap> fileNames = new LinkedList<Bitmap>();
        LinkedListNode<Bitmap> fileNameNode;
        bool run = false; //запущено ли слайдшоу или нет
        float speed = 1f; //скорость смены слайдов

        public Editor(LinkedList<Bitmap> fileNames)
        {
            InitializeComponent();
            this.fileNames = fileNames;
            this.fileNameNode = fileNames.First;
            imageCurrent_picturebox.Image = fileNameNode.Value;

            

            //создаю поток для слайдшоу
            Thread slideshow = new Thread(new ThreadStart(SlideShow));
            slideshow.IsBackground = true; //<-- Set the thread to work in background
            slideshow.Start();
            
        }

        private void leftArrow_picturebox_Click(object sender, EventArgs e)
        {
            if (fileNameNode != fileNames.First) fileNameNode = fileNameNode.Previous;
            ShowImage();
        }

        private void rightArrow_picturebox_Click(object sender, EventArgs e)
        {
            if (fileNameNode != fileNames.Last) fileNameNode = fileNameNode.Next;
            ShowImage();
        }

        private void ShowImage()
        {
            imageCurrent_picturebox.Image = fileNameNode.Value;
        }

        private void runButton_picturebox_Click(object sender, EventArgs e)
        {
            //Включаем, если выключено и выключаем если включено
            run = !run;
            if (run) runButton_picturebox.Image = Properties.Resources.stop_button;
            else runButton_picturebox.Image = Properties.Resources.play_button;
        }

        private void SpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speed = Prompt.ShowDialog("Скорость:", "Выбор скорости смены слайдов");
        }

        //метод слайдшоу выполняется в отдельном потоке
        void SlideShow()
        {
            while (true)
            {
                Thread.Sleep((int)(5 / speed)*1000);
                if (run == true)
                {
                    //скорость смены показов вычисляется за формулой: Скорость = 3 секунды / speed, где speed - целое число
                    if (fileNameNode != fileNames.Last) fileNameNode = fileNameNode.Next;
                    else fileNameNode = fileNames.First;

                    ShowImage();
                }
            }
        }

        private void Editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void GrayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fileNameNode.Value.Width; i++)
            {
                for (int j = 0; j < fileNameNode.Value.Height; j++)
                {
                    //получаем цвета каждого пикселя.
                    //Все изображение это множество точек, с помощью GetPixel(x,y) мы узнаем цвет пикселя на фото
                    Color c = fileNameNode.Value.GetPixel(i, j);

                    byte gray = (byte)(.21 * c.R + .71 * c.G + .071 * c.B);

                    //Заполняем изображение уже "новыми" пикселями
                    fileNameNode.Value.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            ShowImage();
        }

        private void invertColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; (y <= (fileNameNode.Value.Height - 1)); y++)
            {
                for (int x = 0; (x <= (fileNameNode.Value.Width - 1)); x++)
                {
                    Color inv = fileNameNode.Value.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    fileNameNode.Value.SetPixel(x, y, inv);
                }
            }
            ShowImage();
        }

        private void rotateLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileNameNode.Value.RotateFlip(RotateFlipType.Rotate90FlipNone);
            ShowImage();
        }

        private void rotateRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileNameNode.Value.RotateFlip(RotateFlipType.Rotate270FlipNone);
            ShowImage();
        }

        private void mirrorXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileNameNode.Value.RotateFlip(RotateFlipType.RotateNoneFlipX);
            ShowImage();
        }

        private void mirrorYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileNameNode.Value.RotateFlip(RotateFlipType.RotateNoneFlipY);
            ShowImage();
        }

        private void morePhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Изображения (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in openFileDialog.FileNames)
                {
                    fileNames.AddLast(new Bitmap(item));
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    //реализовал небольшой класс для диалогового окна Prompt, в нём будет спрашиватся данные от пользователя
    public static class Prompt
    {
        public static int ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 250,
                Height = 120,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 10, Top = 5, Text = text };
            TrackBar trackbar = new TrackBar() { Left = 10, Top = 20, Width = 200 };
            trackbar.Minimum = 1;
            trackbar.Maximum = 5;
            trackbar.TickFrequency = 1;
            Button confirmation = new Button() { Text = "Применить", Left = 10, Width = 100, Top = 50, DialogResult = DialogResult.OK };
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(trackbar);
            prompt.Controls.Add(textLabel);

            return prompt.ShowDialog() == DialogResult.OK  ? trackbar.Value : 1;
        }
    }
}
