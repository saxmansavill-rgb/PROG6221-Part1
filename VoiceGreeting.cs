using System;
using System.IO;
using System.Diagnostics;

namespace CybersecurityChatbot
{
    // handles playing the voice greeting when the app starts
    // uses afplay on mac and will skip if file not found
    public static class VoiceGreeting
    {
        public static void Play()
        {
            // build path to the wav file
            string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");

            // check if file exists before trying to play
            if (!File.Exists(audioPath))
            {
                // no audio file found, just skip it
                return;
            }

            try
            {
                // mac uses afplay which is built into macos
                Process process = new Process();
                process.StartInfo.FileName = "afplay";
                process.StartInfo.Arguments = audioPath;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception e)
            {
                // if something goes wrong just print the error and move on
                // dont want the whole app to crash because of audio
                Console.WriteLine("Could not play audio: " + e.Message);
            }
        }
    }
}