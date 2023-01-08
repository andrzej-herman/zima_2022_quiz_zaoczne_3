using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Message
    {
        public void DisplayWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("WITAJ W NASZYM QUIZIE");
            Console.WriteLine("Spróbuj odpowiedzieć na 7 pytań");
            Console.WriteLine("POWODZENIA !!!");
            Console.WriteLine();
        }

        public void DisplayLooseAndGameOver()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIESTETY TO NIE JEST DOBRA ODPOWIEDŹ");
            Console.WriteLine("KONIEC GRY");
            Console.WriteLine();
        }

        public void FinalScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("BRAWO, UDAŁO CI SIĘ UKOŃCZYĆ QUIZ !!!!");
            Console.WriteLine("KONIEC GRY");
            Console.WriteLine();
        }

        public void GoodAnswer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("BRAWO,TO POPRAWNA ODPOWIEDŹ !!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Naciśnij ENTER, aby zobaczyć następne pytanie ...");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
