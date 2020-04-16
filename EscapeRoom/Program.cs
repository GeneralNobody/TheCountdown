using EscapeRoom.Objects;
using System;
using System.Threading;

namespace EscapeRoom
{
    class Program
    {
        // Answers object, holds all of the user input answers.
        private static Answers answers = new Answers(null, null, null, null);

        // Correct answers object, holds all of the default values
        private static readonly Answers correctAnswers = new Answers("342222443", "aarde", "159", "kleidiatomee");

        // Main function, gets executed when the program is started.
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Welcome to our Escape Room!!!\n" +
                "To check if your answers were correct, please enter the letter or number codes you got per part into this program.\n" +
                "Please hurry up, because the bomb is still ticking! TICK... TOCK.. TICK... TOCK...\n" +
                "First, select which assignment you want to enter the answer to first:\n" +
                "A: Clay Minerals\n" +
                "B: Crossword Puzzle\n" +
                "C: Rebus\n" +
                "D: Riddle\n");

            // While loop which continues running until all values are filled in and the user has typed 'finish'.
            var unsuccessful = true;
            while (unsuccessful)
            {
                Console.Write("Please choose one of the assignments mentioned above (A/B/C/D) or type 'finish' to check your answers: ");
                var option = Console.ReadLine().ToLower();
                if (option == "a")
                {
                    Console.Write("Please enter your answer for A: ");
                    answers.AnswerA = Console.ReadLine();
                }
                else if (option == "b")
                {
                    Console.Write("Please enter your answer for B: ");
                    answers.AnswerB = Console.ReadLine();
                }
                else if (option == "c")
                {
                    Console.Write("Please enter your answer for C: ");
                    answers.AnswerC = Console.ReadLine();
                }
                else if (option == "d")
                {
                    Console.Write("Please enter your answer for D: ");
                    answers.AnswerD = Console.ReadLine();
                }
                else if (option == "finish")
                {
                    Console.WriteLine("Validating answers...");
                    Thread.Sleep(1000);
                    if (answers.AnswerA != null && answers.AnswerB != null && answers.AnswerC != null && answers.AnswerD != null)
                    {
                        unsuccessful = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: Please fill in all answers and try again.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Please enter one of the options mentioned above.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            }

            Console.WriteLine("Checking answers...");
            Thread.Sleep(800);
            Console.WriteLine("Checking answer A...");
            Thread.Sleep(1000);

            unsuccessful = true;
            while (unsuccessful)
            {
                if (answers.AnswerA == correctAnswers.AnswerA)
                {
                    Console.WriteLine("Answer A is correct");
                    unsuccessful = false;
                }
                else
                {
                    Console.Write("Answer A is incorrect. Please enter a new value for A: ");
                    answers.AnswerA = Console.ReadLine();
                }
            }

            Thread.Sleep(500);
            Console.WriteLine("Checking answer B...");
            Thread.Sleep(900);

            unsuccessful = true;
            while (unsuccessful)
            {
                if (answers.AnswerB == correctAnswers.AnswerB)
                {
                    Console.WriteLine("Answer B is correct");
                    unsuccessful = false;
                }
                else
                {
                    Console.Write("Answer B is incorrect. Please enter a new value for B: ");
                    answers.AnswerB = Console.ReadLine();
                }
            }

            Thread.Sleep(500);
            Console.WriteLine("Checking answer C...");
            Thread.Sleep(1100);

            unsuccessful = true;
            while (unsuccessful)
            {
                if (answers.AnswerC == correctAnswers.AnswerC)
                {
                    Console.WriteLine("Answer C is correct");
                    unsuccessful = false;
                }
                else
                {
                    Console.Write("Answer C is incorrect. Please enter a new value for C: ");
                    answers.AnswerC = Console.ReadLine();
                }
            }

            Thread.Sleep(500);
            Console.WriteLine("Checking answer D...");
            Thread.Sleep(1000);

            unsuccessful = true;
            while (unsuccessful)
            {
                if (answers.AnswerD == correctAnswers.AnswerD)
                {
                    Console.WriteLine("Answer D is correct");
                    unsuccessful = false;
                }
                else
                {
                    Console.Write("Answer D is incorrect. Please enter a new value for D: ");
                    answers.AnswerD = Console.ReadLine();
                }
            }

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success! All your answers are correct. The bomb has now been defused and you may safely leave the room. Have a good day!");
            Console.ResetColor();
        }
    }
}
