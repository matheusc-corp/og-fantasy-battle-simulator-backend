using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_fantasy_battle_simulator.Models.Characters
{
    internal class Barbarian : AbstractCharacter
    {
        public Barbarian(string name) : base(name)
        {
            HealthPoints += 100;
            PhysicalAttack += 10;
            PhysicalDefense += 15;
        }
    }
}
