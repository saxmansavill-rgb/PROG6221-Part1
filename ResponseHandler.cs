using System;
using System.Collections.Generic;

namespace CybersecurityChatbot
{
    // handles all the chatbot responses
    // checks user input for keywords and returns relevant responses
    public class ResponseHandler
    {
        private Random _random = new Random();

        // list of keywords and their matching responses
        // each topic has multiple responses so it doesnt feel repetitive
        private Dictionary<string[], string[]> _responses = new Dictionary<string[], string[]>()
        {
            {
                new string[] { "password", "passwords", "passphrase" },
                new string[]
                {
                    "Make sure your password is at least 12 characters long. Use a mix of uppercase, lowercase, numbers and symbols.",
                    "Never use the same password for multiple accounts. If one gets hacked, they all get hacked.",
                    "A passphrase like PurpleTiger$Runs@Night is actually really strong and easier to remember.",
                    "Turn on two-factor authentication wherever you can. Even if someone has your password they still cant get in."
                }
            },
            {
                new string[] { "phishing", "phish", "email", "scam", "fake" },
                new string[]
                {
                    "Phishing emails usually create urgency like your account will be closed. Slow down and check before clicking anything.",
                    "Always check the actual email address of the sender, not just the display name. Scammers fake the name easily.",
                    "Hover over links before clicking them. If the URL looks weird or misspelled, dont click it.",
                    "When in doubt go directly to the website by typing the address yourself instead of clicking a link in an email."
                }
            },
            {
                new string[] { "malware", "virus", "ransomware", "spyware", "trojan" },
                new string[]
                {
                    "Keep your OS and software updated. A lot of malware exploits old vulnerabilities that patches already fixed.",
                    "Only download software from official sources. Avoid random download sites.",
                    "Ransomware locks your files and demands payment. Your best defence is having regular backups.",
                    "Get a decent antivirus like Windows Defender or Malwarebytes. They catch most common threats."
                }
            },
            {
                new string[] { "browsing", "internet", "website", "online", "safe", "browser" },
                new string[]
                {
                    "Always check for HTTPS and the padlock icon before entering any personal info on a website.",
                    "Use a VPN when connecting to public Wi-Fi. It encrypts your traffic so others cant snoop.",
                    "Keep your browser updated and consider using an extension like uBlock Origin to block malicious ads.",
                    "Avoid clicking pop-up ads. They often redirect to malicious sites or trigger unwanted downloads."
                }
            },
            {
                new string[] { "privacy", "data", "personal", "information" },
                new string[]
                {
                    "Be careful what you share on social media. Scammers use public info for targeted attacks.",
                    "Check app permissions regularly. A flashlight app doesnt need access to your contacts.",
                    "Use a privacy focused search engine like DuckDuckGo to reduce how much data gets tracked.",
                    "Update your privacy settings on social media regularly. Platforms change their defaults often."
                }
            },
            {
                new string[] { "wifi", "wi-fi", "network", "router", "hotspot" },
                new string[]
                {
                    "Change your routers default username and password as soon as you set it up.",
                    "Avoid accessing your bank or sensitive accounts on public Wi-Fi networks.",
                    "Use WPA3 encryption on your home Wi-Fi if your router supports it.",
                    "Set up a separate guest network for visitors so they cant access your main devices."
                }
            },
            {
                new string[] { "social", "facebook", "instagram", "tiktok", "twitter", "media" },
                new string[]
                {
                    "Set your social media profiles to private. Not everyone needs to see your posts.",
                    "Be careful accepting friend requests from people you dont know. Fake profiles are really common.",
                    "Think before you post. Once something is online its very hard to fully remove.",
                    "Social engineering attacks often start with info gathered from your public social media profiles."
                }
            },
            {
                new string[] { "2fa", "two factor", "authentication", "mfa", "verify" },
                new string[]
                {
                    "Two factor authentication means even if your password gets stolen, attackers still cant log in.",
                    "Use an authenticator app like Google Authenticator instead of SMS codes when you can.",
                    "Enable 2FA on your email first. Its basically the master key to all your other accounts.",
                    "Hardware security keys like YubiKey are the strongest form of two factor authentication available."
                }
            }
        };

        // responses for general questions
        private string[] _greetingResponses = new string[]
        {
            "Doing well thanks, ready to help you stay safe online.",
            "All good here. What can I help you with today?",
            "Running smoothly. What cybersecurity topic can I help you with?"
        };

        private string[] _purposeResponses = new string[]
        {
            "I'm a Cybersecurity Awareness Assistant. I help educate people about staying safe online.",
            "My job is to help you understand cyber threats and how to protect yourself.",
            "I'm here to answer your questions about cybersecurity and online safety."
        };

        private string[] _helpResponses = new string[]
        {
            "You can ask me about: passwords, phishing, malware, safe browsing, privacy, Wi-Fi, social media or 2FA.",
            "Try asking me about password safety, phishing scams or how to secure your Wi-Fi.",
            "Topics I can help with: passwords, phishing, malware, browsing, privacy, Wi-Fi, social media, 2FA."
        };

        private string[] _unknownResponses = new string[]
        {
            "I didn't quite understand that. Could you rephrase? Try asking about passwords or phishing.",
            "Not sure what you mean. I specialise in cybersecurity topics like malware and Wi-Fi safety.",
            "That's a bit outside what I know. Try asking me about phishing or password safety."
        };

        // main method that takes user input and returns a response
        public string GetResponse(string userInput)
        {
            // handle empty input
            if (string.IsNullOrWhiteSpace(userInput))
            {
                return "Please type something, I didn't catch that.";
            }

            string input = userInput.ToLower().Trim();

            // check if user wants to exit
            if (input == "exit" || input == "quit" || input == "bye" || input == "goodbye")
            {
                return "EXIT";
            }

            // check for greeting type questions
            if (input.Contains("how are you") || input.Contains("how r you") || input.Contains("hows it"))
            {
                return GetRandom(_greetingResponses);
            }

            // check for questions about what the bot does
            if (input.Contains("what are you") || input.Contains("who are you") || input.Contains("your purpose") || input.Contains("what do you do"))
            {
                return GetRandom(_purposeResponses);
            }

            // check for help request
            if (input.Contains("help") || input.Contains("what can i ask") || input.Contains("topics"))
            {
                return GetRandom(_helpResponses);
            }

            // check keywords dictionary
            foreach (KeyValuePair<string[], string[]> entry in _responses)
            {
                foreach (string keyword in entry.Key)
                {
                    if (input.Contains(keyword))
                    {
                        return GetRandom(entry.Value);
                    }
                }
            }

            // nothing matched
            return GetRandom(_unknownResponses);
        }

        // returns a random item from an array
        private string GetRandom(string[] options)
        {
            int index = _random.Next(0, options.Length);
            return options[index];
        }
    }
}