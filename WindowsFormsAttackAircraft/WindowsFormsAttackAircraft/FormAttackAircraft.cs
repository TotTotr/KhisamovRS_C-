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
    public partial class FormAttackAircraft : Form
    {
        private AttackAircraft aircraft;

        public FormAttackAircraft()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAttackAircraft.Width, pictureBoxAttackAircraft.Height);
            Graphics gr = Graphics.FromImage(bmp);
            aircraft.DrawAttackAircraft(gr);
            pictureBoxAttackAircraft.Image = bmp;
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            aircraft = new AttackAircraft(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray, Color.Blue, Color.Black, true, true);
            aircraft.SetPosition(rnd.Next(100, 300), rnd.Next(100, 300), pictureBoxAttackAircraft.Width, pictureBoxAttackAircraft.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    aircraft.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    aircraft.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    aircraft.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    aircraft.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }

}

