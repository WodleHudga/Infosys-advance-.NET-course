using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class DomesticSeller : Seller
    {
        public bool ExpressDelivery { get; set; }
        public DomesticSeller(string sellerId, string sellerName, string[] sellerLocations,
            bool expressDelivery) : base(sellerId, sellerName, sellerLocations)
        {
            ExpressDelivery = expressDelivery;
        }
        public double CalculateShippingCharges(string destination, IDomesticSellerTaxDetails taxDetails)
        {
            double shippingCharges = 0;

            if (SellerLocations.Contains(destination))
                shippingCharges = 1500 + taxDetails.ServiceTax(destination);
            else
                shippingCharges = 1000;

            if (ExpressDelivery)
                shippingCharges += 250;

            return shippingCharges;
        }
    }
}
