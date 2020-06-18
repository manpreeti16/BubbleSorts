using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {            
            BubbleSort();
            EfficientBubbleSortWithReducedPass();

            Console.ReadLine();
        }

        private static void BubbleSort()
        {
            var array = new int[] { 64, 43, 23, 83, 58, 89, 49, 12, 95, 27, 19, 56, 76, 5 };
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Bubble sorted array = " + string.Join(", ", array));
        }

        private static void EfficientBubbleSortWithReducedPass()
        {
            bool swap = true;
            var array = new int[] { 5, 12, 85, 13, 45, 56, 78, 89, 59, 95 };
            for (int i = 1; i < array.Length; i++)
            {
                if (swap)
                {
                    swap = false;
                    for (int j = 0; j < array.Length - i; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            var temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;

                            swap = true;
                        }
                    }
                }

                if (swap == false)
                    break;
            }
            Console.WriteLine("Bubble sorted array with reduced passes = " + string.Join(", ", array));
        }       
       
    }
}
