using System;

namespace RPG
{

  class newGame
  {
    public static void newGame()
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

    public static void rules()
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
      Console.WriteLine("|   * 11-17 Sucesso Mediano -- Parabéns - foi mediano ( Ganha 1 de vida)        |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   * 18-20+ Sucesso Brilhante -- Um sucesso além de todas as expectativas.     |");
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
  }
}