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

        public Pokemon(string Name, string MoveA1, string MoveA2, string MoveB1, string MoveB2)
        {
            this.Name = Name;
            MoveA.Add(MoveA1);
            MoveA.Add(MoveA2);
            MoveB.Add(MoveB1);
            MoveB.Add(MoveB2);
        }

        public Pokemon(string Name, List<string> MoveA,  List<string> MoveB)
        {
            this.Name = Name;
            this.MoveA.AddRange(MoveA);
            this.MoveB.AddRange(MoveB);
        }
    }
}
