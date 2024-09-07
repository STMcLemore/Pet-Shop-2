using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop_2.ProductOperations
{
    internal static class DecimalExtensions
    {
        public static decimal DiscountThisPrice(this decimal value)
        {
            return Math.Round(value * 0.9M, 2);
        }
    }
}
