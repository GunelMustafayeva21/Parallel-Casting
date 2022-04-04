using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingHomeTask.Models
{
    public class USD
    {
        public double Amount { get; set; }
        public USD(double Amount)
        {
            this.Amount = Amount;
        }
        //For Manat
        public static implicit operator USD(AZN azn)
        {
            return new USD(azn.Amount * 0.59);
        }

        //For Euro
        public static implicit operator USD(EUR euro)
        {
            return new USD(euro.Amount * 1.1);
        }
        //For Manat
        public static bool operator >(USD u, AZN azn)
        {
            return u.Amount > (azn.Amount *0.59);
        }
        public static bool operator <(USD u, AZN azn)
        {
            return u.Amount < (azn.Amount * 0.59);
        }
        //For Euro
        public static bool operator >(USD u, EUR euro)
        {
            return u.Amount > (euro.Amount * 1.1);
        }
        public static bool operator <(USD u, EUR euro)
        {
            return u.Amount <(euro.Amount * 1.1);
        }
    }
}
