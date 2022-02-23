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

        //Print the sum of I plus your int variable
        Console.WriteLine(i + a);
        //Print the sum of d plus your double variable to a scale of one decimal place
        Console.WriteLine(d + b);
        //Concatenate s with the string
        Console.WriteLine(s + c);

    }
}
