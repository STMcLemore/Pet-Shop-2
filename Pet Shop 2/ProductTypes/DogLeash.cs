using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop_2.ProductTypes
{
    public class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material { get; set; }
        public DogLeash()
        {
        }
    }
}
