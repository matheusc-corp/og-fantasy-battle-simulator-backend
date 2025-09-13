using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_fantasy_battle_simulator.Models.Characters
{
    internal class Warrior : AbstractCharacter
    {
        public Warrior(string name) : base(name)
        {
            HealthPoints += 50;
            PhysicalAttack += 15;
            PhysicalDefense += 10;
            CriticalRate += 4;
        }
    }
}
