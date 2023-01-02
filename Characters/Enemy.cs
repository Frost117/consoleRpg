using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg.Characters
{
    public class Enemy
    {
        public int Health { get; set; }
        public String Name { get; set; }

        public bool IsDead { get; set; }


        public Enemy(string name)
        {
            Health = 100 ;

            Name = name;
        }
    }
}

