﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintASequence
{
    static void Main()
    {

        for (int i = 1; i <= 10; i++)
        {
            if(i % 2== 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(i * -1);
            }
        }
        
    }
}

