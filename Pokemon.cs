using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniteWheel
{
    public class Pokemon
    {
        public string Name;
        public List<string> MoveA = new List<string>();
        public List<string> MoveB = new List<string>();

        public Pokemon(string Name, List<string> MoveA,  List<string> MoveB)
        {
            this.Name = Name;
            this.MoveA.AddRange(MoveA);
            this.MoveB.AddRange(MoveB);
        }
    }
}
