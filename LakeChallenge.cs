using System;
using System.Collections.Generic;
namespace RPG
{
    class Lake
    {
        static int diceValue;
        public static void lakeChallenge(List<Character> character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();

            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                    O LAGO                                     |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Após o susto do primeiro desafio, todos acordam mais dispostos prontos     |");
            Console.WriteLine("| para a  segunda tarefa do Torneio Tribruxo, e encaminham-se até o Lago Negro. |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Algo importante, querido, deve ser resgatado do fundo do lago.             |");
            Console.WriteLine("| Mas, cuidado com aqueles que espreitam-se nas profundezas. Mergulhe de cabeça |");
            Console.WriteLine("| para recuperar o que foi perdido!                                             |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();


            for (int i = 0; i < character.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                            DESAFIO DO LAGO NEGRO                              |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| Agora, você tem 3 opções:                                                     |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| (1) Guelricho                                                                 |");
                Console.WriteLine("| (2) Feitiço Cabeça de Bolha                                                   |");
                Console.WriteLine("| (3) Transfigurar-se num peixe                                                 |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine();

                Console.Write($"{character[i].name}, informe a opção desejada para continuar: ");
                string option = Console.ReadLine();
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
                        character[i] = eatGuelricho(character[i]);
                        break;

                    case "2":
                        character[i] = bubbleHead(character[i]);
                        break;

                    case "3":
                        character[i] = transfiguration(character[i]);
                        break;
                }

            }

            merpeoplePhase(character);
        }

        //---------> OPÇÂO 1 <---------
        static Character eatGuelricho(Character character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                  GUELRICHO                                    |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Você escolheu engolir o guelricho! Blargh, a partir de agora role o dado     |");
            Console.WriteLine("| para descobrir os efeitos colaterais da sua decisão!                          |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");


            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue > 10)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                            GUELRICHO -- SUCESSO                               |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Incrível, você consegue sentir os efeitos da planta tomando o seu corpo!     |");
                Console.WriteLine("| Guelras surgem no seu pescoço e membranas entre os dedos.                     |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreGryffindor += 2;
                character.house.scoreHufflePuff += 1;
                character.score += 1;
            }

            else if (character.hasPotion && diceValue > 10)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                            GUELRICHO  --  SUCESSO                             |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Surpresa! Por ter escolhido dedicar-se aos estudos, você ganhou a chance de  |");
                Console.WriteLine("| rodar o dado mais uma vez. Parabéns! 1 ponto extra por ter se dedicado!       |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreRavenclaw += 1;
                character.score += 1;
                character.life += 1;

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                           GUELRICHO  --  FRACASSO                             |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Eita, algo de errado não está certo!Você engasgou com o guelricho e a planta |");
                Console.WriteLine("| desceu pelo lado errado. Perdeu 1 ponto nessa jogada e seu tempo de prova foi |");
                Console.WriteLine("| encurtado!                                                                    |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreGryffindor += 2;
                character.house.scoreHufflePuff += 1;

                character.score -= 1;
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();

            }

            return character;


        }

        //---------> OPÇÂO 2 <---------
        static Character bubbleHead(Character character)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                           FEITIÇO CABEÇA DE BOLHA                             |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Você escolheu utilizar o feitiço cabeça de bolha! Glub-glub, a partir de     |");
            Console.WriteLine("| agora role o para descobrir os efeitos colaterais da sua decisão!             |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue > 10)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                    FEITIÇO CABEÇA DE BOLHA -- SUCESSO                         |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  O feitiço foi lançado com sucesso! Parabéns! Sua cabeça foi envolta por uma  |");
                Console.WriteLine("| bolha e seu tempo submerso aumentou por isso!                                 |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreRavenclaw += 1;
                character.score += 1;

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                     FEITIÇO CABEÇA DE BOLHA  --  FRACASSO                     |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  O feitiço virou-se contra o feiticeiro! A bolha estourou, você está ficando  |");
                Console.WriteLine("| sem ar, tente novamente na próxima rodada fugir desse destino!                |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                //ravenclaw++ NÃO COLOQUEI PQ ACHEI Q N MERECE HAH
                character.score -= 1;
                character.life -= 1;


                Console.WriteLine();
                Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
                Console.ReadLine();
                diceValue = RPG.Dice.throwDice();
                Console.WriteLine($"O Valor do dado é {diceValue}");

                if (diceValue < 10)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                         FUGIR DO AFOGAMENTO  -- SUCESSO                       |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|  Parabéns, você conseguiu fugir do seu destino! Nadou para fora do lago antes |");
                    Console.WriteLine("| da bolha encher-se de água!                                                   |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
                    Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();

                    //ravenclaw++; acho q n merece
                }
                else
                {

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                         FUGIR DO AFOGAMENTO   --  FRACASSO                    |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|  O feitiço virou-se contra o feiticeiro! A bolha estourou, você está ficando  |");
                    Console.WriteLine("| sem ar, tente novamente na próxima rodada fugir desse destino!                |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    character.isAlive = false;

                }


            }

            return character;

        }

        //---------> OPÇÂO 3 <---------
        static Character transfiguration(Character character)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                TRANSFIGURAÇÃO                                 |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Você escolheu utilizar o feitiço de transfiguração! A partir de agora role o |");
            Console.WriteLine("| dado para descobrir se você se lembrou de entrar na água antes de se          |");
            Console.WriteLine("| transformar!                                                                  |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");


            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue > 10)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                         TRANSFIGURAÇÃO -- SUCESSO                             |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  O seu corpo está mudando! Após muito estudo sua transmutação ocorreu com     |");
                Console.WriteLine("| sucesso, você se transformou num peixe.                                       |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreSlytherin += 1;
                character.score += 1;


            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                        TRANSFIGURAÇÃO  --  FRACASSO                           |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  O feitiço deu errado, ao invés de transformá-lo inteiramente em um peixe,    |");
                Console.WriteLine("| apenas as suas pernas foram modificadas! Além da vergonha, você ficou sem     |");
                Console.WriteLine("| guelras pra te ajudar no desafio. Melhor nadar rápido! Humm, acho que não     |");
                Console.WriteLine("| vai dar tempo de completar a prova.                                           |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                //slytherin++ não acho q mereça ahah
                character.score -= 1;
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
            }

            return character;


        }



        //---------> ENFRENTAR SEREIANOS <---------
        static void merpeoplePhase(List<Character> character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                           ENFRENTANDO OS SEREIANOS                            |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Muito bem campeões, hora de iniciar a busca pelo que foi roubado!            |");
            Console.WriteLine("| O tempo está passando, cada competidor tem 1h para completar o desafio! Você  |");
            Console.WriteLine("| está nadando na floresta de algas no fundo do Lago Negro, quando avista seus  |");
            Console.WriteLine("| amigos presos pelos pés em uma armadilha.                                     |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();



            for (int i = 0; i < character.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                            DESAFIO DO LAGO NEGRO                              |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Mas espere! Parece que eles têm companhia, estão sendo vigiados por          |");
                Console.WriteLine("| sereianos! Você precisa resgatá-los, o que você pretende fazer:               |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| (1) Lutar contra os sereianos                                                 |");
                Console.WriteLine("| (2) Tentar salvar todos os reféns                                             |");
                Console.WriteLine("| (3) Persuadir os sereianos a libertar o seu amigo                             |");
                Console.WriteLine("| (4) Enfeitiçar os sereianos                                                   |");
                Console.WriteLine("|                                                                               |");
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
                        character[i] = fightMerpeople(character[i]);
                        break;
                    case "2":
                        character[i] = saveFriends(character[i]);
                        break;
                    case "3":
                        character[i] = wooMerpeople(character[i]);
                        break;
                    case "4":
                        character[i] = enchantMerpeople(character[i]);
                        break;
                }


            }

            breakForNextChallenge(character);

        }

        //---------> OPÇÂO 1 <---------
        static Character fightMerpeople(Character character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                         LUTAR CONTRA OS SEREIANOS                             |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Você escolheu enfrentar os sereianos! A partir de agora role o dado para     |");
            Console.WriteLine("| descobrir se a sua decisão deu certo! Boa sorte!                              |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            Console.WriteLine();

            if (diceValue > 10)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                    LUTAR CONTRA OS SEREIANOS -- SUCESSO                       |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Petrificus Totalus! Deu certo, você pegou os sereianos desprevenidos! Graças |");
                Console.WriteLine("| ao seu feitiço, todos foram petrificados! Parabéns! Conseguiu salvar o seu    |");
                Console.WriteLine("| amigo a tempo de passar na prova!                                             |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.score += 1;
                character.house.scoreGryffindor += 2;

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                    LUTAR CONTRA OS SEREIANOS  --  FRACASSO                    |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Oh, não! Os sereianos são muitos e você acaba sendo enrolado por eles também.|");
                Console.WriteLine("| Como será que perceberam sua movimentação tão rápido? Só havia você e os      |");
                Console.WriteLine("| outros competidores no lago, ou será que não? Perdeu 1 ponto nessa jogada e   |");
                Console.WriteLine("| não vai ser possível completar a prova.                                       |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreGryffindor += 2;
                character.score -= 1;
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
            }

            return character;
        }
        //---------> OPÇÂO 2 <---------
        static Character saveFriends(Character character)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                           SALVAR TODOS OS REFÉNS                              |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Você escolheu tentar salvar todos os reféns! Será que você tem ar            |");
            Console.WriteLine("|  suficiente? Jogue os dados para descobrir!                                   |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");


            if (diceValue > 10)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                     SALVAR TODOS OS REFÉNS -- SUCESSO                         |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Confundus! Em uma jogada de mestre, você atordoou os sereianos e conseguiu   |");
                Console.WriteLine("| livrar todos os reféns! Parabéns, você recebeu um ponto de vida a mais!       |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreHufflePuff += 1;
                character.score += 1;
                character.life += 1;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                      SALVAR TODOS OS REFÉNS  --  FRACASSO                     |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Oh, oh! Os sereianos ficaram bravos com você, apenas um amigo pode ser salvo!|");
                Console.WriteLine("| Você foi mandando de volta pro início do lago! Acabou o tempo antes de chegar |");
                Console.WriteLine("| aos reféns.                                                                   |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreHufflePuff += 1;
                character.score -= 1;
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();

            }

            return character;
        }

        //---------> OPÇÂO 3 <---------
        static Character wooMerpeople(Character character)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                            PERSUADIR OS SEREIANOS                             |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Você escolheu persuadir os sereianos a libertar seu amigo! Role os dados e   |");
            Console.WriteLine("| veja o quão persuasivo você é!                                                |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue > 10)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                     PERSUADIR OS SEREIANOS -- SUCESSO                         |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Você escolheu atacar com diálogo e seu movimento foi super efetivo! Usando a |");
                Console.WriteLine("| lábia, conseguiu convencer os sereianos a te deixar libertar seu amigo!       |");
                Console.WriteLine("| Parabéns, receba um ponto pela ótima conversa!                                |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreSlytherin += 1;
                character.score += 1;


            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                      PERSUADIR OS SEREIANOS  --  FRACASSO                     |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Muito ruim de papo! Os sereianos ficaram entediados com você! Infelizmente,  |");
                Console.WriteLine("| sua lábia foi fraca e você só perdeu tempo! Os sereianos ficam irritados e    |");
                Console.WriteLine("| você sai nadando o mais rápido possível!                                      |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreSlytherin += 1;
                character.score -= 1;
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();

            }
            return character;
        }

        //---------> OPÇÂO 4 <---------
        static Character enchantMerpeople(Character character)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                           ENFEITIÇAR OS SEREIANOS                             |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Você escolheu enfeitiçar os sereianos!! Role o dado e descubra se o feitiço  |");
            Console.WriteLine("| foi efetivo!                                                                  |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue > 10)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                      ENFEITIÇAR OS SEREIANOS -- SUCESSO                       |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Incrível! Você conseguiu distrair os sereianos usando um novo feitiço.       |");
                Console.WriteLine("| Usando a sua varinha, você emitiu uma luz na direção oposta e atraiu os       |");
                Console.WriteLine("| sereianos para o outro lado, deixando o caminho livre para libertar os        |");
                Console.WriteLine("| reféns! Ganhou um ponto pela esperteza!                                       |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreRavenclaw += 1;
                character.score += 1;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                     ENFEITIÇAR OS SEREIANOS -- FRACASSO                       |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Vish! Seu plano não deu certo, um dos sereianos ouviu um barulho próximo de  |");
                Console.WriteLine("| você e acabou percebendo o seu movimento com a varinha! Você estranha ter     |");
                Console.WriteLine("| sido descoberto desse jeito. Algo não cheira bem e não são os peixes!         |");
                Console.WriteLine("| Não tem como você ter sido descoberto sem sabotagem externa!                  |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreRavenclaw += 1;
                character.score -= 1;
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
            }

            return character;
        }


        //---------> BREAK <---------
        static void breakForNextChallenge(List<Character> character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                   DESCANSO                                    |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|           Finalmente encerra-se a segunda parte do desafio.                   |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Porém, alguns campeões tiveram dificuldades em cumprir sua parte do desafio. |");
            Console.WriteLine("| Preocupados com a possível sabotagem, decidiram investigar por conta própria, |");
            Console.WriteLine("| antes da etapa seguinte. Cada campeão decide investir seu tempo de formas     |");
            Console.WriteLine("| diferentes. Enquanto uns decidem procurar pistas sobre os rumores,            |");
            Console.WriteLine("| outros preparam-se para o próximo desafio.                                    |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Pressione Enter para continuar");
            Console.ReadLine();


            for (int i = 0; i < character.Count; i++)
            {
                if (character[i].isAlive)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                    DESCANSO                                   |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("| O que você prefere fazer:                                                     |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("| (1) Descansar no salão comunal                                                |");
                    Console.WriteLine("| (2) Investigar interferências nas provas                                      |");
                    Console.WriteLine("| (3) Contar as histórias do desafio para seus amigos                           |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.Write($"{character[i].name}, informe a opção desejada para continuar: ");
                    string option = Console.ReadLine();
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
                            character[i] = takeRest(character[i]);
                            break;

                        case "2":
                            character[i] = investigate(character[i]);
                            break;

                        case "3":
                            character[i] = tellStories(character[i]);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Você foi desclassificado! Infelizmente o torneio acabou para você, nade mais rápido da próxima vez!");

                }
            }

            RPG.ChessChallenge.wizardChessChallenge(character);
        }

        //---------> OPÇÂO 1 <---------
        static Character takeRest(Character character)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                            DESCANSAR NO SÃO COMUNAL                           |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Você escolheu descansar! Cansado, decidiu poupar as energias para o dia      |");
            Console.WriteLine("| seguinte. Nada como beber suco de abóbora junto aos seus amigos.              |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            character.house.scoreSlytherin += 1;
            character.life -= 1;

            return character;

        }

        //---------> OPÇÂO 2 <---------
        static Character investigate(Character character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                           INVESTIGAR INTERFERÊNCIAS                           |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Você escolheu investigar! A partir de agora role o dado para descobrir       |");
            Console.WriteLine("| alguma pista!                                                                 |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue > 10)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                    INVESTIGAR INTERFERÊNCIAS -- SUCESSO                       |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Encucado com os relatos estranhos durante a última prova, você decide        |");
                Console.WriteLine("| iniciar sua investigação nos terrenos ao redor do lago. Você acaba            |");
                Console.WriteLine("| encontrando pegadas próximas ao píer, em um barranco enlameado. Muito longe   |");
                Console.WriteLine("| das arquibancadas para que possam ter sido feitas por alguém que estivesse    |");
                Console.WriteLine("| assistindo à prova. Além disso, você encontra o mesmo tipo de cascalho        |");
                Console.WriteLine("| do fundo do lago, assim como alguns pedaços de algas, longe demais das        |");
                Console.WriteLine("| profundezas para ser coincidência. Você decide investigar mais.               |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreGryffindor += 2;
                character.house.scoreRavenclaw += 1;
                character.score += 1;

                Console.WriteLine();
                Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
                Console.ReadLine();
                diceValue = RPG.Dice.throwDice();
                Console.WriteLine($"O Valor do dado é {diceValue}");

                if (diceValue > 17)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                   AUMENTAR RAIO DE INVESTIGAÇÃO  -- SUCESSO                   |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|  Incrível! Durante o restante da sua investigação, você decide voltar para    |");
                    Console.WriteLine("| castelo e investigar na biblioteca ocorrências nos últimos torneios,          |");
                    Console.WriteLine("| você acaba encontrando o Mapa do Maroto! Ele pode te ajudar a descobrir       |");
                    Console.WriteLine("| quem está por trás das sabotagens.                                            |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    character.house.scoreRavenclaw += 2;
                    character.house.scoreGryffindor += 1;
                    character.hasMap = true;
                    character.score += 4;
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                AUMENTAR RAIO DE INVESTIGAÇÃO  --  FRACASSO                    |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|  Você procurou por mais pistas, mas sem sucesso. Melhor ir descansar e        |");
                    Console.WriteLine("| se preparar para o desafio de amanhã. Talvez tenha mais sorte no dia          |");
                    Console.WriteLine("| seguinte...                                                                   |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    character.house.scoreRavenclaw += 1;
                    character.house.scoreGryffindor += 2;
                    character.score -= 1;
                    character.life -= 1;

                    Console.WriteLine();
                    Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
                    Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();

                }
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                   INVESTIGAR INTERFERÊNCIAS  --  FRACASSO                     |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Eita, infelizmente sua investigação não levou a nada. Você só perdeu tempo!  |");
                Console.WriteLine("|  Boa sorte tentando não ficar cansado para a prova de amanhã...               |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreRavenclaw += 1;
                character.house.scoreGryffindor += 2;
                character.score -= 1;
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine($"{character.name}, você está com {character.life} pontos de vida.");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();


            }
            return character;
        }

        //---------> OPÇÂO 3 <---------
        static Character tellStories(Character character)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                 CONTAR HISTÓRIAS                              |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Você decide passar um tempo com seus amigos, contando do seu embate com os   |");
            Console.WriteLine("| sereianos, do perrengue de nadar contra o tempo. A conversa foi divertida     |");
            Console.WriteLine("| e você se sente com mais disposição para o dia seguinte!                      |");
            Console.WriteLine("| Ganhou um ponto de vida!                                                      |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            character.house.scoreHufflePuff += 1;
            character.life += 1;

            return character;
        }
    }
}
