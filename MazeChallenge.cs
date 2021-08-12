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
            Console.WriteLine("| aguardam. Escolha sabiamente e, se puder, faça uso de toda e qualquer vanta-  |");
            Console.WriteLine("| gem.                                                                          |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            for (int i = 0; i < character.Count; i++)
            {
                if (!character[i].isAlive)
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();

                if (character[i].hasMap)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                  SORTE GRANDE                                 |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|                                 Mapa do Maroto                                |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Ah, que incrível! Você possui o Mapa do Maroto e tem a vantagem de saber   |");
                    Console.WriteLine("| qual o melhor caminho do labirinto e onde os seus concorrentes estão! Siga    |");
                    Console.WriteLine("| direto para o final.                                                          |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Por isso, você pulou QUASE todos os obstáculos do labirinto... Infeliz-    |");
                    Console.WriteLine("| mente, nem o Mapa poderia ter previsto a presença da enigmática Esfinge. Como |");
                    Console.WriteLine("| guerreiro, resta a você enfrentá-la. Se você está jogando com um ou mais ami- |");
                    Console.WriteLine("| gos, espere que eles enfrentem os desafios do labirinto e, então, vocês en-   |");
                    Console.WriteLine("| frentarão a Esfinge.                                                          |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine($"Pressione ENTER para continuar");
                    Console.ReadLine();

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
                    Console.WriteLine("|    Qual caminho você deseja seguir? Cuidado… isso dirá muito sobre você e os  |");
                    Console.WriteLine("| desafios que enfrentará.                                                      |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("| (1) IR SEMPRE PARA A DIREITA                                                  |");
                    Console.WriteLine("| (2) ALTERNAR ENTRE ESQUERDA E DIREITA                                         |");
                    Console.WriteLine("| (3) IR SEMPRE PARA A ESQUERDA                                                 |");
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
            Console.WriteLine("|    Você achou que seria um labirinto bobinho, né? Ir sempre para a esquerda   |");
            Console.WriteLine("| não é um caminho ruim, mas… aqui está um Bicho Papão, um não-ser que assume a |");
            Console.WriteLine("| forma do pior medo da pessoa que o vê. Normalmente vive confinado dentro de   |");
            Console.WriteLine("| armários e lugares escuros e, por conta de sua natureza de mudar de forma,    |");
            Console.WriteLine("| ninguém sabe sua real aparência.                                              |");
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

            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                    BICHO PAPÃO                                |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| Faça uma escolha:                                                             |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| (1) Lançar feitiço Riddikulus                                                 |");
            Console.WriteLine("| (2) Lançar feitiço Expecto Patronum                                           |");
            Console.WriteLine("| (3) Fugir                                                                     |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();

            Console.WriteLine();
            Console.Write($"{character.name}, informe a opção desejada para continuar: ");
            string option = Console.ReadLine();
            while (option != "1" && option != "2" && option != "3" && option == "")
            {
                Console.WriteLine();
                Console.WriteLine("Opção Invalida, tente novamente");
                Console.WriteLine();
                Console.Write($"{character.name}, escolha novamente: ");
                option = Console.ReadLine();
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
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                 BICHO PAPÃO                                   |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Você escolheu enfeitiçar o bicho-papão! Cuidado pra você não passar ridiculo!|");
            Console.WriteLine("| Boa sorte, que rolem os dados!                                                |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");


            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue >= 6 && diceValue <= 17)
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                        A PUT A SPELL ON YOU -- SUCESSO                        |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    O feitiço funcionou! Você consegue fugir do Bicho Papão e segue no labi-   |");
                Console.WriteLine("| rinto com mais um ponto e uma vida.                                           |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreGryffindor += 1;
                character.score += 1;
                character.life += 1;
            }
            else if (diceValue >= 18)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                           NOW YOUR MINE -- SUCESSO                            |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    O feitiço funcionou! Você consegue fugir do Bicho Papão e segue no labi-   |");
                Console.WriteLine("| rinto com mais 2 pontos score e uma vida.                                     |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreGryffindor += 1;
                character.score += 2;
                character.life += 1;

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                          FOI ENGOLIDO PELO BICHO PAPÃO                        |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    O feitiço não funcionou e você perdeu um score e uma vida, mas tente nova- |");
                Console.WriteLine("| mente.                                                                        |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.score -= 1;
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
                Console.ReadLine();
                diceValue = RPG.Dice.throwDice();
                Console.WriteLine($"O Valor do dado é {diceValue}");

                if (diceValue >= 6 && diceValue <= 17)
                {

                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                 ABRACADABRA                                   |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    O feitiço funcionou! Você consegue fugir do Bicho Papão e segue no labi-   |");
                    Console.WriteLine("| rinto com mais 2 pontos e uma vida.                                           |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    character.house.scoreGryffindor += 1;

                }
                else
                {


                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                    BICHO PAPÃO                                |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    O feitiço não funcionou porque o bicho papão não é um dementador de        |");
                    Console.WriteLine("| verdade e não pode ser derrotado com o Expecto Patronum. Você é paralisado    |");
                    Console.WriteLine("| pelo medo e desmaia. Tente novamente mais tarde :(                            |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    character.isAlive = false;
                }
            }

            return character;
        }
        //---------> OPÇÃO 2 <---------
        static Character riddikulusBoggart(Character character)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                  RIDDIKULUS                                   |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você escolheu a opção menos ridicula pra lutar contra o bicho papão!       |");
            Console.WriteLine("| Jogue os dados e vejo se o feitiço foi eficiente ao espantar a criatura!      |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");


            if (diceValue >= 18)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                             O FEITIÇO DEU CERTO!                              |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    O feitiço funcionou! Você consegue fugir do Bicho Papão e segue no labi-   |");
                Console.WriteLine("| rinto com mais 2 pontos score e uma vida.                                     |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.score += 2;
                character.life += 1;
                character.house.scoreSlytherin += 1;

            }
            else
            {
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                 SOCORRO MÃE!                                  |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| Você chorou de medo chamando por sua mãe, porém chegou na esfinge!            |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.score -= 1;
                character.life -= 1;
                character.house.scoreSlytherin += 1;
            }

            return character;
        }
        //---------> OPÇÃO 3 <---------
        static Character escapeBoggart(Character character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                             ESCAPANDO DA CRIATURA                             |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você escolheu a opção menos corajosa possível! Você é uma vergonha!        |");
            Console.WriteLine("| Jogue os dados e vejo se conseguiu escapar seu medroso!                       |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue >= 6 && diceValue <= 17)
            {

                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                    BICHO PAPÃO                                |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Você conseguiu fugir do Bicho Papão! Continue seu caminho no labirinto com |");
                Console.WriteLine("| mais um ponto e uma vida.                                                     |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.score += 1;
                character.life += 1;

            }


            else if (diceValue >= 18)
            {

                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                    BICHO PAPÃO                                |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    O feitiço funcionou! Você consegue fugir do Bicho Papão e segue no labi-   |");
                Console.WriteLine("| rinto com mais 2 pontos e uma vida.                                           |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.score += 2;
                character.life += 1;
                character.house.scoreRavenclaw += 1;
                character.house.scoreHufflePuff += 1;

            }
            else
            {

                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                    BICHO PAPÃO                                |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Você não consegue fugir, é paralisado pelo medo e desmaia. Tente novamente |");
                Console.WriteLine("|  mais tarde :(                                                                |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.isAlive = false;

            }
            return character;
        }


        //---------> VISGO <---------
        static Character devilsSnareMaze(Character character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                           CUIDADO, UM VISGO DO DIABO                          |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você achou que seria um labirinto bobinho, né? Ir sempre para a direita    |");
            Console.WriteLine("| não é um caminho ruim, mas… aqui está o Visgo do Diabo, uma planta que é      |");
            Console.WriteLine("| comumente confundida com uma trepadeira por trouxas, mas é muito mais sombria |");
            Console.WriteLine("| e perigosa e odeia luz e calor. Crescendo nos muros, uma parte do visgo agar- |");
            Console.WriteLine("| ra o seu pé e começa te puxar e te prender com os seus tentáculos. O que você |");
            Console.WriteLine("| faz?                                                                          |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| (1) REALIZA O FEITIÇO LUMUS SOLEM                                             |");
            Console.WriteLine("| (2) FICA PARADO ATÉ O EFEITO PASSAR                                           |");
            Console.WriteLine("| (3) GRITA POR AJUDA E TORCE PARA QUE ALGUÉM APAREÇA                           |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write($"{character.name}, informe a opção desejada para continuar: ");
            string option = Console.ReadLine();
            Console.WriteLine();

            while (option != "1" && option != "2" && option != "3" && option == "")
            {
                Console.WriteLine();
                Console.WriteLine("Opção Invalida, tente novamente");
                Console.WriteLine();
                Console.Write($"{character.name}, escolha novamente: ");
                option = Console.ReadLine();
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
                    character = Scream(character);
                    break;
            }
            return character;
        }

        //---------> OPÇÃO 1 <---------
        static Character lumus(Character character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                 LUMUS SOLEM!!                                 |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você rapidamente saca sua varinha, com toda sua bravura, pronto para mos-  |");
            Console.WriteLine("| trar que não chegou até aqui à toa... Será que o nervosismo vai te atrapa-    |");
            Console.WriteLine("| lhar? Jogue um dado para descobrir.                                           |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue >= 6)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                 CLAREOU A SITUAÇÃO                            |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Você conseguiu se livrar do Visgo! Continue seu caminho com dois pontos.   |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                character.house.scoreRavenclaw += 1;
                character.score += 2;

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                            PARECE QUE O TEMPO FECHOU                          |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    O feitiço não funciona e o Visgo fica mais forte, apertando muito você.    |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Você tem duas opções:                                                      |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| (1) Tentar novamente soltar um Lumus poderoso.                                |");
                Console.WriteLine("| (2) Aceitar a morte.                                                          |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine();
                Console.Write($"{character.name}, informe a opção desejada para continuar: ");
                string option = Console.ReadLine();
                Console.WriteLine();

                while (option != "1" && option != "2" && option == "")
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção Invalida, tente novamente");
                    Console.WriteLine();
                    Console.Write($"{character.name}, escolha novamente: ");
                    option = Console.ReadLine();
                }

                switch (option)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        Console.WriteLine("|                               CLAREOU A SITUAÇÃO                              |");
                        Console.WriteLine("|-------------------------------------------------------------------------------|");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine("|    Você conseguiu se livrar do Visgo! Continue seu caminho com um ponto.      |");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        character.score += 1;
                        character.house.scoreRavenclaw += 1;
                        break;

                    case "2":
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        Console.WriteLine("|                                 EU DESISTO!                                   |");
                        Console.WriteLine("|-------------------------------------------------------------------------------|");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine("|    Em um ato desesperado, você desiste e é engolido pela planta e não será    |");
                        Console.WriteLine("| capaz de continuar o jogo. Tchauzinho :(                                      |");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        character.isAlive = false;
                        break;

                }
            }
            return character;
        }

        //---------> OPÇÃO 2 <---------
        static Character wait(Character character)
        {
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
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue > 6)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                 CLAREOU A SITUAÇÃO                            |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Você conseguiu se livrar do Visgo! Continue seu caminho com dois pontos.   |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                character.house.scoreGryffindor += 2;
                character.score += 2;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                               PUTS, BEM AGORA?                                 |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|   Atchim! Parece que você espirrou na pior hora possível! A planta te aperta  |");
                Console.WriteLine("| mais, porém você ainda tem uma chance de ficar parado. Jogue o dado novamente |");
                Console.WriteLine("| para descobrir se sua alergia a pólen passou.                                 |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                character.life -= 1;

                if (diceValue > 6)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                               CLAREOU A SITUAÇÃO                              |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Você conseguiu se livrar do Visgo! Continue seu caminho com um ponto.      |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    character.house.scoreGryffindor += 1;
                    character.score += 1;
                }
                else
                {
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                       PARECE QUE A ALERGIA É FORTE                            |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|   Atchim! Atchim! Atchim! Puts, que hora horrível para sua alergia... A       |");
                    Console.WriteLine("| planta te aperta até ser impossível escapar... Parece que não vai ter a sua   |");
                    Console.WriteLine("| chance de terminar o torneio...                                               |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    character.isAlive = false;
                }
            }
            return character;
        }

        //---------> OPÇÃO 3 <---------
        static Character Scream(Character character)
        {
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
            character.house.scoreSlytherin += 1;

            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue > 6)
            {
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
                character.house.scoreHufflePuff += 1;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                             NINGUÉM GOSTA DE VOCÊ                             |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|   Parece que pensar só em pegadinhas, fazer bullying e gabar vantagem traz    |");
                Console.WriteLine("| alguns problemas. Jogue o dado para ver se, enquanto você chora, alguém ainda |");
                Console.WriteLine("| se sensibiliza com você.                                                      |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                character.house.scoreSlytherin += 1;

                Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
                Console.ReadLine();
                diceValue = RPG.Dice.throwDice();
                Console.WriteLine($"O Valor do dado é {diceValue}");

                if (diceValue > 6)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                      ALGUÉM SABE QUEM VOCÊ É DE VERDADE                       |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Parece que, ao ouvir seu gritos, alguém sente sua dor e decide ir te       |");
                    Console.WriteLine("| ajudar. Você pode ter escapado, porém é melhor repensar suas atitudes.        |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    character.house.scoreHufflePuff += 1;
                    character.life -= 1;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                  ESQUECIDO                                    |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Você grita e pede por ajuda até o fim, mas realmente ninguém aparece.      |");
                    Console.WriteLine("| ADEUS.                                                                         |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    character.isAlive = false;
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
            Console.WriteLine("|    Você achou que seria um labirinto bobinho, né? Alternar entre esquerda e   |");
            Console.WriteLine("| direita não é um caminho ruim, mas… aqui está um Explosivim, uma criatura     |");
            Console.WriteLine("| criada por Rúbeo Hagrid, em 1994, através do cruzamento de Manticoras e ca-   |");
            Console.WriteLine("| ranguejos-de-fogo. O que você faz?                                            |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| (1) LANÇA O FEITIÇO PETRIFICUS TOTALUS                                        |");
            Console.WriteLine("| (2) FOGE                                                                      |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.Write($"{character.name}, informe a opção desejada para continuar: ");
            string option = Console.ReadLine();
            Console.WriteLine();

            while (option != "1" && option != "2" && option == "")
            {
                Console.WriteLine();
                Console.WriteLine("Opção Invalida, tente novamente");
                Console.WriteLine();
                Console.Write($"{character.name}, escolha novamente: ");
                option = Console.ReadLine();
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
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue > 6)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                            VOCÊ É QUASE UM AUROR                              |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Uhuul, você venceu esse bicho metade caranguejo-de-fogo e metade Mantícora |");
                Console.WriteLine("| e ganhou 2 pontos e uma vida por isso! Siga seu caminho, bruxão!              |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                character.score += 1;
                character.house.scoreGryffindor += 1;
                character.house.scoreSlytherin += 1;

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                               MEDO DE ESCORPIÃO                               |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Eita, você não conseguiu petrificar o explosivim e se machucou! Mas pode   |");
                Console.WriteLine("| tentar fugir... Jogue o dado para ver se não está machucado demais para       |");
                Console.WriteLine("| correr.                                                                       |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                character.score -= 1;
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
                Console.ReadLine();
                diceValue = RPG.Dice.throwDice();
                Console.WriteLine($"O Valor do dado é {diceValue}");

                if (diceValue > 6)
                {

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                   EXPLOSIVIM                                  |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Você conseguiu fugir do explosivim, continue seu caminho no labirinto!     |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    character.score += 1;
                    character.house.scoreSlytherin += 1;

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                  FERROADA                                     |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Você não foi rápido o suficiente, o explosivim te atacou e você morreu!    |");
                    Console.WriteLine("| Sinto muito :(                                                                |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    character.isAlive = false;

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                }
            }
            return character;
        }

        //---------> OPÇÃO 2 <---------
        static Character run(Character character)
        {
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                    ARACNOFOBIA                                |");
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
            character.score -= 1;

            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue > 6)
            {


                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                           DÊ UM TROCADO PARA SEU BRUXO                        |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Você conseguiu fugir e merece um trocado! Dessa vez você não terá que      |");
                Console.WriteLine("| combater o mal. Siga no labirinto.                                            |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                character.score += 1;
                character.house.scoreSlytherin += 1;

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();

            }
            else
            {

                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                  QUE DESASTRADO                               |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Enquanto corre desesperado, você, devido ao medo, tropeça e desmaia.       |");
                Console.WriteLine("|    Infelizmente você acorda na enfermaria dias depois do torneio.             |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                character.isAlive = false;


                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
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
            Console.WriteLine("|    De acordo com o Ministério da Magia, a Esfinge é uma criatura mágica nati- |");
            Console.WriteLine("| va do Egito que tem a cabeça de um humano e o corpo do leão. Esfinges são     |");
            Console.WriteLine("| capazes de fala humana e são conhecidas por seu amor por quebra-cabeças,      |");
            Console.WriteLine("| enigmas e charadas.                                                           |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Quando o Ministério da Magia começou a categorizar criaturas mágicas, a    |");
            Console.WriteLine("| Esfinge foi colocada na categoria fera e não na categorseria, devido às suas  |");
            Console.WriteLine("| tendências violentas. Mas, não se preocupe, aqui você não precisará enfrentar |");
            Console.WriteLine("| a força física dela, mas a sua mente. Será que você dá conta do recado?       |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");


            for (int i = 0; i < character.Count; i++)
            {
                if (!character[i].isAlive)
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();

                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                   LABIRINTO                                   |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|                               Enigma da Esfinge                               |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Responda à seguinte charada para continuar o seu caminho:                  |");
                Console.WriteLine("|    Se ao meu encontro vier, os olhos deve fechar. Caso contrário, bruxão, a   |");
                Console.WriteLine("| morte te levará! Quem sou eu?                                                 |");
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

                while (option != "1" && option != "2" && option != "3" && option == "")
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção Invalida, tente novamente");
                    Console.WriteLine();
                    Console.Write($"{character[i].name}, escolha novamente: ");
                    option = Console.ReadLine();
                }

                if (option == "2")
                {
                    character[i].sphinxAnswer = true;
                }

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

            }

            var isRight = character.FindAll(x => x.sphinxAnswer == true);

            var isAlive = character.FindAll(x => x.isAlive == true && x.sphinxAnswer == false);

            if (isRight != null)
            {
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                   LABIRINTO                                   |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|                               Enigma da Esfinge                               |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Uau! Esse momento foi tenso, hein? Mas você conseguiu superar a feroz Es-  |");
                Console.WriteLine("| finge e o seu enigma. Parabéns! Por isso, você ganhou um ponto e uma vida! Se |");
                Console.WriteLine("| houver um vencedor no jogo, você vai descobrir quem é agora. Se houver em-    |");
                Console.WriteLine("| pate, prepare-se para mais um desafio...                                      |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                foreach (var player in isRight)
                {

                    Console.WriteLine($"Parabéns! {player.name}");
                    player.score += 1;
                    player.life += 1;

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();

                }

            }
            else if (isAlive != null)
            {
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                   LABIRINTO                                   |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|                               Enigma da Esfinge                               |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Humm… Não. Quem sabe da próxima vez? Você perdeu um score e uma vida :(,   |");
                Console.WriteLine("| mas conseguiu se livrar da Esfinge com menos um score e uma vida! Agora, cor- |");
                Console.WriteLine("| ra o mais rápido que puder para a saída do labirinto! Se houver um vencedor   |");
                Console.WriteLine("| no jogo, você vai descobrir quem é agora. Se houver empate, prepare-se para   |");
                Console.WriteLine("| mais um desafio...                                                            |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                foreach (var player in isAlive)
                {

                    Console.WriteLine($"Você errou! Sinto muito, {player.name}.");
                    player.score -= 1;
                    player.life -= 1;

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();

                }
            }


        }
    }

}
