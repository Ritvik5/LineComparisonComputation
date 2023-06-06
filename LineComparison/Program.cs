namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program\n");

            //Points of Line1
            int a1 = 2;
            int b1 = 4;
            int c1 = 6;

            //Points of Line2
            int a2 = -2;
            int b2 = -4;
            int c2 = -6;

            if( (a1/a2 ==  b1/b2) && (b1/b2 == c1/c2) && (a1/a2 == c1/c2)) 
            {
                Console.WriteLine("The Two Lines are identical.");
            }
            else
            {
                Console.WriteLine("The Two Lines are not identical.");
            }
        }
    }
}