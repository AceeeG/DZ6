using System;
using System.IO;


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
        Console.WriteLine("Выберите лодку - введите её порядковый номер\n");
        bool choise_flag = Int32.TryParse(Console.ReadLine(), out int choise_num);
        if (!choise_flag || (choise_num < 1 || choise_num > shop.GetBoatCount()))
            {
                do
                {
                    Console.WriteLine("Нет такого номера, повторите\n");
                    choise_flag = Int32.TryParse(Console.ReadLine(), out choise_num);

                } while (!choise_flag || (choise_num < 1 || choise_num > shop.GetBoatCount()));
            }
        switch (choise_num)
        {
            case 1:
                shop.ShowBoat(0);             
                Boat boat1 = shop.GetBoat(0);
                double price1 = boat1.CalculatePrice();
                Console.WriteLine($"Вы должны заплатить {price1} рублей");
                break;
            case 2:
                shop.ShowBoat(1);
                Boat boat2 = shop.GetBoat(1);
                double price2 = boat2.CalculatePrice();
                Console.WriteLine($"Вы должны заплатить {price2} рублей");
                break;
            case 3:
                shop.ShowBoat(2);
                Boat boat3 = shop.GetBoat(2);
                double price3 = boat3.CalculatePrice();
                Console.WriteLine($"Вы должны заплатить {price3} рублей");
                break;
            case 4:
                shop.ShowBoat(3);
                Boat boat4 = shop.GetBoat(3);
                double price4 = boat4.CalculatePrice();
                Console.WriteLine($"Вы должны заплатить {price4} рублей");
                break;
            default:
                Console.WriteLine("Такого номера нет");
                break;
            }

                 



            Console.ReadKey();
        }
    }
}
