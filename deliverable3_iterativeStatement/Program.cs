/* Name: Edward Cason
 * Date: 01/26/2023
 * Description: Iterative statement deliverable 
 */
namespace Deliverable3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter a number between 1 and 100:");
                    input = int.Parse(Console.ReadLine());
                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Please specify a series of integer numbers (Even or Odd):");
                    series = Console.ReadLine();
                    if (series == "Even" || series == "Odd")
                    {
                        break;
                    }
                }
                if (series == "Even")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                    for (int i = 0; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }

                }
                if (series == "Odd")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                    for (int i = 1; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Please enter a numeric value for the input.");
                Console.WriteLine("Enter a string value/ in caps for the series");
            }

        }
    }
}