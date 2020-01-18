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
        /// <summary>
        /// Переменная-выбранный самолет
        /// </summary>
        ITransport aircraft = null;
        private event carDelegate eventAddAircraft;
        public FormAircraftConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelFuchsia.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawAircraft()
        {
            if (aircraft != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxAircraft.Width, pictureBoxAircraft.Height);
                Graphics gr = Graphics.FromImage(bmp);
                aircraft.SetPosition(5, 5, pictureBoxAircraft.Width, pictureBoxAircraft.Height);
                aircraft.DrawAircraft(gr);
                pictureBoxAircraft.Image = bmp;
            }
        }
        /// <summary>        
        /// /// Добавление события       
        /// </summary>        
        /// <param name="ev"></param>    
        public void AddEvent(carDelegate ev)
        {
            if (eventAddAircraft == null)
            {
                eventAddAircraft = new carDelegate(ev);
            }
            else
            {
                eventAddAircraft += ev;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelAircraft_MouseDown(object sender, MouseEventArgs e)
        {
            labelAircraft.DoDragDrop(labelAircraft.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelAttackAircraft_MouseDown(object sender, MouseEventArgs e)
        {
            labelAttackAircraft.DoDragDrop(labelAttackAircraft.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelAircraft_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный самолет":
                    aircraft = new Aircraft(100, 500, Color.White);
                    break;
                case "Штурмовик":
                    aircraft = new AttackAircraft(100, 500, Color.White, Color.Black, true, true, true);
                    break;
            }
            DrawAircraft();
        }

        /// Отправляем цвет с панели         
        ///</summary>        
        /// <param name="sender"></param>         
        /// <param name="e"></param>         
        private void panelColor_MouseDown(object sender, MouseEventArgs e)

        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }


        /// <summary>       
        /// Проверка получаемой информации (ее типа на соответствие требуемому)        
        ///  </summary>        
        ///  <param name="sender"></param>         
        ///  <param name="e"></param>       
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)

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

        /// <summary>         
        /// Принимаем основной цвет         
        ///  </summary>       
        ///  <param name="sender"></param>     
        ///  <param name="e"></param>        
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)

        {
            if (aircraft != null)
            {
                aircraft.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawAircraft();
            }
        }
        /// <summary>        
        /// Принимаем дополнительный цвет  
        ///  </summary>         
        ///  <param name="sender"></param>    
        ///  <param name="e"></param>        
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (aircraft != null)
            {
                if (aircraft is AttackAircraft)
                {
                    (aircraft as AttackAircraft).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawAircraft();
                }
            }
        }
        /// <summary>        
        /// /// Добавление машины     
        /// /// </summary>        
        /// /// <param name="sender"></param>       
        /// /// <param name="e"></param>         
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            eventAddAircraft?.Invoke(aircraft);
            Close();
        }
    }
}