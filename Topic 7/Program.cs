using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;


namespace Topic_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int inputNum, listSum, listAverage, listMin, listMax, numSearch, removeNum, addNum, numCount;
            int listLength = 25;
            List<int> numbers = new List<int>();
            Random generator = new Random();

            Console.WriteLine("Before we begin what should be the lowest and highest possible number on the list?");
            Console.WriteLine("List Minimum: ");
            listMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("List Maximum: ");
            listMax = Convert.ToInt32(Console.ReadLine());     

            for (int listNum = 0; listNum < listLength; listNum++)
            {
                 numbers.Add(generator.Next(listMin, listMax));          
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
                Console.WriteLine("8 - Get the sum and the average of the numbers in the list");
                Console.WriteLine("9 - Make a new list of random numbers with a new minimum and maximum");
                Console.WriteLine("10 - Quit");
                Console.WriteLine();
                input = Console.ReadLine();

                if (Int32.TryParse(input, out inputNum))
                {
                    Console.Clear();
                    Thread.Sleep(250);
                    if (inputNum == 1)
                    {
                        numbers.Sort();
                        foreach (int i in numbers)
                        {
                            Console.Write(i + ", ");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else if (inputNum == 2)
                    {
                        Thread.Sleep(250);
                        Console.Clear();
                        for (int listNum = 0; listNum < listLength;)
                        {
                            numbers[listNum] = generator.Next(listMin, listMax);
                            listNum++;
                        }
                        foreach (int i in numbers)
                        {
                            Console.Write(i + ", ");
                        }
                        Console.WriteLine();
                        Console.WriteLine();

                    }
                    else if (inputNum == 3)
                    {
                        Console.Clear();
                        Thread.Sleep(250);
                        foreach (int i in numbers)
                        {
                            Console.Write(i + ", ");
                        }
                        Console.WriteLine(); 
                        Console.WriteLine("Enter the number: ");
                        removeNum = Convert.ToInt32(Console.ReadLine());
                        numbers.RemoveAll(x => x == removeNum);
                        foreach (int i in numbers)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                        Console.WriteLine();

                    }
                    else if (inputNum == 4)
                    {
                        Console.Clear();
                        Thread.Sleep(250);
                        foreach (int i in numbers)
                        {
                            Console.Write(i + ", ");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Enter the number: ");
                        addNum = Convert.ToInt32(Console.ReadLine());
                        numbers.Insert(0, addNum);
                        foreach (int i in numbers)
                        {
                            Console.Write(i + ", ");
                        }
                        Console.WriteLine();
                        Console.WriteLine();

                    }
                    else if (inputNum == 5)
                    {
                        Console.Clear();
                        Thread.Sleep(250);
                        Console.WriteLine("Enter number:");
                        numSearch = Convert.ToInt32(Console.ReadLine());
                        numCount = numbers.Count(x => x == numSearch);                       
                        Console.WriteLine("The number " + numSearch + " was found " + numCount + " times.");
                        Console.WriteLine();
                        Console.WriteLine();

                    }
                    else if (inputNum == 6)
                    {
                        Console.Clear();
                        Thread.Sleep(250);
                        Console.WriteLine(numbers.Max());
                        Console.WriteLine();
                        Console.WriteLine();

                    }
                    else if (inputNum == 7)
                    {
                        Console.Clear();
                        Thread.Sleep(250);
                        Console.WriteLine(numbers.Min());
                        Console.WriteLine();
                        Console.WriteLine();

                    }
                    else if (inputNum == 8)
                    {
                        Console.Clear();
                        listSum = numbers.Sum();
                        Console.WriteLine("The sum of the list is " + listSum);
                        listAverage = listSum / listLength;
                        Console.WriteLine("The average of the list is " + listAverage);
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else if (inputNum == 9)
                    {
                        Console.Clear();
                        Thread.Sleep(250);
                        Console.WriteLine("List Minimum: ");
                        listMin = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("List Maximum: ");
                        listMax = Convert.ToInt32(Console.ReadLine());
                      
                        for (int listNum = 0; listNum < listLength;)
                        {
                            numbers[listNum] = generator.Next(listMin, listMax);
                            listNum++;
                        }
                        foreach (int i in numbers)
                        {
                            Console.Write(i + ", ");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
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