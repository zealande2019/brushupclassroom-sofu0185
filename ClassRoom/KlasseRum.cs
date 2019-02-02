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
            int vinter = 0, forår = 0, sommer = 0, efterår = 0;

            foreach (Studerende s in Klasseliste)
            {
                switch (Årstid.GetÅrstid(s.Fødselsmåned))
                {
                    case "Vinter":
                        vinter++;
                        break;
                    case "Forår":
                        forår++;
                        break;
                    case "Sommer":
                        sommer++;
                        break;
                    case "Efterår":
                        efterår++;
                        break;
                    default:
                        throw new Exception("No valid season");
                }
            }

            Console.WriteLine($"Vinter: {vinter}; Forår: {forår}; Sommer: {sommer}; Efterår: {efterår}");
        }
    }
}
