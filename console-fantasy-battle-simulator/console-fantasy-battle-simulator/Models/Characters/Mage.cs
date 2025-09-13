using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_fantasy_battle_simulator.Models.Characters
{
    internal class Mage : AbstractCharacter
    {
        public Mage(string name) : base(name)
        {
            ManaPoints += 100;
            MagicAttack += 100;
            MagicDenfense += 10;
        }
    }
}
