using System.Text;

namespace Real_Estate_Company
{
    public class RealEstate
    {
        private double area;
        private double pricePerSquareMeter;
        private string location;

        public RealEstate(double area, double pricePerSquareMeter, string location)
        {
            this.Area = area;
            this.PricePerSquareMeter = pricePerSquareMeter;
            this.Location = location;
        }

        protected double Area {
            get { return this.area; }
            private set { this.area = value; }
        }

        protected double PricePerSquareMeter {
            get { return this.pricePerSquareMeter; }
            private set { this.pricePerSquareMeter = value; }
        }

        protected string Location {
            get { return this.location; }
            private set { this.location = value; }
        }

        public override string ToString()
        {
            var realEstateType = this.GetType().Name;

            return $"{realEstateType}, {this.Area}, {this.PricePerSquareMeter}, {this.Location}";
        }
    }
}
