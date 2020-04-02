using System;

namespace EscapeRoom
{
    class System
    {
        public void ConsoleShowError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(error);
            Console.ResetColor();
        }

        public void ConsoleShowInfo(string info)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(info);
            Console.ResetColor();
        }
    }
}
