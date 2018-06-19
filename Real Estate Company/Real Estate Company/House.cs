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
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
