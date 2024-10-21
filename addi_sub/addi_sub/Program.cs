using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1

{
    /*
    class Program
    {
        //prime number 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int status = 0;
            int i = 2;
            while (i < num / 2)
            {
                if (num % i == 0)
                {
                    status = 1;
                    break;
                }
                i++;
            }
            if (status == 1)
            {
                Console.WriteLine("The number is Composite");
            }
            else
            {
                Console.WriteLine("The number is prime");
            }
            Console.Read();
        }
    }
}
*/


    /*obtains four int values from the user and displays the product. 
    {
    class Program
    {
    static void Main(string[] args)
    {
    int prod = 1;
    for (int i = 1; i < 5; i++)
    {
    Console.WriteLine("Enter Number " + i);
    int num = Convert.ToInt32(Console.ReadLine());
    prod = prod * num;
    }
    Console.WriteLine("The product of given numbers is : " + prod);
    Console.Read();
    }
    }
    }  */


    /*Generate Fibonacci series.
 class Program
 {

     static void Main(string[] args)
     {
         int n1 = 0;
         int n2 = 1;
         int sum = n1 + n2;
         int lim = 20;
         Console.WriteLine("Fibonacci series: ");
         Console.WriteLine(n1);
         while (sum < lim)
         {
             Console.WriteLine(sum);
             sum = n1 + n2;
             n1 = n2;
             n2 = sum;
         }
         Console.Read();
     }
 }
}*/


    /* check vowel 
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter character: "); String num = Console.ReadLine();
            int status = 0;
            string[] vovels = { "a", "e", "i", "o", "u" }; foreach (var character in vovels)
            {
                if (character == num)
                {
                    status = 1;
                    break;
                }
            }
            if (status == 1)
            {
                Console.WriteLine("The character is Vowel");
            }
            else
            {
                Console.WriteLine("The character is Consonent");
            }
            Console.Read();
        }
    }
}*/
       /*
    class Program
    {
        static void fact()
        {
            Console.Write("Enter a number to find factorial: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0 || n == 1)
                n = 1;
            long fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"Factorial of {n} is: {fact}");

            Console.ReadLine();
        }
        static void mconvert()
        {
            Console.Write("Enter amount in USD: ");
            decimal usd = Convert.ToDecimal(Console.ReadLine());

            decimal convertedAmount = ConvertToINR(usd);

            Console.WriteLine($"Amount in INR: {convertedAmount}");

            Console.ReadLine();
        }
        static decimal ConvertToINR(decimal usd)
        {
            decimal conversionRate = 79;
            return usd * conversionRate;
        }
        static void qequation()
        {
            Console.WriteLine("Enter coefficients (a, b, c) of the quadratic equation ax^2 + 	bx + c = 0:");
            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine($"Roots are real and different.\nRoot1 = {root1},Root2 = 	{ root2} ");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"Roots are real and same.\nRoot = {root}");
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine($"Roots are complex.\nRoot1 = {realPart} + 			   {imaginaryPart}i, 	Root2 = {realPart} - {imaginaryPart}i");
            }

            Console.ReadLine();
        }
        static void temp()
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsius * 9 / 5 + 32;
            double kelvin = celsius + 273.15;
            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
            Console.WriteLine($"Temperature in Kelvin: {kelvin}");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1-Find Factorial");
            Console.WriteLine("2-Money Conversion");
            Console.WriteLine("3-Solve Quadratic Equation");
            Console.WriteLine("4-Temperature Conversion");
            Console.WriteLine("Select Operation to perform :");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    fact();
                    break;
                case 2:
                    mconvert();
                    break;
                case 3:
                    qequation();
                    break;
                case 4:
                    temp();
                    break;
                default:
                    Console.WriteLine("Invalid Option Selected");
                    break;
            }

        }
    }
}*/










