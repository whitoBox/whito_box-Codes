using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabraryBook
{

    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public bool IsCheckedOut;
        public DateTime RentDate;

        public DateTime DueDate()
        {
            return RentDate.AddDays(14);
        }

        public bool IsOverDue()
        {
            return DueDate() < DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Title} (저자: {Author})";
        }
    }
}
