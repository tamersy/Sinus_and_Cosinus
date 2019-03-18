using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinus_and_Cosinus
{
    class Program
    {
        //Procedure for sinus
        static void Sin(double Number)
        {
            Console.WriteLine($"Sin({Number}) = {Math.Sin(Number)}");
        }

        //Procedure for cosinus
        static void Cos(double Number)
        {
            Console.WriteLine($"Cos({Number}) = {Math.Cos(Number)}");
        }

        static void Main(string[] args)
        {
            //Message to tell the user that he/she must enter a number
            Console.WriteLine("Please, Enter a number :");
            
            //Enter the number
            double Num = Convert.ToDouble(Console.ReadLine());

            //The sinus of the number
            Sin(Num);

            //The cosinus of the number
            Cos(Num);

            //Stop screen
            Console.ReadKey();
        }
    }
}
