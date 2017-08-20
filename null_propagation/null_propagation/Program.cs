using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null_propagation
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x =123;
            double? y=456.7;
            double? s = x + y;

            x = null;
            s = x + y;
            bool hasValue = x.HasValue;
            string text = x.ToString();
            int valueOrDefault1 = x.GetValueOrDefault();
            int valueorDefault2 = x.GetValueOrDefault(10);  
            int value;
          //  value = x.Value;
            if (y != null)
                Console.WriteLine("not null");
            if (y.HasValue)
                Console.WriteLine("not null");
            value = x ?? 10;
            x = 123;
            value = x ?? 10;
            string firstName = "Madonna";
            string secondName = null;
            string name = firstName + " " + (secondName ?? "[no last name]");
            name = firstName + " " + secondName ?? "[no last  name]";
            name = $"{firstName} {secondName ?? "[no last name]"}";
            //int? length = secondName?.Length;
            //int? length = (secondName == null) ? (int?)null : secondName.Length;
            DateTime? date = null;
            DayOfWeek? dow = date?.DayOfWeek;
        }
       
    }
}
