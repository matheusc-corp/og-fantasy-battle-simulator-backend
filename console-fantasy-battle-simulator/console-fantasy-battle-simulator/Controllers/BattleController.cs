using console_fantasy_battle_simulator.Models.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_fantasy_battle_simulator.Controllers
{
    internal class BattleController
    {
        public void Battle(BaseCharacter challenger, BaseCharacter challenged, bool singlePlayer)
        {
            Console.Clear();

            if (challenger == null || challenged == null) {
                Console.WriteLine("Some character is null.");
                return;
            }

            try
            {
                Console.WriteLine("Player 1");
                Console.WriteLine(challenger);
                Console.WriteLine();
                Console.WriteLine("Player 2");
                Console.WriteLine(challenged);

                int round = 1;
                while (true)
                {
                    Console.WriteLine($"-----------Round {round}-----------");
                    Console.WriteLine($"{challenger.Name}\nHP: {challenger.HealthPoints}\nMP: {challenger.ManaPoints}");
                    Console.WriteLine();
                    Console.WriteLine($"{challenged.Name}\nHP: {challenged.HealthPoints}\nMP: {challenged.ManaPoints}");

                    Console.WriteLine("\nPlayer 1");
                    CharacterMove(challenger, challenged);

                    Console.WriteLine("\nPlayer 2");
                    CharacterMove(challenged, challenger, singlePlayer);

                    if (challenger.HealthPoints <= 0 && challenged.HealthPoints <= 0)
                    {
                        Console.WriteLine("Draw!");
                        break;
                    }
                    else if (challenger.HealthPoints <= 0)
                    {
                        Console.WriteLine("Player 2 Wins!");
                        break;
                    }
                    else if (challenged.HealthPoints <= 0)
                    {
                        Console.WriteLine("Player 1 Wins!");
                        break;
                    }

                    round++;
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Recebemos um valor vazio. {e}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Houve um erro inesperado! {e}");
                return;
            }
        }

        public int RandomMove()
        {
            Random random = new Random();
            return random.Next(1, 3);
        }

        public void CharacterMove(BaseCharacter attacker, BaseCharacter target, bool singlePLayer = false)
        {
            bool waiting = true;

            
            while (waiting)
            {
                try
                {
                    int move = 0;

                    if (singlePLayer)
                    {
                        move = RandomMove();
                    }
                    else
                    {
                        Console.WriteLine("1 - Attack \t 2 - Magic");
                        Console.Write("Select your move: ");
                        move = int.Parse(Console.ReadLine());
                    }

                    switch (move)
                    {
                        case 1:
                            target.TakePAtk(attacker.Attack());
                            waiting = false;
                            break;
                        case 2:
                            target.TakeMAtk(attacker.Magic());
                            waiting = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Houve um erro inesperado! {e}");
                }                
            }            
        }
    }
}
