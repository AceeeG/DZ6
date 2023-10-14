using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BoatRent
{

    internal abstract class Boat
    {
        protected string name;

        protected uint capacity;

        protected double rent_price;


        public Boat(string name, uint capacity, double rent_price)
        {
            this.name = name;
            this.capacity = capacity;
            this.rent_price = rent_price;
        }

        public abstract void Print();
        public abstract void Start();
        public abstract void End();

        public abstract double CalculatePrice();
    }
}
