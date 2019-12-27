namespace Lab_Novichkova
{
    partial class FormBusConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDoubleBus = new System.Windows.Forms.Label();
            this.labelBus = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelPurpe = new System.Windows.Forms.Panel();
            this.panelAqua = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBus = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.pictureBoxBus = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.panelBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDoubleBus);
            this.groupBox1.Controls.Add(this.labelBus);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип автобуса";
            // 
            // labelBus2
            // 
            this.labelDoubleBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDoubleBus.Location = new System.Drawing.Point(27, 99);
            this.labelDoubleBus.Name = "labelBus2";
            this.labelDoubleBus.Size = new System.Drawing.Size(120, 47);
            this.labelDoubleBus.TabIndex = 1;
            this.labelDoubleBus.Text = "Автобус с гармошкой";
            this.labelDoubleBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDoubleBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDoubleBus_MouseDown);
            // 
            // labelBus
            // 
            this.labelBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBus.Location = new System.Drawing.Point(27, 50);
            this.labelBus.Name = "labelBus";
            this.labelBus.Size = new System.Drawing.Size(120, 33);
            this.labelBus.TabIndex = 0;
            this.labelBus.Text = "Автобус";
            this.labelBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBus_MouseDown);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(39, 325);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(146, 45);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(39, 261);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(144, 44);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.panelBlack);
            this.panelColor.Controls.Add(this.panelWhite);
            this.panelColor.Controls.Add(this.panelPurpe);
            this.panelColor.Controls.Add(this.panelAqua);
            this.panelColor.Controls.Add(this.panelRed);
            this.panelColor.Controls.Add(this.panelBlue);
            this.panelColor.Controls.Add(this.panelGreen);
            this.panelColor.Controls.Add(this.panelYellow);
            this.panelColor.Location = new System.Drawing.Point(700, 22);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(206, 315);
            this.panelColor.TabIndex = 14;
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(133, 237);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(55, 46);
            this.panelBlack.TabIndex = 7;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(31, 238);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(55, 47);
            this.panelWhite.TabIndex = 6;
            // 
            // panelPurpe
            // 
            this.panelPurpe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelPurpe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPurpe.Location = new System.Drawing.Point(133, 170);
            this.panelPurpe.Name = "panelPurpe";
            this.panelPurpe.Size = new System.Drawing.Size(55, 45);
            this.panelPurpe.TabIndex = 5;
            // 
            // panelAqua
            // 
            this.panelAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelAqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAqua.Location = new System.Drawing.Point(133, 107);
            this.panelAqua.Name = "panelAqua";
            this.panelAqua.Size = new System.Drawing.Size(55, 46);
            this.panelAqua.TabIndex = 3;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(133, 43);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(56, 47);
            this.panelRed.TabIndex = 1;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(32, 171);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(55, 46);
            this.panelBlue.TabIndex = 4;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(32, 107);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(55, 47);
            this.panelGreen.TabIndex = 2;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(31, 44);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(56, 47);
            this.panelYellow.TabIndex = 0;
            // 
            // panelBus
            // 
            this.panelBus.AllowDrop = true;
            this.panelBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBus.Controls.Add(this.labelDopColor);
            this.panelBus.Controls.Add(this.labelBaseColor);
            this.panelBus.Controls.Add(this.pictureBoxBus);
            this.panelBus.Location = new System.Drawing.Point(236, 22);
            this.panelBus.Name = "panelBus";
            this.panelBus.Size = new System.Drawing.Size(371, 373);
            this.panelBus.TabIndex = 13;
            this.panelBus.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBus_DragDrop);
            this.panelBus.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBus_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(97, 324);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(179, 35);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп.цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(97, 281);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(179, 33);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // pictureBoxBus
            // 
            this.pictureBoxBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBus.Location = new System.Drawing.Point(13, 18);
            this.pictureBoxBus.Name = "pictureBoxBus";
            this.pictureBoxBus.Size = new System.Drawing.Size(336, 230);
            this.pictureBoxBus.TabIndex = 0;
            this.pictureBoxBus.TabStop = false;
            // 
            // FormBusConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 508);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panelBus);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBusConfig";
            this.Text = "FormBusConfig";
            this.groupBox1.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            this.panelBus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDoubleBus;
        private System.Windows.Forms.Label labelBus;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelPurpe;
        private System.Windows.Forms.Panel panelAqua;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBus;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.PictureBox pictureBoxBus;
    }
}