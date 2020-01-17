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
        private ITransport attackAircraft;

        public FormAttackAircraft()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAttackAircraft.Width, pictureBoxAttackAircraft.Height);
            Graphics gr = Graphics.FromImage(bmp);
            attackAircraft.DrawAircraft(gr);
            pictureBoxAttackAircraft.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            attackAircraft = new AttackAircraft(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black, Color.Gray, true, true, true);
            attackAircraft.SetPosition(rnd.Next(100, 300), rnd.Next(100, 300), pictureBoxAttackAircraft.Width, pictureBoxAttackAircraft.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    attackAircraft.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    attackAircraft.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    attackAircraft.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    attackAircraft.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreateAtackAircraft_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            attackAircraft = new AttackAircraft(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black, Color.Gray, false, false, false);
            attackAircraft.SetPosition(rnd.Next(100, 300), rnd.Next(100, 300), pictureBoxAttackAircraft.Width, pictureBoxAttackAircraft.Height);
            Draw();
        }
    }

}

