namespace KauppakantaTunnilla;

using Microsoft.Data.Sqlite;
class Program
{
    static void Main(string[] args)
    {
        KauppaDB kauppaDB = new KauppaDB();

        while (true)
        {
            Console.WriteLine("Haluatko lisätä tuotteen (L), hakea (H) vai lopettaa (X)?");
            string? vastaus = Console.ReadLine();
            switch (vastaus)
            {

                case "L":
                    Console.WriteLine("Anna tuotteen nimi:");
                    string? nimi = Console.ReadLine();

                    Console.WriteLine("Mikä sen tuotteen hinta on?");
                    double hinta = Convert.ToDouble(Console.ReadLine());

                    // Lisätään tuote.
                    kauppaDB.LisaaTuote(nimi, hinta);
                    break;

                case "H":
                    // Hae tuote tietokannasta.
                    Console.WriteLine("Anna haettavan tuotteen nimi:");
                    string? haettavaNimi = Console.ReadLine();
                    string tuotteet = kauppaDB.HaeTuotteet(haettavaNimi);
                    Console.WriteLine(tuotteet);
                    break;


                case "X":
                    return;

                default:
                    Console.WriteLine("Väärä valinta. Anna L, H tai X.");
                    break;
            }
        }
    }
}