using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        // Delegate type
        delegate int Operation(int a, int b);

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Div(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Operation op = Add;
            int res1 = op(2, 3);

            op = Sub;
            int res2 = Sub(5, 2);

            op = Div;
            int res3 = Div(20, 4);
       }
    }
}
