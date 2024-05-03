using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockScissorPaper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string welcomeMesssage = "=*= WelCome To My Rock Scissor Paper Game =*=";
            string[] options = new string[3] { "Rock", "Scissor", "Paper" };
            int score = 0;
            int sysScore = 0;
            Console.WriteLine(welcomeMesssage);
            while (score < 10 && sysScore < 10)
            {

                int index = 0;
                ShapePrinter(welcomeMesssage.Length, "*");

                Console.WriteLine($"Your Score: {score} ");
                Console.WriteLine($"System Score: {sysScore} ");
                Console.WriteLine("Select Your Move From Below Options:");
                foreach (string option in options)
                {
                    Console.WriteLine($"{index + 1} - {option}");
                    index++;
                }

                int userOption = int.Parse(Console.ReadLine()) - 1;
                Random random = new Random();
                int pcOption = random.Next(0, options.Length);
                try
                { 
                ShapePrinter(welcomeMesssage.Length, "_");
                Console.WriteLine($"Your Move : {options[userOption]} - System Move : {options[pcOption]}");
                }
                catch
                {
                    Console.WriteLine("Just Select From 1, 2, 3");
                    continue;
                }

                

                if (options[pcOption] == options[userOption])
                {
                    Console.WriteLine("Draw");
                    score++;
                    sysScore++;
                }
                else if (options[pcOption] == "Rock" && options[userOption] == "Scissor")
                {
                    Console.WriteLine("Lose !");
                    sysScore += 3;
                }
                else if (options[pcOption] == "Rock" && options[userOption] == "Paper")
                {
                    Console.WriteLine("Win ^_^");
                    score += 3;

                }
                else if (options[pcOption] == "Scissor" && options[userOption] == "Rock")
                {
                    Console.WriteLine("Win ^_^");
                    score += 3;

                }
                else if (options[pcOption] == "Scissor" && options[userOption] == "Paper")
                {
                    Console.WriteLine("Lose !");

                    sysScore += 3;
                }
                else if (options[pcOption] == "Paper" && options[userOption] == "Scissor")
                {
                    Console.WriteLine("Win ^_^");
                    score += 3;

                }
                else if (options[pcOption] == "Paper" && options[userOption] == "Rock")
                {
                    Console.WriteLine("Lose !");

                    sysScore += 3;
                }

            }
            string win = "You Win Horaay ! ^___^ ";
            string lose = "        You Lose ";
            Console.WriteLine("\n");
            ShapePrinter(23, "=");
            Console.WriteLine(score == 10 ? win : lose);
            ShapePrinter(23, "=");

            Console.ReadKey();
        }

        static void ShapePrinter(int numberOfStars, string shape)
        {
            for (int i = 0; i <= numberOfStars; i++)
            {
                if (i == numberOfStars)
                {
                    Console.WriteLine(shape);
                }
                else
                {

                    Console.Write(shape);
                }
            }
        }
    }
}
