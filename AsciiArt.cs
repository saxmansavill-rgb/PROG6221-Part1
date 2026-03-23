using System;

namespace CybersecurityChatbot
{
    // displays the ASCII art logo when the app starts
    public static class AsciiArt
    {
        public static void Display()
        {
            // cyan for the main logo
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("  ██████╗██╗   ██╗██████╗ ███████╗██████╗ ");
            Console.WriteLine(" ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗");
            Console.WriteLine(" ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝");
            Console.WriteLine(" ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗");
            Console.WriteLine(" ╚██████╗   ██║   ██████╔╝███████╗██║  ██║");
            Console.WriteLine("  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝");
            Console.WriteLine();

            // green for the bot title banner
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   +--------------------------------------+");
            Console.WriteLine("   |   CYBERSECURITY AWARENESS BOT        |");
            Console.WriteLine("   |   Keeping South Africa Safe Online   |");
            Console.WriteLine("   |   2026                               |");
            Console.WriteLine("   +--------------------------------------+");
            Console.WriteLine();

            // shield symbol
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("            [ SHIELD ACTIVATED ]");
            Console.WriteLine("                /\\   /\\");
            Console.WriteLine("               /  \\ /  \\");
            Console.WriteLine("              | () | () |");
            Console.WriteLine("               \\  / \\  /");
            Console.WriteLine("                \\/   \\/");
            Console.WriteLine("          ___________________");
            Console.WriteLine("         |   S E C U R E     |");
            Console.WriteLine("         |___________________|");
            Console.WriteLine();

            Console.ResetColor();
        }
    }
}