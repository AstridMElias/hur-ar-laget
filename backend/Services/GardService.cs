using System; //Adresser och verktyg man lånar
using HurArLaget.Backend.Models; //Adresser using, verktyg man lånar

namespace HurArLaget.Backend.Services // viken mapp filen finns
{
    public class GardService //Behållare för våra funktioner som har med gårdar att göra
    {
        // Mina metoder
        public bool ValideraStatus(string statusen)
        {
           if (statusen == "Röd" || statusen == "Orange" || statusen == "Grön")
            {
                return true;
            }
            return false;
        }

        public bool ValideraNamn (string namnet)
        {
            if (string.IsNullOrEmpty(namnet))
            {
                return false;
            }
            return true;
        }

        public bool ValideraKommentar(string texten)
        {
            //logiken
            if (string.IsNullOrEmpty(texten))
            {
                return false;
            }
            return true;
        }
    }
}