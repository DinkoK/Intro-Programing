using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintFirstAndLastName
{
    static void Main()
    {
        Console.WriteLine("Enter your First name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter your Last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Your NAME is: " + firstName + " " + lastName);
    }
}

