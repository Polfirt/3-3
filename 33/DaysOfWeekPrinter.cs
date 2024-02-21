using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    class DaysOfWeekPrinter : IPrintable
    {
        public void Print()
        {
            string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
