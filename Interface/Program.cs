using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    interface IBinaryOperation
    {
        double A { get; set; }
        double B { get; set; }

        double GetResult();
    }

    public class Adder : IBinaryOperation
    {
        public double A { get; set; }
        public double B { get; set; }

        public double GetResult()
        {
            return A + B;
        }
    }

    public class Multiplier : IBinaryOperation
    {
        public double A { get; set; }
        public double B { get; set; }

        public double GetResult()
        {
            return A * B;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IBinaryOperation op = null;
            double result;

            // Adder implements the interface IBinaryOperation.
            op = new Adder();
            op.A = 2;
            op.B = 3;
       
            result = op.GetResult();

            // Multiplier also implements the interface.
            op = new Multiplier();
            op.A = 5;
            op.B = 4;

            result = op.GetResult(); 
        }
    }
}