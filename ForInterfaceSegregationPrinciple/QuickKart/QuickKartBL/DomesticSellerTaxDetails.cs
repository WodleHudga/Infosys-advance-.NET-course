using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class DomesticSellerTaxDetails : IDomesticSellerTaxDetails
    {
    
    
        public double ServiceTax(string destination)
        {
            double serviceTax = 0.0;

            if (LocalCities.Contains(destination))
            {
                serviceTax = 10;
            }
            else
            {
                serviceTax = 5;
            }

            return serviceTax;
        }
    }
}
