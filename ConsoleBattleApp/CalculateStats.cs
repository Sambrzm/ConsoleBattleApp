using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattleApp
{
    public class CalculateStats
    {     
        public static int CalcHealth(int stam)
        {
            int Stamina = stam;
            return Stamina * 10;
        }
        public static int CalcMana(int intel)
        {
            int Intellect = intel;
            return Intellect * 10;
        }
        public static int CalcAtkDmg(int str)
        {
            int Strength = str;
            return str * 1;
        }
        public static double CalcCritChance(int agi)
        {
            double CritChance = agi * 0.5;
            return CritChance;
        }
        public static double CalcCritDmg(int str)
        {
            return str * 1.3;
        }
        public static int CalcSpellPower(int intel)
        {
            return intel * 1;
        }
    }
}
