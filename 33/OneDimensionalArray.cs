using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    public class OneDimensionalArray : ArrayBase, IRemover
    {
        private int[] array;

        public OneDimensionalArray(int size, bool userInput = false)
        {
            array = new int[size];
            if (userInput)
            {
                Initialize();
            }
            else
            {
                RandomInitialize();
            }
        }
        public override void RandomInitialize()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
            }
        }
        public void RemoveDuplicates()
        {
            array = array.Distinct().ToArray();
            Console.WriteLine("Одномерный массив с удаленными дубликатами:");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public override void Initialize()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите значение элемента {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public override void Print()
        {
            Console.WriteLine("Одномерный массив:");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public override double CalculateAverage()
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }
    }
}
