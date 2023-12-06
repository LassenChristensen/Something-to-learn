// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Velkommen til din lommeregner");
        float pi = 3.141592653589793238462643383279502884197169399375105820974944592307816406286f;
        Console.WriteLine("Indtast radius");
        string radius = Console.ReadLine();
        float radius1 = float.Parse(radius);
        float areal = pi * radius1 * radius1;
        Console.WriteLine("Arealet er " + areal);
        Console.WriteLine("Indtast højde");
        string højde = Console.ReadLine();
        float højde1 = float.Parse(højde);
        float rumfang = areal * højde1;
        Console.WriteLine("Rumfanget er " + rumfang);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}