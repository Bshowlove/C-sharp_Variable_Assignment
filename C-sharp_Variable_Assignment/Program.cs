using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "Polyilaro ";


        Console.WriteLine("Enter an integer value");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a double value");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter a string value");
        string c = Console.ReadLine();


        Console.WriteLine(i + a);
        Console.WriteLine(d + b);
        Console.WriteLine(s + c);

    }
}
