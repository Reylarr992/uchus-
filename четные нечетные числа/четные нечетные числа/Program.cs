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
            double counteven =0.0; //четные
            double countodd =0.0; //нечетные 

           
            double limitcount = double.Parse(Console.ReadLine());
            while (counteven < limitcount)
            {
                
             
                if (counteven % 2 == 0)
                {
                    counteven++;
                    
                }
                else if (countodd % 2 != 0)
                        {
                    countodd++;
                }
                else
                {
                    Console.WriteLine("Ошибка!!");
                }
                Console.WriteLine("количество нечетных чисел: " + countodd);
                Console.WriteLine("количество четных чисел: " + counteven);
                Console.ReadLine();
            }

          
                
           
        }
    }
}
