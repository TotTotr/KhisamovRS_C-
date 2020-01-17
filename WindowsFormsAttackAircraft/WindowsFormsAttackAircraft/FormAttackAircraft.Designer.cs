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


            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeAircraft = new System.Windows.Forms.PictureBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTake_Aircraft = new System.Windows.Forms.Button();

            this.listBoxLevels = new System.Windows.Forms.ListBox();

            this.Zakazat = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttackAircraft)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxTakeAircraft);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonTake_Aircraft);
            this.groupBox1.Location = new System.Drawing.Point(784, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 142);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Свойства штурмовика";
            // 
            // pictureBoxTakeAircraft
            // 
            this.pictureBoxTakeAircraft.Location = new System.Drawing.Point(6, 47);
            this.pictureBoxTakeAircraft.Name = "pictureBoxTakeAircraft";
            this.pictureBoxTakeAircraft.Size = new System.Drawing.Size(141, 86);
            this.pictureBoxTakeAircraft.TabIndex = 3;
            this.pictureBoxTakeAircraft.TabStop = false;
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(115, 21);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(38, 20);
            this.maskedTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Место:";
            // 
            // buttonTake_Aircraft
            // 
            this.buttonTake_Aircraft.Location = new System.Drawing.Point(0, 19);
            this.buttonTake_Aircraft.Name = "buttonTake_Aircraft";
            this.buttonTake_Aircraft.Size = new System.Drawing.Size(75, 23);
            this.buttonTake_Aircraft.TabIndex = 0;
            this.buttonTake_Aircraft.Text = "Забрать";
            this.buttonTake_Aircraft.UseVisualStyleBackColor = true;
            this.buttonTake_Aircraft.Click += new System.EventHandler(this.buttonTake_Aircraft_Click);
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(784, 12);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(153, 82);
            this.listBoxLevels.TabIndex = 8;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // Zakazat
            // 
            this.Zakazat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Zakazat.Location = new System.Drawing.Point(806, 135);
            this.Zakazat.Name = "Zakazat";
            this.Zakazat.Size = new System.Drawing.Size(116, 71);
            this.Zakazat.TabIndex = 9;
            this.Zakazat.Text = "Заказать самолет";
            this.Zakazat.UseVisualStyleBackColor = true;
            this.Zakazat.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 461);
            this.Controls.Add(this.Zakazat);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox1);


            this.Controls.Add(this.pictureBoxAttackAircraft);
            this.Name = "FormParking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttackAircraft)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeAircraft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAttackAircraft;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTake_Aircraft;
        private System.Windows.Forms.PictureBox pictureBoxTakeAircraft;

        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxLevels;

        private System.Windows.Forms.Button Zakazat;

    }
}

