using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseTracker
{
    public class Expense
    {
        public string Description;
        public string Category;
        public int Amount;
        public DateTime Date;

        public override string ToString()
        {
            return $"{Date.ToString("yyyy-MM-dd")} - {Category} - {Description} ({Amount:N0}원)";
        }
    }
}
