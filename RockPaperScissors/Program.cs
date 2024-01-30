using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerWins = 0;
            int computerWins = 0;
            while (true)
            {
                Console.Write($"Choose [r]ock, [p]aper or [s]cissors: ");
                char playerChoice = char.Parse(Console.ReadLine());
                Picker playerMove = Picker.Rock;
                while (true)
                {
                    if (playerChoice == 'r')
                    {
                        playerMove = Picker.Rock;
                        break;
                    }

                    else if (playerChoice == 'p')
                    {
                        playerMove = Picker.Paper;
                        break;
                    }

                    else if (playerChoice == 's')
                    {
                        playerMove = Picker.Scissors;
                        break;
                    }

                    else
                    {
                        Console.Write($"Invalid value! Choose [r]ock, [p]aper or [s]cissors: ");
                        playerChoice = char.Parse(Console.ReadLine());
                    }
                }

                Picker computerMove = Picker.Rock;
                Random r = new Random();

                char[] options = { 'r', 'p', 's' };

                char computerChoice = options[r.Next(0, 3)];

                if (computerChoice == 'r')
                {
                    computerMove = Picker.Rock;
                    Console.WriteLine($"The computer chose Rock");
                }

                else if (computerChoice == 'p')
                {
                    computerMove = Picker.Paper;
                    Console.WriteLine($"The computer chose Paper");
                }

                else if (playerChoice == 's')
                {
                    computerMove = Picker.Scissors;
                    Console.WriteLine($"The computer chose Scissors");
                }

                if (playerMove == Picker.Rock)
                {
                    if (computerMove == Picker.Rock)
                    {
                        Console.WriteLine("Draw!");
                    }

                    else if (computerMove == Picker.Paper)
                    {
                        Console.WriteLine("You lose!");
                        computerWins++;
                    }

                    else if (computerMove == Picker.Scissors)
                    {
                        Console.WriteLine("You win!");
                        playerWins++;
                    }
                }

                else if (playerMove == Picker.Paper)
                {
                    if (computerMove == Picker.Rock)
                    {
                        Console.WriteLine("You win!");
                        playerWins++;
                    }

                    else if (computerMove == Picker.Paper)
                    {
                        Console.WriteLine("Draw!");

                    }

                    else if (computerMove == Picker.Scissors)
                    {
                        Console.WriteLine("You lose!");
                        computerWins++;
                    }
                }

                else if (playerMove == Picker.Scissors)
                {
                    if (computerMove == Picker.Rock)
                    {
                        Console.WriteLine("You lose!");
                        computerWins++;
                    }

                    else if (computerMove == Picker.Paper)
                    {
                        Console.WriteLine("You win!");
                        playerWins++;
                    }

                    else if (computerMove == Picker.Scissors)
                    {
                        Console.WriteLine("Draw!");
                    }
                }
                Console.WriteLine();
                Console.Write($"Do you want to play again (y/n)? ");

                char answer = Char.Parse(Console.ReadLine());
                Console.WriteLine();
                if (answer != 'y')
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Results:\nComputer: {computerWins}\nPlayer: {playerWins}");
        }
    }
}
