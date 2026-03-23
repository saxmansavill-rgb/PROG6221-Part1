using CybersecurityChatbot;
using System;
using System.Text;

// set console encoding so special characters display correctly on all platforms
Console.OutputEncoding = Encoding.UTF8;

// start the chatbot
ChatBot bot = new ChatBot();
bot.Run();