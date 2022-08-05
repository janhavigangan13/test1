using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT01
{
    internal class AreaCircumference
    {
        static void Main(string[] args)
        {
            try
            {
                double radius;
                double area = 0;
                double circumference = 0;

                Console.WriteLine("Enter the radius of circle");
                radius = double.Parse(Console.ReadLine());

                area = Math.PI * radius * radius;
                Console.WriteLine($"Area of circle ={area}");

                circumference = 2 * Math.PI * radius;
                Console.WriteLine($"circumference of circle = {circumference}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }




        }
    }
}
