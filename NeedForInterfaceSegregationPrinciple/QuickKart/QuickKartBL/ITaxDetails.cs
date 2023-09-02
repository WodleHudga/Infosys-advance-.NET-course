using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public interface ITaxDetails
    {
        string[] LocalCities { get; set; }
        string[] ForeignCountries { get; set; }
        double ServiceTax(string destination);
        double CustomsTax(string destination);
        double PropertyTax(string propertyType);
    }
}
