﻿using EscapeRoom.Objects;
using System;
using System.Collections;
using System.Linq;

namespace EscapeRoom
{
    class Program
    {
        // Answers object, holds all of the user input answers.
        private static Answers answers = new Answers(null, null, null, null);

        // Correct answers object, holds all of the default values
        private static Answers correctAnswers = new Answers("77777277755555337777", "aarde", "22900", "kleidiatomee");

        // Main function, gets executed when the program is started.
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Welcome to our Escape Room!!!\n" +
                "To check if your answers were correct, please enter the letter or number codes you got per part into this program.\n" +
                "First, select which assignment you want to enter the answer to first:\n" +
                "A: Clay Minerals\n" +
                "B: Crossword Puzzle\n" +
                "C: Rebus\n" +
                "D: Riddle\n");
            var unsuccessful = true;
            // While loop which continues running until all values are filled in and the user has typed 'finish'.
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
            /*
            string[] answersArr = ((IEnumerable)answers).Cast<object>()
                                                        .Select(x => x.ToString())
                                                        .ToArray();
            string[] correctAnswersArr = ((IEnumerable)answers).Cast<object>()
                                                               .Select(x => x.ToString())
                                                               .ToArray();

            for (int i = 0; i < answersArr.Length; i++)
            {
                if (answersArr[i] != correctAnswersArr[i])
                {
                    Console.WriteLine("Error: Answer " + i + " doesn't match.");
                }
            }
            */
            Console.ResetColor();
        }
    }
}
