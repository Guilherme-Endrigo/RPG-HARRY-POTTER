using System;

namespace RPG
{
  class Program
  {
    static void Main(string[] args)
    {

      menuInicial();
      dragonsChallenge();
      breakBeforeNextChallenge();
      empate();
    }

    static void menuInicial()
    {

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                        Bem vindo ao jogo de RPG                               |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   Escolha uma das opções abaixo:                                              |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (1) Novo jogo                                                                 |");
      Console.WriteLine("| (2) Carregar jogo (precisamos pensar como)                                    |");
      Console.WriteLine("| (3) Sair                                                                      |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      string firstOption = Console.ReadLine();

      while (firstOption != "1" && firstOption != "2" && firstOption != "3")
      { Console.WriteLine("Opção Invalida, tente novamente"); };

      switch (firstOption)
      {
        case "1":
          Console.Write("ERA UMA VEZ");
          break;

        case "2":

          Console.Write("Carregando..");
          break;

        case "3":
          Console.Write("Saindo... Esperamos vocês uma outra hora");
          break;
      }
    }
    //---------> OPÇÂO 1 <---------
    static void searchEgg(string option)
    {
      Console.WriteLine();
      Console.WriteLine("Opção 1 - sucesso");
      //if option 1 && dado > 10

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           PROCURAR O OVO  --  SUCESSO                         |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Parece que o ovo estava embaixo da água! Parabéns! Você conseguiu avançar  |");
      Console.WriteLine("| nas investigações, colheu pistas pelo castelo de Hogwarts e está perto de     |");
      Console.WriteLine("| conseguir encontrar o ovo! Jogue o dado novamente para saber se encontrará    |");
      Console.WriteLine("| a última pista para chegar ao ovo!                                            |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      //recebeDado = jogaDado()

      Console.WriteLine();
      Console.WriteLine("Opção 1 - Joga dado novamente -- sucesso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           PROCURAR O OVO  --  SUCESSO                         |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Parabéns! Você trabalhou duro e conseguiu achar o ovo!                     |");
      Console.WriteLine("| Bônus de 5 pontos por essa conquista                                          |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine("Opção 1 - Joga dado novamente -- fracasso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           PROCURAR O OVO  --  FRACASSO                        |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Ih não foi dessa vez. A Murta Que Geme não quis te ajudar e                |");
      Console.WriteLine("| você não conseguiu encontrar o ovo. Você perdeu um ponto e uma vida           |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

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

      //shift+alt 
    }

    //---------> OPÇÂO 2 <---------
    static void fightDragon(string option)
    {

      Console.WriteLine();
      Console.WriteLine("Opção 2 - sucesso");
      //if option 1 && dado > 10

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           ENFRENTAR DRAGÃO  --  SUCESSO                       |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Uau, é preciso muita audácia para enfrentarmos os nossos inimigos, você    |");
      Console.WriteLine("| teve uma batalha árdua e desafiante, mas no final conseguiu derrotar o dragão |");
      Console.WriteLine("| e impressionar os juízes! Para você, a vida não tem graça sem alguns dragões, |");
      Console.WriteLine("| certo? Parabéns! Você ganhou um ponto por isso :D                             |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

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

    }

    //---------> OPÇÂO 3 <---------
    static void avoidDragon(string option)
    {

      Console.WriteLine();
      Console.WriteLine("Opção 3 - sucesso");
      //if option 1 && dado > 10

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

    breakBeforeNextChallenge()
    {


    }

    static void empate()
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
      Console.WriteLine("|    Assim percebe-se que ambos os jogadores se posicionam e com passos firme,  |");
      Console.WriteLine("|  ao o encontro do tablado a qual rangia com seus passeares, os mesmos         |");
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

  }
}
