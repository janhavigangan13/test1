using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT05
{
    internal class Player
    {
        public string Name;
        public int runs;

        public string getData()
        {
            return "Player " + this.Name + " scored " + this.runs + " runs ";
        }
    }
}
