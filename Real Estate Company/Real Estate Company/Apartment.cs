namespace Real_Estate_Company
{
    public class Apartment : RealEstate
    {
        private int floor;
        private bool elevator;
        private bool furnishing;

        public Apartment(double area, double pricePerSquareMeter, string location, int floor, bool elevator, bool furnishing)
            :base(area, pricePerSquareMeter, location)
        {
            this.Floor = floor;
            this.Elevator = elevator;
            this.Furnishing = furnishing;
        }

        public int Floor
        {
            get { return this.floor; }
            set { this.floor = value; }
        }

        public bool Elevator {
            get { return this.elevator; }
            set { this.elevator = value; }
        }

        public bool Furnishing {
            get { return this.furnishing; }
            set { this.furnishing = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {this.Floor}, {this.Elevator}, {this.Furnishing}";
        }
    }
}
