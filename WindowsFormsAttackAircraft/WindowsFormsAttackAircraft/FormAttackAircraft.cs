using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsAttackAircraft
{
    public partial class FormParking : Form
    {
        MultiLevelParking parking;
        FormAircraftConfig form;

        private const int countLevel = 5;
        private Logger logger;
        public FormParking()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
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
                    try
                    {
                        var aircraft = parking[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);

                        Bitmap bmp = new Bitmap(pictureBoxTakeAircraft.Width, pictureBoxTakeAircraft.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        aircraft.SetPosition(5, 5, pictureBoxTakeAircraft.Width, pictureBoxTakeAircraft.Height);
                        aircraft.DrawAircraft(gr);
                        pictureBoxTakeAircraft.Image = bmp;

                        logger.Info("Изъят самолет " + aircraft.ToString() + " с места " + maskedTextBox.Text);

                        Draw();
                    }
                    catch (ParkingNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.Error("Не найдено");
                        Bitmap bmp = new Bitmap(pictureBoxTakeAircraft.Width, pictureBoxTakeAircraft.Height);
                        pictureBoxTakeAircraft.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.Error("Неизвестная ошибка");
                    }

                }
            }
        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();

        }
        private void AddAircraft(ITransport aircraft)
        {
            if (aircraft != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = parking[listBoxLevels.SelectedIndex] + aircraft;
                    logger.Info("Добавлен самолет " + aircraft.ToString() + " на место " + place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Переполнение");
                }
                catch
                (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка");
                }
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            form = new FormAircraftConfig();
            form.AddEvent(AddAircraft);
            form.Show();
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Не сохранилось");

                }
            }
        }

        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}