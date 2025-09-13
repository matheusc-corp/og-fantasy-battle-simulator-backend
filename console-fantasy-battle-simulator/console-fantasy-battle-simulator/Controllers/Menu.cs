using console_fantasy_battle_simulator.Models.Characters;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_fantasy_battle_simulator.Controllers
{
    internal class Menu
    {
        public void MainMenu()
        {
            bool loop = true;
            while (loop)
            {
                List<string> menuOptions = new List<string>();

                menuOptions.Add("Single");
                menuOptions.Add("Versus");
                menuOptions.Add("Characters list");
                menuOptions.Add("Exit");

                int cont = 1;
                string msg = "";

                foreach (var option in menuOptions)
                {
                    msg += $"{cont} - {option}\n";
                    cont++;
                }

                Console.WriteLine(msg);

                Console.Write("Choose an option: ");
                int opc = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Unavailable");
                        break;
                    case 2:
                        Console.WriteLine("Unavailable");
                        break;
                    case 3:
                        CharacterMenu();
                        break;
                    case 4:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.WriteLine();
            }
        }

        public Object CharacterMenu()
        {
            while (true)
            {
                List<BaseCharacter> characters = new List<BaseCharacter>();

                characters.AddRange(new BaseCharacter[]
                {
                new Warrior ("Hero"),
                new Mage ("Sage"),
                new Barbarian("Brute"),
                new Assassin("Darkness")
                });

                string msg = $"-------------------------\nSELECAO DE PERSONAGEM\n-------------------------\n";
                int cont = 1;

                foreach (var character in characters)
                {
                    msg += $"{cont} - {character.Name}\n";
                    cont++;
                }

                msg += $"{cont} - sair";

                Console.WriteLine(msg);

                Console.Write("Choose an option: ");
                int opc = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine();

                if (opc <= characters.Count)
                {
                    Console.WriteLine($"-------------------------\n");
                    Console.WriteLine(characters[opc - 1]);
                    return characters[opc - 1];
                }
                else if (opc == 5)
                {
                    return null;
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
        }
    }
}
