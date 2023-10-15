using System;
using System.Collections.Generic;

namespace BoatRent
{
    internal class BoatShop
    {
        private List<Boat> boats;
        
        /// <summary>
        /// Cоздает список с экземплярами класса
        /// </summary>
        public BoatShop() 
        {
            boats = new List<Boat>();
        }

        /// <summary>
        /// Доавляет экземпляр в список
        /// </summary>
        /// <param name="boat"></param>
        public void AddBoat(Boat boat)
        {
            boats.Add(boat);
        }

        /// <summary>
        /// Выводит информацию об экземпляре,находящегося в списке
        /// </summary>
        /// <param name="num"> Индекс экземпляра </param>
        public void ShowBoat(int num)
        {
            boats[num].Print();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"> Индекс экземпляра </param>
        /// <returns> Экземпляр класса </returns>
        public Boat GetBoat(int num)
        {
            return boats[num];
        }

        /// <summary>
        /// Выводит информацию о всех экземплярах списка
        /// </summary>
        public void PrintAllBoats()
        {
            Console.WriteLine("В наличии данные лодки:\n");
            foreach (Boat boat in boats)
            {
                boat.Print();
            }
        }

        /// <summary>
        /// Выводит количество экземпляров в списке
        /// </summary>
        /// <returns></returns>
        public int GetBoatCount()
        {
            return boats.Count;
        }

    }
}
