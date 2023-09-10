using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operator1 = ("+");
            string operator2 = ("-");
            string operator3 = ("*");
            string operator4 = ("/");

            Console.Write("Choose an operator: ");
            string Answer1 = Console.ReadLine();
            Console.Write("Write First Number: ");
            int NUM1 =  Convert.ToInt32(Console.ReadLine());
            Console.Write("Write Second Number: ");
            int NUM2 = Convert.ToInt32( Console.ReadLine());
            
            if (Answer1 == operator1) {
                Console.WriteLine(NUM1 + NUM2);
                Console.ReadLine();
                return;
            }
            else if (Answer1 == operator2) {
                Console.WriteLine(NUM1 - NUM2);
                Console.ReadLine();
                return;
            }
            else if (Answer1 == operator3)
            {
                Console.WriteLine(NUM1 * NUM2);
                Console.ReadLine();
                return;
            }
            else if (Answer1 == operator4)
            {
                Console.WriteLine(NUM1 / NUM2);
                Console.ReadLine();
                return;
            }
            else { Console.WriteLine("please write a valid operator");
                Console.ReadLine();
            }
            
            
        }
    }
}
