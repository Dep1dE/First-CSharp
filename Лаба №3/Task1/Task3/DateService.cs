using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class DateService
    {
        public void GetDay(string date)
        {
            try
            {
                DateTime datevalue= DateTime.Parse(date);
                Console.WriteLine(datevalue.DayOfWeek);
            }
            catch {
                Console.WriteLine("Неправильный формат даты");
            }
        }
        public void GetDaysSpan(int day, int month, int year)
        {
            try
            {
                DateTime date1 = DateTime.Today;
                DateTime date2 = new DateTime(year, month, day);
                Console.WriteLine(date1.Subtract(date2).TotalDays);
            }
            catch{
                Console.WriteLine("Неправильный формат даты");
            }
        }
    }
}
