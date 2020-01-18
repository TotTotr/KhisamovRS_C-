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
            this.white = new System.Windows.Forms.Panel();
            this.yellow = new System.Windows.Forms.Panel();
            this.green = new System.Windows.Forms.Panel();
            this.blue = new System.Windows.Forms.Panel();
            this.black = new System.Windows.Forms.Panel();
            this.brown = new System.Windows.Forms.Panel();
            this.red = new System.Windows.Forms.Panel();
            this.gray = new System.Windows.Forms.Panel();
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
            this.OsnovCvet.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.OsnovCvet.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
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
            this.DopCvet.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.DopCvet.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
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
            this.groupBoxCveta.Controls.Add(this.white);
            this.groupBoxCveta.Controls.Add(this.blue);
            this.groupBoxCveta.Controls.Add(this.black);
            this.groupBoxCveta.Controls.Add(this.yellow);
            this.groupBoxCveta.Controls.Add(this.red);
            this.groupBoxCveta.Controls.Add(this.brown);
            this.groupBoxCveta.Controls.Add(this.green);
            this.groupBoxCveta.Controls.Add(this.gray);
            this.groupBoxCveta.Location = new System.Drawing.Point(453, 49);
            this.groupBoxCveta.Name = "groupBoxCveta";
            this.groupBoxCveta.Size = new System.Drawing.Size(118, 252);
            this.groupBoxCveta.TabIndex = 2;
            this.groupBoxCveta.TabStop = false;
            this.groupBoxCveta.Text = "Цвета";
          
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.black.Location = new System.Drawing.Point(62, 187);
            this.black.Name = "panel5";
            this.black.Size = new System.Drawing.Size(50, 50);
            this.black.TabIndex = 8;
            this.black.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
           
            this.gray.BackColor = System.Drawing.Color.Gray;
            this.gray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gray.Location = new System.Drawing.Point(6, 187);
            this.gray.Name = "panel4";
            this.gray.Size = new System.Drawing.Size(50, 50);
            this.gray.TabIndex = 6;
            this.gray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
          
            this.red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.red.Location = new System.Drawing.Point(62, 131);
            this.red.Name = "panel6";
            this.red.Size = new System.Drawing.Size(50, 50);
            this.red.TabIndex = 9;
            this.red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
          
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blue.Location = new System.Drawing.Point(6, 131);
            this.blue.Name = "panel3";
            this.blue.Size = new System.Drawing.Size(50, 50);
            this.blue.TabIndex = 6;
            this.blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
            
            this.green.BackColor = System.Drawing.Color.Lime;
            this.green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.green.Location = new System.Drawing.Point(62, 75);
            this.green.Name = "panel7";
            this.green.Size = new System.Drawing.Size(50, 50);
            this.green.TabIndex = 10;
            this.green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
 
            this.brown.BackColor = System.Drawing.Color.Red;
            this.brown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brown.Location = new System.Drawing.Point(6, 75);
            this.brown.Name = "panel2";
            this.brown.Size = new System.Drawing.Size(50, 50);
            this.brown.TabIndex = 6;
            this.brown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
            
            this.white.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.white.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.white.Location = new System.Drawing.Point(62, 19);
            this.white.Name = "panel8";
            this.white.Size = new System.Drawing.Size(50, 50);
            this.white.TabIndex = 7;
            this.white.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
            
            this.yellow.BackColor = System.Drawing.Color.White;
            this.yellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yellow.Location = new System.Drawing.Point(6, 19);
            this.yellow.Name = "panel1";
            this.yellow.Size = new System.Drawing.Size(50, 50);
            this.yellow.TabIndex = 5;
            this.yellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAircraft_MouseDow);
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
        private System.Windows.Forms.Panel white;
        private System.Windows.Forms.Panel black;
        private System.Windows.Forms.Panel brown;
        private System.Windows.Forms.Panel green;
        private System.Windows.Forms.Panel blue;
        private System.Windows.Forms.Panel red;
        private System.Windows.Forms.Panel gray;
        private System.Windows.Forms.Panel yellow;
        private System.Windows.Forms.Button buttonDob;
        private System.Windows.Forms.Button buttonUbr;
    }
}
