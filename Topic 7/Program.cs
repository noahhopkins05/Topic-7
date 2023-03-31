using static System.Formats.Asn1.AsnWriter;

namespace Topic_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int inputNum, listSum, listAverage, listMin, listMax;
            int listLength = 25;
            int[] list = new int[listLength];
            Random generator = new Random();

            Console.WriteLine("Before we begin what should be the lowest and highest possible number on the list?");
            Console.WriteLine("List Minimum: ");
            listMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("List Maximum: ");
            listMax = Convert.ToInt32(Console.ReadLine());     

            for (int listNum = 0; listNum < list.Length;)
            {
                list[listNum] = generator.Next(listMin, listMax);
                listNum++;
            }


            while (true)
            {             
                Console.WriteLine("1 - Sort the list");
                Console.WriteLine("2 - Make a new list of random numbers");
                Console.WriteLine("3 - Remove a number");
                Console.WriteLine("4 - Add a value");
                Console.WriteLine("5 - Count the number of occurences of a specific number");
                Console.WriteLine("6 - Print the largest value");
                Console.WriteLine("7 - Print the smallest value");
                Console.WriteLine("8 - Get the average of the numbers in the list");
                Console.WriteLine("9 - Make a new list of random numbers with a new minimum and maximum");
                Console.WriteLine("10 - Quit");
                Console.WriteLine();
                input = Console.ReadLine();
                Console.WriteLine();

                if (Int32.TryParse(input, out inputNum))
                {
                    if (inputNum == 1)
                    {
                        Array.Sort(list);
                        foreach (int i in list)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Thread.Sleep(250);
                    }
                    else if (inputNum == 2)
                    {                  
                        for (int listNum = 0; listNum < list.Length;)
                        {
                            list[listNum] = generator.Next(listMin, listMax);
                            listNum++;
                        }
                        foreach (int i in list)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Thread.Sleep(250);
                    }
                    else if (inputNum == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Thread.Sleep(250);

                    }
                    else if (inputNum == 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Thread.Sleep(250);

                    }
                    else if (inputNum == 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Thread.Sleep(250);

                    }
                    else if (inputNum == 6)
                    {
                        Console.WriteLine(list.Max());
                        Console.WriteLine();
                        Console.WriteLine();
                        Thread.Sleep(250);

                    }
                    else if (inputNum == 7)
                    {
                        Console.WriteLine(list.Min());
                        Console.WriteLine();
                        Console.WriteLine();
                        Thread.Sleep(250);

                    }
                    else if (inputNum == 8)
                    {
                        listSum = list.Sum();
                        listAverage = listSum / listLength;
                        Console.WriteLine(listAverage);
                        Console.WriteLine();
                        Console.WriteLine();
                        Thread.Sleep(250);
                    }
                    else if (inputNum == 9)
                    {
                        Console.WriteLine("List Minimum: ");
                        listMin = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("List Maximum: ");
                        listMax = Convert.ToInt32(Console.ReadLine());
                      
                        for (int listNum = 0; listNum < list.Length;)
                        {
                            list[listNum] = generator.Next(listMin, listMax);
                            listNum++;
                        }
                        foreach (int i in list)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Thread.Sleep(250);
                    }
                    else if (inputNum == 10)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again."); 
                    Thread.Sleep(250);
                }

            }
        }
    }
}