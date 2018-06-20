using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattleApp
{
    class Skeleton : Enemy
    {
        public override int Stamina { get; protected set; } = 12;
        public override int Strength { get; protected set; } = 12;
        public override int Intellect { get; protected set; } = 10;
        public override int Agility { get; protected set; } = 10;
        public override int Defence { get; protected set; } = 10;
        public override int MagicResist { get; protected set; } = 10;

        public Skeleton() : base()
        {
        }

        public override void Attack()
        {
            Random R = new Random();
            int attack = R.Next(1, 5);

            if (attack == 1)
            {
                Attack1();
            }
            else if (attack == 2)
            {
                Attack2();
            }
            else if (attack == 3)
            {
                Attack3();
            }
            else
            {
                Attack4();
            }
        }

        public static void Attack1()
        {
            Console.WriteLine("Skeleton swings it's sword");
            Hero.DecreaseHealth(AttackDamage);
            Console.WriteLine("Your HP is now {0}", Hero.Health);
        }
        public static void Attack2()
        {
            Program.PrintColorMessage(ConsoleColor.Red, "Skeleton shreiks! Your attack goes down");
            Hero.AttackDamage -= 1;
            Hero.CritDMG -= 2;
        }
        public static void Attack3()
        {
            Program.PrintColorMessage(ConsoleColor.Red, "Skeleton enrages, it's attack goes up!");
            AttackDamage += 2;
            CritDMG += 5;
        }
        public static void Attack4()
        {
            Program.PrintColorMessage(ConsoleColor.Red, "Skeleton sprays you in the eyes - Your accuracy goes down");
            if (Hero.Accuracy >= 0.35)
            {
                Hero.Accuracy -= .05;
            }
            else
            {
                Program.PrintColorMessage(ConsoleColor.Red, "Your accuracy cant go down any more");
            }
        }
    }
}
