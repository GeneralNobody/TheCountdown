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
                "To check if your answers were correct, please enter the letter or number codes you got per part into this program.\n" +
                "First, select which assignment you want to enter the answer to first:\n" +
                "A: Clay Minerals\n" +
                "B: Crossword Puzzle\n" +
                "C: Rebus\n" +
                "D: Riddle\n");
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
                    if (answers.AnswerA != null && answers.AnswerB != null && answers.AnswerC != null && answers.AnswerD != null)
                    {
                        unsuccessful = false;
                    }
                    else
                    {
                        Console.WriteLine("Error: Please fill in all answers and try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Please enter one of the options mentioned above.");
                }
            }
        }
    }
}
