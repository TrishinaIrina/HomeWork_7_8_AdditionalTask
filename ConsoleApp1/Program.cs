using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_7_8;

namespace ConsoleApp1
{
    //ДОПОЛНИТЕЛЬНО.
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //1.Создать класс с несколькими свойствами. Реализовать перегрузку операторов ==, != и Equals.
                Rectangle rectangle1 = new Rectangle(6, 5);
                Rectangle rectangle2 = new Rectangle(3, 10);
                if (rectangle1 == rectangle2)
                    Console.WriteLine("Прямоугольники равны");
                else
                    Console.WriteLine("Прямоугольники не равны");
                if (rectangle1.Equals(rectangle2))
                    Console.WriteLine("Площадь прямоугольников равна");

                //2.Дан класс сожержащий внутри себя массив. Реализовать перегрузку операторов < , > так, 
                //чтобы если сумма элементов массива 1 класса больше, возвращалось значение true и наоборот.
                Arrays arr1 = new Arrays(5);
                Arrays.PrintArray(arr1.array);
                System.Threading.Thread.Sleep(2);
                Arrays arr2 = new Arrays(6);
                Arrays.PrintArray(arr2.array);

                if (arr1 > arr2)
                    Console.WriteLine("Cумма элементов первого массива больше");

                else if (arr1 < arr2)
                    Console.WriteLine("Cумма элементов второго массива больше");

                else
                    Console.WriteLine("Cуммы элементов двух массивов равны");


                /*3.Задание на примере из урока:
                Необходимо реализовать второй вариант сложения денег – чтобы можно было суммировать деньги в разных валютах. 
                Для этого создайте отдельный класс, который будет предоставлять механизм конвертации денег по заданному курсу.
                Кроме этого, перегрузите для класса Money оператор сравнения «==» (при перегрузке данного оператора, 
                обязательной является и перегрузка противоположного ему оператора «!=»).
                */

                Money money1 = new Money("тенге", 10000);
                Money money2 = new Money("тенге", 250);
                Money.PrintMoney(money1 + money2);
                Money money3 = new Money("рубль", 70000);
                Money.PrintMoney(money3 + money2);







            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
