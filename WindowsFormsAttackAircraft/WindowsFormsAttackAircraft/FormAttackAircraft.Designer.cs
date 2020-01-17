namespace WindowsFormsAttackAircraft
{
    partial class FormParking
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

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.pictureBoxAttackAircraft = new System.Windows.Forms.PictureBox();

            this.buttonSet_Aircraft = new System.Windows.Forms.Button();
            this.buttonSet_AttackAircraft = new System.Windows.Forms.Button();
            this.SvoystvoSam = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeAircraft = new System.Windows.Forms.PictureBox();
            this.NomerSamolet = new System.Windows.Forms.MaskedTextBox();
            this.labelMesto = new System.Windows.Forms.Label();
            this.buttonTake_Aircraft = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttackAircraft)).BeginInit();
            this.SvoystvoSam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeAircraft)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAttackAircraft
            // 
            this.pictureBoxAttackAircraft.Location = new System.Drawing.Point(1, 12);
            this.pictureBoxAttackAircraft.Name = "pictureBoxAttackAircraft";
            this.pictureBoxAttackAircraft.Size = new System.Drawing.Size(777, 446);
            this.pictureBoxAttackAircraft.TabIndex = 0;
            this.pictureBoxAttackAircraft.TabStop = false;

            // 
            // buttonSet_Aircraft
            // 
            this.buttonSet_Aircraft.Location = new System.Drawing.Point(862, 12);
            this.buttonSet_Aircraft.Name = "buttonSet_Aircraft";
            this.buttonSet_Aircraft.Size = new System.Drawing.Size(75, 45);
            this.buttonSet_Aircraft.TabIndex = 1;
            this.buttonSet_Aircraft.Text = "Посадить самолет ";
            this.buttonSet_Aircraft.UseVisualStyleBackColor = true;
            this.buttonSet_Aircraft.Click += new System.EventHandler(this.ButtonSet_Aircraft_Click);
            // 
            // buttonSet_AttackAircraft
            // 
            this.buttonSet_AttackAircraft.Location = new System.Drawing.Point(862, 63);
            this.buttonSet_AttackAircraft.Name = "buttonSet_AttackAircraft";
            this.buttonSet_AttackAircraft.Size = new System.Drawing.Size(75, 52);
            this.buttonSet_AttackAircraft.TabIndex = 6;
            this.buttonSet_AttackAircraft.Text = "Посадить бомбордировщик";
            this.buttonSet_AttackAircraft.UseVisualStyleBackColor = true;
            this.buttonSet_AttackAircraft.Click += new System.EventHandler(this.ButtonSet_AttackAircraft_Click);
            // 
            // SvoystvoSam
            // 
            this.SvoystvoSam.Controls.Add(this.pictureBoxTakeAircraft);
            this.SvoystvoSam.Controls.Add(this.NomerSamolet);
            this.SvoystvoSam.Controls.Add(this.labelMesto);
            this.SvoystvoSam.Controls.Add(this.buttonTake_Aircraft);
            this.SvoystvoSam.Location = new System.Drawing.Point(784, 209);
            this.SvoystvoSam.Name = "SvoystvoSam";
            this.SvoystvoSam.Size = new System.Drawing.Size(153, 240);
            this.SvoystvoSam.TabIndex = 7;
            this.SvoystvoSam.TabStop = false;
            this.SvoystvoSam.Text = "Свойства Самолета";
            // 
            // pictureBoxTakeAircraft
            // 
            this.pictureBoxTakeAircraft.Location = new System.Drawing.Point(6, 90);
            this.pictureBoxTakeAircraft.Name = "pictureBoxTakeAircraft";
            this.pictureBoxTakeAircraft.Size = new System.Drawing.Size(141, 144);
            this.pictureBoxTakeAircraft.TabIndex = 3;
            this.pictureBoxTakeAircraft.TabStop = false;
            // 
            // NomerSamolet
            // 
            this.NomerSamolet.Location = new System.Drawing.Point(50, 32);
            this.NomerSamolet.Name = "NomerSamolet";
            this.NomerSamolet.Size = new System.Drawing.Size(38, 20);
            this.NomerSamolet.TabIndex = 2;
            // 
            // labelMesto
            // 
            this.labelMesto.AutoSize = true;
            this.labelMesto.Location = new System.Drawing.Point(2, 35);
            this.labelMesto.Name = "labelMesto";
            this.labelMesto.Size = new System.Drawing.Size(42, 13);
            this.labelMesto.TabIndex = 1;
            this.labelMesto.Text = "Место:";
            // 
            // buttonTake_Aircraft
            // 
            this.buttonTake_Aircraft.Location = new System.Drawing.Point(5, 61);
            this.buttonTake_Aircraft.Name = "buttonTake_Aircraft";
            this.buttonTake_Aircraft.Size = new System.Drawing.Size(75, 23);
            this.buttonTake_Aircraft.TabIndex = 0;
            this.buttonTake_Aircraft.Text = "Забрать";
            this.buttonTake_Aircraft.UseVisualStyleBackColor = true;
            this.buttonTake_Aircraft.Click += new System.EventHandler(this.ButtonTake_Aircraft_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 461);
            this.Controls.Add(this.SvoystvoSam);
            this.Controls.Add(this.buttonSet_AttackAircraft);
            this.Controls.Add(this.buttonSet_Aircraft);

            this.Controls.Add(this.pictureBoxAttackAircraft);
            this.Name = "FormParking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttackAircraft)).EndInit();
            this.SvoystvoSam.ResumeLayout(false);
            this.SvoystvoSam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeAircraft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAttackAircraft;

        private System.Windows.Forms.Button buttonSet_Aircraft;
        private System.Windows.Forms.Button buttonSet_AttackAircraft;
        private System.Windows.Forms.GroupBox SvoystvoSam;
        private System.Windows.Forms.Button buttonTake_Aircraft;
        private System.Windows.Forms.PictureBox pictureBoxTakeAircraft;
        private System.Windows.Forms.MaskedTextBox NomerSamolet;
        private System.Windows.Forms.Label labelMesto;

    }
}

