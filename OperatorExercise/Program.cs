using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 9;
            Console.WriteLine($"{a} + {b} is " + (a + b));
            Console.WriteLine($"{a} - {b} is " + (a - b));
            Console.WriteLine($"{a} * {b} is " + (a * b));
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} with a remainder of {remainder}");
            Console.WriteLine("\n\n What is the radius of your circle?");
            var input = Console.ReadLine();
            int radius = (input!=null) ?  int.Parse(input) : 1;
            Console.WriteLine("The area of the circle is "+AreaOfCircle(radius));
        }
        public static double AreaOfCircle(int radius)
        {
            return(Math.PI * radius);
        }
    }
}
