using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_6__Pythagoras_
{
    class Program
    {
        static void Main(string[] args)
        { int a=0, b=0, c = 0;
            for (a = 0; a<=1000; a++)
            {
                for (b=0; b<=1000; b++)
                {
                    for (c=0; c<=1000; c++)
                    {
                        if ((a * a + b * b == c * c && ((a + b + c) == 1000) && a<b && b<c))
                        {
                            Console.WriteLine("a är: " + a + "     b är : " + b + "     c är : " + c );
                        }
                    }
                }
            }
        }
    }
}
