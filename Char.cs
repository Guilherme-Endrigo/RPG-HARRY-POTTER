using System;
using System.Collections.Generic;

namespace RPG
{
    class Character
    {
        public int idChar { get; set; }

        public string name { get; set; }

        public int life { get; set; }

        public int score { get; set; }

        public bool isAlive { get; set; }

        public bool hasMap { get; set; }

        public bool hasPotion { get; set; }

        public bool isBlocked { get; set; }

        public House house { get; set; }

    }
}
