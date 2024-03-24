using System;

namespace FunctionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            // Challenge 1: String and Number Processor
            Console.WriteLine("Challenge 1: String and Number Processor");

            // Console.WriteLine("Challenge 1: String and Number Processor");
            StringNumberProcessor("Hello", 100, 200, "World"); // Expected outcome: "Hello World; 300"
            /*-----------------------------------------------------------*/
            void StringNumberProcessor(params object[] data)
            {

                string str = "";
                int total = 0;

                foreach (var item in data)
                {
                    if (item is string a)
                    {
                        str += a;
                    }

                    if (item is int b)
                    {
                        total += b;
                    }
                }
                Console.WriteLine($"All The STR: {str}");
                Console.WriteLine($"The total: {total}");
            }




            // Challenge 2: Object Swapper
            Console.WriteLine("\nChallenge 2: Object Swapper");
            int num1 = 25, num2 = 30;
            int num3 = 10, num4 = 30;
            string str1 = "HelloWorld", str2 = "Programming";
            string str3 = "Hi", str4 = "Programming";
            void SwapObjects<T>(ref T obj1, ref T obj2)
            {
                if (obj1 is string str1 && obj2 is string str2)
                {
                    Console.WriteLine($"STR 1: {str1}");
                    Console.WriteLine($"STR 2: {str2}");
                }

                if (obj1 is int num1 && obj2 is int num2)
                {
                    Console.WriteLine($"num 1: {num1}");
                    Console.WriteLine($"num 2: {num2}");
                }

            }
            SwapObjects(ref str1, ref str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            SwapObjects(ref num1, ref num2); // Expected outcome: num1 = 30, num2 = 25 
            // SwapObjects(ref num3, ref num4); // Error: Value must be more than 18

            // SwapObjects(str3, str4); // Error: Length must be more than 5

            // SwapObjects(true, false); // Error: Upsupported data type
            // SwapObjects(ref num1, str1); // Error: Objects must be of same types

            // Console.WriteLine($"Numbers: {num1}, {num2}");
            // Console.WriteLine($"Strings: {str1}, {str2}");

            // Challenge 3: Guessing Game
            Console.WriteLine("\nChallenge 3: Guessing Game");
            void GuessingGame()
            {
                Random game = new Random();
                int guess = game.Next(1, 10);
                // Console.WriteLine("The Random number is:" + guess);

                // int guessNumber = input



                while (true)
                {
                    Console.WriteLine("Guess a number between (1 - 10)\n or type (quit) to leave the guessing game");
                    string? input = Console.ReadLine();

                    if (input == "" || input is null || input.ToLower() == "quit")
                    {
                        Console.WriteLine("Terminated");
                        break;
                    }

                    int guessNumber;


                    if (int.TryParse(input, out guessNumber))
                    {
                        if (guessNumber == guess)
                        {
                            Console.WriteLine("Congratulation! You gussed the right number");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You are bad with guessing. Try again.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Wrong asnwer, please enter a number or type quit.");
                    }



                }
            }



            GuessingGame(); // Expected outcome: User input until the correct number is guessed or user inputs `Quit`

            // Challenge 4: Simple Word Reversal
            Console.WriteLine("\nChallenge 4: Simple Word Reversal");
            string sentence = "This is the original sentence!";



            string ReverseWords(string sentence)
            {
                string[] words = sentence.Split();
                List<string> reversedWords = [];
                foreach (string word in words)
                {
                    // Console.WriteLine(string.Join("", word.Reverse()));
                    string reversed = String.Join("", word.Reverse());
                    reversedWords.Add(reversed);
                }

                Console.WriteLine(string.Join(" ", reversedWords));
                return "";
            }


            string reversed = ReverseWords(sentence);

            Console.WriteLine(reversed); // Expected outcome: "sihT si eht lanigiro !ecnetnes"

            // */


        }
    }
}
