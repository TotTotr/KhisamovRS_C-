namespace WindowsFormsAttackAircraft
{
    partial class FormAircraftConfig
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
            this.pictureBoxAircraft = new System.Windows.Forms.PictureBox();
            this.groupBoxAircraft = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelAttackAircraft = new System.Windows.Forms.Label();
            this.labelAircraft = new System.Windows.Forms.Label();
            this.panelAircraft = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelFuchsia = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft)).BeginInit();
            this.groupBoxAircraft.SuspendLayout();
            this.panelAircraft.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAircraft
            // 
            this.pictureBoxAircraft.Location = new System.Drawing.Point(51, 27);
            this.pictureBoxAircraft.Name = "pictureBoxAircraft";
            this.pictureBoxAircraft.Size = new System.Drawing.Size(114, 86);
            this.pictureBoxAircraft.TabIndex = 0;
            this.pictureBoxAircraft.TabStop = false;
            // 
            // groupBoxAircraft
            // 
            this.groupBoxAircraft.Controls.Add(this.buttonCancel);
            this.groupBoxAircraft.Controls.Add(this.buttonOk);
            this.groupBoxAircraft.Controls.Add(this.labelAttackAircraft);
            this.groupBoxAircraft.Controls.Add(this.labelAircraft);
            this.groupBoxAircraft.Location = new System.Drawing.Point(33, 29);
            this.groupBoxAircraft.Name = "groupBoxAircraft";
            this.groupBoxAircraft.Size = new System.Drawing.Size(147, 260);
            this.groupBoxAircraft.TabIndex = 1;
            this.groupBoxAircraft.TabStop = false;
            this.groupBoxAircraft.Text = "Тип Корпуса";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(39, 204);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(39, 170);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // labelAttackAircraft
            // 
            this.labelAttackAircraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAttackAircraft.Location = new System.Drawing.Point(14, 123);
            this.labelAttackAircraft.Name = "labelAttackAircraft";
            this.labelAttackAircraft.Size = new System.Drawing.Size(114, 33);
            this.labelAttackAircraft.TabIndex = 1;
            this.labelAttackAircraft.Text = "Штурмовик";
            this.labelAttackAircraft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAttackAircraft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAttackAircraft_MouseDown);
            // 
            // labelAircraft
            // 
            this.labelAircraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAircraft.Location = new System.Drawing.Point(14, 51);
            this.labelAircraft.Name = "labelAircraft";
            this.labelAircraft.Size = new System.Drawing.Size(114, 33);
            this.labelAircraft.TabIndex = 0;
            this.labelAircraft.Text = "Обычный самолет";
            this.labelAircraft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAircraft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAircraft_MouseDown);
            // 
            // panelAircraft
            // 
            this.panelAircraft.AllowDrop = true;
            this.panelAircraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAircraft.Controls.Add(this.labelDopColor);
            this.panelAircraft.Controls.Add(this.labelBaseColor);
            this.panelAircraft.Controls.Add(this.pictureBoxAircraft);
            this.panelAircraft.Location = new System.Drawing.Point(199, 29);
            this.panelAircraft.Name = "panelAircraft";
            this.panelAircraft.Size = new System.Drawing.Size(226, 260);
            this.panelAircraft.TabIndex = 2;
            this.panelAircraft.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAircraft_DragDrop);
            this.panelAircraft.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAircraft_DragEnter);

            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(51, 203);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(114, 33);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(51, 146);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(114, 33);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelFuchsia);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(445, 29);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(167, 260);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(93, 19);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(54, 54);
            this.panelWhite.TabIndex = 4;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Location = new System.Drawing.Point(6, 199);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(54, 54);
            this.panelGray.TabIndex = 3;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(6, 139);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(54, 54);
            this.panelRed.TabIndex = 2;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(6, 79);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(54, 54);
            this.panelGreen.TabIndex = 1;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(93, 199);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(54, 54);
            this.panelYellow.TabIndex = 7;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelFuchsia
            // 
            this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelFuchsia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuchsia.Location = new System.Drawing.Point(93, 139);
            this.panelFuchsia.Name = "panelFuchsia";
            this.panelFuchsia.Size = new System.Drawing.Size(54, 54);
            this.panelFuchsia.TabIndex = 6;
            this.panelFuchsia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(93, 79);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(54, 54);
            this.panelBlue.TabIndex = 5;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(6, 19);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(54, 54);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);

            // 
            // FormAircraftConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 318);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelAircraft);
            this.Controls.Add(this.groupBoxAircraft);
            this.Name = "FormAircraftConfig";
            this.Text = "FormAircraftConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft)).EndInit();
            this.groupBoxAircraft.ResumeLayout(false);
            this.panelAircraft.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.PictureBox pictureBoxAircraft;
        private System.Windows.Forms.GroupBox groupBoxAircraft;
        private System.Windows.Forms.Label labelAttackAircraft;
        private System.Windows.Forms.Label labelAircraft;
        private System.Windows.Forms.Panel panelAircraft;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelFuchsia;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}