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
        Parking<ITransport> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(20, pictureBoxAttackAircraft.Width, pictureBoxAttackAircraft.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAttackAircraft.Width, pictureBoxAttackAircraft.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxAttackAircraft.Image = bmp;
        }
        private void ButtonSet_Aircraft_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Aircraft(100, 1000, dialog.Color);
                int place = parking + car;
                Draw();
            }
        }

        private void ButtonSet_AttackAircraft_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new AttackAircraft(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                    int place = parking + car;
                    Draw();
                }
            }
        }


        private void ButtonTake_Aircraft_Click(object sender, EventArgs e)

        {
            if (NomerSamolet.Text != "")
            {
                var car = parking - Convert.ToInt32(NomerSamolet.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeAircraft.Width, pictureBoxTakeAircraft.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(5, 5, pictureBoxTakeAircraft.Width, pictureBoxTakeAircraft.Height);
                    car.DrawAircraft(gr);
                    pictureBoxTakeAircraft.Image = bmp;
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
}
