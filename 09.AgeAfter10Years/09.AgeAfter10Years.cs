using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your AGE: ");
        int age = int.Parse(Console.ReadLine());
        age += 10;
        Console.WriteLine("Your age after ten years will be: {0}",age);
    }
}

