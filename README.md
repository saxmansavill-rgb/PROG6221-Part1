# PROG6221 - Part 1
## Cybersecurity Awareness Chatbot

**Student:** Saxon Dane Saville  
**Student Number:** ST10473914  
**Module:** Programming 2A

---

## What is this?

A console application written in C# that acts as a cybersecurity awareness chatbot. The bot educates users about common cybersecurity threats and best practices through a conversational interface.

The idea came from the growing number of cyberattacks targeting South Africans. The bot covers topics like phishing, passwords, malware, Wi-Fi security and more.

---

## How to run it

You will need the .NET 10 SDK installed. You can download it from https://dotnet.microsoft.com/download

1. Clone the repo:
```
git clone https://github.com/saxmansavill-rgb/PROG6221-Part1.git
```

2. Navigate to the project folder:
```
cd PROG6221-Part1/CybersecurityChatbot
```

3. Run the app:
```
dotnet run
```

---

## How to use it

When the app starts it will play a short voice greeting and display the logo. It will then ask for your name and from there you can start asking questions.

Some things you can ask about:
- passwords
- phishing
- malware
- safe browsing
- Wi-Fi security
- privacy
- social media safety
- two factor authentication

Type `help` at any time to see the topics. Type `exit` to quit.

---

## Project structure
```
CybersecurityChatbot/
├── Program.cs            - entry point
├── ChatBot.cs            - main conversation loop and user interaction
├── ResponseHandler.cs    - keyword detection and response logic
├── UIHelper.cs           - console colours, borders and typing effect
├── VoiceGreeting.cs      - plays the WAV greeting on startup
├── AsciiArt.cs           - displays the logo
└── greeting.wav          - voice greeting audio file
```

---

## GitHub Actions

CI is set up using GitHub Actions. Every time code is pushed to main it automatically builds the project and checks for errors.

---

## Video

YouTube presentation link: (to be added before submission)

---

## References

Pieterse, H. 2021. The Cyber Threat Landscape in South Africa: A 10-Year Review. The African Journal of Information and Communication, 28(28).