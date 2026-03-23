using System;
using System.Threading;

namespace CybersecurityChatbot
{
    // helper class for all the console UI stuff
    // handles colours, borders, typing effect etc
    public static class UIHelper
    {
        // just writes text in a specific colour
        public static void WriteColour(string text, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void WriteLineColour(string text, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        // typing effect - prints one char at a time with a delay
        // makes it feel more like a real chatbot
        public static void TypeText(string text, int delay = 30)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        public static void TypeTextColour(string text, ConsoleColor colour, int delay = 30)
        {
            Console.ForegroundColor = colour;
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(delay);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        // border for separating sections
        public static void PrintBorder()
        {
            WriteLineColour("========================================================", ConsoleColor.Cyan);
        }

        public static void PrintThinBorder()
        {
            WriteLineColour("--------------------------------------------------------", ConsoleColor.DarkCyan);
        }

        // prints a section header with borders around it
        public static void PrintHeader(string title)
        {
            Console.WriteLine();
            PrintBorder();
            WriteLineColour("  " + title, ConsoleColor.Cyan);
            PrintBorder();
        }

        // bot response formatting
        public static void BotSay(string message)
        {
            WriteColour("  Bot: ", ConsoleColor.Green);
            TypeText(message, 25);
        }

        // for showing error messages to the user
        public static void ShowError(string message)
        {
            WriteLineColour("  Error: " + message, ConsoleColor.Red);
        }

        public static void Pause(int ms = 500)
        {
            Thread.Sleep(ms);
        }
    }
}