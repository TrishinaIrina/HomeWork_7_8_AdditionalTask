using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7_8
{
    //Дан класс сожержащий внутри себя массив. Реализовать перегрузку операторов < , > так, 
    //чтобы если сумма элементов массива 1 класса больше, возвращалось значение true и наоборот.
    public class Arrays
    {
        Random rnd = new Random();
        public int[] array;
        private int sum = 0;
        public Arrays(int size)
        {
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(1, 10);
                sum += array[i];
            }
        }

        public static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static bool operator >(Arrays array1, Arrays array2)
        {
            return (array1.sum > array2.sum);
        }

        public static bool operator <(Arrays array1, Arrays array2)
        {
            return (array1.sum < array2.sum);
        }
    }
}