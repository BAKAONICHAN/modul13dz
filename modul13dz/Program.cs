using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace modul13dz
{
    class Program
    {

        static void Main(string[] args)
        {
            int sum = 0;
            int maxElement = 0;
            int secondMax = 0;
            List<int> list = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rand.Next(100));
            }

            list.Sort();
            int[] mas = list.ToArray();
            maxElement = list.Last();            
            for (int i = 1; i < 10; i++)
            {
                if (mas[i] < maxElement)
                {
                    secondMax = mas[i];
                }
                if (mas[i] % 2 == 0)
                {
                    sum = sum + mas[i];
                }
                WriteLine(mas[i]);
            }

            WriteLine(maxElement);
            WriteLine("Второй по величине элемент:" + secondMax);
            WriteLine("Сумма элементов на четных позициях:" + sum);
            ReadLine();
        }
    }
}

