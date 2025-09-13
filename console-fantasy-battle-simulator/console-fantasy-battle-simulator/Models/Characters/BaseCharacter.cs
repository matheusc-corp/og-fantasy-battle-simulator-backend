using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace console_fantasy_battle_simulator.Models.Characters
{
    abstract class BaseCharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int ManaPoints { get; set; }
        public int PhysicalAttack { get; set; }
        public int MagicAttack { get; set; }
        public int PhysicalDefense { get; set; }
        public int MagicDefense { get; set; }
        public int CriticalRate { get; set; }
        public int LastHit { get; set; }

        public BaseCharacter(string name)
        {
            Name = name;
            HealthPoints = 500;
            ManaPoints = 100;
            PhysicalAttack = 100;
            MagicAttack = 50;
            PhysicalDefense = 20;
            MagicDefense = 15;
            CriticalRate = 1;
        }

        public int Attack()
        {
            LastHit = CriticalDamage(CriticalRate, PhysicalAttack);

            return LastHit;
        }

        public int Magic()
        {
            LastHit = CriticalDamage(CriticalRate, MagicAttack);

            return LastHit;
        }

        public int CriticalDamage(int criticalRate, int baseDamage)
        {
            Random random = new Random();
            long critical = random.NextInt64(0, 100);

            if (critical <= criticalRate)
            {
                Console.WriteLine("Critco!");
                return (int)(baseDamage * 1.5);
            }

            return baseDamage;
        }

        public void TakePAtk(int damage) {
            damage -= PhysicalDefense;
            HealthPoints -= damage;
        }

        public void TakeMAtk(int damage)
        {
            damage -= MagicDefense;
            HealthPoints -= damage;
        }

        public override string ToString()
        {
            string msg =
$@"Name: {Name}
HP: {HealthPoints}
MP: {ManaPoints}
Physica Attack: {PhysicalAttack}
Magic Attack: {MagicAttack}
Physica Defense: {PhysicalDefense}
Magic Defense: {MagicDefense}
Critical rate: {CriticalRate}";

            return msg;
        }
    }
}
