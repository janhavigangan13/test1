using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT01
{
    internal class swap
    {
        static void Main(string[] args)
        {
            swap swap = new swap();
            swap.swapnum();
        }

        public void swapnum()
        {
            int temp = 0;
            int num1;
            int num2;

            Console.WriteLine("enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;              //temp=4
            num1 = num2;            //num1=5
            num2 = temp;            //num2=4

            Console.WriteLine("Ater swapped");

            Console.WriteLine($"First number = {num1}");
            Console.WriteLine($"second number = {num2}");



        }
    }
}