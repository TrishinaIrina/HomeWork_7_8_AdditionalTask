using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7_8
{

    public class Money
    {
        private const double RUBLE_EXCHANGE_RATE = 5.73;
        private const double DOLLAR_EXCHANGE_RATE = 418.99;
        public string currency { get; set; }
        public double value { get; set; }

        public Money() { }

        public Money(string currency, double value)
        {
            if (value < 0)
                throw new Exception("Значение суммы не может быть отрицательным числом");
            else if (currency == "тенге" || currency == "рубль" || currency == "доллар")
            {
                this.currency = currency;
                this.value = value;
            }
            else
            {
                throw new Exception("Неверно указан тип валюты");
            }
        }
        public static Money operator +(Money sum1, Money sum2)
        {
            Money Summa = new Money();
            Money convertSum1 = СurrencyСonversion(sum1);
            Money convertSum2 = СurrencyСonversion(sum2);
            Summa.currency = "тенге";
            Summa.value = convertSum1.value + convertSum2.value;
            return Summa;
        }

       
        public static Money СurrencyСonversion(Money sum)
        {
            if (sum.currency == "тенге") return sum;
            else if (sum.currency == "рубль")
            {
                double value = sum.value * RUBLE_EXCHANGE_RATE;
                Money convertSum = new Money("тенге", value);
                return convertSum;
            }
            else if (sum.currency == "доллар")
            {
                double value = sum.value * DOLLAR_EXCHANGE_RATE;
                Money convertSum = new Money("тенге", value);
                return convertSum;
            }
            else throw new Exception("Ошибка в сумме подлежащей конвертации");
        }

        public static void PrintMoney(Money sum)
        {
            Console.WriteLine(sum.value + " " + sum.currency);
        }


    }
}
