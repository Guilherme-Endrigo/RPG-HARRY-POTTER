using System;
using System.Collections.Generic;

namespace RPG
{
    class House
    {
        public House createHouse(int _idChar)
        {
            House model = new House();

            model.houseName = "Sem definição";
            model.idChar = _idChar;
            model.scoreGryffindor = 0;
            model.scoreHufflePuff = 0;
            model.scoreRavenclaw = 0;
            model.scoreSlytherin = 0;

            return model;

        }
        public int idChar { get; set; }

        public string houseName { get; set; }

        public int scoreSlytherin { get; set; }


        public int scoreRavenclaw { get; set; }


        public int scoreGryffindor { get; set; }


        public int scoreHufflePuff { get; set; }

    }

}
