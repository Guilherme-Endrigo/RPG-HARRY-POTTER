using System;

namespace RPG
{

  class endGame
  {


    public static void draw()
    {
      // if (Jogador1.pontos == Jogador2.pontos) ;

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                  EPÍLOGO                                      |");
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
      Console.WriteLine("|    No mundo mágico o duelo mágico é a forma mais honrosa de resolver algumas  |");
      Console.WriteLine("| disputas como essa, para manter o princípio da igualdade todas as suas        |");
      Console.WriteLine("| conquistas durante a jornada serão temporariamente esquecidas – continuou     |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Por favor, escolha qual varinha você deseja utilizar neste duelo, esta     |");
      Console.WriteLine("| será a única vantagem que você possuirá no duelo:                             |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (1) Varinha de Cerejeira, rígida e feita com coração de dragão;               |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (2) Varinha de castanheira, maleável e feita com núcleo de unicórnio;         |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (3) Varinha de Olmo, flexível e feita com pena de fênix;                      |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (4) Varinha de Pereira, rígida e feita com cabelo de Veela;                   |");
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
          Console.WriteLine("|                             Varinha de Castanheira                            |");
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
          Console.WriteLine("| varinhas de Olmo, e conhecida pelos feitiços mais elegantes.                  |");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          //função recebimento ponto
          break;

        case "4":
          Console.WriteLine(" ------------------------------------------------------------------------------- ");
          Console.WriteLine("|                               Varinha de Pereira                              |");
          Console.WriteLine("|-------------------------------------------------------------------------------|");
          Console.WriteLine("|                                                                               |");
          Console.WriteLine("|    Essa varinha de poderes mágicos esplêndidos se dá melhor nas mãos dos      |");
          Console.WriteLine("| sábios. Donos dessas varinhas são, normalmente populares e e bem respeitados. |");
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
      Console.WriteLine("|  - Cada varinha tem suas características únicas - aproveitou Sr Olivaras para |");
      Console.WriteLine("| mostrar seus conhecimentos. - Não só são conhecidas por essas habilidades     |");
      Console.WriteLine("| únicas como também tem suas vantagens em um duelo.                            |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  - Se o Aluno escolhe a varinha de Cerejeira, ele atacará sempre um pouco     |");
      Console.WriteLine("| mais forte ( +2 dadoAtaque ).                                                 |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  - Se o Aluno escolhe a varinha de Castanheira, ele conseguirá se defender    |");
      Console.WriteLine("| mais facilmente ( +2 dadoDefesa ).                                            |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  - Se o Aluno escolhe a varinha de Olmo, devido à sua característica          |");
      Console.WriteLine("| flexível, sem dúvida, conseguirá aguentar o primeiro ataque direto            |");
      Console.WriteLine("| (primeiro dado = 20)                                                          |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  - Se o Aluno escolhe a varinha de Pereira ele será alguém equilibrado que    |");
      Console.WriteLine("| será tão bom no ataque quanto na defesa ( +1 dadoAtaque, +1 dadoDefesa )      |");
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
        Console.WriteLine("Opção Inválida, tente novamente");
        coin = Console.ReadLine();
      }

      // if(coin == "valor dado") { 
      //   Console.WriteLine("{JOGADOR1} você é o primeiro a atacar");
      //   Console.WriteLine("Pressione ENTER para continuar: ");
      //   Console.ReadLine();
      // } else { 
      //   Console.WriteLine("{JOGADOR2} você será o primeiro a atacar");
      //   Console.WriteLine("Pressione ENTER para continuar: ");
      //   Console.ReadLine(); }

      Console.WriteLine();
      Console.WriteLine("Pressione ENTER para continuar: ");
      Console.ReadLine();

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                A REVERÊNCIA                                   |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Assim, ambos jogadores posicionam-se frente a frente no centro do tablado. |");
      Console.WriteLine("| É um momento solene, no qual se entreolham enxergando a determinação um no    |");
      Console.WriteLine("| outro. Os dois empunham suas varinhas na posição de combate normalmente       |");
      Console.WriteLine("| adotada. Nas arquibancadas, permeia um silêncio coletivo. Quando contar-se    |");
      Console.WriteLine("| três, após o sinal de saudação, serão lançados os primeiros feitiços,         |");
      Console.WriteLine("| iniciando o duelo.                                                            |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      // JOGAR DADOS BASEADOS NO CRITERIOS DE SUCESSO 
      // SE SUCESSO IMPRIMIR
      // Console.WriteLine(FEITIÇO DE ATAQUE 1/2 ou 3)

      // SE NÃO 
      // Console.WriteLine("FEITIÇO DE DEFESA 1/2/3");
    }
  }
}
