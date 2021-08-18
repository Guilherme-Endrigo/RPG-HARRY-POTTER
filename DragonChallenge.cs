using System;
using System.Collections.Generic;

namespace RPG
{
  class Dragon
  {
    static int diceValue = 0;
    public static void dragonsChallenge(List<Character> character)
    {

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                   TORNEIO                                     |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|                          O Torneio Tribruxo começou!                          |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    A torcida já está nas arquibancadas do campo de quadribol, e é quando, na  |");
      Console.WriteLine("|  tenda dos participantes, vocês se reúnem, todos igualmente ansiosos pelas    |");
      Console.WriteLine("| instruções. Logo Rony Weasley chega, anunciando que não será um desafio       |");
      Console.WriteLine("| qualquer: você começará com o mesmo desafio que um  dia Harry Potter          |");
      Console.WriteLine("| enfrentou, o DESAFIO DOS DRAGÕES.                                             |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine();
      RPG.Drawings.dragon();
      Console.WriteLine();
      Console.WriteLine("Pressione ENTER para continuar");
      Console.ReadLine();

      for (int i = 0; i < character.Count; i++)
      {

        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                             DESAFIO DOS DRAGÕES                               |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("| Agora, você tem 3 opções:                                                     |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("| (1) Procurar o ovo                                                            |");
        Console.WriteLine("| (2) Lutar contra o dragão                                                     |");
        Console.WriteLine("| (3) Fugir do dragão                                                           |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.Write($"{character[i].name}, informe a opção desejada para continuar: ");
        string option = Console.ReadLine();
        Console.WriteLine();

        while (option != "1" && option != "2" && option != "3" || option == "")
        {
          Console.WriteLine();
          Console.WriteLine("Opção inválida, tente novamente");
          Console.WriteLine();
          Console.Write($"{character[i].name}, escolha novamente: ");
          option = Console.ReadLine();
        }
        switch (option)
        {
          case "1":
            character[i] = searchEgg(character[i]);
            break;
          case "2":
            character[i] = fightDragon(character[i]);
            break;
          case "3":
            character[i] = avoidDragon(character[i]);
            break;
        }
      }

      RPG.Dragon.breakAfterDragonsChallenge(character);
    }

    //--------> OPÇÃO 1 <----------
    static Character searchEgg(Character character)
    {
      character.house.scoreRavenclaw += 1;

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                 PROCURAR O OVO                                |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    O ovo dourado está sendo guardado por um dragão Rabo-Córneo - porém como,  |");
      Console.WriteLine("| você escolheu não enfrentar o dragão cujo ovo a localização é conhecida,      |");
      Console.WriteLine("| agora entrará em uma busca pelo que pode estar em qualquer lugar de Hogwarts. |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      //sucesso marginal
      if (diceValue >= 6)
      {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                       PARECE QUE TEMOS UM XEROQUE ROMES                       |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Parabéns! Você conseguiu avançar nas investigações, colheu pistas pelo     |");
        Console.WriteLine("|  castelo de Hogwarts e está bem perto de conseguir encontrar o ovo! Jogue o   |");
        Console.WriteLine("|  dado novamente para saber se encontrará a última pista para chegar a ele!    |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
        Console.ReadLine();
        diceValue = RPG.Dice.throwDice();
        Console.WriteLine($"O Valor do dado é {diceValue}");

        //sucesso brilhante
        if (diceValue >= 18)
        {
          character.score += 5;

          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          Console.WriteLine("|                               PARABÉNS, SHERLOCK                              |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    Parabéns! Parece que o ovo estava embaixo d'água! Você trabalhou duro e    |");
          Console.WriteLine("| conseguiu achar o ovo! Bônus de 5 pontos por essa conquista.                  |");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine(" ------------------------------------------------------------------------------- ");

          Console.WriteLine();
          Console.WriteLine("Pressione ENTER para continuar");
          Console.ReadLine();

        }
        else
        {
          character.score -= 1;
          character.life -= 1;

          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          Console.WriteLine("|                        PARECE QUE ALGUÉM SOFREU BULLYING                      |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    Ih, não foi dessa vez. A Murta Que Geme não quis te ajudar e você não      |");
          Console.WriteLine("| conseguiu encontrar o ovo. Você perdeu um ponto no torneio e uma vida por     |");
          Console.WriteLine($"| isso. Está com {character.life} pontos de vida!                                              |");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine(" ------------------------------------------------------------------------------- ");


          Console.WriteLine();
          Console.WriteLine("Pressione ENTER para continuar");
          Console.ReadLine();
        }

      }
      else
      {
        character.score -= 1;
        character.life -= 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                           PRECISA DE UM OCULUS REPARO                         |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Humm, parece que foi uma busca que deu em nada. Você se perdeu na floresta |");
        Console.WriteLine("| e nem mesmo chegou a investigar pelo castelo, onde as principais pistas       |");
        Console.WriteLine("| estavam. Infelizmente seu tempo se esgotou, perdendo um ponto e um ponto de   |");
        Console.WriteLine($"| vida por isso. Ficando com {character.life} pontos de vida!                                  |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");


        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
      }

      //shift+alt 
      return character;
    }

    //---------> OPÇÃO 2 <---------
    static Character fightDragon(Character character)
    {
      character.house.scoreGryffindor += 1;

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                             EM POSIÇÃO DE ATAQUE                              |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Em um ato de coragem você se coloca em posição de ataque, pronto para      |");
      Console.WriteLine("| qualquer possível armadilha que o dragão esteja pensando.                     |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Será que o dragão irá conseguir tirar seus pontos de vida? Role o dado  e  |");
      Console.WriteLine("| descubra o desfecho deste duelo.                                              |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      //sucesso brilhante
      if (diceValue >= 18)
      {
        character.score += 4;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                              PRONTO PARA O DUELO                              |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Uau, é preciso muita audácia para enfrentarmos os nossos inimigos! Você    |");
        Console.WriteLine("| teve uma batalha árdua e desafiante, mas no final conseguiu derrotar o dragão |");
        Console.WriteLine("| e impressionar os juízes! Para você, a vida não tem graça sem alguns dragões, |");
        Console.WriteLine("| certo? Parabéns! Você ganhou um ponto por isso :D                             |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");


        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();

      }
      else
      {

        character.score -= 1;
        character.life -= 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                         MELHOR PASSAR NO VASSOURAX                            |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Vish, parece que o Dragão cuspiu fogo enquanto você lutava com ele no ar,  |");
        Console.WriteLine("| as chamas te desestabilizaram e arruinaram as cerdas da vassoura… Urgh, foi   |");
        Console.WriteLine("| uma queda feia! Que pena, acabou de perder um ponto e um ponto de vida.       |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine($"| Ficou com apenas {character.life} pontos de vida!                                            |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
      }
      return character;
    }

    //---------> OPÇÃO 3 <---------
    static Character avoidDragon(Character character)
    {
      character.house.scoreSlytherin += 1;
      character.house.scoreHufflePuff += 1;

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           AS VEZES É MELHOR FUGIR                             |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Você escolheu tentar fugir diante deste monstro poderoso, porém será capaz |");
      Console.WriteLine("| de escapar ? role o dado para saber saber se consegue escapar ou se será a    |");
      Console.WriteLine("| vez do dragão usar flamethrower!                                              |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      //sucesso mediano
      if (diceValue >= 11)
      {
        character.score += 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                         QUASE UM APANHADOR DE QUADRIBOL                       |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Virando à esquerda, depois à direita, dando giros pelas tendas e abrindo   |");
        Console.WriteLine("| espaço pelas arquibancadas… Vuuuuum, sua vassoura corta o ar! Isso, o dragão  |");
        Console.WriteLine("| está longe! Ele não consegue te alcançar! Uau, sua fuga foi bem-sucedida, e   |");
        Console.WriteLine("| suas habilidades furtivas conseguiram impressionar os juízes! Parabéns!       |");
        Console.WriteLine("| Você ganhou um ponto por isso :D                                              |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();

      }
      else
      {

        character.score -= 1;
        character.life -= 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                DRAGÕES PODEM REALMENTE SER MONTARIAS DE QUADRIBOL?            |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Ele está se aproximando… Mais rápido! Voe mais rápido….! Ah não, você foi  |");
        Console.WriteLine("| devagar demais e acabou sendo pego pelo dragão! Que pena, parece que acabou   |");
        Console.WriteLine("| de perder um ponto e um ponto de vida.                                        |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine($"| Está com {character.life} pontos de vida!                                                    |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();

      }
      return character;
    }

    //---------> BREAK <-----------
    public static void breakAfterDragonsChallenge(List<Character> character)
    {
      Console.WriteLine();
      Console.WriteLine();

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                 HORA DO RECREIO                               |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|                        A primeira parte chegou ao fim                         |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Muito bem, jovens competidores! Após um dia inteiro competindo, vocês      |");
      Console.WriteLine("| finalmente podem descansar o corpo e a mente de um desafio tão exaustivo e    |");
      Console.WriteLine("| após deixar o campo, vocês vão para os corredores do castelo.                 |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine("Pressione ENTER para continuar");
      Console.ReadLine();


      for (int i = 0; i < character.Count; i++)
      {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                                    DESCANSO                                   |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("| O que você deseja fazer antes do próximo desafio?                             |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("| (1) Estudar poções                                                            |");
        Console.WriteLine("| (2) Sabotar outros participantes                                              |");
        Console.WriteLine("| (3) Pedir ajuda aos seus amigos                                               |");
        Console.WriteLine("| (4) Treinar feitiços                                                          |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine();

        Console.Write($"{character[i].name}, informe a opção desejada para continuar: ");
        string option = Console.ReadLine();

        while (option != "1" && option != "2" && option != "3" && option != "4" || option == "")
        {
          Console.WriteLine();
          Console.WriteLine("Opção inválida, tente novamente");
          Console.WriteLine();
          Console.Write($"{character[i].name}, escolha novamente: ");
          option = Console.ReadLine();
        }
        switch (option)
        {
          case "1":
            character[i] = studyPotions(character[i]);
            break;
          case "2":
            character[i] = sabotageParticipants(character[i], character);
            if (character[i].hasSucceedSabotage)
            {
              int indexSabotage = RPG.Update.sabotageSucceed(character[i], character);
              character[indexSabotage].isBlocked = true;
            }
            break;
          case "3":
            character[i] = askFriendsForHelp(character[i]);
            break;
          case "4":
            character[i] = practiceSpells(character[i]);
            break;
        }
      }
      RPG.Lake.lakeChallenge(character);
    }

    //---------> OPÇÃO 1 <---------
    static Character studyPotions(Character character)
    {

      character.house.scoreRavenclaw += 1;

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                 ESTUDAR POÇÕES                                |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  Você escolheu estudar poções. Role o dado e veja se as horas de estudo       |");
      Console.WriteLine("| levaram a alguma descoberta interessante!                                     |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      //sucesso mediano
      if (diceValue >= 11)
      {

        character.house.scoreRavenclaw += 1;
        character.hasPotion = true;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                             UMA POÇÃO EXTRAORDINÁRIA                          |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Você aprendeu uma nova fórmula! Mas para que serve a Wiggenweld? Será que  |");
        Console.WriteLine("| ela te dará alguma vantagem?                                                  |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();

      }
      else
      {
        character.life -= 1;
        character.score -= 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                                 NA HORA ERRADA                                |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Você estava cansado demais e caiu no sono sobre o livro de poções. O       |");
        Console.WriteLine("| monitor te encontrou no laboratório no meio da madrugada e mandou que         |");
        Console.WriteLine($"| subisse para o dormitório. Está com {character.life} pontos de vida!                         |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");


        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();

      }
      return character;
    }

    //---------> OPÇÃO 2 <---------
    static Character sabotageParticipants(Character character, List<Character> listCharacter)
    {
      character.house.scoreSlytherin += 1;

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                             SABOTAR PARTICIPANTES                             |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  Você escolheu sabotar os outros participantes. Um movimento estrategicamente |");
      Console.WriteLine("| calculado que pode temporariamente tirar um concorrente do jogo e te conferir |");
      Console.WriteLine("| vantagens, porém com um alto risco envolvido. Role o dado para descobrir se a |");
      Console.WriteLine("| sabotagem deu certo. Boa sorte!                                               |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      //sucesso brilhante
      if (diceValue >= 11)
      {
        character.hasSucceedSabotage = true;
        character.house.scoreSlytherin += 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                               UM GÊNIO DA SABOTAGEM                           |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Muito bem, você foi sorrateiro e conseguiu encantar os equipamentos de um  |");
        Console.WriteLine("| participante. Informe o número da pessoa que será sabotada.                   |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();

      }
      else
      {

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                                 NA HORA ERRADA                                |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Humm, não deu muito certo. Um professor passou pelo corredor enquanto você |");
        Console.WriteLine("| tentava sabotar outro participante e te mandou para a detenção. Fique uma     |");
        Console.WriteLine("| uma rodada sem participar. Porém, antes, jogue o dado novamente para impedir  |");
        Console.WriteLine("| que a sua vítima descubra a sua trapaça.                                      |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
        Console.ReadLine();
        diceValue = RPG.Dice.throwDice();
        Console.WriteLine($"O Valor do dado é {diceValue}");


        //sucesso mediano
        if (diceValue >= 11)
        {
          character.house.scoreSlytherin += 1;

          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          Console.WriteLine("|                           UMA ESCAPATÓRIA BRILHANTE                           |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    Boa! Ninguém ficou sabendo da sua tentativa! Hehehhehehe                   |");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine(" ------------------------------------------------------------------------------- ");

          Console.WriteLine();
          Console.WriteLine("Pressione ENTER para continuar");
          Console.ReadLine();

        }
        else
        {
          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          Console.WriteLine("|                                 PEGO NO FLAGRA!                               |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    Você foi flagrado! Agora todos sabem que você tentou sabotar outro aluno.  |");
          Console.WriteLine("| Quando estiver andando por aí, fique de olhos abertos...                      |");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine(" ------------------------------------------------------------------------------- ");

          Console.WriteLine();
          Console.WriteLine("Pressione ENTER para continuar");
          Console.ReadLine();

        }
      }
      return character;
    }

    //---------> OPÇÃO 3 <---------
    static Character askFriendsForHelp(Character character)
    {
      character.house.scoreHufflePuff += 2;
      character.life += 1;

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                     COM AMIGOS, TUDO SE TORNA MAIS DIVERTIDO                  |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    “Existem coisas mais importantes, como amizade e bravura. Todos nós temos  |");
      Console.WriteLine("| luz e trevas dentro de nós. O que importa é o lado no qual escolhemos agir” e |");
      Console.WriteLine("| nossos amigos trazem à tona o melhor de nós.                                  |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Você conversou com seus amigos e agora se sente revigorado! Ganhou uma     |");
      Console.WriteLine($"| vida extra! Está com {character.life} pontos de vida!                                        |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine("Pressione ENTER para continuar");
      Console.ReadLine();

      return character;
    }

    //---------> OPÇÃO 4 <---------
    static Character practiceSpells(Character character)
    {
      character.house.scoreGryffindor += 1;

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                TREINAR FEITIÇOS                               |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  Você escolheu treinar feitiços esperando melhorar seus ataques e estar mais  |");
      Console.WriteLine("| preparado para os desafios seguintes. Jogue o dado para saber se você dominou |");
      Console.WriteLine("| ou não um novo feitiço. Boa sorte!                                            |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      //sucesso marginal
      if (diceValue >= 6)
      {

        character.house.scoreGryffindor += 1;
        character.score += 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                             ENTRE NO CLUBE DE DUELOS                          |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Como diz um importante bruxo: “A dedicação nunca te deixa na mão”, e ao    |");
        Console.WriteLine("| treinar feitiços você melhorou suas habilidades! Ganhou um ponto.             |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();

      }
      else
      {
        character.score -= 1;
        character.life -= 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                                UM INFELIZ ACIDENTE                            |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Argh! Parece que você se machucou tentando realizar o feitiço! Perdeu uma  |");
        Console.WriteLine($"| vida e um ponto, além de passar vergonha. Está com {character.life} pontos                   |");
        Console.WriteLine("| de vida!                                                                      |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
      }
      return character;
    }
  }
}