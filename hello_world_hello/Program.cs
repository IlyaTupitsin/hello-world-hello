using System;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        string pattern = @"\b(\w+)\b(.*?)\b\1\b";
        Regex rgx = new Regex(pattern);

        string result = rgx.Replace(input, "<strong>$1</strong>$2<strong>$1</strong>");
        Console.WriteLine(result);
    }
}
