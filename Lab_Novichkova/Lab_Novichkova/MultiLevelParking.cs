using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Novichkova
{
    class MultiLevelParking
    {
        List<Parking<ITransport>> parkingStages;
        private int pictureWidth;
        private int pictureHeight;
        private const int countPlaces = 20;

        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
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
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename, false, Encoding.UTF8))
            {
                sw.WriteLine("CountLeveles:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        try
                        {
                            var bus = level[i];
                            if (bus != null)
                            {
                                if (bus.GetType().Name == "Bus")
                                {
                                    sw.Write(i + ":Bus:");
                                }
                                if (bus.GetType().Name == "DoubleBus")
                                {
                                    sw.Write(i + ":DoubleBus:");
                                }
                                sw.WriteLine(bus);
                            }
                        }
                        finally { }
                    }
                }
            }
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            int counter = -1;
            ITransport bus = null;
            using (StreamReader sr = new StreamReader(filename))
            {
                string str = sr.ReadLine();

                if (str.Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(str.Split(':')[1]);
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

                while ((str = sr.ReadLine()) != null)
                {
                    if (str == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Parking<ITransport>(countPlaces,
                        pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(str))
                    {
                        continue;
                    }
                    string[] splitStr = str.Split(':');
                    if (splitStr.Length > 2)
                    {
                        if (splitStr[1] == "Bus")
                        {
                            bus = new Bus(splitStr[2]);
                        }
                        else if (splitStr[1] == "DoubleBus")
                        {
                            bus = new DoubleBus(splitStr[2]);
                        }
                        parkingStages[counter][Convert.ToInt32(splitStr[0])] = bus;
                    }
                }
            }
        }
        public void Sort()
        {
            parkingStages.Sort();
        }
    }
}
