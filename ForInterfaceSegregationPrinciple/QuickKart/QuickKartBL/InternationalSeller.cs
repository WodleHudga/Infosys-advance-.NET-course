using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class InternationalSeller : Seller
    {
        public double ExportCharges { get; set; }
        public InternationalSeller(string sellerId, string sellerName, string[] sellerLocations,
            double exportCharges) : base(sellerId, sellerName, sellerLocations)
        {
            ExportCharges = exportCharges;
        }
        public double CalculateShippingCharges(string destination, IInternationalSellerTaxDetails taxDetails)
        {
            double shippingCharges = 0;

            if (SellerLocations.Contains(destination))
                shippingCharges = ExportCharges + taxDetails.CustomsTax(destination);
            else
                shippingCharges = ExportCharges;

            return shippingCharges;
        }
    }
}
