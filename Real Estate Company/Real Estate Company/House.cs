namespace Real_Estate_Company
{
    public class House : RealEstate
    {
        private double squarMeterBuildUpArea;
        private double squarMeterYard;
        private int floors;
        private bool furnishing;

        public House(double area, double pricePerSquareMeter, string location, double squarMeterBuildUpArea, double squarMeterYard, int floors, bool furnishing)
            : base(area, pricePerSquareMeter, location)
        {
            this.SquarMeterBuildUpArea = squarMeterBuildUpArea;
            this.SquarMeterYard = squarMeterYard;
            this.Floors = floors;
            this.Furnishing = furnishing;
        }

        public double SquarMeterBuildUpArea {
            get {return this.squarMeterBuildUpArea; }
            private set {this.squarMeterBuildUpArea = value; }
        }

        public double SquarMeterYard
        {
            get { return this.squarMeterYard; }
            private set { this.squarMeterYard = value; }
        }

        public int Floors
        {
            get { return this.floors; }
            private set { this.floors = value; }
        }

        public bool Furnishing
        {
            get { return this.furnishing; }
            private set { this.furnishing = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {this.Floors}, {this.SquarMeterYard}, {this.Furnishing}, {this.SquarMeterBuildUpArea}";
        }
    }
}
