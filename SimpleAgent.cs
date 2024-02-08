using System.Xml.Linq;

namespace SchoolApp;

public class SimpleAgent
{
    //Parameters
    private string ime = "";
    int years = 0;

    //TextMessages
    private string hello = "Zdravo";
    private string askName = "Zdravo, Kako se Zoves?";
    private string askYears = "Koliko godina imas";
    private string tooYung = "Jako si mlad";
    private string midAge = "Trebalo bi da razmisljas o fakultetu....";
    private string oldAge = "Trebalo bi da razmisljas o usavrsavanju na poslu....";
    private string tooOldAge = "Trebalo bi da razmisljas o penzionisanju....";

    public void TryAgent()
    {
        GetName();
        //GetYearsOld(ime);
        GetYearsOldSwitch();
    }

    public void GetName()
    {
        // Hello and get Name
        Console.WriteLine("");

        Console.WriteLine(askName);
        var name = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine(hello + " " + name);
    }

    public void GetYearsOldSwitch()
    {
        Console.WriteLine("");
        Console.WriteLine(askYears);
        var yearsOld = int.Parse(Console.ReadLine());

        switch (yearsOld)
        {
            case var age when age <= 0:
                Console.WriteLine("Jos ste niste rodili");
                break;

            case var age when age <= 18:
                Console.WriteLine(tooYung);
                break;

            case var age when age > 18 && age <= 25:
                Console.WriteLine(midAge);
                break;

            case var age when age > 25 && age <= 63:
                Console.WriteLine(oldAge);
                break;

            case var age when age > 63:
                Console.WriteLine(tooOldAge);
                break;
        }

    }

    public void GetYearsOld(string name)
    {
        Console.WriteLine("");
        Console.WriteLine(askYears + " " + name);
        var yearsOld = int.Parse(Console.ReadLine());

        if (yearsOld <= 18)
            Console.WriteLine(tooYung);

        if (yearsOld > 18 && yearsOld <= 25)
            Console.WriteLine(midAge);

        if (yearsOld > 25 && yearsOld <= 63)
            Console.WriteLine(oldAge);

        if (yearsOld > 63)
            Console.WriteLine(tooOldAge);
    }
}
