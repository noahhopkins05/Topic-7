using static System.Formats.Asn1.AsnWriter;

namespace Topic_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int inputNum;
            int listNum = 0;
            int[] list = new int[25];
            Random generator = new Random();
            Console.WriteLine("hi");

            while (listNum <= 25)
            {

            }

            Console.WriteLine("1 - Sort the list");
            Console.WriteLine("2 - Make a new list of random numbers");
            Console.WriteLine("3 - Remove a number");
            Console.WriteLine("4 - Add a value");
            Console.WriteLine("5 - Count the number of occurences of a specific number");
            Console.WriteLine("6 - Print the largest value");
            Console.WriteLine("7 - Print the smallest value");
            Console.WriteLine("8 - Quit");
            Console.WriteLine(list);
            input = Console.ReadLine();

            if (Int32.TryParse(input, out inputNum))
            {

            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }

        }
    }
}