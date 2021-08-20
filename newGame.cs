using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{

  class newGame
  {
    public static void menuInitial()
    {

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                        Bem vindo ao jogo de RPG                               |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   Escolha uma das opções abaixo:                                              |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (1) Novo jogo                                                                 |");
      Console.WriteLine("| (2) Regras do jogo                                                            |");
      Console.WriteLine("| (3) Sair                                                                      |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.Write("Informe a opção desejada: ");
      string option = Console.ReadLine();
      Console.WriteLine();
      RPG.Tune.enter();


      while (option != "1" && option != "2" && option != "3" || option == "")
      {
        Console.WriteLine();
        Console.WriteLine("Opção inválida, tente novamente");
        Console.WriteLine();
        Console.Write("Informe sua escolha novamente: ");
        option = Console.ReadLine();
        RPG.Tune.enter();
      }
      switch (option)
      {
        case "1":
          startGame();
          break;

        case "2":
          rules();
          break;

        case "3":
          RPG.Tune.selectSound();
          Console.Write("Saindo... Esperamos vocês uma outra hora");
          break;

      }
    }
    public static void startGame()
    {

      RPG.Tune.selectSound();

      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                UM NOVO ANO!                                   |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|     Sejam bem-vindos! Um novo ano letivo inicia—se em Hogwarts...             |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Já atrasados como sempre, todos entram correndo no Salão Comunal para      |");
      Console.WriteLine("| receber as novas instruções. Rapidamente, vocês procuram sentar na mesa dos   |");
      Console.WriteLine("| seus amigos.                                                                  |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Quantas pessoas têm na sua mesa?                                           |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.Write("(Isso delimitará quantos amigos irão jogar): ");
      string groupSize = Console.ReadLine();
      Console.WriteLine();
      RPG.Tune.enter();

      int number;

      while (!int.TryParse(groupSize, out number) || groupSize == "0" || number < 1)
      {
        Console.WriteLine();
        Console.WriteLine("Opção inválida, tente novamente");
        Console.WriteLine();
        Console.Write("Informe novamente a quantidade de amigos: ");
        groupSize = Console.ReadLine();
        Console.WriteLine();
        RPG.Tune.enter();
      }


      Console.WriteLine(" -------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                OS ESCOLHIDOS                                   |");
      Console.WriteLine("|------------------------------------------------------------------------------- |");
      Console.WriteLine("|    A diretora McGonagall dirige-se à frente do Salão Comunal e começa seu      |");
      Console.WriteLine("| típico discurso de volta às aulas.                                             |");
      Console.WriteLine("|                                                                                |");
      Console.WriteLine("|  - Temos a honra de sediar o Torneio Tribruxo, e como todos sabem, após os     |");
      Console.WriteLine($"  eventos recentes, nós decidimos que neste ano o jogo será aberto a {groupSize}  ");
      Console.WriteLine("| participantes.                                                                 |");
      Console.WriteLine("|                                                                                |");
      Console.WriteLine("|   As instruções para as tarefas que os campeões deverão enfrentar este ano     |");
      Console.WriteLine("| serão informadas após vocês serem selecionados pelo Cálice. Haverá cinco       |");
      Console.WriteLine("| tarefas que servirão para testar os campeões de diferentes maneiras. Sua       |");
      Console.WriteLine("| perícia em magia, sua coragem, seus poderes de dedução e, naturalmente, sua    |");
      Console.WriteLine("| capacidade de enfrentar o perigo.                                              |");
      Console.WriteLine("|                                                                                |");
      Console.WriteLine("|    Os campeões escolhidos pelo cálice receberão notas por seu desempenho em    |");
      Console.WriteLine("| cada uma das tarefas do torneio e quem tiver obtido o maior resultado ao final |");
      Console.WriteLine("| das tarefas ganhará a Taça Tribruxo.                                           |");
      Console.WriteLine("|                                                                                |");
      Console.WriteLine("|    Agora, caros possíveis candidatos, se quiserem se candidatar a campeão,     |");
      Console.WriteLine("| deveram escrever seu nome claramente em um pedaço de pergaminho e depositá-lo  |");
      Console.WriteLine("| no Cálice imediatamente.                                                       |");
      Console.WriteLine("|                                                                                |");
      Console.WriteLine("|    Insira o seu nome se você tiver coragem!                                    |");
      Console.WriteLine("|                                                                                |");
      Console.WriteLine(" -------------------------------------------------------------------------------- ");

      List<RPG.Character> character = new List<Character>();

      for (int i = 0; i < number; i++)
      {

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
        RPG.Tune.enter();

        Console.WriteLine();
        Console.WriteLine(" -------------------------------------------------------------------------------- ");
        Console.WriteLine("|                               ACEITA O DESAFIO?                               |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|  Você deseja inserir seu nome no Cálice de Fogo?                              |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("| (1) Com certeza! É a minha chance de provar minha bravura e superioridade.    |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("| (2) Melhor não. Depois do que aconteceu com o Cedrico, não me parece uma boa  |");
        Console.WriteLine("| ideia.                                                                        |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.WriteLine();
        Console.Write($"Informe sua decisão, jogador nº {i + 1}: ");
        string newNameChoice = Console.ReadLine();
        Console.WriteLine();
        RPG.Tune.enter();


        while (newNameChoice != "1" && newNameChoice != "2" || newNameChoice == "")
        {
          Console.WriteLine();
          Console.WriteLine("Opção inválida, tente novamente");
          Console.WriteLine();
          Console.Write("Informe sua decisão novamente: ");
          newNameChoice = Console.ReadLine();
          RPG.Tune.enter();
        }
        switch (newNameChoice)
        {
          case "1":
            Console.Write("Você corajosamente se posiciona na frente do Cálice e coloca seu nome, que é: ");
            string name = Console.ReadLine();
            RPG.Tune.enter();

            bool onlyLettersAndWhitespace = name.All(i => char.IsLetter(i) || char.IsWhiteSpace(i));

            while (string.IsNullOrEmpty(name) || !onlyLettersAndWhitespace)
            {
              Console.WriteLine();
              Console.WriteLine("Texto inválido, tente novamente");
              Console.WriteLine();
              Console.Write("Informe seu nome novamente: ");
              name = Console.ReadLine();
              Console.WriteLine();
              RPG.Tune.enter();
            }
            var charc = RPG.Creations.createChar(name, _idChar: i);
            character.Add(charc);
            break;

          case "2":
            Console.Write("Você é empurrado pelo restante dos seus amigos e, pela vergonha decide colocar seu nome: ");
            name = Console.ReadLine();
            RPG.Tune.enter();

            onlyLettersAndWhitespace = name.All(i => char.IsLetter(i) || char.IsWhiteSpace(i));

            while (string.IsNullOrEmpty(name) || !onlyLettersAndWhitespace)
            {
              Console.WriteLine();
              Console.WriteLine("Texto inválido, tente novamente");
              Console.WriteLine();
              Console.Write("Informe seu nome novamente: ");
              name = Console.ReadLine();
              RPG.Tune.enter();
            }
            var charct = RPG.Creations.createChar(name, _idChar: i);
            character.Add(charct);
            break;

        }
      }

      Console.WriteLine();
      firstBreak(character);
    }

    public static void rules()
    {

      RPG.Tune.selectSound();

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                AS REGRAS                                      |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  Tabela de pontuação para cada número do dado D20                             |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   * Falha Crítica (0 - 3) -- Não poderia ter sido pior, mesmo que             |");
      Console.WriteLine("| tentasse... (perde 2 pontos de vida).                                         |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   * Falha (3 - 6) -- Você falhou, mas podia ser pior... (Perde 1 ponto vida)  |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   * Sucesso Marginal (6 - 10) -- Você foi bem sucedido. (Não ganha nem perde) |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   * Sucesso Mediano (11 - 17) -- Parabéns, foi mediano ( Ganha 1 de vida)     |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   * Sucesso Brilhante (18 - 20) -- Um sucesso além de todas as expectativas   |");
      Console.WriteLine("|   (ganha 2 pontos)                                                            |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   Caso haja empate, será feita uma disputa de duelo                           |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   * Obs:Fique atento! Escondemos pequenos easter eggs pelo jogo, divirtam-se! |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");


      Console.WriteLine();
      Console.WriteLine("Pressione ENTER para voltar para o menu");
      Console.ReadLine();
      RPG.Tune.enter();
      Console.WriteLine();

      menuInitial();

    }

    public static void firstBreak(List<Character> character)
    {
      Console.WriteLine();

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                       DESCANSO ANTES DO PRIMEIRO DESAFIO                      |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Atenção, o Torneio está prestes a começar… Amanhã será um dia de altas     |");
      Console.WriteLine("| emoções e o primeiro de muitos desafios. Antes de tudo, escolha o que deseja  |");
      Console.WriteLine("| fazer até amanhã. Lembre-se apenas, que toda ação pode levar tanto a          |");
      Console.WriteLine("| vantagens quanto a consequências.                                             |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("Pressione ENTER para continuar");
      Console.ReadLine();
      RPG.Tune.enter();



      for (int i = 0; i < character.Count; i++)
      {
        Console.WriteLine();
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                       DESCANSO ANTES DO PRIMEIRO DESAFIO                      |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|    O que você deseja fazer?                                                   |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("| (1) Escrever uma fofoca para o Profeta Diário                                 |");
        Console.WriteLine("| (2) Passar a tarde lendo um livro                                             |");
        Console.WriteLine("| (3) Treinar quadribol                                                         |");
        Console.WriteLine("| (4) Cuidar de uma planta                                                      |");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine(" ------------------------------------------------------------------------------- ");

        Console.WriteLine();
        Console.Write($"{character[i].name}, informe a opção desejada para continuar: ");
        string option = Console.ReadLine();
        RPG.Tune.enter();

        while (option != "1" && option != "2" && option != "3" && option != "4" || option == "")
        {
          Console.WriteLine();
          Console.WriteLine("Opção inválida, tente novamente");
          Console.WriteLine();
          Console.Write($"{character[i].name}, escolha novamente: ");
          option = Console.ReadLine();
          RPG.Tune.enter();
        }
        switch (option)
        {
          case "1":

            character[i].house = RPG.Update.updateHouse(character[i], 0, 0, 1, 0);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                ESCREVER UMA FOFOCA                            |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você escreveu uma fofoca para o Profeta Diário, colocando em prática sua   |");
            Console.WriteLine("| astúcia. Porém, perdeu as amizades.                                           |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            RPG.Tune.enter();

            break;
          case "2":

            character[i].house = RPG.Update.updateHouse(character[i], 0, 1, 0, 0);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                    LER LIVRO                                  |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Ao esperar o resultado lendo um livro, você aumentou sua inteligência, mas |");
            Console.WriteLine("| sua percepção diminuiu porque está com a vista cansada.                       |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            RPG.Tune.enter();

            break;
          case "3":

            character[i].house = RPG.Update.updateHouse(character[i], 1, 0, 0, 0);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                TREINAR QUADRIBOL                              |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Treinar quadribol aumentou sua força, porém o deixou mais cansado.         |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");


            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            RPG.Tune.enter();

            break;
          case "4":

            character[i].house = RPG.Update.updateHouse(character[i], 0, 0, 0, 1);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                CUIDAR DA PLANTA                               |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Escolher cuidar de uma planta em um mundo pós-guerra é um gesto de         |");
            Console.WriteLine("| gentileza apreciado. Você aumentou seu carisma com essa ação.                 |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            RPG.Tune.enter();

            break;
        }
      }

      RPG.Dragon.dragonsChallenge(character);

    }
  }
}