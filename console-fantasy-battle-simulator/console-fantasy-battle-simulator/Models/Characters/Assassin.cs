using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_fantasy_battle_simulator.Models.Characters
{
    internal class Assassin : BaseCharacter
    {
        public Assassin(string name) : base(name)
        {
            PhysicalAttack += 20;
            CriticalRate += 30;
        }
    }
}
