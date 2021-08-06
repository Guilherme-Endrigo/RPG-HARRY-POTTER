using System;

namespace RPG
{

  class endGame
  {


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
  }
}
