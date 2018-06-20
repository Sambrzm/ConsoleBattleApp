using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattleApp.Dungeons
{
    class Dungeon
    {
        public static void DungeonMenu()
        {
            Console.WriteLine("You are in the dungeon, how will you proceed?");
            Console.WriteLine("1 Venture deeper...");
            Console.WriteLine("2 Manage team");
            Console.WriteLine("3 Get out");

            int answer = Int32.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Battle.StartBattle();
            }
            else if (answer == 2)
            {
                //manage team
            }
            else if (answer == 3)
            {
                Program.PrintColorMessage(ConsoleColor.Red, "Got out safely");
                TownHome.townArrival();
            }
            else
            {
                Program.PrintColorMessage(ConsoleColor.Red, "Please enter a valid number");
                DungeonMenu();
            }
            
        }        
    }
}
