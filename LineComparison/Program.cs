namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program\n");

            int x1 = 2;
            int x2 = 4;
            int y1 = 6;
            int y2 = 8;

            double lengthOfALine = 0;

            lengthOfALine = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));

            Console.WriteLine("Length of a Line is : " + lengthOfALine);
        }
    }
}