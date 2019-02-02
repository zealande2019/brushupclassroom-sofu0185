using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public static class Årstid
    {
        public static string GetÅrstid(int month)
        {
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    return "Vinter";
                case 3:
                case 4:
                case 5:
                    return "Forår";
                case 6:
                case 7:
                case 8:
                    return "Sommer";
                case 9:
                case 10:
                case 11:
                    return "Efterår";
                default:
                    throw new ArgumentOutOfRangeException("fødselsmåned", "fødselsmåned angivet er ikke valid.");
            }
        }
    }
}
