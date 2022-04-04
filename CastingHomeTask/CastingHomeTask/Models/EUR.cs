using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingHomeTask.Models
{
    public class EUR
    {
        public double Amount { get; set; }
        public EUR(double Amount)
        {
            this.Amount = Amount;
        }
        //For USD
        public static implicit operator EUR(USD usd)
        {
            return new EUR(usd.Amount * 0.91);
        }

        //For AZN
        public static implicit operator EUR(AZN azn)
        {
            return new EUR(azn.Amount * 0.54);
        }
        //For USD
        public static bool operator >(EUR euro, USD usd)
        {
            return euro.Amount > (usd.Amount * 0.91);
        }
        public static bool operator <(EUR euro, USD usd)
        {
            return euro.Amount < (usd.Amount * 0.91);
        }
        //For AZN
        public static bool operator >(EUR euro, AZN azn)
        {
            return euro.Amount > (azn.Amount *0.54);
        }
        public static bool operator <(EUR euro, AZN azn)
        {
            return euro.Amount < (azn.Amount * 0.54);
        }
    }
}
