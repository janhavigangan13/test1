using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT05
{
    internal class team
    {
        public static void Main()
        {
          
            Player India = new Player();
            string[] player = new string[3] { "Dhoni", "Virat", "Rohit" };
            int[] r = new int[3] { 200, 500, 400 };
            foreach (string s in player)
            {
                Console.WriteLine($"player {s} ");
            }

            foreach (int i in r)
            {
                Console.WriteLine($"{i} runs");
            }

        }
    }
}
