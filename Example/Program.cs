internal class Program
{
    private static void Main(string[] args)
    {
        float pi = 3.141592653589793238462643383279502884197169399375105820974944592307816406286f;
        Console.WriteLine("Velkommen til din cylinderberegner");
        Console.WriteLine("Indtast radius af cylinderen");
        string radius = Console.ReadLine();
        float radius1;
        if (radius == "pi")
        {
            radius1 = pi;
        }
        else
        {
            radius1 = float.Parse(radius);
        }
        float areal = pi * radius1 * radius1;
        Console.WriteLine("Arealet er " + areal);
        Console.WriteLine("Indtast højde");
        string højde = Console.ReadLine();
        float højde1;
        if (højde == "pi")
        {
            højde1 = pi;
        }
        else
        {
            højde1 = float.Parse(radius);
        }
        float rumfang = areal * højde1;
        Console.WriteLine("Rumfanget er " + rumfang);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}