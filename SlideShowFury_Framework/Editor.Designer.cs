
namespace SlideShowFury_Framework
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morePhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отразитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анимацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.runButton_picturebox = new System.Windows.Forms.PictureBox();
            this.rightArrow_picturebox = new System.Windows.Forms.PictureBox();
            this.leftArrow_picturebox = new System.Windows.Forms.PictureBox();
            this.imageCurrent_picturebox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runButton_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCurrent_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.эффектыToolStripMenuItem,
            this.анимацияToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.morePhotoToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // morePhotoToolStripMenuItem
            // 
            this.morePhotoToolStripMenuItem.Name = "morePhotoToolStripMenuItem";
            this.morePhotoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.morePhotoToolStripMenuItem.Text = "Добавить фото";
            this.morePhotoToolStripMenuItem.ToolTipText = "Добавление новых фотографий";
            this.morePhotoToolStripMenuItem.Click += new System.EventHandler(this.morePhotoToolStripMenuItem_Click);
            // 
            // эффектыToolStripMenuItem
            // 
            this.эффектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GrayscaleToolStripMenuItem,
            this.invertColorToolStripMenuItem,
            this.поворотToolStripMenuItem,
            this.отразитьToolStripMenuItem});
            this.эффектыToolStripMenuItem.Name = "эффектыToolStripMenuItem";
            this.эффектыToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.эффектыToolStripMenuItem.Text = "Эффекты";
            // 
            // GrayscaleToolStripMenuItem
            // 
            this.GrayscaleToolStripMenuItem.Name = "GrayscaleToolStripMenuItem";
            this.GrayscaleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.GrayscaleToolStripMenuItem.Text = "Ч/Б";
            this.GrayscaleToolStripMenuItem.ToolTipText = "Черное/Белое фото";
            this.GrayscaleToolStripMenuItem.Click += new System.EventHandler(this.GrayscaleToolStripMenuItem_Click);
            // 
            // invertColorToolStripMenuItem
            // 
            this.invertColorToolStripMenuItem.Name = "invertColorToolStripMenuItem";
            this.invertColorToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.invertColorToolStripMenuItem.Text = "Инвертирования цвета";
            this.invertColorToolStripMenuItem.ToolTipText = "Инвертирования цвета";
            this.invertColorToolStripMenuItem.Click += new System.EventHandler(this.invertColorToolStripMenuItem_Click);
            // 
            // поворотToolStripMenuItem
            // 
            this.поворотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateLeftToolStripMenuItem,
            this.rotateRightToolStripMenuItem});
            this.поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            this.поворотToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.поворотToolStripMenuItem.Text = "Поворот";
            // 
            // rotateLeftToolStripMenuItem
            // 
            this.rotateLeftToolStripMenuItem.Name = "rotateLeftToolStripMenuItem";
            this.rotateLeftToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.rotateLeftToolStripMenuItem.Text = "Повернуть вперед (UpArrow)";
            this.rotateLeftToolStripMenuItem.Click += new System.EventHandler(this.rotateLeftToolStripMenuItem_Click);
            // 
            // rotateRightToolStripMenuItem
            // 
            this.rotateRightToolStripMenuItem.Name = "rotateRightToolStripMenuItem";
            this.rotateRightToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.rotateRightToolStripMenuItem.Text = "Повернуть назад (DownArrow)";
            this.rotateRightToolStripMenuItem.Click += new System.EventHandler(this.rotateRightToolStripMenuItem_Click);
            // 
            // отразитьToolStripMenuItem
            // 
            this.отразитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mirrorXToolStripMenuItem,
            this.mirrorYToolStripMenuItem});
            this.отразитьToolStripMenuItem.Name = "отразитьToolStripMenuItem";
            this.отразитьToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.отразитьToolStripMenuItem.Text = "Отразить";
            // 
            // mirrorXToolStripMenuItem
            // 
            this.mirrorXToolStripMenuItem.Name = "mirrorXToolStripMenuItem";
            this.mirrorXToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.mirrorXToolStripMenuItem.Text = "По горизонтали";
            this.mirrorXToolStripMenuItem.Click += new System.EventHandler(this.mirrorXToolStripMenuItem_Click);
            // 
            // mirrorYToolStripMenuItem
            // 
            this.mirrorYToolStripMenuItem.Name = "mirrorYToolStripMenuItem";
            this.mirrorYToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.mirrorYToolStripMenuItem.Text = "По вертикали";
            this.mirrorYToolStripMenuItem.Click += new System.EventHandler(this.mirrorYToolStripMenuItem_Click);
            // 
            // анимацияToolStripMenuItem
            // 
            this.анимацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpeedToolStripMenuItem});
            this.анимацияToolStripMenuItem.Name = "анимацияToolStripMenuItem";
            this.анимацияToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.анимацияToolStripMenuItem.Text = "Анимация";
            // 
            // SpeedToolStripMenuItem
            // 
            this.SpeedToolStripMenuItem.Name = "SpeedToolStripMenuItem";
            this.SpeedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SpeedToolStripMenuItem.Text = "Скорость показа";
            this.SpeedToolStripMenuItem.Click += new System.EventHandler(this.SpeedToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Multiselect = true;
            // 
            // runButton_picturebox
            // 
            this.runButton_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runButton_picturebox.Image = global::SlideShowFury_Framework.Properties.Resources.play_button;
            this.runButton_picturebox.Location = new System.Drawing.Point(355, 378);
            this.runButton_picturebox.Name = "runButton_picturebox";
            this.runButton_picturebox.Size = new System.Drawing.Size(102, 80);
            this.runButton_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.runButton_picturebox.TabIndex = 4;
            this.runButton_picturebox.TabStop = false;
            this.runButton_picturebox.Click += new System.EventHandler(this.runButton_picturebox_Click);
            // 
            // rightArrow_picturebox
            // 
            this.rightArrow_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightArrow_picturebox.Image = global::SlideShowFury_Framework.Properties.Resources.right_arrow1;
            this.rightArrow_picturebox.Location = new System.Drawing.Point(551, 378);
            this.rightArrow_picturebox.Name = "rightArrow_picturebox";
            this.rightArrow_picturebox.Size = new System.Drawing.Size(102, 80);
            this.rightArrow_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rightArrow_picturebox.TabIndex = 3;
            this.rightArrow_picturebox.TabStop = false;
            this.rightArrow_picturebox.Click += new System.EventHandler(this.rightArrow_picturebox_Click);
            // 
            // leftArrow_picturebox
            // 
            this.leftArrow_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftArrow_picturebox.Image = global::SlideShowFury_Framework.Properties.Resources.left_arrow1;
            this.leftArrow_picturebox.Location = new System.Drawing.Point(149, 378);
            this.leftArrow_picturebox.Name = "leftArrow_picturebox";
            this.leftArrow_picturebox.Size = new System.Drawing.Size(124, 80);
            this.leftArrow_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.leftArrow_picturebox.TabIndex = 2;
            this.leftArrow_picturebox.TabStop = false;
            this.leftArrow_picturebox.Click += new System.EventHandler(this.leftArrow_picturebox_Click);
            // 
            // imageCurrent_picturebox
            // 
            this.imageCurrent_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageCurrent_picturebox.Location = new System.Drawing.Point(149, 41);
            this.imageCurrent_picturebox.Name = "imageCurrent_picturebox";
            this.imageCurrent_picturebox.Size = new System.Drawing.Size(504, 292);
            this.imageCurrent_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageCurrent_picturebox.TabIndex = 1;
            this.imageCurrent_picturebox.TabStop = false;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.runButton_picturebox);
            this.Controls.Add(this.rightArrow_picturebox);
            this.Controls.Add(this.leftArrow_picturebox);
            this.Controls.Add(this.imageCurrent_picturebox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor";
            this.Text = "SlideShow Fury v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Editor_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runButton_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCurrent_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morePhotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GrayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анимацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpeedToolStripMenuItem;
        private System.Windows.Forms.PictureBox imageCurrent_picturebox;
        private System.Windows.Forms.PictureBox leftArrow_picturebox;
        private System.Windows.Forms.PictureBox rightArrow_picturebox;
        private System.Windows.Forms.PictureBox runButton_picturebox;
        private System.Windows.Forms.ToolStripMenuItem поворотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отразитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorYToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}