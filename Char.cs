using System;
using System.Collections.Generic;

namespace RPG
{
    class Character
    {
        public House whatHouse(Character character)
        {

            House house = character.house;

            if (house.scoreGryffindor > house.scoreSlytherin && house.scoreGryffindor > house.scoreRavenclaw && house.scoreGryffindor > house.scoreHufflePuff)
            {

                character.house.houseName = "Grifinória";
                //Gryffindor
            }
            else if (house.scoreSlytherin > house.scoreGryffindor && house.scoreSlytherin > house.scoreRavenclaw && house.scoreSlytherin > house.scoreHufflePuff)
            {
                character.house.houseName = "Sonserina";
                //Slytherin
            }
            else if (house.scoreRavenclaw > house.scoreGryffindor && house.scoreRavenclaw > house.scoreSlytherin && house.scoreRavenclaw > house.scoreHufflePuff)
            {
                character.house.houseName = "Corvinal";
                //Ravenclaw
            }
            else
            {
                character.house.houseName = "Lufa-lufa";
                //HufflePuff
            }

            return character.house;

        }

        public int idChar { get; set; }

        public string name { get; set; }

        public string wand { get; set; }

        public int life { get; set; }

        public int score { get; set; }

        public bool isAlive { get; set; }

        public bool hasMap { get; set; }

        public bool hasPotion { get; set; }

        public House house { get; set; }

    }

    // public static IList<Personagens> populateChar(int groupSize)
    // {

    //   return new List<Personagens>() {
    //     new Personagens("Chaves", "barril", "8"),
    //     new Personagens("Chiquinha", "anã", "14"),
    //     new Personagens("Bruxa do 71", "bruxas", "71"),
    //     new Personagens("Seu Madruga", "caloteiro", "14"),
    //   };
    // }
}
