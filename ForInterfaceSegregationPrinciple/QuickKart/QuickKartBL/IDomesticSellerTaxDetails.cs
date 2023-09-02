using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public interface IDomesticSellerTaxDetails
    {
        string[] LocalCities { get; set; }
        double ServiceTax(string destination);
    }

}
