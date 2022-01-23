using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConjugatorCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert the root:");
            string root = Console.ReadLine();
            Console.WriteLine("Is it first person (1), second person (2), or third person (3)?");
            int person = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is it one person (1) or multiple people (2)?");
            int number = Convert.ToInt32(Console.ReadLine());

            string[,] arED = new string[3, 2]{
                                {"o", "amos"},
                                {"as", "ais"},
                                {"a", "an"}
                            };
            string[,] erED = new string[3, 2]{
                                {"e", "emos"},
                                {"es", "eis"},
                                {"e", "en"}
                            };
            string[,] irED = new string[3, 2]{
                                {"o", "imos"},
                                {"es", "is"},
                                {"e", "en"}
                            };

            if(root.EndsWith("ar") == true)
            {
                Console.WriteLine(root.Trim('a', 'r') + arED[person, number]);
            }
            else if(root.EndsWith("er") == true)
            {
                Console.WriteLine(root.Trim('e', 'r') + erED[person, number]);
            }
            else if(root.EndsWith("ir") == true)
            {
                Console.WriteLine(root.Trim('i', 'r') + irED[person, number]);
            }
            else
            {
                Console.WriteLine("That root is not valid.");
            }
            
        }
    }
}
