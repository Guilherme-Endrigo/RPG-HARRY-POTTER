using System;
using System.Collections.Generic;

namespace RPG
{
    class Maze
    {
        static int diceValue;

        public static void mazeChallenge(List<Character> character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                   LABIRINTO                                   |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|                              Desafio do labirinto                             |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Agora, você entrará em um temível labirinto, onde perigosos desafios te    |");
            Console.WriteLine("| aguardam. Escolha sabiamente e, se puder, faça uso de toda e qualquer         |");
            Console.WriteLine("| vantagem.                                                                     |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            RPG.Drawings.maze();

            for (int i = 0; i < character.Count; i++)
            {
                if (!character[i].isAlive)
                {
                    continue;
                }

                if (character[i].hasMap)
                {
                    character[i].score += 6;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                  SORTE GRANDE                                 |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|                                 Mapa do Maroto                                |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Ah, que incrível! Você possui o Mapa do Maroto e tem a vantagem de saber   |");
                    Console.WriteLine("| qual o melhor caminho do labirinto e onde os seus concorrentes estão!         |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Por isso, você ganhou quatro pontos e pulou QUASE todos os obstáculos do   |");
                    Console.WriteLine("| labirinto. Infelizmente, nem o Mapa poderia ter previsto a presença da        |");
                    Console.WriteLine("| enigmática Esfinge. Como guerreiro, resta a você enfrentá-la. Se você está    |");
                    Console.WriteLine("| jogando com um ou mais amigos, espere que eles enfrentem os desafios do       |");
                    Console.WriteLine("| labirinto e, então, vocês enfrentarão a Esfinge.                              |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.Write($"{character[i].name}, boa sorte na Esfinge! ");
                    Console.WriteLine();
                    Console.WriteLine($"Você se dirige pelo atalho descoberto, porém não chega muito antes dos demais.");
                    Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine($"Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                  ESTOU PERDIDO                                |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|                              Direção do labirinto                             |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Qual caminho você deseja seguir? Cuidado, isso dirá muito sobre os         |");
                    Console.WriteLine("| desafios que enfrentará.                                                      |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("| (1) Ir sempre para a direita                                                  |");
                    Console.WriteLine("| (2) Alternar entre esquerda e direita                                         |");
                    Console.WriteLine("| (3) Ir sempre para a esquerda                                                 |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.Write($"{character[i].name}, informe a opção desejada para continuar: ");
                    string option = Console.ReadLine();
                    Console.WriteLine();
                    RPG.Tune.enter();

                    while (option != "1" && option != "2" && option != "3" || option == "")
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
                            character[i] = devilsSnareMaze(character[i]);
                            break;

                        case "2":
                            character[i] = blastEndedSkrewtMaze(character[i]);
                            break;

                        case "3":
                            character[i] = boggartMaze(character[i]);
                            break;
                    }
                }

            }

            var survivedMaze = character.FindAll(x => x.isAlive == true);

            if (survivedMaze.Count != 0)
            {
                sphinxChallenge(character);
            }
            else
            {
                RPG.endGame.endTheGame(character);
            }


        }


        //---------> BICHO PAPÃO <---------
        static Character boggartMaze(Character character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                   BICHO PAPÃO                                 |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Ir sempre para a esquerda não é tão ruim, mas encontrou um Bicho Papão,   |");
            Console.WriteLine("| um não-ser que assume a forma do pior medo da pessoa que o vê. Normalmente    |");
            Console.WriteLine("| vive confinado dentro de armários e lugares escuros e, por conta de sua       |");
            Console.WriteLine("| natureza de mudar de forma, ninguém sabe sua real aparência.                  |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Após a batalha de Hogwarts, muitos dos dementadores fugiram do controle do |");
            Console.WriteLine("| Ministério da Magia, e muitas pessoas sentem um medo generalizado deles. Por  |");
            Console.WriteLine("| isso, hoje, o Bicho Papão que você enfrentará assume a forma de um dementador |");
            Console.WriteLine("| de Azkaban. O que você deseja fazer para combatê-lo?                          |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            RPG.Tune.enter();

            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                    BICHO PAPÃO                                |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| Faça uma escolha:                                                             |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| (1) Lançar feitiço Expecto Patronum                                           |");
            Console.WriteLine("| (2) Lançar feitiço Riddikulus                                                 |");
            Console.WriteLine("| (3) Fugir                                                                     |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();

            Console.WriteLine();
            Console.Write($"{character.name}, informe a opção desejada para continuar: ");
            string option = Console.ReadLine();
            RPG.Tune.enter();

            while (option != "1" && option != "2" && option != "3" || option == "")
            {
                Console.WriteLine();
                Console.WriteLine("Opção inválida, tente novamente");
                Console.WriteLine();
                Console.Write($"{character.name}, escolha novamente: ");
                option = Console.ReadLine();
                RPG.Tune.enter();
            }
            switch (option)
            {
                case "1":
                    character = expectoBoggart(character);
                    break;

                case "2":
                    character = riddikulusBoggart(character);
                    break;

                case "3":
                    character = escapeBoggart(character);
                    break;
            }

            return character;
        }
        //---------> OPÇÃO 1 <---------
        static Character expectoBoggart(Character character)
        {
            character.house.scoreGryffindor += 1;
            character.house.scoreHufflePuff += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                 BICHO PAPÃO                                   |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você escolheu enfeitiçar o Bicho-Papão! Cuidado para não passar ridículo!  |");
            Console.WriteLine("| Boa sorte, que rolem os dados!                                                |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");


            if (diceValue >= 11)
            {
                character.score += 1;
                character.house.scoreGryffindor += 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                             I PUT A SPELL ON YOU                              |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    O feitiço funcionou! Você conseguiu fugir do Bicho Papão e segue no        |");
                Console.WriteLine("| labirinto com mais um ponto.                                                  |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

            }
            else
            {
                character.score -= 1;
                character.life -= 1;
                character.house.scoreHufflePuff += 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                        NÃO TEM NENHUMA MEMÓRIA FELIZ?                         |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    O feitiço não funcionou e você perdeu um ponto e uma vida, mas tente nova- |");
                Console.WriteLine($"| mente. Está com {character.life} pontos de vida!                                             |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
                Console.ReadLine();
                diceValue = RPG.Dice.throwDice();
                RPG.Tune.diceSound(diceValue);
                Console.WriteLine($"O Valor do dado é {diceValue}");

                if (diceValue >= 18)
                {
                    character.score += 1;

                    RPG.Tune.expectoPatronum();

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                  ABRACADABRA                                  |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Remo Lupin provavelmente está orgulhoso de você! Arrasa com esse Patronum! |");
                    Console.WriteLine("|  Mais um ponto para você!                                                     |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();

                }
                else
                {
                    character.life = 0;
                    character.isAlive = false;
                    RPG.Tune.die();

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                      MORREU DE MEDINHO DO BICHO PAPÃO                         |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Ficou desconsertado, hein? O feitiço não funcionou devido à sua falta de   |");
                    Console.WriteLine("| foco! Você foi paralisado pelo medo e não pode mais jogar. Sinto muito :(     |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();
                }
            }

            return character;
        }
        //---------> OPÇÃO 2 <---------
        static Character riddikulusBoggart(Character character)
        {
            character.house.scoreRavenclaw += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                  RIDDIKULUS                                   |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você escolheu a opção menos ridícula para lutar contra o Bicho Papão!      |");
            Console.WriteLine("| Jogue os dados e veja se o feitiço foi eficiente contra a criatura!           |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            if (diceValue >= 11)
            {
                character.score += 1;
                character.house.scoreRavenclaw += 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                     RÍDICULO? SE ISSO É SER RIDÍCULO...                       |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    O feitiço funcionou! Você combateu o Bicho Papão transformando-o em um     |");
                Console.WriteLine("| boneco de palhaço de mola. Siga com um pontos a mais!                         |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

            }
            else
            {
                character.score -= 1;
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                SOCORRO, MÃE!                                  |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Você chorou de medo chamando por sua mãe, porém chegou na Esfinge!         |");
                Console.WriteLine($"|    Está com {character.life} pontos de vida!                                                 |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();
            }

            return character;
        }
        //---------> OPÇÃO 3 <---------
        static Character escapeBoggart(Character character)
        {
            character.house.scoreSlytherin += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                             ESCAPANDO DA CRIATURA                             |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você escolheu a opção menos corajosa possível! Você é uma vergonha!        |");
            Console.WriteLine("| Jogue os dados e veja se conseguiu escapar, seu medroso!                      |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");


            if (diceValue >= 11)
            {
                character.score += 1;
                character.house.scoreSlytherin += 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                      BRUXÃO? BRUXÃO? VOLTA AQUI, BRUXÃO!                      |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Você conseguiu fugir do Bicho Papão! Continue seu caminho no labirinto com |");
                Console.WriteLine("| mais um ponto.                                                                |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

            }
            else
            {
                character.life = 0;
                character.isAlive = false;
                RPG.Tune.die();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                            PRESS F TO PAY RESPECTS                            |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Você não consegue fugir, é paralisado pelo medo e desmaia. Tente novamente |");
                Console.WriteLine("|  daqui quatro anos, se o Cálice permitir :)                                   |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

            }
            return character;
        }


        //---------> VISGO <---------
        static Character devilsSnareMaze(Character character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                          CUIDADO, UM VISGO DO DIABO!                          |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você achou que seria um labirinto bobinho, né? Ir sempre para a direita    |");
            Console.WriteLine("| não é um caminho ruim, porém encontrou um Visgo do Diabo, uma planta que é    |");
            Console.WriteLine("| comumente confundida com uma trepadeira por trouxas, mas é muito mais sombria |");
            Console.WriteLine("| e perigosa e odeia luz e calor. Crescendo nos muros, uma parte do visgo agar- |");
            Console.WriteLine("| ra o seu pé e começa te puxar e te prender com os seus ramos e cipós. O que   |");
            Console.WriteLine("| você faz?                                                                     |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| (1) Realiza o feitiço Lumus Solem                                             |");
            Console.WriteLine("| (2) Fica parado até o efeito passar                                           |");
            Console.WriteLine("| (3) Grita por ajuda e torce para que alguém apareça                           |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write($"{character.name}, informe a opção desejada para continuar: ");
            string option = Console.ReadLine();
            Console.WriteLine();
            RPG.Tune.enter();

            while (option != "1" && option != "2" && option != "3" || option == "")
            {
                Console.WriteLine();
                Console.WriteLine("Opção inválida, tente novamente");
                Console.WriteLine();
                Console.Write($"{character.name}, escolha novamente: ");
                option = Console.ReadLine();
                RPG.Tune.enter();
            }
            switch (option)
            {
                case "1":
                    character = lumus(character);
                    break;

                case "2":
                    character = wait(character);
                    break;

                case "3":
                    character = scream(character);
                    break;
            }
            return character;
        }

        //---------> OPÇÃO 1 <---------
        static Character lumus(Character character)
        {
            character.house.scoreGryffindor += 1;
            character.house.scoreRavenclaw += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                 LUMUS SOLEM!!                                 |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você rapidamente saca sua varinha com toda sua bravura, pronto para        |");
            Console.WriteLine("| mostrar que não chegou até aqui à toa... Será que o nervosismo vai te         |");
            Console.WriteLine("| atrapalhar? Jogue um dado para descobrir.                                     |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue >= 11)
            {
                character.house.scoreRavenclaw += 1;
                character.score += 1;

                RPG.Tune.lumus();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                               CLAREOU A SITUAÇÃO                              |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Você conseguiu se livrar do Visgo! Continue seu caminho com um ponto.      |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

            }
            else
            {
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                            PARECE QUE O TEMPO FECHOU                          |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    O feitiço não funciona e o Visgo fica mais forte, apertando muito você.    |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| Você tem duas opções:                                                         |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| (1) Tentar novamente soltar um Lumus poderoso.                                |");
                Console.WriteLine("| (2) Aceitar a morte.                                                          |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine();

                Console.Write($"{character.name}, você está com {character.life} pontos de vida, informe a opção desejada para continuar: ");
                string option = Console.ReadLine();
                RPG.Tune.enter();
                Console.WriteLine();

                while (option != "1" && option != "2" || option == "")
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção inválida, tente novamente");
                    Console.WriteLine();
                    Console.Write($"{character.name}, escolha novamente: ");
                    option = Console.ReadLine();
                    RPG.Tune.enter();
                }


                switch (option)
                {
                    case "1":
                        character.score += 1;
                        character.house.scoreGryffindor += 1;

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        Console.WriteLine("|                        A LUMUS DO SOL SUPEROU O DIABO                         |");
                        Console.WriteLine("|-------------------------------------------------------------------------------|");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine("|    Você conseguiu se livrar do Visgo! Continue seu caminho com um ponto.      |");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");


                        Console.WriteLine();
                        Console.WriteLine("Pressione ENTER para continuar");
                        Console.ReadLine();
                        RPG.Tune.enter();

                        break;

                    case "2":
                        character.life = 0;
                        character.isAlive = false;
                        RPG.Tune.die();

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        Console.WriteLine("|                             TREPADEIRA MALDITA                                |");
                        Console.WriteLine("|-------------------------------------------------------------------------------|");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine("|    Você perde as forças para lutar e é engolido pela planta. Por isso, não    |");
                        Console.WriteLine("| será capaz de continuar o jogo. Tchauzinho!                                   |");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");

                        Console.WriteLine();
                        Console.WriteLine("Pressione ENTER para continuar");
                        Console.ReadLine();
                        RPG.Tune.enter();

                        break;

                }
            }
            return character;
        }

        //---------> OPÇÃO 2 <---------
        static Character wait(Character character)
        {
            character.house.scoreHufflePuff += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                  QUE CORAGEM                                  |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você foi muito corajoso! Porém, será que essa coragem deu frutos? Jogue o  |");
            Console.WriteLine("| dado para ver se conseguiu ficar parado.                                      |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");



            if (diceValue >= 11)
            {
                character.house.scoreHufflePuff += 1;
                character.score += 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                               SORTUDO(A), HEIN?                               |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Ainda bem que o Visgo te soltou! Continue seu caminho com um ponto.        |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

            }
            else
            {
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                               PUTS, BEM AGORA?                                |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|   Atchim! Parece que você espirrou na pior hora possível! A planta te aperta  |");
                Console.WriteLine("| mais, porém você ainda tem uma chance de ficar parado. Jogue o dado novamente |");
                Console.WriteLine($"| para descobrir se sua alergia a pólen passou. Está com {character.life} pontos de vida!      |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
                Console.ReadLine();
                diceValue = RPG.Dice.throwDice();
                RPG.Tune.diceSound(diceValue);
                Console.WriteLine($"O Valor do dado é {diceValue}");

                if (diceValue >= 11)
                {
                    character.score += 1;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                          LIVRE DE ALERGIA, MARGARIDA                          |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Ainda bem que você segurou seu nariz! Continue seu caminho com um ponto!   |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();

                }
                else
                {
                    character.life = 0;
                    character.isAlive = false;
                    RPG.Tune.die();

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                       PARECE QUE A ALERGIA É FORTE                            |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|   Atchim! Atchim! Atchim! Puts, que hora horrível para sua alergia... A       |");
                    Console.WriteLine("| planta te aperta até ser impossível escapar... Parece que não vai ter a sua   |");
                    Console.WriteLine("| chance de terminar o torneio...                                               |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();

                }
            }
            return character;
        }

        //---------> OPÇÃO 3 <---------
        static Character scream(Character character)
        {
            character.house.scoreSlytherin += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                       PARECE QUE ALGUÉM ESTÁ COM MEDO                         |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Não esperávamos isso de você neste ponto do torneio. Jogue o dado para ver |");
            Console.WriteLine("| se alguém vai aparecer para te ajudar.                                        |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue >= 11)
            {
                character.score += 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                              VOCÊ É MUITO QUERIDO                             |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Seus amigos, sensibilizados pelo seu desespero, decidem ir te ajudar.      |");
                Console.WriteLine("| Parece que, dessa vez, ser uma boa pessoa trouxe resultados.                  |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

            }
            else
            {
                character.house.scoreSlytherin += 1;
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                             NINGUÉM GOSTA DE VOCÊ                             |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|   Parece que pensar só em pegadinhas, fazer bullying e gabar vantagem traz    |");
                Console.WriteLine("| alguns problemas. Jogue o dado para ver se, enquanto você chora, alguém ainda |");
                Console.WriteLine($"| se sensibiliza com você. Está com {character.life} pontos de vida!                           |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
                Console.ReadLine();
                diceValue = RPG.Dice.throwDice();
                RPG.Tune.diceSound(diceValue);
                Console.WriteLine($"O Valor do dado é {diceValue}");

                if (diceValue >= 11)
                {
                    character.score += 1;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                      ALGUÉM SABE QUEM VOCÊ É DE VERDADE                       |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Parece que, ao ouvir seu gritos, alguém sente sua dor e decide ir te       |");
                    Console.WriteLine("| ajudar. Você pode ter escapado, porém é melhor repensar suas atitudes.        |");
                    Console.WriteLine($"| Está com {character.life} pontos de vida!                                                    |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");


                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();

                }
                else
                {
                    character.life = 0;
                    character.isAlive = false;
                    RPG.Tune.die();

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                  ESQUECIDO                                    |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Você grita e pede por ajuda até o fim, mas realmente ninguém aparece.      |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|                                   ADEUS.                                      |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();

                }
            }
            return character;
        }


        //---------> ESCORPIÂO <---------
        static Character blastEndedSkrewtMaze(Character character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                   EXPLOSIVIM                                  |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Alternar entre esquerda e direita é um caminho díficil. Um Explosivim te   |");
            Console.WriteLine("| seguiu até aqui, uma criatura criada por Rúbeo Hagrid, em 1994, através do    |");
            Console.WriteLine("| cruzamento de Manticoras e caranguejos-de-fogo. E agora?                      |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| (1) Lança o feitiço Petrificus Totalus                                        |");
            Console.WriteLine("| (2) Foge                                                                      |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.Write($"{character.name}, informe a opção desejada para continuar: ");
            string option = Console.ReadLine();
            Console.WriteLine();
            RPG.Tune.enter();

            while (option != "1" && option != "2" || option == "")
            {
                Console.WriteLine();
                Console.WriteLine("Opção inválida, tente novamente");
                Console.WriteLine();
                Console.Write($"{character.name}, escolha novamente: ");
                option = Console.ReadLine();
                RPG.Tune.enter();
            }
            switch (option)
            {
                case "1":
                    character = petrificus(character);
                    break;

                case "2":
                    character = run(character);
                    break;
            }

            return character;
        }

        //---------> OPÇÃO 1 <---------
        static Character petrificus(Character character)
        {
            character.house.scoreGryffindor += 1;
            character.house.scoreRavenclaw += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                   EXPLOSIVIM                                  |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você se posiciona para atacar enquanto a criatura vem em sua direção.      |");
            Console.WriteLine("| Jogue o dado para saber se você foi capaz de petrificá-la.                    |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");


            if (diceValue >= 11)
            {
                character.score += 1;
                character.house.scoreGryffindor += 1;

                RPG.Tune.petrificus();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                            VOCÊ É QUASE UM AUROR                              |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Uhuul, você venceu esse bicho metade caranguejo-de-fogo e metade Mantícora |");
                Console.WriteLine("| e ganhou 2 pontos e uma vida por isso! Siga seu caminho!                      |");
                Console.WriteLine($"| Está com {character.life} pontos de vida!                                                    |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

            }
            else
            {
                character.score -= 1;
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                               MEDO DE ESCORPIÃO                               |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Eita, você não conseguiu petrificar o explosivim e se machucou! Mas pode   |");
                Console.WriteLine("| tentar fugir... Jogue o dado para ver se não está machucado demais para       |");
                Console.WriteLine($"| correr. Está com {character.life} pontos de vida!                                            |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
                Console.ReadLine();
                diceValue = RPG.Dice.throwDice();
                RPG.Tune.diceSound(diceValue);
                Console.WriteLine($"O Valor do dado é {diceValue}");

                if (diceValue >= 11)
                {
                    character.score += 1;
                    character.house.scoreRavenclaw += 1;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|          NÃO TEVE DOPPING? UM FERIMENTO DESSE É DIFÍCIL DE AGUENTAR           |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Você conseguiu fugir do explosivim, continue seu caminho no labirinto!     |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();

                }
                else
                {
                    character.life = 0;
                    character.isAlive = false;
                    RPG.Tune.die();

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                   FERROADA                                    |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Você não foi rápido o suficiente, o explosivim te atacou e você morreu!    |");
                    Console.WriteLine("| Sinto muito :(                                                                |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();

                }
            }
            return character;
        }

        //---------> OPÇÃO 2 <---------
        static Character run(Character character)
        {
            character.score -= 1;
            character.house.scoreSlytherin += 2;
            character.house.scoreHufflePuff += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                  ARACNOFOBIA                                  |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    O menor, o maior o do meio. É sempre o mal. Não estou te julgando, eu não  |");
            Console.WriteLine("| passei a minha vida fazendo só o bem.                                         |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Mas agora se eu tiver mesmo que escolher entre o mal ou outro, eu prefiro  |");
            Console.WriteLine("| não escolher nenhum. Está tudo bem fugir desta vez...                         |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Jogue o dado para saber se conseguiu.                                      |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue >= 11)
            {
                character.score += 1;
                character.house.scoreHufflePuff += 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                           DÊ UM TROCADO PARA SEU BRUXO                        |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Você conseguiu fugir e merece um trocado! Dessa vez você não terá que      |");
                Console.WriteLine("| combater o mal. Siga no labirinto.                                            |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

            }
            else
            {
                character.life = 0;
                character.isAlive = false;
                RPG.Tune.die();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                  QUE DESASTRADO                               |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Enquanto corre desesperado, você, devido ao medo, tropeça e desmaia.       |");
                Console.WriteLine("| Infelizmente, você acorda na enfermaria somente dias depois do torneio.       |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

            }
            return character;
        }


        //---------> ESFINGE <---------
        static void sphinxChallenge(List<Character> character)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                   LABIRINTO                                   |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|                              Desafio da Esfinge                               |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    De acordo com o Ministério da Magia, a Esfinge é uma criatura mágica       |");
            Console.WriteLine("| nativa do Egito que tem a cabeça de um humano e o corpo do leão. Esfinges são |");
            Console.WriteLine("| capazes de fala humana e são conhecidas por seu amor por quebra-cabeças,      |");
            Console.WriteLine("| enigmas e charadas.                                                           |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Quando o Ministério da Magia começou a categorizar criaturas mágicas, a    |");
            Console.WriteLine("| Esfinge foi colocada na categoria Fera e não na categoria Ser devido às suas |");
            Console.WriteLine("| tendências violentas. Mas, não se preocupe, aqui você não precisará enfrentar |");
            Console.WriteLine("| a força física dela, mas a sua mente. Será que você dá conta do recado?       |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");


            for (int i = 0; i < character.Count; i++)
            {
                if (!character[i].isAlive)
                {
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                   LABIRINTO                                   |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|                               Enigma da Esfinge                               |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Responda à seguinte charada para continuar o seu caminho:                  |");
                Console.WriteLine("|  Se ao meu encontro vier, os olhos deve fechar. Caso contrário, a morte te    |");
                Console.WriteLine("|  levará! Quem sou eu?                                                         |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| (1) VOLDEMORT                                                                 |");
                Console.WriteLine("| (2) BASILISCO                                                                 |");
                Console.WriteLine("| (3) HIPOGRIFO                                                                 |");
                Console.WriteLine("| (4) NAGINI                                                                    |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine();

                Console.WriteLine();
                Console.Write($"{character[i].name}, informe a opção desejada para continuar: ");
                string option = Console.ReadLine();
                Console.WriteLine();
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

                if (option == "2")
                {
                    character[i].sphinxAnswer = true;
                }

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                   LABIRINTO                                   |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|                          Resposta do enigma da Esfinge                        |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Humm, será que você(s) acertou(aram)? Veremos agora...                     |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine();

            var isRight = character.FindAll(x => x.sphinxAnswer == true);

            var isAlive = character.FindAll(x => x.isAlive == true && x.sphinxAnswer == false);

            if (isRight.Count != 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                   LABIRINTO                                   |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|                               Enigma da Esfinge                               |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Uau! Esse momento foi tenso, hein? Mas você conseguiu superar a feroz Es-  |");
                Console.WriteLine("| finge e o seu enigma. Parabéns! Por isso, você ganhou um ponto e uma vida! Se |");
                Console.WriteLine("| houver um vencedor no jogo, você vai descobrir quem é agora. Se houver        |");
                Console.WriteLine("| empate, prepare-se para mais um desafio...                                    |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                foreach (var player in isRight)
                {
                    Console.WriteLine();
                    Console.Write("Parabéns! Você acertou: ");
                    Console.Write($"{player.name}; ");

                    player.score += 1;
                    player.life += 1;

                    Console.WriteLine();
                    Console.WriteLine($"{player.name}, você está com {player.life} pontos de vida e {player.score} pontos no torneio!");
                    Console.WriteLine();


                }


                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                // RPG.Tune.enter();

            }

            if (isAlive.Count != 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                   LABIRINTO                                   |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|                               Enigma da Esfinge                               |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Humm… Não. Quem sabe da próxima vez? Você perdeu um score e uma vida :(,   |");
                Console.WriteLine("| mas conseguiu se livrar da Esfinge com menos um ponto e uma vida! Agora, cor- |");
                Console.WriteLine("| ra o mais rápido que puder para a saída do labirinto! Se houver um vencedor   |");
                Console.WriteLine("| no jogo, você vai descobrir quem é agora. Se houver empate, prepare-se para   |");
                Console.WriteLine("| mais um desafio...                                                            |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();

                foreach (var player in isAlive)
                {
                    Console.Write("Você errou! Sinto muito: ");
                    Console.Write($"{player.name}; ");

                    player.score -= 1;
                    player.life -= 1;

                    if (player.life < 1)
                    {
                        player.isAlive = false;
                        player.life = 0;
                        RPG.Tune.die();
                        Console.Write("Sinto muito parece que suas vidas acabaram, gracinha: ");
                        Console.Write($"{player.name}; ");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{player.name}, você está com {player.life} pontos de vida e {player.score} pontos no torneio!");
                        Console.WriteLine();
                    }


                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                // RPG.Tune.enter();
                Console.WriteLine();
            }

            RPG.Update.biggestScore(character);//chamada da função do duelo

        }
    }

}
