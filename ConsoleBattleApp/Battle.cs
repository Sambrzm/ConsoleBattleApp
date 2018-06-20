using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattleApp
{
    class Battle
    {    
        public static void StartBattle()
        {            
            BattleOrRun();
        }

        public static void BattleOrRun()
        {
            Console.WriteLine("A Skeleton arises from the ground!");
            Console.WriteLine("Enter 1 to Battle!");
            Console.WriteLine("Enter 2 to Run!");

            Knight player = new Knight();
            Skeleton skeleton = new Skeleton(); 
            

            int answer = Int32.Parse(Console.ReadLine());

            if (answer == 1)
            {
                player.Attack();
                skeleton.Attack();
            }
            else if (answer == 2)
            {
                Console.WriteLine("You got away...");
                return;
            }
            else
            {
                Program.PrintColorMessage(ConsoleColor.Red, "Please enter a valid number");
                player.Attack();
            }
            while (skeleton.IsActive && player.IsActive)
            {
                player.Attack();
                skeleton.Attack();
            }
            if (skeleton.IsNeutralized)
            {
                Program.PrintColorMessage(ConsoleColor.Green, "----------");
                Program.PrintColorMessage(ConsoleColor.Green, "You are victorious!");
                Program.PrintColorMessage(ConsoleColor.Green, "----------");
                Dungeons.Dungeon.DungeonMenu();
            }
            else
            {
                Program.PrintColorMessage(ConsoleColor.Red, "----------");
                Program.PrintColorMessage(ConsoleColor.Red, "You have been defeated!");
                Program.PrintColorMessage(ConsoleColor.Red, "----------");
            }
        }
    }    
}
