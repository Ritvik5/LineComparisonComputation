namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program\n");

            /*//Points of Line1
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
            }*/

            //Coordinates of First Line

            int x1 = 2;
            int y1 = 4;
            int x2 = 3;
            int y2 = 6;

            //Coordinates of Second Line

            int x3 = 5;
            int y3 = 10;
            int x4 = 6;
            int y4 = 12;

            double lengthOfALine1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double lengthOfALine2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

            int result = lengthOfALine1.CompareTo(lengthOfALine2);

            if( result > 0 )
            {
                Console.WriteLine("First Line is greater than the second line.");
            }
            else if(result < 0)
            {
                Console.WriteLine("Second Line is greater than the second line.");
            }
            else
            {
                Console.WriteLine("Both lines are equal.");
            }
        }
    }
}