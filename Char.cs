using System;
using System.Collections.Generic;

namespace RPG
{
  class Character
  {
    public void Personagens(string _nome, string _wand, int _life, int _score, bool _isAlive, bool _hasMap, bool _hasPotion)
    {
      Nome = _nome;
      Wand = _wand;
      Life = _life;
      Score = _score;
      IsAlive = _isAlive;
      HasMap = _hasMap;
      HasPotion = _hasPotion;
    }

    public string Nome { get; set; }

    public string Wand { get; set; }

    public int Life { get; set; }

    public int Score { get; set; }

    public bool IsAlive { get; set; }

    public bool HasMap { get; set; }

    public bool HasPotion { get; set; }

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
