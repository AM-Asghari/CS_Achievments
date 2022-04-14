using System;
class Program
{
    static string VoorAchter(string VoorNaam, string AchterNaam)
    {
        string separator = " ";
        string result = VoorNaam + separator + AchterNaam;
        return result;
    }
    static void Main()
    {
        Console.WriteLine(VoorAchter("Mosawer", "Asghari"));
    }
}