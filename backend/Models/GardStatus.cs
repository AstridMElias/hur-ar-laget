using System; // Använder C# inbyggda verktyg

namespace HurArLaget.Backend.Models // Filens adress HurArLaget -> Backend -> Models
{
    // public - Öppen för andra mappar att läsa och använda
    public class GardStatus
    {
        //Är ID på fastigheten.
        // get- kod tillåtelse att läsa fältet.
        // Set- tillåtelse skriva nytt värde.
        public string Objektsnummer { get; set; }

        //Namn på gården
        public string Gardsnamn { get; set; }

        // Namn på delar av större gårdar
        public string Smeknamn { get; set; }

        // Är gården klar eller ej påbörjad Grön-klar, Röd-Ej påbörjad, Orange-delvis klar
        public string Status { get; set; }

        //Vem uppdaterade senast
        public string SenastUppdateradAv { get; set; }

        //Tid och datum sparas ifall man behöver gå tillbaka och titta
        public DateTime UppdateradTid { get; set; } = DateTime.Now;
    }
}