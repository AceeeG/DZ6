namespace BoatRent
{

    internal abstract class Boat
    {
        protected string name;

        public string Name
        {
            get 
            {
                return name; 
            }
            set 
            { 
                name = value; 
            }
        }
        
        protected uint capacity;

        public uint Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        protected double rent_price;

        public double RentPrice
        {
            get
            {
                return rent_price;
            }
            set 
            {
                rent_price = value;
            }
        }

        /// <summary>
        /// Заполняет экзепляр класса Boat
        /// </summary>
        /// <param name="name"></param>
        /// <param name="capacity"></param>
        /// <param name="rent_price"></param>
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
