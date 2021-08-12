using System;
using System.Collections.Generic;

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


            while (option != "1" && option != "2" && option != "3" && option == "")
            {
                Console.WriteLine();
                Console.WriteLine("Opção Invalida, tente novamente");
                Console.WriteLine();
                Console.Write("Informe sua escolha novamente: ");
                option = Console.ReadLine();
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
                    Console.Write("Saindo... Esperamos vocês uma outra hora");
                    break;

            }
        }
        public static void startGame()
        {
            // Console.ForegroundColor = ConsoleColor.Red;
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
            Console.Write("(Isso delimitará quantos amigos irão jogar): ");
            string groupSize = Console.ReadLine();
            Console.WriteLine();

            int number;

            while (!int.TryParse(groupSize, out number) || groupSize == "0" || number < 1)
            {
                Console.WriteLine();
                Console.WriteLine("Opção Invalida, tente novamente");
                Console.WriteLine();
                Console.Write("Informe novamente a quantidade de amigos: ");
                groupSize = Console.ReadLine();
                Console.WriteLine();
            }


            Console.WriteLine(" -------------------------------------------------------------------------------- ");
            Console.WriteLine("|                              OS ESCOLHIDOS                                     |");
            Console.WriteLine("|------------------------------------------------------------------------------- |");
            Console.WriteLine("|    A diretora McGonagall dirige-se a frente do salão comunal e começa seu      |");
            Console.WriteLine("| típico discurso de volta às aulas.                                             |");
            Console.WriteLine("|                                                                                |");
            Console.WriteLine("|  - Temos a infame honra de sediar o Torneio Tribruxo, e como todos sabem,      |");
            Console.WriteLine("| após os eventos recentes, o cálice decidiu que neste ano o jogo será aberto a  |");
            Console.WriteLine($"|{groupSize} participante(s).                                                   ");
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
            Console.WriteLine("|    Agora, caros possíveis candidatos, se quiser se candidatar a campeão deverá |");
            Console.WriteLine("| escrever seu nome claramente em um pedaço de pergaminho e depositá-lo no       |");
            Console.WriteLine("| cálice imediatamente                                                           |");
            Console.WriteLine("|                                                                                |");
            Console.WriteLine("|    Insira o seu nome se você tiver coragem!                                    |");
            Console.WriteLine("|                                                                                |");
            Console.WriteLine(" -------------------------------------------------------------------------------- ");

            List<RPG.Character> character = new List<Character>();

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();


                Console.WriteLine(" -------------------------------------------------------------------------------- ");
                Console.WriteLine("|                               ACEITA O DESAFIO?                               |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Você deseja inserir seu nome no Cálice de Fogo?                              |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| (1) Com certeza! é a minha chance de provar minha bravura e superioridade.    |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| (2) Melhor não, desde o que aconteceu com o Cedrico não me parece uma boa     |");
                Console.WriteLine("| ideia                                                                         |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.Write("Informe sua decisão: ");
                string newNameChoice = Console.ReadLine();
                Console.WriteLine();


                while (newNameChoice != "1" && newNameChoice != "2" && newNameChoice != "")
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção Invalida, tente novamente");
                    Console.WriteLine();
                    Console.Write("Informe seu nome novamente: ");
                    newNameChoice = Console.ReadLine();
                }
                switch (newNameChoice)
                {
                    case "1":
                        Console.Write("Você corajosamente se posiciona na frente do calice e coloca seu nome que é: ");
                        string name = Console.ReadLine();
                        var charc = RPG.Creations.createChar(name, _idChar: i);
                        character.Add(charc);
                        break;

                    case "2":
                        Console.Write("Você é empurrado pelo restante dos seus amigos e pela vergonha de estar diante do calice decide colocar seu nome: ");
                        name = Console.ReadLine();
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
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                AS REGRAS                                      |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Role o dado D20, acrescente os modificadores apropriados e consulte a tabela |");
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
            Console.WriteLine("|   Caso haja empate, será feita uma disputa de duelo)                          |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para voltar para o menu");
            Console.ReadLine();
            Console.WriteLine();

            menuInitial();

        }

        public static void firstBreak(List<Character> character)
        {
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ResetColor(); //quando quiser parar de colorir


            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                       DESCANSO ANTES DO PRIMEIRO DESAFIO                      |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Atenção, o torneio está para começar… Amanhã será um dia de altas emoções, |");
            Console.WriteLine("| e o primeiro de muitos desafios. Antes de tudo, escolha o que deseja fazer    |");
            Console.WriteLine("| até amanhã. Lembre-se apenas, jovem bruxo, que toda ação pode levar tanto a   |");
            Console.WriteLine("| vantagens quanto a uma respectiva consequência                                |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();



            for (int i = 0; i < character.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                       DESCANSO ANTES DO PRIMEIRO DESAFIO                      |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| (1) Escrever uma fofoca para o blog da escola                                 |");
                Console.WriteLine("| (2) Passar a tarde lendo um livro                                             |");
                Console.WriteLine("| (3) Treinar quadribol                                                         |");
                Console.WriteLine("| (4) Cuidar de uma planta                                                      |");
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
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        Console.WriteLine("|                                ESCREVER UMA FOFOCA                            |");
                        Console.WriteLine("|-------------------------------------------------------------------------------|");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine("|    Você escreveu uma fofoca para o blog da escola, colocando em prática sua   |");
                        Console.WriteLine("| astúcia, porém com os ataques que fez, perdeu amizades.                       |");
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");

                        character[i].house = RPG.Update.updateHouse(character[i], 0, 0, 1, 0);
                        //character[i].house.scoreSlytherin += 1;

                        break;
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        Console.WriteLine("|                                    LER LIVRO                                  |");
                        Console.WriteLine("|-------------------------------------------------------------------------------|");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine("|    Ao esperar o resultado lendo um livro você aumentou sua inteligência, mas  |");
                        Console.WriteLine("| sua percepção diminuiu porque está com a vista cansada.                       |");
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");

                        character[i].house = RPG.Update.updateHouse(character[i], 0, 1, 0, 0);
                        //corvinal++;
                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        Console.WriteLine("|                                TREINAR QUADRIBOL                              |");
                        Console.WriteLine("|-------------------------------------------------------------------------------|");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine("|    Treinar quadribol aumentou sua força, porém o deixou mais cansado.         |");
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");

                        character[i].house = RPG.Update.updateHouse(character[i], 1, 0, 0, 0);
                        break;
                    case "4":
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        Console.WriteLine("|                                CUIDAR DA PLANTA                               |");
                        Console.WriteLine("|-------------------------------------------------------------------------------|");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine("|    Escolher cuidar de uma planta em um mundo pós-guerra é um gesto de         |");
                        Console.WriteLine("| gentileza apreciado, você aumentou seu carisma com essa ação.                 |");
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");

                        character[i].house = RPG.Update.updateHouse(character[i], 0, 0, 0, 1);
                        break;
                }


            }

            RPG.Dragon.dragonsChallenge(character);
        }

    }

}



