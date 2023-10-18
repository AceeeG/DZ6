using System;


namespace BoatRent
{
    internal class MotorBoat : Boat
    {
        private int horsepower;

        public int Horsepower
        {
            get
            { 
                return horsepower; 
            }
            set
            {
                horsepower = value;
            }
        }

        /// <summary>
        /// Заполняет экземпляр класса MotorBoat
        /// </summary>
        /// <param name="name"></param>
        /// <param name="capacity"></param>
        /// <param name="rent_price"></param>
        /// <param name="horsepower"></param>
        public MotorBoat(string name, uint capacity, double rent_price, int horsepower)
            : base(name, capacity, rent_price)
        {
            this.horsepower = horsepower;
        }

        /// <summary>
        /// Выводит информацию о экземпляре
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Лодка {name}, вместимость {capacity} человек(а), мощность {horsepower} HP\n");
        }

        /// <summary>
        /// Выводит информацию о экземпляре
        /// </summary>
        public override void Start()
        {
            
            Console.WriteLine($"Начали свой путь на лодке {name}, мощностью {horsepower} HP\n");
        }

        /// <summary>
        /// Выводит информацию о экземпляре
        /// </summary>
        public override void End()
        {
            Console.WriteLine($"Закончили свой путь на лодке {name}\n");
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
                    Console.WriteLine("Вы не ввели число\n");
                    hour_flag = Int32.TryParse(Console.ReadLine(), out hours);
                } while(!hour_flag);
            }
            return hours * rent_price;
        }


    }
}
