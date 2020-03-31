using EscapeRoom.Objects;
using System;

namespace EscapeRoom
{
    class Program
    {
        private static Answers answers = new Answers(null, null, null, null);
        static void Main(string[] args)
        {
            Console.Write("Welcome to our Escape Room!!!\n" +
                "To check if your answers were correct, please enter the letter codes you got per part into this program.\n" +
                "First, select which assignment you want to enter the answer to first:\n" +
                "A: Clay Minerals\n" +
                "B: Crossword Puzzle\n" +
                "C: Rebus\n" +
                "D: Riddle\n");
            while (true)
            {
                Console.Write("Please choose one of the assignments mentioned above (A/B/C/D): ");
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
                else
                {
                    Console.WriteLine("Error: Please enter one of the options mentioned above.");
                }
            }
        }
    }
}
