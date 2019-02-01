using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum kr = new KlasseRum("3B", new DateTime(2018, 9, 4));
            kr.Klasseliste.AddRange(new Studerende[] {
                new Studerende("Sofus", 12, 11),
                new Studerende("Tom plads 1", 0, 0),
                new Studerende("Tom plads 2", 0, 0) });
        }
    }
}
