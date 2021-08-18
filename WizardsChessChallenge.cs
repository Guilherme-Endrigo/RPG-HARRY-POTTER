using System;
using System.Collections.Generic;

namespace RPG
{
  class ChessChallenge
  {
    static int diceValue;

    public static void wizardChessChallenge(List<Character> character)
    {
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" --------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                   XADREZ BRUXO                                  |");
      Console.WriteLine("|---------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                                 |");
      Console.WriteLine("|     Começou um novo dia, sem saber para onde se direm a uma sala escura!        |");
      Console.WriteLine("|                                                                                 |");
      Console.WriteLine("|    Em meio ao caos, as luzes se acendem e vocês estão em um grande tabuleiro de |");
      Console.WriteLine("| xadrez. Do outro lado do tabuleiro, há uma porta, porém, para chegar até ela e  |");
      Console.WriteLine("| descobrir seus mistérios, temos que jogar o Xadrez Bruxo. Vamos ao jogo!        |");
      Console.WriteLine("|                                                                                 |");
      Console.WriteLine("|    As pessoas são peões em um tabuleiro de xadrez. Guiadas por mãos             |");
      Console.WriteLine("| desconhecidas, servem apenas para serem sacrificadas por um objetivo maior.     |");
      Console.WriteLine("|                                                                                 |");
      Console.WriteLine("|    Suba na sua peça!                                                            |");
      Console.WriteLine("|                                                                                 |");
      Console.WriteLine(" --------------------------------------------------------------------------------- ");

      RPG.Drawings.chess();

      for (int i = 0; i < character.Count; i++)
      {
        if (!character[i].isAlive)
        {
          continue;
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                             XADREZ DE BRUXO!                                  |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("| Agora, você tem 3 opções:                                                     |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("| (1) Cavalo do Rei                                                             |");
        Console.WriteLine("| (2) Torre da Rainha                                                           |");
        Console.WriteLine("| (3) Bispo Negro                                                               |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine();

        Console.Write($"{character[i].name}, informe a opção desejada para continuar: ");
        Console.WriteLine();
        string option = Console.ReadLine();
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
            character[i] = kingHorse(character[i]);
            break;
          case "2":
            character[i] = queenTower(character[i]);
            break;
          case "3":
            character[i] = blackBishop(character[i]);
            break;
        }
      }

      breakAfterXadrezBruxoChallenge(character);
    }

    //--------> OPÇÃO 1 <----------
    static Character kingHorse(Character character)
    {
      character.house.scoreRavenclaw += 1;

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                 CAVALO DO REI                                 |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Cavalo do rei, uma escolha de sorte e coragem. Você se sacrificou para     |");
      Console.WriteLine("| vencer o jogo! Após o lance que move o cavalo para a posição h3, o bispo      |");
      Console.WriteLine("| poderá se encaminhar para o xeque-mate graças à sua jogada.                   |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      if (diceValue >= 6)
      {
        character.house.scoreRavenclaw += 1;
        character.score += 2;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                         CAVALO DO REI AVANÇA PARA CHEQUE                       |");
        Console.WriteLine("|------------------------------------------------------------------------------- |");
        Console.WriteLine("|                                                                                |");
        Console.WriteLine("|    Magnífico, é preciso muita coragem e lealdade para se sacrificar por um bem |");
        Console.WriteLine("| maior. Você teve um jogo digno de grande mestre do xadrez. Como dizia um       |");
        Console.WriteLine("| Grande Mestre:                                                                 |");
        Console.WriteLine("|                                                                                |");
        Console.WriteLine("|    - Não há nenhum grande mestre de xadrez que seja normal, diferenciam-se     |");
        Console.WriteLine("| apenas pela magnitude da loucura.                                              |");
        Console.WriteLine("|                                                                                |");
        Console.WriteLine("|                         Ganhou dois ponto por isso :D                          |");
        Console.WriteLine("|                                                                                |");
        Console.WriteLine(" -------------------------------------------------------------------------------  ");

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();

        if (character.name == "Rony Weasley" || character.name == "Rony")
        {
          character.score += 5;
          character.life += 1;

          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          Console.WriteLine("|                            EASTER EGG ENCONTRADO                              |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|     Shazam! Por ter o mesmo nome que o corajoso Ronald Bilius Weasley, você   |");
          Console.WriteLine("| ganhou mais um ponto de vida e 5 pontos extras por essa conquista             |");
          Console.WriteLine($"| Está com {character.life} pontos de vida!                                                    |");
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
        Console.WriteLine("|                     CAVALO DO REI DÁ XEQUE, MAS NÃO MATE                      |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Lindo xeque no rei, mas não foi o suficiente, a Rainha do adversário       |");
        Console.WriteLine("| acabou com você, te reduzindo a pó. Você está fora do jogo de xadrez e perdeu |");
        Console.WriteLine($"| um ponto e uma vida. Que pena! Está com {character.life} pontos de vida!                     |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");


        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
      }

      return character;
    }

    //---------> OPÇÃO 2 <---------
    static Character queenTower(Character character)
    {
      character.house.scoreHufflePuff += 1;

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                 TORRE DA RAINHA                               |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Torre da rainha, uma escolha de segura. Você ficou observando o jogo sem   |");
      Console.WriteLine("| correr grande perigo até o momento! Role o dado para saber se essa foi a      |");
      Console.WriteLine("| melhor estratégia.                                                            |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      if (diceValue >= 6)
      {
        character.house.scoreHufflePuff += 1;
        character.score += 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                       XADREZ É PACIÊNCIA E AUTOCONFIANÇA                      |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|   Sacrificando a sua peça, com honra, você se posiciona para vencer o jogo.   |");
        Console.WriteLine("| Você também se manteve firme até aqui - em um jogo em que cada movimento      |");
        Console.WriteLine("| conta!                                                                        |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Parabéns! Você ganhou um ponto por isso :D                                 |");
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
        Console.WriteLine("|              A IMPACIÊNCIA É UM GRANDE OBSTÁCULO PARA O BOM ÊXITO             |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Vish, parece que sacrifícar a sua peça não foi o suficiente para ajudar.   |");
        Console.WriteLine("|  Além de ter feito uma jogada em vão, acabou de perder um ponto e uma vida.   |");
        Console.WriteLine($"|  Está com {character.life} pontos de vida!                                                   |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
      }

      return character;
    }

    //---------> OPÇÃO 3 <---------
    static Character blackBishop(Character character)
    {
      character.house.scoreGryffindor += 1;
      character.house.scoreSlytherin += 1;

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                    BISPO NEGRO                                |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Bispo Negro, após uma jogada de honra e coragem, o XEQUE MATE ficou por    |");
      Console.WriteLine("|    sua conta!                                                                 |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine();

      Console.WriteLine();
      Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      if (diceValue >= 6)
      {
        character.house.scoreGryffindor += 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" -------------------------------------------------------------------------------");
        Console.WriteLine("|           ACALMA ESSE CORAÇÃO, QUE DESESPERO NUNCA RESOLVEU NADA              |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Com muita sabedoria, você conteve a torre da rainha no seu devido lugar,   |");
        Console.WriteLine("| assim podendo efetuar seu lance!                                              |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Jogue o dado novamente para tentar o xeque-mate!                           |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
        Console.ReadLine();
        diceValue = RPG.Dice.throwDice();
        Console.WriteLine($"O Valor do dado é {diceValue}");

        if (diceValue >= 6)
        {
          character.score += 5;
          character.life += 1;

          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          Console.WriteLine("|       NA VIDA, AO CONTRÁRIO DO XADREZ, O JOGO CONTINUA APÓS O XEQUE-MATE      |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    Parabéns! Seu xeque-mate foi magnífico, deixando seu adversário em pedaços!|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    UHUUL! Bônus de 5 pontos por essa conquista e também uma vida!             |");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine($"|    Está com {character.life} pontos de vida!                                                 |");
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
          Console.WriteLine("|      SOMOS PEDRAS DE UM JOGO DE XADREZ PRESTE A TOMAR OU DAR UM XEQUE-MATE    |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    Ih, não foi dessa vez. Você avançou o número de casas de maneira errada e  |");
          Console.WriteLine("| e foi decapitado pela rainha, perdendo um ponto e uma vida.                   |");
          Console.WriteLine($"| Está com {character.life} pontos de vida!                                                    |");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine(" ------------------------------------------------------------------------------- ");

          Console.WriteLine();
          Console.WriteLine("Pressione ENTER para continuar");
          Console.ReadLine();
        }

      }
      else
      {
        character.house.scoreSlytherin += 1;
        character.score -= 3;
        character.life -= 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                  NEM SEMPRE TUDO QUE ESTÁ INDO BEM ACABA BEM                  |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|         Grrr! Parece que a torre da rainha se movimentou na sua vez!          |");
        Console.WriteLine("|   O adversário, além de destruir a sua peça, conseguiu se defender do         |");
        Console.WriteLine("| xeque-mate. Perdeu três pontos e uma vida!                                    |");
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
    public static void breakAfterXadrezBruxoChallenge(List<Character> character)
    {

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                   DESCANSO                                    |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|                       O Xadrez Bruxo chegou ao seu fim                        |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Rolou muita emoção! Agora você precisa descansar. Após esse grande         |");
      Console.WriteLine("|  desafio, você poderá escolher algo para fazer.                               |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  Bom, vamos lá para as suas opções!                                           |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine("Pressione ENTER para continuar");
      Console.ReadLine();

      for (int i = 0; i < character.Count; i++)
      {

        if (!character[i].isAlive)
        {
          continue;
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                                   DESCANSO                                    |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("| Faça uma escolha:                                                             |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("| (1) Fazer uma festa no Salão Principal                                        |");
        Console.WriteLine("| (2) Tirar cochilo                                                             |");
        Console.WriteLine("| (3) Relaxar na estufa da Prof. Sprout                                         |");
        Console.WriteLine("| (4) Ir visitar Hagrid                                                         |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine();

        Console.Write($"{character[i].name}, informe a opção desejada para continuar: ");
        string option = Console.ReadLine();

        while (option != "1" && option != "2" && option != "3" && option != "4" || option == "")
        {
          Console.WriteLine();
          Console.WriteLine("Opção inválida, tente novamente.");
          Console.WriteLine();
          Console.Write($"{character[i].name}, escolha novamente: ");
          option = Console.ReadLine();
        }
        switch (option)
        {
          case "1":
            character[i] = mainHallParty(character[i]);
            break;
          case "2":
            character[i] = nap(character[i]);
            break;
          case "3":
            character[i] = relaxInTheGreenHouse(character[i]);
            break;
          case "4":
            character[i] = visitHagrid(character[i]);
            break;
        }
      }

      RPG.Maze.mazeChallenge(character);
    }
    //---------> OPÇÃO 1 <---------
    static Character mainHallParty(Character character)
    {
      character.house.scoreGryffindor += 1;

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------  ");
      Console.WriteLine("|                                 A GRANDE FESTA                                |");
      Console.WriteLine("|------------------------------------------------------------------------------ |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Você escolheu ir à festa. Agora role o dado para saber o que virá!         |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------  ");

      Console.WriteLine();
      Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");


      if (diceValue >= 6)
      {
        character.life += 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                      COM AMIGOS TUDO SE TORNA MAIS DIVERTIDO                  |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Conseguiu novas amizades com essa festa, tempos difíceis revelam grandes   |");
        Console.WriteLine($"| amigos. Está com {character.life} pontos de vida!                                            |");
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
        Console.WriteLine("|                         ANTES SÓ DO QUE MAL ACOMPANHADO                       |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Você não fez nenhuma amizade, porém já dizia o ditado \"não há pior         |");
        Console.WriteLine("| inimigo que um falso amigo\".                                                  |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();

      }
      return character;
    }

    //---------> OPÇÃO 2 <---------
    static Character nap(Character character)
    {
      character.house.scoreSlytherin += 1;

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|           SHIIIIU, MANTENHA-SE EM SILÊNCIO, ESTAMOS NO COCHILO ZZzzzZ         |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Você escolheu tirar um cochilo, e descansar sempre é importante. Vamos ver |");
      Console.WriteLine("| os benefícios e malefícios desse cochilo, tudo tem os dois lados. Pode ser    |");
      Console.WriteLine("| que dê bom ou ruim. Prepare-se e...                                           |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Let it Rip! Jogue os dados para saber o que vai acontecer!                 |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      if (diceValue >= 6)
      {
        character.life += 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                         VAMOS PARA O SONO DA BELEZA                           |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Que sono revigorante! Você teve um sonho e, através dele, aprendeu a como  |");
        Console.WriteLine($"| abrir o Oráculo dos sonhos! Está com {character.life} pontos de vida!                        |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
      }
      else
      {
        character.score -= 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                       DORMIR É UM MODO INTERINO DE MORRER                     |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Acho que alguém dormiu muito... ZzzzZzZ. Te deram a poção do morto vivo!   |");
        Console.WriteLine("| Você não conseguiu realizar nenhuma ação e dormiu por dias.                   |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
      }
      return character;
    }

    //---------> OPÇÃO 3 <---------
    static Character relaxInTheGreenHouse(Character character)
    {
      character.house.scoreHufflePuff += 1;

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|          ESTUFA DA PROFª SPROUT, UM LUGAR QUE GUARDA VÁRIOS MISTÉRIOS         |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|    Nesse lugar misterioso, podemos encontrar desde ervas e fungos até... Aah, |");
      Console.WriteLine("| não irei revelar. Bora lá?                                                    |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");

      if (diceValue >= 6)
      {
        character.score += 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                  NÃO HÁ SORTE NA VIDA, O QUE HÁ É OPORTUNIDADE                |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Você achou uma poção para reverter quem foi petrificado e ganhou um ponto! |");
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
        Console.WriteLine("|                 TEM PESSOAS QUE TÊM AZAR NO AMOR E AZAR NO JOGO               |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Shazam! Você foi atingido pelo grito ensurdecedor da Mandrácora! Deveria   |");
        Console.WriteLine("| ter colocado os protetores de ouvido, ein? Menos um ponto e uma vida!         |");
        Console.WriteLine($"| Está com {character.life} pontos de vida!                                                    |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();

      }
      return character;
    }

    //---------> OPÇÃO 4 <---------
    static Character visitHagrid(Character character)
    {
      character.house.scoreRavenclaw += 1;

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|         VAMOS ATÉ A CASA DO HAGRID FAZER AQUELA VISITINHA? SIM OU CLARO?      |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Não adianta a gente ficar sentado se preocupando. O que tiver que ser      |");
      Console.WriteLine("|  será, e nós enfrentaremos quando vier. Jogue o dado para descobrir como será |");
      Console.WriteLine("|  essa visita.                                                                 |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
      Console.ReadLine();
      diceValue = RPG.Dice.throwDice();
      Console.WriteLine($"O Valor do dado é {diceValue}");


      if (diceValue >= 6)
      {
        character.score += 1;
        character.life += 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                 HMMM, SÓ DE SENTIR O CHEIRO DEU ÁGUA NA BOCA                  |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Como diz Rúbeo Hagrid: “Eu sou o que sou e eu não tenho vergonha”. Você    |");
        Console.WriteLine("| ganhou um delicioso bolo feito com muito amor <3.                             |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

      }
      else
      {
        character.score -= 1;
        character.life -= 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                                NEM TUDO É FLORES                              |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    Xiiii, Hagrid te levou para a Floresta Proibida e, para seu azar, o Filch  |");
        Console.WriteLine($"| viu vocês e te levou à diretoria. Está com {character.life} pontos de vida!                  |");
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