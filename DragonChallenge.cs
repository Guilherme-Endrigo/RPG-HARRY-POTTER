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
      Console.WriteLine("Pressione ENTER para continuar");
      Console.ReadLine();

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                   TORNEIO                                     |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|                              O torneio começou!                               |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Todos se encaminharam para o campo de quadribol, a torcida já está nas     |");
      Console.WriteLine("| arquibancadas e é quando na tenda dos participantes você se reúne com os      |");
      Console.WriteLine("| outros participantes, aguardando ansiosamente pelas instruções. Você está     |");
      Console.WriteLine("| empolgado para o seu primeiro desafio, e logo Rony Weasley chega, anunciando  |");
      Console.WriteLine("| que não será um desafio qualquer, você começará com o mesmo desafio que um    |");
      Console.WriteLine("| dia Harry Potter enfrentou, o DESAFIO DOS DRAGÕES.                            |");
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

        while (option != "1" && option != "2" && option != "3" && option == "")
        {
          Console.WriteLine();
          Console.WriteLine("Opção Invalida, tente novamente");
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
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                 PROCURAR O OVO                                |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    O ovo dourado está sendo guardado por um dragão, dentro de uma ninhada de  |");
      Console.WriteLine("| ovos de dragão reais - porém como você escolheu não enfrentar o dragão pelo   |");
      Console.WriteLine("| ovo cuja localização é conhecida, agora entrará em uma busca pelo outro ovo   |");
      Console.WriteLine("| que pode estar em qualquer lugar de Hogwarts                                  |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      character.house.scoreRavenclaw += 1;

      Console.WriteLine();
      Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      //sucesso marginal
      if (diceValue >= 6)
      {

        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                           ONDE SERÁ QUE ESTÁ O OVO?                           |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Parabéns! Você conseguiu avançar nas investigações, colheu pistas pelo     |");
        Console.WriteLine("|  castelo de Hogwarts e está bem perto de conseguir encontrar o ovo! Jogue o   |");
        Console.WriteLine("|  dado novamente para saber se encontrará a última pista para chegar ao ovo!   |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
        Console.ReadLine();
        diceValue = RPG.Dice.throwDice();
        Console.WriteLine($"O Valor do dado é {diceValue}");

        //sucesso brilhante
        if (diceValue >= 18)
        {
          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          Console.WriteLine("|                           ONDE ESTÁ O OVO  --  SUCESSO                        |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    Parabéns! Parece que o ovo estava embaixo da água! Você trabalhou duro e   |");
          Console.WriteLine("| conseguiu achar o ovo! Bônus de 5 pontos por essa conquista                   |");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine(" ------------------------------------------------------------------------------- ");

          character.score += 5;

        }
        else
        {

          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          Console.WriteLine("|                           ONDE ESTÁ O OVO  --  FRACASSO                       |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    Ih não foi dessa vez. A Murta Que Geme não quis te ajudar e                |");
          Console.WriteLine("| você não conseguiu encontrar o ovo. Você perdeu um ponto e um ponto de vida.  |");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine(" ------------------------------------------------------------------------------- ");

          character.score -= 1;
          character.life -= 1;

          Console.WriteLine();
          Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
          Console.ReadLine();

          Console.WriteLine();
          Console.WriteLine("Pressione ENTER para continuar");
          Console.ReadLine();
        }

      }
      else
      {

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                           PROCURAR O OVO  --  FRACASSO                        |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Hmm parece que foi uma busca que não deu em nada, você se perdeu na        |");
        Console.WriteLine("| floresta e nem mesmo chegou a investigar pelo castelo, onde as principais     |");
        Console.WriteLine("| pistas estavam. Infelizmente seu tempo se esgotou, portanto vai ficar com     |");
        Console.WriteLine("| um ponto e um ponto de vida a menos                                           |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        character.score -= 1;
        character.life -= 1;

        Console.WriteLine();
        Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
        Console.ReadLine();

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
      Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      //sucesso brilhante
      if (diceValue >= 18)
      {

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                           ENFRENTAR DRAGÃO  --  SUCESSO                       |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Uau, é preciso muita audácia para enfrentarmos os nossos inimigos, você    |");
        Console.WriteLine("| teve uma batalha árdua e desafiante, mas no final conseguiu derrotar o dragão |");
        Console.WriteLine("| e impressionar os juízes! Para você, a vida não tem graça sem alguns dragões, |");
        Console.WriteLine("| certo? Parabéns! Você ganhou um ponto por isso :D                             |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        character.score += 1;

        //if(maiorPonto)
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                       ENFRENTAR DRAGÃO  --  MAIOR PONTO                       |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Incrível! Além da vitória, você ganhou o ovo por ter sido o jogador        |");
        Console.WriteLine("| com maior pontuação. Parabéns! Aqui vão 5 pontos extras por essa conquista    |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        character.score += 5;

      }
      else
      {

        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                         ENFRENTAR DRAGÃO  --  FRACASSO                        |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Vish, parece que o Dragão cuspiu fogo enquanto você lutava com ele no ar,  |");
        Console.WriteLine("| as chamas o desestabilizaram e arruinaram as cerdas da vassoura… Urgh, foi    |");
        Console.WriteLine("| uma queda feia! Que pena, acabou de perder um ponto e um ponto de vida        |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        character.score -= 1;
        character.life -= 1;

        Console.WriteLine();
        Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
      }
      return character;
    }

    //---------> OPÇÃO 3 <---------
    static Character avoidDragon(Character character)
    {
      character.house.scoreSlytherin += 2;
      character.house.scoreHufflePuff += 1;

      Console.WriteLine();
      Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      //sucesso mediano
      if (diceValue >= 11)
      {

        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                           FUGIR DRAGÃO  --  SUCESSO                           |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Virando à esquerda, depois à direita, dando giros pelas tendas e abrindo   |");
        Console.WriteLine("| espaço pelas arquibancadas… Vuuuuum, sua vassoura corta o ar! Isso, o dragão  |");
        Console.WriteLine("| está longe! Ele não consegue te alcançar! Uau, sua fuga foi bem-sucedida, e   |");
        Console.WriteLine("| suas habilidades furtivas conseguiram impressionar os juízes! Parabéns!       |");
        Console.WriteLine("| Você ganhou um ponto por isso :D                                              |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        character.score += 1;

      }
      else
      {

        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                          FUGIR DRAGÃO  --  FRACASSO                           |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Ele está se aproximando…Mais rápido! Voe mais rápido….! Ah não, você foi   |");
        Console.WriteLine("| devagar demais e acabou sendo pego pelo dragão! Que pena, parece que acabou   |");
        Console.WriteLine("| de perder um ponto e um ponto de vida.                                        |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        character.score -= 1;
        character.life -= 1;

        Console.WriteLine();
        Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
        Console.ReadLine();

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
      Console.WriteLine("Pressione ENTER para continuar");
      Console.ReadLine();

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                   DESCANSO                                    |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|                        A primeira parte chegou ao fim.                        |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Muito bem, jovens competidores! Após um dia inteiro competindo, você       |");
      Console.WriteLine("| finalmente pode descansar o corpo e a mente de um desafio tão exaustivo.      |");
      Console.WriteLine("| Após deixar o campo, você está nos corredores do castelo perguntando-se       |");
      Console.WriteLine("| o que pode fazer antes do 2º desafio começar...                               |");
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
        Console.WriteLine("| Faça uma escolha:                                                             |");
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

        while (option != "1" && option != "2" && option != "3" && option != "4" && option == "")
        {
          Console.WriteLine();
          Console.WriteLine("Opção Invalida, tente novamente");
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

      character.house.scoreRavenclaw += 1;

      Console.WriteLine();
      Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      //sucesso mediano
      if (diceValue >= 11)
      {

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                          ESTUDAR POÇÕES  --  SUCESSO                          |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Você descobriu uma poção que pode aumentar seu tempo debaixo d'água.       |");
        Console.WriteLine("| Na próxima etapa do torneio, isso lhe dará uma vantagem                       |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        character.hasMap = true;

      }
      else
      {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                          ESTUDAR POÇÕES  --  FRACASSO                         |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Você estava cansado demais e caiu no sono sobre o livro de poções.         |");
        Console.WriteLine("| O monitor o encontrou no laboratório no meio da madrugada e mandou que        |");
        Console.WriteLine("| subisse para o dormitório.                                                    |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        character.life -= 1;
        character.score -= 1;

        Console.WriteLine();
        Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();

      }
      return character;
    }

    //---------> OPÇÃO 2 <---------
    static Character sabotageParticipants(Character character, List<Character> listCharacter)
    {
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                             SABOTAR PARTICIPANTES                             |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  Você escolheu sabotar os outros participantes. Um movimento estrategicamente |");
      Console.WriteLine("| calculado que pode temporariamente tirar um concorrente do jogo e lhe conferir|");
      Console.WriteLine("| vantagens, porém com um alto risco envolvido. Role o dado para descobrir se a |");
      Console.WriteLine("| sabotagem deu certo. Boa sorte!                                               |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      character.house.scoreSlytherin += 1;

      Console.WriteLine();
      Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      //sucesso brilhante
      if (diceValue >= 18)
      {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                      SABOTAR PARTICIPANTES  --  SUCESSO                       |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Muito bem, você foi sorrateiro e conseguiu encantar os equipamentos de um  |");
        Console.WriteLine("| participante para que ele não consiga disputar a prova seguinte. Diga quem    |");
        Console.WriteLine("| será a pessoa que não participará do próximo desafio:                         |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        character.hasSucceedSabotage = true;
        character.house.scoreSlytherin += 1;

      }
      else
      {

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                      SABOTAR PARTICIPANTES  --  FRACASSO                      |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Hmmm não deu muito certo. Um professor passou pelo corredor enquanto       |");
        Console.WriteLine("| você tentava sabotar outro participante e o mandou para a detenção. Fique uma |");
        Console.WriteLine("| uma rodada sem participar. Porém, antes, jogue o dado novamente para impedir  |");
        Console.WriteLine("| que o grupo descubra a sua trapaça.                                           |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
        Console.ReadLine();
        diceValue = RPG.Dice.throwDice();
        Console.WriteLine($"O Valor do dado é {diceValue}");


        //sucesso mediano
        if (diceValue >= 11)
        {
          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          Console.WriteLine("|                          SAFAR-SE  --  SUCESSO                                |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    Boa! Ninguém ficou sabendo da sua tentativa! Hehehhehehe                   |");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine(" ------------------------------------------------------------------------------- ");

          // RPG.Drawings.diabolicLaugh();

          character.house.scoreSlytherin += 1;

        }
        else
        {
          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          Console.WriteLine("|                          SAFAR-SE  --  FRACASSO                               |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    Você foi flagrado! Agora todos sabem que você tentou sabotá-los.           |");
          Console.WriteLine("| Quando estiver andando por aí, fique de olhos abertos...                      |");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine(" ------------------------------------------------------------------------------- ");

          Console.WriteLine();
          Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
          Console.ReadLine();

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

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                              PEDIR AJUDA AOS AMIGOS                           |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    “Existem coisas mais importantes, como amizade e bravura. Todos nós temos  |");
      Console.WriteLine("| luz e trevas dentro de nós. O que importa é o lado no qual escolhemos agir”,  |");
      Console.WriteLine("| e nossos amigos trazem o melhor de nós.                                       |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| Você conversou com seus amigos e agora sente-se revigorado! Ganhou um ponto   |");
      Console.WriteLine("| de vida extra!                                                                |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      character.house.scoreHufflePuff += 1;
      character.life += 1;
      return character;
    }

    //---------> OPÇÃO 4 <---------
    static Character practiceSpells(Character character)
    {
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                TREINAR FEITIÇOS                               |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  Você escolheu treinar feitiços, esperando melhorar seus ataques e estar mais |");
      Console.WriteLine("| preparado para os desafios seguintes. Jogue o dado para saber se você dominou |");
      Console.WriteLine("| dominou, ou não o feitiço. Boa sorte!                                         |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      character.house.scoreGryffindor += 1;

      Console.WriteLine();
      Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      //sucesso marginal
      if (diceValue >= 6)
      {

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                          TREINAR FEITIÇOS -- SUCESSO                          |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Como diz um importante bruxo: “A dedicação nunca te deixa na mão”, e ao    |");
        Console.WriteLine("| treinar feitiços você melhorou suas habilidades! Ganhou um ponto, além de     |");
        Console.WriteLine("| pontos de inteligência.                                                       |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        character.score += 1;

      }
      else
      {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                          TREINAR FEITIÇOS -- FRACASSO                         |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Argh! Parece que você se machucou tentando realizar o feitiço! Perdeu uma  |");
        Console.WriteLine("| vida e um ponto, além de passar vergonha.                                     |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        character.score -= 1;
        character.life -= 1;

        Console.WriteLine();
        Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
      }
      return character;
    }
  }
}