using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string commands = Console.ReadLine();
            while (commands != "Reveal")
            {
                string[] tokens = commands.Split(":|:");
                switch (tokens[0])
                {
                    case "ChangeAll":
                        {
                            string substring = tokens[1];
                            string replacement = tokens[2];
                            message = message.Replace(substring, replacement);
                            break;
                        }
                    case "Reverse":
                        {
                            string substring = tokens[1];
                            if (message.Contains(substring))
                            {
                                int index = message.IndexOf(substring);
                                message = message.Remove(index, substring.Length);
                                message = message + string.Join("", substring.Reverse());
                            }
                            else
                            {
                                Console.WriteLine("error");
                                commands = Console.ReadLine();
                                continue;
                            }
                            break;
                        }
                    case "InsertSpace":
                        {
                            int index = int.Parse(tokens[1]);
                            
                            message = message.Insert(index, " ");
                            break;
                        }

                }
                Console.WriteLine(message);
                commands = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");

        }
    }
}
