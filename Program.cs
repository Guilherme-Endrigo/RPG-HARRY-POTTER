using System;

namespace RPG
{
  class Program
  {
    static void Main(string[] args)
    {

      menu();
      dragonsChallenge();
      breakBeforeNextChallenge();
      draw();
    }

    static void menu()
    {

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                        Bem vindo ao jogo de RPG                               |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   Escolha uma das opções abaixo:                                              |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (1) Novo jogo                                                                 |");
      Console.WriteLine("| (2) Carregar jogo (precisamos pensar como)                                    |");
      Console.WriteLine("| (3) Regras                                                                    |");
      Console.WriteLine("| (4) Sair                                                                      |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      string firstOption = Console.ReadLine();

      while (firstOption != "1" && firstOption != "2" && firstOption != "3")
      { Console.WriteLine("Opção Invalida, tente novamente"); };

      switch (firstOption)
      {
        case "1":
          newGame();
          break;

        case "2":

          Console.Write("Carregando..");
          break;

        case "3":
          rules();
          menu();
          break;

        case "4":
          Console.Write("Saindo... Esperamos vocês uma outra hora");
          break;
      }
    }
    //---------> OPÇÂO 1 <---------
    static void searchEgg(string option)
    {
      //corvinal++;

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                 PROCURAR O OVO                                |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    O ovo dourado está sendo guardado por um dragão, dentro de uma ninhada de  |");
      Console.WriteLine("| ovos de dragão reais - porém como você escolheu não enfrentar o dragão pelo   |");
      Console.WriteLine("| ovo cuja localização é conhecida, agora entrará em uma busca pelo outro ovo   |");
      Console.WriteLine("| que pode estar em qualquer lugar de Hogwarts                                  |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //throwDice();

      //se success()

      Console.WriteLine();
      Console.WriteLine("Opção 1 - sucesso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           PROCURAR O OVO  --  SUCESSO                         |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Parabéns! Você conseguiu avançarnas investigações, colheu pistas pelo      |");
      Console.WriteLine("|  castelo de Hogwarts e está bem perto de conseguir encontrar o ovo! Jogue o   |");
      Console.WriteLine("|  dado novamente para saber se encontrará a última pista para chegar ao ovo!   |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //throwDice();
      //receiveDice = throwDice();

      //se receiveDice for sucesso

      Console.WriteLine();
      Console.WriteLine("Opção 1 - Joga dado novamente -- sucesso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           PROCURAR O OVO  --  SUCESSO                         |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Parabéns! Parece que o ovo estava embaixo da água! Você trabalhou duro e   |");
      Console.WriteLine("| conseguiu achar o ovo! Bônus de 5 pontos por essa conquista                   |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //point+=5;

      //else

      Console.WriteLine();
      Console.WriteLine("Opção 1 - Joga dado novamente -- fracasso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           PROCURAR O OVO  --  FRACASSO                        |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Ih não foi dessa vez. A Murta Que Geme não quis te ajudar e                |");
      Console.WriteLine("| você não conseguiu encontrar o ovo. Você perdeu um ponto e uma vida           |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //point--;
      //life--;

      //else
      Console.WriteLine();
      Console.WriteLine("Opção 1 - fracasso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           PROCURAR O OVO  --  FRACASSO                        |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Hmm parece que foi uma busca que não deu em nada, você se perdeu na        |");
      Console.WriteLine("| floresta e nem mesmo chegou a investigar pelo castelo, onde as principais     |");
      Console.WriteLine("| pistas estavam. Infelizmente seu tempo se esgotou, portanto vai ficar com     |");
      Console.WriteLine("| um ponto e uma vida a menos                                                   |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //point--;
      //life--;

      //shift+alt 
    }

    //---------> OPÇÂO 2 <---------
    static void fightDragon(string option)
    {
      //grifinoria++;

      //throwDice();
      //se success()

      Console.WriteLine();
      Console.WriteLine("Opção 2 - sucesso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           ENFRENTAR DRAGÃO  --  SUCESSO                       |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Uau, é preciso muita audácia para enfrentarmos os nossos inimigos, você    |");
      Console.WriteLine("| teve uma batalha árdua e desafiante, mas no final conseguiu derrotar o dragão |");
      Console.WriteLine("| e impressionar os juízes! Para você, a vida não tem graça sem alguns dragões, |");
      Console.WriteLine("| certo? Parabéns! Você ganhou um ponto por isso :D                             |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //point++;

      //se maiorPonto
      Console.WriteLine();
      Console.WriteLine("Opção 2 - MaiorPonto -- sucesso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                       ENFRENTAR DRAGÃO  --  MAIOR PONTO                       |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Incrível! Além da vitória, você ganhou o ovo por ter sido o jogador        |");
      Console.WriteLine("| com maior pontuação. Parabéns! Aqui vão 5 pontos extras por essa conquista    |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //point+=5;

      //else

      Console.WriteLine();
      Console.WriteLine("Opção 2 - fracasso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                         ENFRENTAR DRAGÃO  --  FRACASSO                        |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Vish, parece que o Dragão cuspiu fogo enquanto você lutava com ele no ar,  |");
      Console.WriteLine("| as chamas o desestabilizaram e arruinaram as cerdas da vassoura… Urgh, foi    |");
      Console.WriteLine("| uma queda feia! Que pena, acabou de perder um ponto e uma vida                |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //point--;
      //life--;

    }

    //---------> OPÇÂO 3 <---------
    static void avoidDragon(string option)
    {
      //sonserina+=2;
      //lufalufa++;

      //throwDice();
      //se success()

      Console.WriteLine();
      Console.WriteLine("Opção 3 - sucesso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           FUGIR DRAGÃO  --  SUCESSO                           |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Virando à esquerda, depois à direita, dando giros pelas tendas e abrindo   |");
      Console.WriteLine("| espaço pelas arquibancadas… Vuuuuum, sua vassoura corta o ar! Isso, o dragão  |");
      Console.WriteLine("| está longe! Ele não consegue te alcançar! Uau, sua fuga foi bem-sucedida, e   |");
      Console.WriteLine("| suas habilidades furtivas conseguiram impressionar os juízes! Parabéns!       |");
      Console.WriteLine("| Você ganhou um ponto por isso :D                                              |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //point++;

      Console.WriteLine();
      Console.WriteLine("Opção 3 - fracasso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                          FUGIR DRAGÃO  --  FRACASSO                           |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Ele está se aproximando…Mais rápido! Voe mais rápido….! Ah não, você foi   |");
      Console.WriteLine("| devagar demais e acabou sendo pego pelo dragão! Que pena, parece que acabou   |");
      Console.WriteLine("| de perder um ponto e uma vida                                                 |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //point--;
      //life--;

    }
    static void dragonsChallenge()
    {

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
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine("Pressione Enter para continuar");
      Console.ReadLine();

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                             DESAFIO DOS DRAGÕES                               |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| Agora, você tem 3 opções:                                                     |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (1) Procurar o ovo                                                            |");
      Console.WriteLine("| (2) Lutar contra o dragão                                                     |");
      Console.WriteLine("| (3) Fugir do dragão                                                           |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.Write("Informe a opção desejada para continuar: ");
      string option = Console.ReadLine();

      switch (option)
      {
        case "1":
          searchEgg(option);
          break;
        case "2":
          fightDragon(option);
          break;
        case "3":
          avoidDragon(option);
          break;
      }
    }

    //BREAK

    //---------> OPÇÂO 1 <---------
    static void studyPotions(string option)
    {
      //corvinal++;

      //throwDice();
      //se success()

      Console.WriteLine();
      Console.WriteLine("Opção 1 - sucesso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                          ESTUDAR POÇÕES  --  SUCESSO                          |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Você descobriu uma poção que pode aumentar seu tempo debaixo d'água.       |");
      Console.WriteLine("| Na próxima etapa do torneio, isso lhe dará uma vantagem                       |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //habilidadeAgua++

      //else

      Console.WriteLine();
      Console.WriteLine("Opção 1 - fracasso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                          ESTUDAR POÇÕES  --  FRACASSO                         |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Você estava cansado demais e caiu no sono sobre o livro de poções.         |");
      Console.WriteLine("| O monitor o encontrou no laboratório no meio da madrugada e mandou que        |");
      Console.WriteLine("| subisse para o dormitório                                                     |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

    }

    //---------> OPÇÂO 2 <---------
    static void sabotageParticipants(string option)
    {
      //sonserina++;

      //throwDice();
      //se success()

      Console.WriteLine();
      Console.WriteLine("Opção 2 - sucesso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                      SABOTAR PARTICIPANTES  --  SUCESSO                       |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Muito bem, você foi sorrateiro e conseguiu encantar os equipamentos de um  |");
      Console.WriteLine("| participante para que ele não consiga disputar a prova seguinte. Diga quem    |");
      Console.WriteLine("| será a pessoa que não participará do próximo desafio:                         |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      string blockedParticipant = Console.ReadLine();

      //else

      Console.WriteLine();
      Console.WriteLine("Opção 2 - fracasso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                      SABOTAR PARTICIPANTES  --  FRACASSO                      |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Hmmm não deu muito certo. Um professor passou pelo corredor enquanto       |");
      Console.WriteLine("| você tentava sabotar outro participante e o mandou para a detenção. Fique uma |");
      Console.WriteLine("| uma rodada sem participar. Porém, antes, jogue o dado novamente para impedir  |");
      Console.WriteLine("| que o grupo descubra a sua trapaça                                            |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //throwDice()
      //receiveDice = throwDice();

      //se receiveDice > 10

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                          SAFAR-SE  --  SUCESSO                                |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Boa! Ninguém ficou sabendo da sua tentativa! Hehehhehehe                   |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //imagem do diabinho da tazmania?
      //sonserina++;

      //else

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                          SAFAR-SE  --  FRACASSO                               |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Você foi flagrado! Agora todos sabem que você tentou sabotá-los.           |");
      Console.WriteLine("| Quando estiver andando por aí, fique de olhos abertos...                      |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

    }

    //---------> OPÇÂO 3 <---------
    static void askFriendsForHelp(string option)
    {
      //lufalufa++

      Console.WriteLine();
      Console.WriteLine("Opção 3");

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
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //life++
    }

    //---------> OPÇÂO 4 <---------
    static void practiceSpells(string option)
    {
      //grifinoria++

      //throwDice();
      //se success()

      Console.WriteLine();
      Console.WriteLine("Opção 4 - sucesso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                          TREINAR FEITIÇOS -- SUCESSO                          |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Como diz um importante bruxo: “A dedicação nunca te deixa na mão”, e ao    |");
      Console.WriteLine("| treinar feitiços você melhorou suas habilidades! Ganhou um ponto, além de     |");
      Console.WriteLine("| pontos de inteligência                                                        |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //point++
      //intelligence++

      //else

      Console.WriteLine();
      Console.WriteLine("Opção 4 - fracasso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                          TREINAR FEITIÇOS -- FRACASSO                         |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Argh! Parece que você se machucou tentando realizar o feitiço! Perdeu uma  |");
      Console.WriteLine("| vida e um ponto, além de passar vergonha                                      |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //point--
      //life--

    }

    static void breakBeforeNextChallenge()
    {

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
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine("Pressione Enter para continuar");
      Console.ReadLine();

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
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.Write("Informe a opção desejada para continuar: ");
      string option = Console.ReadLine();

      switch (option)
      {
        case "1":
          studyPotions(option);
          break;
        case "2":
          sabotageParticipants(option);
          break;
        case "3":
          askFriendsForHelp(option);
          break;
        case "4":
          practiceSpells(option);
          break;
      }
    }

    static void draw()
    {
      // if (Jogador1.pontos == Jogador2.pontos) ;

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                  EPILOGO                                      |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Parabéns a todos os participantes, este torneio foi apenas o começo        |");
      Console.WriteLine("| do que sei que será uma jornada extraordinária – começou Neville.             |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    O êxito da vida não se mede pelo caminho que você conquistou,  mas sim     |");
      Console.WriteLine("| pelas dificuldades superadas no caminho, e  o torneio tribruxo é sobre isso.  |");
      Console.WriteLine("| Porém parece que ainda possuímos um empate entre: {JOGADOR1} e {JOGADOR2}     |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine("Pressione ENTER para continuar");
      Console.ReadLine();

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                  A ESCOLHA                                    |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    No mundo magico o duelo magico é a forma mais honrosa de resolver algumas  |");
      Console.WriteLine("| disputas como essa, para manter o princípio da igualdade todas as suas        |");
      Console.WriteLine("| conquistas durante a jornada serão temporariamente esquecidas. – continuou    |");
      Console.WriteLine("|    Por favor escolha qual varinha você deseja utilizar neste duelo, está será |");
      Console.WriteLine("| a única vantagem que vocês possuíram no duelo:                                |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (1) Varinha de Cerejeira, rígida e feita com coração de dragão;               |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (2) Varinha de castanheira, maleável e feita com núcleo de unicórnio;         |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (3) Varinha de Olmo, flexível e feita com pena de fênix;                      |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (4) Varinha de Pereira, rígida e feita com cabelo de veela;                   |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine("Qual varinha você quer escolher?");
      string wand = Console.ReadLine();

      while (wand != "1" && wand != "2" && wand != "3")
      {
        Console.WriteLine("Opção Invalida, tente novamente");
        wand = Console.ReadLine();
      }

      //loop de cada jogador 

      switch (wand)
      {
        case "1":
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          Console.WriteLine("|                              Varinha de Cerejeira                             |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    A varinha escolhida nunca pode ficar nas mãos de um bruxo que não tenha    |");
          Console.WriteLine("| excepcional controle sobre suas ações além de uma mente muito bem estruturada.|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          //função recebimento ponto
          break;

        case "2":
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          Console.WriteLine("|                             Varinha de castanheira                            |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    A varinha escolhida se atrai por bruxos e bruxas que são habilidosos em    |");
          Console.WriteLine("| domar criaturas mágicas, por aqueles que possuem grande aptidão em Herbologia |");
          Console.WriteLine("| e os que são voadores natos e justos.                                         |");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          //função recebimento ponto
          break;

        case "3":
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          Console.WriteLine("|                                 Varinha de Olmo                               |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    Acredita-se que apenas puros-sangues podem produzir magia a partir das     |");
          Console.WriteLine("| varinhas de olmo, e conhecida pelos feitiços mais elegantes.                  |");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          //função recebimento ponto
          break;

        case "4":
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          Console.WriteLine("|                               Varinha de Pereira                              |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    Com essa varinha de poderes mágicos esplêndidos, as quais dão o melhor de  |");
          Console.WriteLine("| si nas mãos dos sábios. Donos dessas varinhas são, normalmente populares e    |");
          Console.WriteLine("| e bem respeitados.                                                            |");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          //função recebimento ponto
          break;
      }

      Console.WriteLine();

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                    O DUELO                                    |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Cada varinha tem suas características únicas aproveitou a Hermione para    |");
      Console.WriteLine("| mostrar seus conhecimentos. Não só são conhecidas por essas habilidades       |");
      Console.WriteLine("| únicas como também tem suas vantagens em um duelo.                            |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Se o Aluno escolhe a varinha de cerejeira ele atacará sempre um pouco      |");
      Console.WriteLine("| mais forte ( +2 dadoAtaque);                                                  |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Se o Aluno escolhe a varinha de castanheira ele conseguirá se defender     |");
      Console.WriteLine("| mais facilmente ( +2 dadoDefesa);                                             |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Se o Aluno escolhe a carinha de Olmo, devido a sua característica          |");
      Console.WriteLine("| flexível, sem duvida conseguirá aguentar o primeiro ataque direto             |");
      Console.WriteLine("| (primeiro dado = 20)                                                          |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| Se o Aluno escolhe a carinha de Pereira ele será alguém equilibrado que       |");
      Console.WriteLine("| será tão bom no ataque quanto na defesa ( +1 dadoAtaque, +1 dadoDefesa)       |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine("Pressione ENTER para continuar");
      Console.ReadLine();

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                    DECISÃO                                    |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  {JOGADOR1} escolha cara ou coroa para definir quem deve começar os ataques:  |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (1) CARA                                                                      |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (2) COROA                                                                     |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine("Selecione a opção decidida Jogador:");
      string coin = Console.ReadLine();

      while (coin != "1" && coin != "2")
      {
        Console.WriteLine("Opção Invalida, tente novamente");
        coin = Console.ReadLine();
      }

      // if(coin == "valor dado") { 
      //   Console.WriteLine("{JOGADOR1} você é o primeiro a atacar");
      //   Console.WriteLine("Precione ENTER para continuar: ");
      //   Console.ReadLine();
      // } else { 
      //   Console.WriteLine("{JOGADOR2} você será o primeiro a atacar");
      //   Console.WriteLine("Precione ENTER para continuar: ");
      //   Console.ReadLine(); }

      Console.WriteLine();
      Console.WriteLine("Precione ENTER para continuar: ");
      Console.ReadLine();

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                A REVERENCIA                                   |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Assim percebe-se que ambos os jogadores se posicionam e com passos firmes, |");
      Console.WriteLine("|  ao o encontro do tablado o qual rangia com seus passeares, os mesmos         |");
      Console.WriteLine("| dirigiam-se até o centro do tablado ao deter-se o olhar um ao outro a frente  |");
      Console.WriteLine("| num breve resvalar  Logo ligeiramente erguiam-na até a frente de seu rosto e  |");
      Console.WriteLine("| assim cortando o ar com a mesma na diagonal direcionando-a para baixo         |");
      Console.WriteLine("| mantendo-a ali firme com os braços eretos na diagonal com a varinha mirada    |");
      Console.WriteLine("| para o solo, e em seguida inclinando o corpo apoiando a mão esquerda que está |");
      Console.WriteLine("| livre na barriga, deslizando seu pé esquerdo para trás buscando apoio e       |");
      Console.WriteLine("| flexionando o joelho direito abaixando-se centímetros, exercendo uma sublime  |");
      Console.WriteLine("| reverencia.                                                                   |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      // JOGAR DADOS BASEADOS NO CRITERIOS DE SUCESSO 
      // SE SUCESSO IMPRIMIR
      // Console.WriteLine(FEITIÇO DE ATAQUE 1/2 ou 3)

      // SE NÃO 
      // Console.WriteLine("FETIÇO DE DEFESA 1/2/3");
    }

    static void rules()
    {
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                AS REGRAS                                      |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  Role o dado D20, acrescente os modificadores apropriados e consulte a tabela |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   * 0 ou 3 Falha Crítica -- Não poderia ter sido pior, mesmo que              |");
      Console.WriteLine("| tentasse... (perde 2 pontos de vida).                                         |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   *3 - 6 Falha -- Você falhou, mas podia ser pior... (Perde 1 ponto vida).    |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   * 6-10 Sucesso Marginal -- Você foi bem sucedido. (Não ganha nem perde)     |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   * 11-15 Sucesso Mediano -- Parabéns - foi mediano ( Ganha 1 de vida)        |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   * 15-20+ Sucesso Brilhante -- Um sucesso além de todas as expectativas.     |");
      Console.WriteLine("|   (ganha 2 pontos)                                                            |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   Caso haja empate, sera feita uma disputa de duelo)                          |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine("Pressione ENTER para continuar");
      Console.ReadLine();
      Console.WriteLine();
    }

    static void newGame()
    {
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                UM NOVO ANO!                                   |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  Sejam bem-vindos! Um novo ano letivo inicia—se em Hogwarts                   |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  Já atrasados como sempre todos entram correndo no salão comunal para receber |");
      Console.WriteLine("| as novas instruções, rapidamente procuram sentar na mesa do seus amigos       |");
      Console.WriteLine("| dentre as inúmeras mesas.                                                     |");
      Console.WriteLine("|  Até que você senta na mesa dos seus amigos, quantas pessoas tem na sua mesa? |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");


      Console.WriteLine();
      Console.WriteLine("(Isso delimitará quantos amigos irão jogar)");
      Console.WriteLine();
      string groupSize = Console.ReadLine();
      Console.WriteLine();


      Console.WriteLine(" -------------------------------------------------------------------------------- ");
      Console.WriteLine("|                              OS ESCOLHIDOS                                     |");
      Console.WriteLine("|------------------------------------------------------------------------------- |");
      Console.WriteLine("|    A diretora Maggonagol, dirige-se a frente do salão comunal e começa seu     |");
      Console.WriteLine("| tipico discurso de começo as aulas, porém essa neste ano - ela começa          |");
      Console.WriteLine("|                                                                                |");
      Console.WriteLine("|    Temos a honra de sediar o infame Torneio Tribruxo, e como todos sabem,      |");
      Console.WriteLine("| após os eventos recentes, o cálice decidiu que neste ano o jogo sera aberto a  |");
      Console.WriteLine($"| {groupSize} participantes.                                                               |");
      Console.WriteLine("|                                                                                |");
      Console.WriteLine("|   As instruções para as tarefas que os campeões deverão enfrentar este ano     |");
      Console.WriteLine("| serão informadas após seres selecionadas pelo cálice. Haverá, no total cinco   |");
      Console.WriteLine("| tarefas, espaçadas durante o ano letivo, que servirão para testar os campeões  |");
      Console.WriteLine("| de diferentes maneiras...sua perícia em magia, sua coragem seus poderes de     |");
      Console.WriteLine("| dedução e, naturalmente, sua capacidade de enfrentar o perigo.                 |");
      Console.WriteLine("|                                                                                |");
      Console.WriteLine("|    Os campeões escolhidos pelo cálice receberão notas por seu desempenho em    |");
      Console.WriteLine("| cada uma das tarefas do torneio, quem tiver obtido o maior resultado no final  |");
      Console.WriteLine("| das tarefas ganhará a Taça Tribruxo.                                           |");
      Console.WriteLine("|                                                                                |");
      Console.WriteLine("|    Agora, caros possiveis candidatos, se quiser se candidatar a campeão deverá |");
      Console.WriteLine("| escrever seu nome claramente em um pedaço de pergaminho e depositá-lo no       |");
      Console.WriteLine("| cálice imediatamente                                                           |");
      Console.WriteLine("|                                                                                |");
      Console.WriteLine("|    Insira o seu nome se você tiver coragem!                                    |");
      Console.WriteLine("|                                                                                |");
      Console.WriteLine(" -------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine("Pressione ENTER para continuar");
      Console.ReadLine();
      Console.WriteLine();

      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  Você deseja inserir seu nome no calice de Fogo?                              |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (1) com certeza! é a minha chance de provar minha bravura e superioridade.    |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (2) Melhor não, desde do que aconteceu com o cedrico não me parece uma boa    |");
      Console.WriteLine("| ideia                                                                         |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine("Escolha seu nome aventureiro");
      string newNameChoice = Console.ReadLine();
      Console.WriteLine();

      while (newNameChoice != "1" && newNameChoice != "2")
      {
        Console.WriteLine("Opção Invalida, tente novamente");
        newNameChoice = Console.ReadLine();
      }
      switch (newNameChoice)
      {
        case "1":
          Console.WriteLine(" Você corajosamente se posiciona na frente do calice e coloca seu nome que é: ");
          string name = Console.ReadLine();
          break;

        case "2":
          Console.WriteLine(" Você é empurrado pelo restante dos seus amigos e pela vergonha de estar diante do calice decide colocar seu nome : ");
          break;

      }
    }
  }
}

