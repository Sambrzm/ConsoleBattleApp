using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattleApp
{
    class Knight : Hero
    {
        public override int Stamina { get; protected set; } = 12;
        public override int Strength { get; protected set; } = 12;
        public override int Intellect { get; protected set; } = 10;
        public override int Agility { get; protected set; } = 10;
        public override int Defence { get; protected set; } = 10;
        public override int MagicResist { get; protected set; } = 10;

        public override int CurrentXP { get; protected set; } = 0;

        public Knight() : base()
        {
        }

        public override void Attack()
        {
            Console.WriteLine("1 - Slash");
            Console.WriteLine("2 - Demoralizing shout");
            Console.WriteLine("3 - Battle cry");
            Console.WriteLine("4 - Shield bash");

            int answer = Int32.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Program.PrintColorMessage(ConsoleColor.Green, "You attack!");
                //Enemy.Health = Enemy.Health - MyPunch(Enemy.Health);                
                Enemy.DecreaseHealth(Slash());
                Console.WriteLine("Enemy HP is now {0}", Enemy.Health);
            }
            else if (answer == 2)
            {
                Program.PrintColorMessage(ConsoleColor.Green, "Enemy attack goes down");
                Enemy.AttackDamage -= 1;
                Enemy.CritDMG -= 2;
            }
            else if (answer == 3)
            {
                Program.PrintColorMessage(ConsoleColor.Green, "Your attack goes up!");
                AttackDamage += 2;
                CritDMG += 5;
            }
            else if (answer == 4)
            {
                Program.PrintColorMessage(ConsoleColor.Green, "Enemy accuracy goes down!");
                if (Enemy.Accuracy >= .35)
                {
                    Enemy.Accuracy -= .05;
                }
                else
                {
                    Program.PrintColorMessage(ConsoleColor.Red, "It's accuracy cant go down any more");
                }
            }
            else
            {
                Program.PrintColorMessage(ConsoleColor.Red, "Please enter a valid number");
                Attack();
            }

            int Slash()
            {
                int damage = AttackDamage;
                if (!IsSuccessfulHit())
                {
                    damage = 0;
                    Console.WriteLine("Missed!");
                }
                else
                {
                    if (IsCriticalHit())
                    {
                        Console.WriteLine("Critial Hit!");
                        damage = Convert.ToInt32(CritDMG);
                    }
                    else
                    {
                        damage = AttackDamage;
                    }
                }
                return damage;
            }
        }
    }
}
