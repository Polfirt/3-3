using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    public class MultiDimensionalArray : ArrayBase, ISolidSnake
    {
        private int[,] array;

        public MultiDimensionalArray(int rows, int columns, bool userInput = false)
        {
            array = new int[rows, columns];
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
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 101);
                }
            }
        }


        public override void Initialize()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"Введите значение элемента [{i},{j}]: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void Snake()
        {
            Console.WriteLine("Двумерный массив змейкой: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = array.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                else
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public override void Print()
        {
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public override double CalculateAverage()
        {
            double sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            return sum / (array.GetLength(0) * array.GetLength(1));
        }
    }
}
