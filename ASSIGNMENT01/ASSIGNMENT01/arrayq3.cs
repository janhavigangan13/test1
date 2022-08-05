using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT01
{
    internal class arrayq3
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[20];
                int sum = 0;
                int i;


                Console.WriteLine("enter the number array elements");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("enter the array elements");
                for (i = 0; i < num; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("array list is");
                for (i = 0; i < num; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                for (i = 0; i < num; i++)
                {
                    sum = sum + arr[i];
                }
                Console.WriteLine($"sum of array integers is {sum}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }
        }
    }
}
