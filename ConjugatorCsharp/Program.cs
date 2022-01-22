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
            Console.WriteLine("What ending does it have? ar (1); er (2); or ir (3)?");
            int ending = Convert.ToInt32(Console.ReadLine());
            if (ending == 1)
            {
                switch (person)
                {
                    case 1:
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine(root.Trim('a', 'r') + "o");
                                break;
                            case 2:
                                Console.WriteLine(root.Trim('a', 'r') + "amos");
                                break;
                        }
                        break;
                    case 2:
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine(root.Trim('a', 'r') + "as");
                                break;
                            case 2:
                                Console.WriteLine(root.Trim('a', 'r') + "áis");
                                break;
                        }
                        break;
                    case 3:
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine(root.Trim('a', 'r') + "a");
                                break;
                            case 2:
                                Console.WriteLine(root.Trim('a', 'r') + "an");
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (ending == 2)
            {
                switch (person)
                {
                    case 1:
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine(root.Trim('e', 'r') + "o");
                                break;
                            case 2:
                                Console.WriteLine(root.Trim('e', 'r') + "emos");
                                break;
                        }
                        break;
                    case 2:
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine(root.Trim('e', 'r') + "es");
                                break;
                            case 2:
                                Console.WriteLine(root.Trim('e', 'r') + "éis");
                                break;
                        }
                        break;
                    case 3:
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine(root.Trim('e', 'r') + "e");
                                break;
                            case 2:
                                Console.WriteLine(root.Trim('e', 'r') + "en");
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (ending == 3)
            {
                switch (person)
                {
                    case 1:
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine(root.Trim('i', 'r') + "o");
                                break;
                            case 2:
                                Console.WriteLine(root.Trim('i', 'r') + "imos");
                                break;
                        }
                        break;
                    case 2:
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine(root.Trim('i', 'r') + "es");
                                break;
                            case 2:
                                Console.WriteLine(root.Trim('i', 'r') + "ís");
                                break;
                        }
                        break;
                    case 3:
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine(root.Trim('i', 'r') + "e");
                                break;
                            case 2:
                                Console.WriteLine(root.Trim('i', 'r') + "en");
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {

            }
        }
    }
}
