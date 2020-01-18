using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAttackAircraft
{
    class MultiLevelParking
    {
        List<Parking<ITransport>> parkingStages;
        private const int countPlaces = 20;
        private int pictureWidth;
        private int pictureHeight;
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; i++)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine("CountLeveles:" + parkingStages.Count);
            foreach (var level in parkingStages)
            {
                writer.WriteLine("Level");
                for (int i = 0; i < countPlaces; i++)
                {
                    var aircraft = level[i];
                    if (aircraft != null)
                    {
                        if (aircraft.GetType().Name == "Aircraft")
                        {
                            writer.Write(i + ":Aircraft:");
                        }
                        if (aircraft.GetType().Name == "AttackAircraft")
                        {
                            writer.Write(i + ":AttackAircraft:");
                        }
                        writer.WriteLine(aircraft);
                    }
                }
            }
            writer.Close();
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.Default))
            {

                int counter = -1;
                ITransport aircraft = null;

                string temp = sr.ReadLine();
                if (temp.Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(temp.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport>>(count);

                }
                else
                {
                    throw new Exception("Неверный формат файла");

                }
                while (true)
                {

                    temp = sr.ReadLine();

                    if (temp == null)
                        break;
                    if (temp == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight)); continue;
                    }

                    if (string.IsNullOrEmpty(temp))
                    {
                        continue;
                    }
                    if (temp.Split(':')[1] == "Aircraft")
                    {
                        aircraft = new Aircraft(temp.Split(':')[2]);
                    }
                    else if (temp.Split(':')[1] == "AttackAircraft")
                    {
                        aircraft = new AttackAircraft(temp.Split(':')[2]);
                    }

                    parkingStages[counter][Convert.ToInt32(temp.Split(':')[0])] = aircraft;

                }
            }
            return true;
        }
        /// <summary>        
        /// /// Метод записи информации в файл        
        /// /// </summary>        
        /// /// <param name="text">Строка, которую следует записать</param>         
        /// // <param name="stream">Поток для записи</param>     
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
    }
}
