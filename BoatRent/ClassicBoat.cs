using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRent
{
    internal class ClassicBoat : Boat
    {
        public int oars;

        public int Oars
        {
            get
            { 
                return oars; 
            }
            set
            {
                oars = value;
            }
        }


        public ClassicBoat(string name, uint capacity, double rent_price, int horsepower)
            : base(name, capacity, rent_price)
        {
            this.oars = horsepower;
        }

        public override void Print()
        {
            Console.WriteLine($"Лодка {name}, вместимость {capacity} человек(а), кол - во вёсел {oars}\n");
        }

        public override void Start()
        {

            Console.WriteLine($"Начали свой путь на лодке {name}, кол - во вёсел {oars}\n");
        }

        public override void End()
        {
            Console.WriteLine($"Закончили свой путь на лодке {name}, кол - во вёсел {oars}\n");
        }

        public override double CalculatePrice()
        {
            Console.WriteLine("Сколько часов вы плавали\n");
            bool hour_flag = Int32.TryParse(Console.ReadLine(), out int hours);
            if (!hour_flag)
            {
                do
                {
                    Console.WriteLine("Вы не ввели число");
                    hour_flag = Int32.TryParse(Console.ReadLine(), out hours);
                } while (!hour_flag);
            }
            return hours * rent_price;
        }

    }
}
