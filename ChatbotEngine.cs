using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePart1._1
{
    internal class ChatbotEngine
    {
        private readonly UserProfile _user;

        public ChatbotEngine(UserProfile user)
        {
            _user = user;
        }

        public void StartChatLoop()
        {
            bool isChatting = true;

            while (isChatting)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n[{_user.Name}] > ");
                Console.ResetColor();

                string input = Console.ReadLine();

                // Q5: Input Validation for empty entries
                if (string.IsNullOrWhiteSpace(input))
                {
                    ConsoleUI.WriteError("Input cannot be empty. Please say something.");
                    continue;
                }

                string normalizedInput = input.Trim().ToLowerInvariant();

                if (normalizedInput == "exit" || normalizedInput == "quit")
                {
                    ConsoleUI.TypeWriteLine("Shutting down secure session. Stay safe online!", ConsoleColor.Cyan);
                    isChatting = false;
                    continue;
                }

                GenerateResponse(normalizedInput);
                ConsoleUI.PrintDivider();
            }
        }

        private void GenerateResponse(string query)
        {
            // Q4: Specific required responses and cybersecurity topics
            if (query.Contains("how are you"))
            {
                ConsoleUI.TypeWriteLine("I'm functioning at optimal capacity, thank you for asking!");
            }
            else if (query.Contains("purpose"))
            {
                ConsoleUI.TypeWriteLine("I am the Cybersecurity Awareness Bot. I'm here to help you stay safe online.");
            }
            else if (query.Contains("what can i ask") || query.Contains("help"))
            {
                ConsoleUI.TypeWriteLine("You can ask me about: \n- Password safety\n- Phishing\n- Safe browsing");
            }
            else if (query.Contains("password"))
            {
                ConsoleUI.TypeWriteLine("Password Safety: Always use passwords that are at least 12 characters long, combining uppercase, lowercase, numbers, and symbols. Never reuse passwords across sites.");
            }
            else if (query.Contains("phish"))
            {
                ConsoleUI.TypeWriteLine("Phishing Awareness: Be cautious of urgent emails asking for personal info. Always verify the sender's email address and hover over links before clicking them.");
            }
            else if (query.Contains("browse") || query.Contains("browsing"))
            {
                ConsoleUI.TypeWriteLine("Safe Browsing: Ensure websites use HTTPS (look for the padlock icon). Avoid accessing sensitive accounts like banking on public, unsecured Wi-Fi networks.");
            }
            else
            {
                // Q5: Default response for unsupported queries
                ConsoleUI.TypeWriteLine("I didn’t quite understand that. Could you rephrase?", ConsoleColor.Yellow);
            }
        }
    }
}
