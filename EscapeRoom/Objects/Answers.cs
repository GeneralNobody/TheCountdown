using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom.Objects
{
    class Answers
    {
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }

        public Answers(string answerA, string answerB, string answerC, string answerD)
        {
            AnswerA = answerA;
            AnswerB = answerB;
            AnswerC = answerC;
            AnswerD = answerD;
        }
    }
}
