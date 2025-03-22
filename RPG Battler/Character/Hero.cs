using RPG_Battler.Character.Upgrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    public class Hero : Creations
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<Spell> Spells { get; set; } = new List<Spell>();
        public List<Equipment> Equipment { get; set; } = new List<Equipment>();

        public Hero()
        {
            Name = "Unknown";
            Level = 0;
            Health = Power = Luck = 1;
            Mana = 0;
            ExperienceRemaining = 100;
        }

        public void LevelUp()
        {
            var generator = new Random();
            Level++;

            switch (CombatClass.ToString())
            {
                case "Mage":
                    Health += generator.Next(1, 16);
                    Power += generator.Next(3, 6);
                    Luck += generator.Next(1, 4);
                    break;
                case "Warrior":
                    Health += generator.Next(10, 21);
                    Power += generator.Next(1, 4);
                    Luck += generator.Next(1, 4);
                    break;
                case "Rogue":
                    Health += generator.Next(1, 16);
                    Power += generator.Next(1, 4);
                    Luck += generator.Next(3, 6);
                    break;
            }

            ExperienceRemaining = 100;
            Console.WriteLine($"{Name} has reached Level {Level}. Strength increased!");
        }

        public void DisplayStats(bool showTotalStats = true)
        {
            Console.WriteLine($"\n*** {Name}'s Status ***");
            Console.WriteLine($"{"Level:",-10} {Level}");
            Console.WriteLine($"{"Health:",-10} {Health}");
            Console.WriteLine($"{"Power:",-10} {Power}");
            Console.WriteLine($"{"Luck:",-10} {Luck}");
            Console.WriteLine($"{"Mana:",-10} {Mana}");

            if (showTotalStats)
            {
                Console.WriteLine("\n[Total Stats with Equipment Bonuses Included]");
            }
            else
            {
                Console.WriteLine("\n[Base Stats Only]");
            }
        }

        public void CalculateTotals()
        {
            
        }
    }
}

