using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintLongSequence
{
    static void Main()
    {
        string[] numbers = new string[1000];
        

        for (int i = 0; i < 1000; i++)
        {
            if(i % 2 ==0)
            {
                numbers[i] = i.ToString();
            }
            else
            {
                numbers[i] = (i * -1).ToString();
            }
        }
        foreach (var item in numbers)
        {
            Console.Write(item);
        }
    }
}

