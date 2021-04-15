
namespace SlideShowFury_Framework
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dragPlaceholder_label = new System.Windows.Forms.Label();
            this.chooseFiles_button = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.PictureBox();
            this.dragZone_picture = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.infoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragZone_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "SlideShow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(408, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fury";
            // 
            // dragPlaceholder_label
            // 
            this.dragPlaceholder_label.AutoSize = true;
            this.dragPlaceholder_label.BackColor = System.Drawing.Color.White;
            this.dragPlaceholder_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dragPlaceholder_label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.dragPlaceholder_label.Location = new System.Drawing.Point(221, 217);
            this.dragPlaceholder_label.Name = "dragPlaceholder_label";
            this.dragPlaceholder_label.Size = new System.Drawing.Size(247, 35);
            this.dragPlaceholder_label.TabIndex = 3;
            this.dragPlaceholder_label.Text = "Drag and Drop here";
            // 
            // chooseFiles_button
            // 
            this.chooseFiles_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseFiles_button.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseFiles_button.Location = new System.Drawing.Point(174, 400);
            this.chooseFiles_button.Name = "chooseFiles_button";
            this.chooseFiles_button.Size = new System.Drawing.Size(367, 51);
            this.chooseFiles_button.TabIndex = 4;
            this.chooseFiles_button.Text = "Choose files";
            this.chooseFiles_button.UseVisualStyleBackColor = true;
            this.chooseFiles_button.Click += new System.EventHandler(this.chooseFiles_button_Click);
            // 
            // infoButton
            // 
            this.infoButton.Image = global::SlideShowFury_Framework.Properties.Resources.info;
            this.infoButton.Location = new System.Drawing.Point(652, 9);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(32, 32);
            this.infoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoButton.TabIndex = 5;
            this.infoButton.TabStop = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click_1);
            // 
            // dragZone_picture
            // 
            this.dragZone_picture.BackgroundImage = global::SlideShowFury_Framework.Properties.Resources.dropzone_static;
            this.dragZone_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dragZone_picture.Location = new System.Drawing.Point(105, 79);
            this.dragZone_picture.Name = "dragZone_picture";
            this.dragZone_picture.Size = new System.Drawing.Size(485, 302);
            this.dragZone_picture.TabIndex = 2;
            this.dragZone_picture.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Multiselect = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(696, 467);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.chooseFiles_button);
            this.Controls.Add(this.dragPlaceholder_label);
            this.Controls.Add(this.dragZone_picture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SlideShowFury v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.infoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragZone_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox dragZone_picture;
        private System.Windows.Forms.Label dragPlaceholder_label;
        private System.Windows.Forms.Button chooseFiles_button;
        private System.Windows.Forms.PictureBox infoButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

