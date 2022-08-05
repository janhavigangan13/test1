using System;

namespace ASSIGNMENT01
{
    internal class avg
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("enter first students avg marks");
                int stud1 = int.Parse(Console.ReadLine());


                Console.WriteLine("enter second students avg marks");
                int stud2 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter third students avg marks");
                int stud3 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter fourth students avg marks");
                int stud4 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter fifth students avg marks");
                int stud5 = int.Parse(Console.ReadLine());



                if (stud1 > stud2 & stud1 > stud3 & stud1 > stud4 & stud1 > stud5)
                {
                    Console.WriteLine($"highest score = {stud1}");
                }
                else if (stud2 > stud1 & stud2 > stud3 & stud2 > stud4 & stud2 > stud5)
                {
                    Console.WriteLine($"highest score = {stud2}");
                }
                else if (stud3 > stud1 & stud3 > stud2 & stud3 > stud4 & stud3 > stud5)
                {
                    Console.WriteLine($"highest score = {stud3}");
                }
                else if (stud4 > stud1 & stud4 > stud2 & stud4 > stud3 & stud4 > stud5)
                {
                    Console.WriteLine($"highest score = {stud4}");
                }
                else if (stud5 > stud1 & stud5 > stud2 & stud5 > stud3 & stud5 > stud4)
                {
                    Console.WriteLine($"highest score = {stud5}");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }
        }
    }
}