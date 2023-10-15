using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRent
{
    internal class BoatShop
    {
        private List<Boat> boats;
        public BoatShop() 
        {
            boats = new List<Boat>();
        }

        public void AddBoat(Boat boat)
        {
            boats.Add(boat);
        }

        public void ShowBoat(int num)
        {
            boats[num].Print();
        }

        public Boat GetBoat(int num)
        {
            return boats[num];
        }

        public void PrintAllBoats()
        {
            Console.WriteLine("В наличии:");
            foreach (Boat boat in boats)
            {
                boat.Print();
            }
        }

        public int GetBoatCount()
        {
            return boats.Count;
        }

    }
}
