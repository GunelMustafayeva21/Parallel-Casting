using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingHomeTask.Models
{
    public class AZN
    {
        public double Amount { get; set; }
        public AZN(double Amount)
        {
            this.Amount = Amount;
        }
        //For USD
        public static implicit operator AZN(USD usd)
        {
            return new AZN(usd.Amount * 1.7);
        }

        //For Euro
        public static implicit operator AZN(EUR euro)
        {
            return new AZN(euro.Amount * 1.87);
        }
        //For USD
        public static bool operator >(AZN azn, USD usd )
        {
            return azn.Amount > (usd.Amount * 1.70);
        }
        public static bool operator <(AZN azn, USD usd)
        {
            return azn.Amount < (usd.Amount * 1.70);
        }
        //For Euro
        public static bool operator >(AZN azn, EUR euro)
        {
            return azn.Amount > (euro.Amount * 1.87);
        }
        public static bool operator <(AZN azn, EUR euro)
        {
            return azn.Amount < (euro.Amount * 1.87);
        }
    }
}
