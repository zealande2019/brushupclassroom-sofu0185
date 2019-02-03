using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class KlasseRum
    {
        public string KlasseNavn { get; set; }
        public List<Studerende> Klasseliste { get; set; }
        public DateTime SemesterStart { get; set; }

        public KlasseRum(string klasseNavn, DateTime semesterStart)
        {
            Klasseliste = new List<Studerende>();
            KlasseNavn = klasseNavn;
            SemesterStart = semesterStart;
        }

        public void HowManyBornInSeason()
        {
            var c = Klasseliste.GroupBy(
                x => Årstid.GetÅrstid(x.Fødselsmåned),
                (k, kl) => new {Årstid = k, Count = kl.Count()});

            // uses foreach to print the result to the console
            foreach (var a in c)
            {
                Console.Write($"{a.Årstid}: {a.Count}; ");
            }
            Console.WriteLine();
        }
    }
}
