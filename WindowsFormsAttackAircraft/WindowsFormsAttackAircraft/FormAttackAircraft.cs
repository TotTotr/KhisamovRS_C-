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
        FormAircraftConfig form;
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
        //отрисовка паврковки
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
        /// <summary>        
        /// /// Обработка нажатия кнопки "Забрать"     
        /// /// </summary>         
        /// /// <param name="sender"></param>      
        /// /// <param name="e"></param>        
        private void ButtonTake_Aircraft_Click(object sender, EventArgs e)
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
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            form = new FormAircraftConfig();
            form.AddEvent(AddAircraft);
            form.Show();
        }
        private void AddAircraft(ITransport car)
        {
            if (car != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = parking[listBoxLevels.SelectedIndex] + car;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Самолет" +
                        " не удалось поставить");
                }
            }
        }
        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}