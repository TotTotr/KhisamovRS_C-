namespace WindowsFormsAttackAircraft
{
    partial class FormAircraftConfig
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.labelAttackAircraft = new System.Windows.Forms.Label();
            this.labelAircraft = new System.Windows.Forms.Label();
            this.panelAircraft = new System.Windows.Forms.Panel();
            this.OsnovCvet = new System.Windows.Forms.Label();
            this.DopCvet = new System.Windows.Forms.Label();
            this.pictureBoxAircrafta = new System.Windows.Forms.PictureBox();
            this.groupBoxCveta = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDob = new System.Windows.Forms.Button();
            this.buttonUbr = new System.Windows.Forms.Button();
            this.groupBoxType.SuspendLayout();
            this.panelAircraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircrafta)).BeginInit();
            this.groupBoxCveta.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.labelAttackAircraft);
            this.groupBoxType.Controls.Add(this.labelAircraft);
            this.groupBoxType.Location = new System.Drawing.Point(100, 79);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(130, 191);
            this.groupBoxType.TabIndex = 0;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип Самолета";
            // 
            // labelAttackAircraft
            // 
            this.labelAttackAircraft.BackColor = System.Drawing.Color.White;
            this.labelAttackAircraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAttackAircraft.Location = new System.Drawing.Point(6, 112);
            this.labelAttackAircraft.Name = "labelAttackAircraft";
            this.labelAttackAircraft.Size = new System.Drawing.Size(116, 66);
            this.labelAttackAircraft.TabIndex = 1;
            this.labelAttackAircraft.Text = "Бомбордировщик";
            this.labelAttackAircraft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAttackAircraft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lableAttackAircraft_MouseDown);
            // 
            // labelAircraft
            // 
            this.labelAircraft.BackColor = System.Drawing.Color.White;
            this.labelAircraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAircraft.Location = new System.Drawing.Point(6, 32);
            this.labelAircraft.Name = "labelAircraft";
            this.labelAircraft.Size = new System.Drawing.Size(116, 66);
            this.labelAircraft.TabIndex = 0;
            this.labelAircraft.Text = "Самолет";
            this.labelAircraft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAircraft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lableAircraft_MouseDown);
            // 
            // panelAircraft
            // 
            this.panelAircraft.AllowDrop = true;
            this.panelAircraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAircraft.Controls.Add(this.OsnovCvet);
            this.panelAircraft.Controls.Add(this.DopCvet);
            this.panelAircraft.Controls.Add(this.pictureBoxAircrafta);
            this.panelAircraft.Location = new System.Drawing.Point(236, 37);
            this.panelAircraft.Name = "panelAircraft";
            this.panelAircraft.Size = new System.Drawing.Size(211, 271);
            this.panelAircraft.TabIndex = 1;
            this.panelAircraft.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAircraft_DragDrop);
            this.panelAircraft.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAircraft_DragEnter);
            this.panelAircraft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDown);
            // 
            // OsnovCvet
            // 
            this.OsnovCvet.AllowDrop = true;
            this.OsnovCvet.BackColor = System.Drawing.Color.White;
            this.OsnovCvet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OsnovCvet.Location = new System.Drawing.Point(4, 222);
            this.OsnovCvet.Name = "OsnovCvet";
            this.OsnovCvet.Size = new System.Drawing.Size(98, 41);
            this.OsnovCvet.TabIndex = 2;
            this.OsnovCvet.Text = "Основной Цвет";
            this.OsnovCvet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OsnovCvet.DragDrop += new System.Windows.Forms.DragEventHandler(this.label3_DragDrop);
            this.OsnovCvet.DragEnter += new System.Windows.Forms.DragEventHandler(this.label3_DragEnter);
            // 
            // DopCvet
            // 
            this.DopCvet.AllowDrop = true;
            this.DopCvet.BackColor = System.Drawing.Color.White;
            this.DopCvet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DopCvet.Location = new System.Drawing.Point(108, 222);
            this.DopCvet.Name = "DopCvet";
            this.DopCvet.Size = new System.Drawing.Size(98, 41);
            this.DopCvet.TabIndex = 1;
            this.DopCvet.Text = "Доп Цвет";
            this.DopCvet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DopCvet.DragDrop += new System.Windows.Forms.DragEventHandler(this.label4_DragDrop);
            this.DopCvet.DragEnter += new System.Windows.Forms.DragEventHandler(this.label3_DragEnter);
            // 
            // pictureBoxAircrafta
            // 
            this.pictureBoxAircrafta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAircrafta.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxAircrafta.Name = "pictureBoxAircrafta";
            this.pictureBoxAircrafta.Size = new System.Drawing.Size(203, 216);
            this.pictureBoxAircrafta.TabIndex = 0;
            this.pictureBoxAircrafta.TabStop = false;
            // 
            // groupBoxCveta
            // 
            this.groupBoxCveta.Controls.Add(this.panel5);
            this.groupBoxCveta.Controls.Add(this.panel4);
            this.groupBoxCveta.Controls.Add(this.panel6);
            this.groupBoxCveta.Controls.Add(this.panel3);
            this.groupBoxCveta.Controls.Add(this.panel7);
            this.groupBoxCveta.Controls.Add(this.panel2);
            this.groupBoxCveta.Controls.Add(this.panel8);
            this.groupBoxCveta.Controls.Add(this.panel1);
            this.groupBoxCveta.Location = new System.Drawing.Point(453, 49);
            this.groupBoxCveta.Name = "groupBoxCveta";
            this.groupBoxCveta.Size = new System.Drawing.Size(118, 252);
            this.groupBoxCveta.TabIndex = 2;
            this.groupBoxCveta.TabStop = false;
            this.groupBoxCveta.Text = "Цвета";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(62, 187);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 50);
            this.panel5.TabIndex = 8;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(6, 187);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 50);
            this.panel4.TabIndex = 6;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(62, 131);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(50, 50);
            this.panel6.TabIndex = 9;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(6, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 50);
            this.panel3.TabIndex = 6;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Lime;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(62, 75);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(50, 50);
            this.panel7.TabIndex = 10;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(6, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 50);
            this.panel2.TabIndex = 6;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(62, 19);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(50, 50);
            this.panel8.TabIndex = 7;
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
            // 
            // buttonDob
            // 
            this.buttonDob.Location = new System.Drawing.Point(100, 269);
            this.buttonDob.Name = "buttonDob";
            this.buttonDob.Size = new System.Drawing.Size(64, 35);
            this.buttonDob.TabIndex = 3;
            this.buttonDob.Text = "Доб";
            this.buttonDob.UseVisualStyleBackColor = true;
            this.buttonDob.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonUbr
            // 
            this.buttonUbr.Location = new System.Drawing.Point(166, 269);
            this.buttonUbr.Name = "buttonUbr";
            this.buttonUbr.Size = new System.Drawing.Size(64, 35);
            this.buttonUbr.TabIndex = 4;
            this.buttonUbr.Text = "Убрать";
            this.buttonUbr.UseVisualStyleBackColor = true;
            // 
            // FormAircraftConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUbr);
            this.Controls.Add(this.buttonDob);
            this.Controls.Add(this.groupBoxCveta);
            this.Controls.Add(this.panelAircraft);
            this.Controls.Add(this.groupBoxType);
            this.Name = "FormAircraftConfig";
            this.Text = "FormAircraftConfig";
            this.groupBoxType.ResumeLayout(false);
            this.panelAircraft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircrafta)).EndInit();
            this.groupBoxCveta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Label labelAttackAircraft;
        private System.Windows.Forms.Label labelAircraft;
        private System.Windows.Forms.Panel panelAircraft;
        private System.Windows.Forms.PictureBox pictureBoxAircrafta;
        private System.Windows.Forms.Label OsnovCvet;
        private System.Windows.Forms.Label DopCvet;
        private System.Windows.Forms.GroupBox groupBoxCveta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonDob;
        private System.Windows.Forms.Button buttonUbr;
    }
}