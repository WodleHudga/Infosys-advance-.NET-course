﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public interface IInternationalSellerTaxDetails
    {
        string[] ForeignCountries { get; set; }
        double CustomsTax(string destination);
    }

}
