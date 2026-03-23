using System;

namespace CybersecurityChatbot
{
    // main chatbot class
    // handles the conversation loop and user interaction
    public class ChatBot
    {
        private ResponseHandler _responseHandler = new ResponseHandler();
        private string _userName = "";

        // starts the chatbot
        public void Run()
        {
            Console.Clear();

            // show ascii art logo
            AsciiArt.Display();

            // play voice greeting
            UIHelper.Pause(500);
            VoiceGreeting.Play();

            // welcome message
            UIHelper.Pause(300);
            UIHelper.PrintBorder();
            UIHelper.TypeTextColour("  Welcome to the Cybersecurity Awareness Bot!", ConsoleColor.Green, 30);
            UIHelper.TypeTextColour("  Your personal guide to staying safe online.", ConsoleColor.Green, 30);
            UIHelper.PrintBorder();

            // ask for name first
            GetUserName();

            // start the main chat loop
            ChatLoop();
        }

        // asks the user for their name before starting
        private void GetUserName()
        {
            Console.WriteLine();
            UIHelper.BotSay("Before we start, what is your name?");
            Console.WriteLine();

            while (true)
            {
                UIHelper.WriteColour("  You: ", ConsoleColor.Yellow);
                string input = Console.ReadLine();

                // validate the name
                if (string.IsNullOrWhiteSpace(input))
                {
                    UIHelper.ShowError("Please enter your name.");
                    continue;
                }

                if (input.Trim().Length < 2)
                {
                    UIHelper.ShowError("That name is too short, please try again.");
                    continue;
                }

                if (input.Trim().Length > 50)
                {
                    UIHelper.ShowError("That name is too long, please try again.");
                    continue;
                }

                // save the name with first letter capitalised
                _userName = CapitaliseName(input.Trim());
                break;
            }

            // greet the user by name
            Console.WriteLine();
            UIHelper.PrintBorder();
            UIHelper.TypeTextColour("  Nice to meet you, " + _userName + "!", ConsoleColor.Cyan, 30);
            UIHelper.TypeTextColour("  I am your Cybersecurity Awareness Assistant.", ConsoleColor.Cyan, 30);
            UIHelper.TypeTextColour("  Feel free to ask me anything about staying safe online.", ConsoleColor.Cyan, 30);
            UIHelper.PrintBorder();
            Console.WriteLine();
            UIHelper.BotSay("Type 'help' to see what I can assist with, or just ask away.");
            UIHelper.PrintThinBorder();
        }

        // main conversation loop
        private void ChatLoop()
        {
            while (true)
            {
                Console.WriteLine();
                UIHelper.WriteColour("  " + _userName + ": ", ConsoleColor.Yellow);
                string input = Console.ReadLine();

                // validate input
                if (string.IsNullOrWhiteSpace(input))
                {
                    UIHelper.ShowError("Please type something, I didn't catch that.");
                    continue;
                }

                if (input.Trim().Length < 2)
                {
                    UIHelper.ShowError("That is too short, please ask me a proper question.");
                    continue;
                }

                // get response from response handler
                string response = _responseHandler.GetResponse(input.Trim());

                // check if user wants to exit
                if (response == "EXIT")
                {
                    ExitMessage();
                    break;
                }

                // print the response
                Console.WriteLine();
                UIHelper.PrintThinBorder();
                UIHelper.BotSay(response);
                UIHelper.PrintThinBorder();
            }
        }

        // goodbye message when user exits
        private void ExitMessage()
        {
            Console.WriteLine();
            UIHelper.PrintBorder();
            UIHelper.TypeTextColour("  Thanks for chatting, " + _userName + ". Stay safe online.", ConsoleColor.Green, 30);
            UIHelper.TypeTextColour("  Remember: think before you click.", ConsoleColor.Green, 30);
            UIHelper.PrintBorder();
            Console.WriteLine();
        }

        // capitalises the first letter of the name
        private string CapitaliseName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return name;
            }
            return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }
    }
}