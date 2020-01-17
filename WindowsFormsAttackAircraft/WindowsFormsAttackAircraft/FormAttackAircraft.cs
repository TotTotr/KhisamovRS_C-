using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAttackAircraft
{
    public partial class FormParking : Form
    {
        MultiLevelParking parking;
        private const int countLevel = 5;
        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxAttackAircraft.Width, pictureBoxAttackAircraft.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxAttackAircraft.Width, pictureBoxAttackAircraft.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxAttackAircraft.Image = bmp;
            }
        }

        private void buttonSet_Aircraft_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var car = new Aircraft(100, 1000, dialog.Color);
                    int place = parking[listBoxLevels.SelectedIndex] + car;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }

        }


        private void buttonSet_AttackAircraft_Click(object sender, EventArgs e)

        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var car = new AttackAircraft(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                        int place = parking[listBoxLevels.SelectedIndex] + car;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();

                    }
                }
            }
        }
        private void buttonTake_Aircraft_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var car = parking[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);
                    if (car != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeAircraft.Width, pictureBoxTakeAircraft.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        car.SetPosition(5, 5, pictureBoxTakeAircraft.Width, pictureBoxTakeAircraft.Height);
                        car.DrawAircraft(gr); pictureBoxTakeAircraft.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeAircraft.Width, pictureBoxTakeAircraft.Height);
                        pictureBoxTakeAircraft.Image = bmp;
                    }
                    Draw();
                }
            }
        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
