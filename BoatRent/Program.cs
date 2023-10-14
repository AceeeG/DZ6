using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BoatRent
{
    internal class Program
    {
        static void Main(string[] link)
        {
            BoatShop shop = new BoatShop();

            try
        {
            using (StreamReader reader = new StreamReader(link[0]))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    if (data.Length == 5)
                    {
                        string boat_type = data[0];
                        string name = data[1];
                        bool capacity_flag = uint.TryParse(data[2], out uint capacity);
                        bool price_flag = double.TryParse(data[3], out double rent_price);

                        if (boat_type == "MotorBoat")
                        {
                            bool horsepower_flag = Int32.TryParse(data[4], out int horsepower);
                            shop.AddBoat(new MotorBoat(name, capacity, rent_price, horsepower));
                        }
                        else if (boat_type == "ClassicBoat")
                        {
                            bool oars_flag = Int32.TryParse(data[4], out int oars);
                            shop.AddBoat(new ClassicBoat(name, capacity, rent_price, oars));
                        }
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            throw new Exception("Файл не найден\n");
        }

        shop.PrintAllBoats();






            Console.ReadKey();
        }
    }
}
