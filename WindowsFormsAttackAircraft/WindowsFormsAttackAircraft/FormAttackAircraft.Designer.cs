namespace WindowsFormsAttackAircraft
{
    partial class FormParking
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
            this.pictureBoxAttackAircraft = new System.Windows.Forms.PictureBox();
            this.buttonSet_Aircraft = new System.Windows.Forms.Button();
            this.buttonSet_AttackAircraft = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeAircraft = new System.Windows.Forms.PictureBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTake_Aircraft = new System.Windows.Forms.Button();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
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
            // buttonSet_Aircraft
            // 
            this.buttonSet_Aircraft.Location = new System.Drawing.Point(784, 140);
            this.buttonSet_Aircraft.Name = "buttonSet_Aircraft";
            this.buttonSet_Aircraft.Size = new System.Drawing.Size(75, 52);
            this.buttonSet_Aircraft.TabIndex = 1;
            this.buttonSet_Aircraft.Text = "Посадить самолет ";
            this.buttonSet_Aircraft.UseVisualStyleBackColor = true;
            this.buttonSet_Aircraft.Click += new System.EventHandler(this.buttonSet_Aircraft_Click);
            // 
            // buttonSet_AttackAircraft
            // 
            this.buttonSet_AttackAircraft.Location = new System.Drawing.Point(862, 140);
            this.buttonSet_AttackAircraft.Name = "buttonSet_AttackAircraft";
            this.buttonSet_AttackAircraft.Size = new System.Drawing.Size(75, 52);
            this.buttonSet_AttackAircraft.TabIndex = 6;
            this.buttonSet_AttackAircraft.Text = "Посадить бомбордировщик";
            this.buttonSet_AttackAircraft.UseVisualStyleBackColor = true;
            this.buttonSet_AttackAircraft.Click += new System.EventHandler(this.buttonSet_AttackAircraft_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxTakeAircraft);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonTake_Aircraft);
            this.groupBox1.Location = new System.Drawing.Point(784, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 240);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Свойства штурмовика";
            // 
            // pictureBoxTakeAircraft
            // 
            this.pictureBoxTakeAircraft.Location = new System.Drawing.Point(6, 90);
            this.pictureBoxTakeAircraft.Name = "pictureBoxTakeAircraft";
            this.pictureBoxTakeAircraft.Size = new System.Drawing.Size(141, 144);
            this.pictureBoxTakeAircraft.TabIndex = 3;
            this.pictureBoxTakeAircraft.TabStop = false;
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(50, 32);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(38, 20);
            this.maskedTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Место:";
            // 
            // buttonTake_Aircraft
            // 
            this.buttonTake_Aircraft.Location = new System.Drawing.Point(5, 61);
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
            this.listBoxLevels.Location = new System.Drawing.Point(784, 24);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(153, 121);
            this.listBoxLevels.TabIndex = 9;
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 461);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSet_AttackAircraft);
            this.Controls.Add(this.buttonSet_Aircraft);
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
        private System.Windows.Forms.Button buttonSet_Aircraft;
        private System.Windows.Forms.Button buttonSet_AttackAircraft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTake_Aircraft;
        private System.Windows.Forms.PictureBox pictureBoxTakeAircraft;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}

