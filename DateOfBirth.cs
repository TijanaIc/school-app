namespace SchoolApp;

public class DateOfBirth
{
    public static void GetDateOfBirth()
    {
        Console.WriteLine("Unesite datum rodjenja");
        string input = Console.ReadLine();
        DateTime dateOfBirth = DateTime.Parse(input);
        TimeSpan ts = DateTime.Now - dateOfBirth;
        int years = (int)ts.TotalDays / 365;
        int days = (int)ts.TotalDays % 365;
        Console.WriteLine($"Imate {years} godina i {days} dana ili ukupno {(int)ts.TotalDays} dana");
    }
}
