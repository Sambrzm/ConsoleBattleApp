using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattleApp
{
    class TownHome
    {
        public static void townArrival()
        {
            Console.WriteLine("You have arrived in town. What would you like to do?");
            Console.WriteLine("1 Enter Dungeon");
            Console.WriteLine("2 Shop");
            Console.WriteLine("3 Manage Party");
            Console.WriteLine("4 Inventory");

            int answer = Int32.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Program.PrintColorMessage(ConsoleColor.Red, "Abandon all hope ye who enter here");
                Battle.BattleOrRun();
            }
            else if (answer == 2)
            {
                //enter shop
            }
            else if (answer == 3)
            {
                //manage party
            }
            else if (answer == 4)
            {
                //Inventory
            }
            else
            {
                Program.PrintColorMessage(ConsoleColor.Red, "Please enter a valid number");
                townArrival();
            }
        }       
        

    }
}
