using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace четные_нечетные_числа
{
    internal class Program
    {
        static void Main(string[] args)
            //подсчет четных и нечетных чисел до знач которое задаст пользователь//
        {
            int counteven =0;
            int countodd =0;

           
            int limitcount = int.Parse(Console.ReadLine());
            while (counteven  < limitcount)
            {
                counteven++;
             
                if (counteven % 2 == 0)
                {
                    Console.WriteLine("количество четных чисел");
                }
                else if (counteven % 2 != 0)
                        {
                    Console.WriteLine("количество нечетных чисел");
                }
                else
                {
                    Console.WriteLine("Ошибка!!");
                }
            }
          
                
           
        }
    }
}
