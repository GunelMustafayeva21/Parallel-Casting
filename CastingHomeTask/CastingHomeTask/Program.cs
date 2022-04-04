using CastingHomeTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingHomeTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            USD usd = new USD(700);
            AZN azn = new AZN(1000);
            EUR euro= new EUR(700);

            AZN azn1 = usd;
            AZN azn2 = euro;

            USD usd1 = azn;
            USD usd2 = euro;

            EUR euro1 = azn;
            EUR euro2 = usd;

            Console.WriteLine(azn > usd);
            Console.WriteLine(azn > euro);
            Console.WriteLine(usd > euro);

        }
    }
}
