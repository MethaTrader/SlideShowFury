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

namespace SlideShowFury_Framework
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            dragZone_picture.AllowDrop = true;
            dragZone_picture.DragOver += new DragEventHandler(FilesDragOver);
            dragZone_picture.DragEnter += new DragEventHandler(Form1_DragEnter);
            dragZone_picture.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        public LinkedList<Bitmap> fileNames = new LinkedList<Bitmap>();

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            dragPlaceholder_label.BackColor = Color.White;
            dragZone_picture.BackgroundImage = Properties.Resources.dropzone_static;
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            dragPlaceholder_label.BackColor = Color.White;
            dragZone_picture.BackgroundImage = Properties.Resources.dropzone_static;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) fileNames.AddLast(new Bitmap(file));

            if (fileNames.Count > 0)
            {
                NextForm();
            }
        }

        void NextForm()
        {
            Cursor = Cursors.WaitCursor;
            Thread.Sleep(1000);

            this.Hide();
            Editor editor = new Editor(fileNames);
            editor.Closed += (s, args) => this.Close();
            editor.Show();
        }

        private void FilesDragOver(object sender, DragEventArgs e)
        {
            dragPlaceholder_label.BackColor = ColorTranslator.FromHtml("#eeebdd");
            dragZone_picture.BackgroundImage = Properties.Resources.dropzone_hover;
        }

        private void chooseFiles_button_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Изображения (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in openFileDialog.FileNames)
                {
                    fileNames.AddLast(new Bitmap(item));
                }
            }

            if (fileNames.Count > 0) NextForm();
        }

        private void infoButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("SlideShowFury - мощная программа для редактирования фото и просмотра нескольких фотографий в режиме слайд-шоу.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
