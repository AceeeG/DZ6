using System;


namespace BoatRent
{
    internal class ClassicBoat : Boat
    {
        private int oars;

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

        /// <summary>
        /// Заполняет экземпляр класса ClassicBoat
        /// </summary>
        /// <param name="name"></param>
        /// <param name="capacity"></param>
        /// <param name="rent_price"></param>
        /// <param name="horsepower"></param>
        public ClassicBoat(string name, uint capacity, double rent_price, int oars)
            : base(name, capacity, rent_price)
        {
            this.oars = oars;
        }

        /// <summary>
        /// Выводит информацию о экземпляре
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Лодка {name}, вместимость {capacity} человек(а), кол - во вёсел {oars}\n");
        }

        /// <summary>
        /// Выводит информацию о экземпляре
        /// </summary>
        public override void Start()
        {

            Console.WriteLine($"Начали свой путь на лодке {name}, кол - во вёсел {oars}\n");
        }

        /// <summary>
        /// Выводит информацию о экземпляре
        /// </summary>
        public override void End()
        {
            Console.WriteLine($"Закончили свой путь на лодке {name}, кол - во вёсел {oars}\n");
        }

        /// <summary>
        /// Высчитывает цену
        /// </summary>
        /// <returns></returns>
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
