using ConsoleRpg.GUI;

namespace ConsoleRpg.Characters
{
    public class Player
    {
        //Core
        public String Name { get; set; }
        public String Description { get; set; }
        public int Level { get; set; }
        public int SkillPoints { get; set; }
        public int Exp { get; set; }
        public int ExpMax { get; set; } = 100;


        //Attributes
        public int Strenght { get; set; } = 3;
        public int Agility { get; set; } = 5; 
        public int Inteligence { get; set; } = 2;
        public int Vitality { get; set; } = 7;
        public int Stamina { get; set; } = 4;


        //Stats
        public int Health { get; set; }
        public int HealthMax { get; set; }
        public int Damage { get; set; }
        public int DamageMax { get; set; }
        public int Accuracy { get; set; }
        public int Defense { get; set; }


        /// <summary>
        /// Miscellaneous items that the player has
        /// </summary>
        public int Gold { get; set; }

        private void CalculateExp()
        {
            ExpMax = Level * 100;
        }

        private void CalculateStats()
        {
            Health = Vitality * 10;
            DamageMax = Strenght * 2;
            Damage = Strenght;
            Accuracy = (int)(Agility * 0.1);
            Defense = Stamina * 1;
        }

        public Player(String name, String description) 
        {
            Name = name;
            Description = description;
            CalculateStats();
        }

        public String GetName()
        {
            return Name;
        }

        public String PlayerInformation()
        {
            String str =
                $"Name: \t\t{Name}\n" +
                $"Level: \t\t{Level}\n" +
                $"Experience: \t{Exp}/{ExpMax} \t{Gui.ProgressBar(Exp, ExpMax, 10)}\n";
            return str;
        }

        public String DetailedPlayerInformation()
        {
            String str =
                $"Name: \t\t{Name}\n" +
                $"Description: \t{Description}\n" +
                $"Level: \t\t{Level}\n " +
                $"Strenght: \t {Strenght}\n " +
                $"Agility: \t {Agility}\n " +
                $"Inteligence: \t {Inteligence}\n " +
                $"Vitality: \t {Vitality}\n " +
                $"Stamina: \t {Stamina}\n\n" +
                $"Skill points: \t{SkillPoints}\n" +
                $"Experience: \t{Exp}/{ExpMax} \t{Gui.ProgressBar(Exp, ExpMax, 10)}\n";
            return str;
        }

        public String Banner()
        {
            String str =
                "============================================\n" +
                $"\t\t {Name} | Lvl: {Level} | {Gui.ProgressBar(Exp, ExpMax)}\n" +
                "\t ============================================\n";
            return str;
        }

    }
}
