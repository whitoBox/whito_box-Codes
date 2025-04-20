using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07KimYoHan
{
    public class Product
    {
        public String Name;
        public String Code;
        public int Price;
        public int Stock;
        public DateTime RegDate;

        public override string ToString()
        {
            return $"[{Code}] {Name}";
        }

        public int SalePrice()
        {
            if (RegDate < DateTime.Now.AddDays(-30))
            {
                return (int)(Price * 0.7);
            }
            else
            {
                return Price;
            }
        }
        public int CalPrice(int count)
        {
            return count * SalePrice();
        }
    }
}
