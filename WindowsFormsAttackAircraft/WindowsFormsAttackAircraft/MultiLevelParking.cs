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
            System.IO.StreamWriter writer = new System.IO.StreamWriter(filename);
            //Записываем количество уровней                
            writer.WriteLine("CountLeveles:" + parkingStages.Count);
            foreach (var level in parkingStages)
            {
                //Начинаем уровень                    
                writer.WriteLine("Level");
                for (int i = 0; i < countPlaces; i++)
                {
                    var aircraft = level[i];
                    if (aircraft != null)
                    {
                        //если место не пустое          
                        //Записываем тип мшаины            
                        if (aircraft.GetType().Name == "Aircraft")
                        {
                            writer.Write(i + ":Aircraft:");
                        }
                        if (aircraft.GetType().Name == "AttackAircraft")
                        {
                            writer.Write(i + ":AttackAircraft:");
                        }
                        //Записываемые параметры           
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
                return false;
            }
            using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.Default))
            {
                int counter = -1;
                ITransport aircraft = null;

                string tempe = sr.ReadLine();
                if (tempe.Contains("CountLeveles"))
                {
                    //считываем количество уровней   
                    int count = Convert.ToInt32(tempe.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport>>(count);
                }
                else
                {
                    return false;
                }
                while (true)
                {
                    tempe = sr.ReadLine();

                    if (tempe == null)
                        break;
                    //идем по считанным записям           
                    if (tempe == "Level")
                    {
                        //начинаем новый уровень        
                        counter++;
                        parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight)); continue;
                    }

                    if (string.IsNullOrEmpty(tempe))
                    {
                        continue;
                    }
                    if (tempe.Split(':')[1] == "Aircraft")
                    {
                        aircraft = new Aircraft(tempe.Split(':')[2]);
                    }
                    else if (tempe.Split(':')[1] == "AttackAircraft")
                    {
                        aircraft = new AttackAircraft(tempe.Split(':')[2]);
                    }
                    parkingStages[counter][Convert.ToInt32(tempe.Split(':')[0])] = aircraft;
                }
            }
            return true;
        }
    }
}
