using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra
{
    internal class Menu
    {
        bool continueFlag = true;
        List<Items> item;
        public void Execute()
        {
            item = new List<Items>();

            continueFlag = true;

            while (continueFlag)
            {
                MenuPrincipal();

            }

        }

        public void MenuPrincipal()
        {
            Console.WriteLine("Enter the number you want to make:");
            Console.WriteLine("1. Create player/Npc/Item");
            Console.WriteLine("2. See information");
            Console.WriteLine("3. Delete Npc/Item");
            Console.WriteLine("4. Add something");
            Console.WriteLine("5. Exit");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ShowCreate();
                    break;
                case "2":
                    ShowInformation();
                    break;
                case "3":
                    ShowDelete();
                    break;
                case "4":
                    ShowAdd();
                    break;
                case "5":
                    continueFlag = false;
                    break;
                default:
                    break;
            }

        }
        public void ShowCreate()
        {
            Console.WriteLine("What do you like to do? ");
            Console.WriteLine("1.Create Player ");
            Console.WriteLine("2.Create Npc ");
            Console.WriteLine("2.Create Item ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    AddPlayer();
                    break;
                case "2":
                    AddNpc();
                    break;
                case "3":
                    AddItem();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
        public void AddPlayer()
        {
            Console.WriteLine("Welcome, introduce player data");
            Player player = new Player();
            Console.WriteLine("Player name");
            string playerName = Console.ReadLine();
            player.GetName(playerName);
            Console.WriteLine("How many experience points do you want?");
            float playerExperience = float.Parse(Console.ReadLine());
            player.GetExperience(playerExperience);
            Console.WriteLine(player.ShowData());
        }
        public void AddNpc()
        {
            Console.WriteLine("What NPC would you like to create? ");
            Console.WriteLine("1.Create Enemy ");
            Console.WriteLine("2.Create Seller ");
            Console.WriteLine("3.Create Talker ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    AddEnemy();
                    break;
                case "2":
                    AddSeller();
                    break;
                case "3":
                    AddTalker();
                    break;
                default:
                    Console.WriteLine("Bad Option");
                    break;
            }

        }
    }
}