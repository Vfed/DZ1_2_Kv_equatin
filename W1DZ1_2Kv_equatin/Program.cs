using System;

namespace W1DZ1_2Kv_equatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equation : Ax^2 + Bx + C = 0 ");
            Console.Write("Enter A : ");
            bool a_in = Double.TryParse(Console.ReadLine(), out double a);
            Console.Write("Enter B : ");
            bool b_in = Double.TryParse(Console.ReadLine(), out double b);
            Console.Write("Enter C : ");
            bool c_in = Double.TryParse(Console.ReadLine(), out double c);
            string error = "";
            double x1 = 0, x2 = 0;
            
            if (a_in && b_in && c_in)
            {
                double D = a * a - 4 * b * c;
                if (D < 0)
                {
                    error += "Equation ( " + a + "x ^ 2 + " + b + "x + " + c +"  = 0 ) has no solutions, D= " + D;
                }
                else
                {
                    x1 = (- b - Math.Sqrt(D)) / (2 * a);
                    x2 = (- b + Math.Sqrt(D)) / (2 * a);
                }
            }
            else 
            {
                error += "Some problems with A,B,C input";
            }

            if (error.Length > 0)
            {
                Console.WriteLine(error);
            }
            else
            {
                Console.WriteLine("Equation ( " + a + "x^2 + " + b + "x + " + c + " = 0 ) solutions are : \n x1 = " + x1 + " \n x2 = " + x2);
            }
            Console.ReadKey();
        }
    }
}
