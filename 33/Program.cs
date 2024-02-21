using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace _33
{
    class Program
    {
        static void Main()
        {
            IBasedArray[] arrays = new IBasedArray[3];
            IPrintable[] iprint = new IPrintable[4];
            Console.WriteLine("Если хотите ввести все сами, введите 'true', если же нет, то пишите 'false'.");
            bool v = bool.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество элементов для одномерного массива");
            int b = int.Parse(Console.ReadLine());

            OneDimensionalArray one = new OneDimensionalArray(b, v);
            arrays[0] = one;
            iprint[0] = one;
            Console.WriteLine("Введите количество строк и столбцов для двумерного массива");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            MultiDimensionalArray multi = new MultiDimensionalArray(c, d, v);
            arrays[1] = multi;
            iprint[1] = multi;

            Console.WriteLine("Введите количество строк для ступенчатого массива");
            int f = int.Parse(Console.ReadLine());

            JaggedArray jag = new JaggedArray(f, v);
            arrays[2] = jag;
            iprint[2] = jag;

            DaysOfWeekPrinter daysPrinter = new DaysOfWeekPrinter();
            iprint[3] = daysPrinter;

            foreach (IPrintable array in iprint)
            {
                array.Print();
            }

            foreach (IBasedArray array in arrays)
            {
                Console.WriteLine($"Среднее значение: {array.CalculateAverage()}\n");
            }

            one.RemoveDuplicates();
            multi.Snake();
            jag.Rechange();
        }
    }
}