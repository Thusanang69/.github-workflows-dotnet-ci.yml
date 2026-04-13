using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Media;

namespace PoePart1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Update the path to include the folder name


            DisplayLogo();
            // ... rest of the code

            // Q1: Voice Greeting
            SpeechSynthesizer voice = new SpeechSynthesizer();
            
            voice.Speak("Hello, welcome to the cybersecurity Awareness bot.I am here to help you stay safe online");
            SoundPlayer speech = new SoundPlayer("C:\\Users\\Student\\source\\repos\\PoePart1.1\\PoePart1.1\\greeting intro.wav");
            speech.Load();
            speech.Play();

            // Q2: ASCII Art Logo
            DisplayLogo();

            ConsoleUI.PrintHeader("Cybersecurity Awareness Bot Initialized");

            // Q3: Text-based greeting & User Interaction
            ConsoleUI.TypeWriteLine("Welcome! To establish a secure session, please identify yourself.", ConsoleColor.Cyan);

            string name = GetValidName();
            var userSession = new UserProfile(name);

            ConsoleUI.TypeWriteLine($"\nHello, {userSession.Name}. Your secure session is active. Type 'exit' to quit.", ConsoleColor.Green);
            ConsoleUI.PrintDivider();

            // Pass control to the core engine
            var engine = new ChatbotEngine(userSession);
            engine.StartChatLoop();
        }
        private static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
   _____       __               ____        __ 
  / ___/__  __/ /_  ___  ____  / __ )____  / /_
  \__ \/ / / / __ \/ _ \/ __ \/ __  / __ \/ __/
 ___/ / /_/ / /_/ /  __/ / / / /_/ / /_/ / /_  
/____/\__, /_.___/\___/_/ /_/_____/\____/\__/  
     /____/                                    
        ");
            Console.ResetColor();
        }


        private static string GetValidName()
        {
            string input;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Enter your name: ");
                Console.ResetColor();

                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    ConsoleUI.WriteError("Name cannot be blank.");
                }
            } while (string.IsNullOrWhiteSpace(input));

            return input.Trim();
        }
    }
}
