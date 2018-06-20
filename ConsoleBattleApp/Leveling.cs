using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattleApp
{
    class Leveling
    {
        public static int NextLevel(int level)
        {
            double exponent = 1.5;
            int baseXP = 1000;
            double totalXP = (baseXP * Math.Pow(level, exponent));
            return Convert.ToInt32(totalXP);
        }
    }
}
