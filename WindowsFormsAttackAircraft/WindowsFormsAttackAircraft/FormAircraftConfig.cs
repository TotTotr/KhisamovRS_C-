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
    public partial class FormAircraftConfig : Form
    {
        ITransport aircraft = null;
        private event aircraftDelegate eventAddAircraft;
        public FormAircraftConfig()
        {
            InitializeComponent();
            white.MouseDown += panelAircraft_MouseDown;
            black.MouseDown += panelAircraft_MouseDown;
            blue.MouseDown += panelAircraft_MouseDown;
            brown.MouseDown += panelAircraft_MouseDown;
            green.MouseDown += panelAircraft_MouseDown;
            yellow.MouseDown += panelAircraft_MouseDown;
            gray.MouseDown += panelAircraft_MouseDown;
            red.MouseDown += panelAircraft_MouseDown;

            buttonDob.Click += (object sender, EventArgs e) => { Close(); };
        }


        private void DrawAircraft()
        {
            if (aircraft != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxAircrafta.Width, pictureBoxAircrafta.Height);
                Graphics gr = Graphics.FromImage(bmp);
                aircraft.SetPosition(5, 5, pictureBoxAircrafta.Width, pictureBoxAircrafta.Height);
                aircraft.DrawAircraft(gr);
                pictureBoxAircrafta.Image = bmp;
            }
        }
        public void AddEvent(aircraftDelegate ev)
        {
            if (eventAddAircraft == null)
            {
                eventAddAircraft = new aircraftDelegate(ev);
            }
            else
            {
                eventAddAircraft += ev;
            }
        }

        private void lableAircraft_MouseDown(object sender, MouseEventArgs e)
        {
            labelAircraft.DoDragDrop(labelAircraft.Text, DragDropEffects.Move | DragDropEffects.Copy);


        }
        private void panelAircraft_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }



        private void lableAttackAircraft_MouseDown(object sender, MouseEventArgs e)
        {
            labelAttackAircraft.DoDragDrop(labelAttackAircraft.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void panelAircraft_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelAircraft_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Самолет":
                    aircraft = new Aircraft(100, 500, Color.White);
                    break;
                case "Бомбордировщик":
                    aircraft = new AttackAircraft(100, 500, Color.White, Color.Black, true, true, true);
                    break;
            }
            DrawAircraft();
        }
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (aircraft != null)
            {
                aircraft.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawAircraft();
            }
        }
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (aircraft != null)
            {
                if (aircraft is Aircraft)
                {
                    (aircraft as AttackAircraft).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawAircraft();
                }
            }

        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddAircraft?.Invoke(aircraft);
            Close();
        }

        private void panelAircraft_MouseDow(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }
    }
}
