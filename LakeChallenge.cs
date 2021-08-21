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

            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                    O LAGO                                     |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Após o susto do primeiro desafio, todos acordam mais dispostos e prontos   |");
            Console.WriteLine("| para a segunda tarefa do Torneio Tribruxo, encaminhando-se até o Lago Negro.  |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Algo importante, querido, deve ser resgatado do fundo do lago. Mas,        |");
            Console.WriteLine("| cuidado com aqueles que espreitam-se nas profundezas. Mergulhe de cabeça para |");
            Console.WriteLine("| recuperar o que foi perdido!                                                  |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine();
            RPG.Drawings.merPeople();
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            RPG.Tune.enter();


            for (int i = 0; i < character.Count; i++)
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                            DESAFIO DO LAGO NEGRO                              |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| Para que possa ficar tempo suficiente submerso no lago, você tem 3 opções:    |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| (1) Guelricho                                                                 |");
                Console.WriteLine("| (2) Feitiço Cabeça de Bolha                                                   |");
                Console.WriteLine("| (3) Transfigurar-se num peixe                                                 |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine();

                Console.Write($"{character[i].name}, informe a opção desejada para continuar: ");
                string option = Console.ReadLine();
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

                if (character[i].isBlocked == true)
                {
                    Console.WriteLine($"Eita! Surpresa, você não participará desse desafio, foi sabotado nessa rodada! hehehehe");
                    RPG.Tune.trap();
                    continue;
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

            if (character.hasPotion)
            {
                character.score += 1;
                character.life += 2;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                         AS NOITES SEM DORMIR COMPENSARAM                      |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|   Surpresa! A poção realmente foi útil!!!                                     |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|   Por dedicar-se aos estudos, você ganhou 2 ponto extras de vida!             |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine($"|   Está com {character.life} pontos de vida!                                                  |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();
            }

            character.house.scoreGryffindor += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                GUELRICHO! ÉCA                                 |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você escolheu engolir o guelricho! Blargh, a partir de agora role o dado   |");
            Console.WriteLine("| para descobrir os efeitos colaterais da sua decisão!                          |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue >= 11)
            {
                character.house.scoreHufflePuff += 2;
                character.score += 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                 QUASE UM TRITÃO                               |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Incrível, você consegue sentir os efeitos da planta tomando o seu corpo!   |");
                Console.WriteLine("| Guelras surgem no seu pescoço e membranas entre os dedos. Muito bem!          |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

            }
            else
            {
                character.house.scoreGryffindor += 1;
                character.score -= 1;
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" -------------------------------------------------------------------------------- ");
                Console.WriteLine("|                            O GOSTO RUIM DO FRACASSO                            |");
                Console.WriteLine("|--------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                                |");
                Console.WriteLine("|    Eita, algo de errado não está certo! Você engasgou com o guelricho e a      |");
                Console.WriteLine("| planta desceu pelo lado errado. Perdeu 1 ponto nessa jogada e seu tempo de     |");
                Console.WriteLine($"| prova foi encurtado! Está com {character.life} pontos de vida!                                |");
                Console.WriteLine("|                                                                                |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

            }

            return character;


        }

        //---------> OPÇÂO 2 <---------
        static Character bubbleHead(Character character)
        {
            character.house.scoreRavenclaw += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                           FEITIÇO CABEÇA DE BOLHA                             |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você escolheu utilizar o feitiço cabeça de bolha! Glub-glub, a partir de   |");
            Console.WriteLine("| agora role o para descobrir os efeitos colaterais da sua decisão!             |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue >= 11)
            {
                character.house.scoreRavenclaw += 1;
                character.score += 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                 SOPRANDO BOLHAS                               |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  O feitiço foi lançado com sucesso! Parabéns! Sua cabeça foi envolta por uma  |");
                Console.WriteLine("| bolha e seu tempo submerso aumentou por isso!                                 |");
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
                Console.WriteLine("|                           UMA REVIRAVOLTA DESESPERANTE                        |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  O feitiço virou-se contra o feiticeiro! A bolha estourou, você está ficando  |");
                Console.WriteLine("| sem ar, tente novamente na próxima rodada fugir desse destino!                |");
                Console.WriteLine($"| Está com {character.life} pontos de vida!                                                    |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
                Console.ReadLine();
                diceValue = RPG.Dice.throwDice();
                RPG.Tune.diceSound(diceValue);
                Console.WriteLine($"O Valor do dado é {diceValue}");

                if (diceValue >= 11)
                {

                    RPG.Tune.drowning();

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                            'AFOGANDO' COM O NAVIO                             |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Parabéns, você conseguiu fugir do seu destino! Nadou para fora do lago     |");
                    Console.WriteLine("| antes da bolha encher-se de água!                                             |");
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

                    RPG.Tune.underwater();

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                           UM DESTINO TRISTE! SNIFF SNIFF                      |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Ihhh, o seu tempo se esgotou! Você tentou nadar, mas se desesperou e não   |");
                    Console.WriteLine("| conseguiu bater as pernas rápido o bastante, ficando sem ar e perdendo a vida.|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");


                    Console.WriteLine($"Infelizmente o torneio acabou para você, {character.name}!");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();

                }


            }

            return character;

        }

        //---------> OPÇÂO 3 <---------
        static Character transfiguration(Character character)
        {
            character.house.scoreSlytherin += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                 TRANSFIGURAÇÃO                                |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você escolheu utilizar o feitiço de transfiguração! A partir de agora role |");
            Console.WriteLine("| o dado para descobrir se você se lembrou de entrar na água antes de se        |");
            Console.WriteLine("| transformar!                                                                  |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue >= 11)
            {
                character.house.scoreSlytherin += 1;
                character.score += 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                               ISSO QUE É PUBERDADE?                           |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    O seu corpo está mudando! Após muito estudo, sua transmutação ocorreu com  |");
                Console.WriteLine("| sucesso. Você se transformou num peixe!                                       |");
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
                Console.WriteLine("|                             A EVOLUÇÃO DEU ERRADO                             |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    O feitiço deu errado! Ao invés de transformá-lo inteiramente em um peixe,  |");
                Console.WriteLine("| apenas as suas pernas foram modificadas! Além da vergonha, você ficou sem     |");
                Console.WriteLine("| guelras pra te ajudar no desafio. Melhor nadar rápido! Humm, acho que não     |");
                Console.WriteLine($"| vai dar tempo de completar a prova. Está com {character.life} pontos de vida!                |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

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
            Console.WriteLine("|    Muito bem, campeões, hora de iniciar a busca pelo que foi roubado! O tempo |");
            Console.WriteLine("| está passando, cada competidor tem 1h para completar o desafio! Você está     |");
            Console.WriteLine("| nadando na floresta de algas no fundo do Lago Negro, quando avista seus       |");
            Console.WriteLine("| amigos presos pelos pés em uma armadilha.                                     |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            RPG.Tune.enter();



            for (int i = 0; i < character.Count; i++)
            {
                if (character[i].isBlocked == true)
                {
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                            DESAFIO DO LAGO NEGRO                              |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Mas espere! Parece que eles têm companhia, estão sendo vigiados por        |");
                Console.WriteLine("| sereianos! Você precisa resgatá-los! O que você pretende fazer?               |");
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
            character.house.scoreGryffindor += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                         LUTAR CONTRA OS SEREIANOS                             |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você escolheu enfrentar os sereianos! A partir de agora role o dado para   |");
            Console.WriteLine("| descobrir se a sua decisão deu certo! Boa sorte!                              |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");

            Console.WriteLine();

            if (diceValue >= 11)
            {
                character.house.scoreGryffindor += 1;
                character.score += 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                               FIGHT! SEREIANOS                                |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Petrificus Totalus! Deu certo, você pegou os sereianos desprevenidos!      |");
                Console.WriteLine("| Graças ao seu feitiço, todos foram petrificados! Parabéns! Conseguiu salvar o |");
                Console.WriteLine("| seu amigo a tempo de passar na prova!                                         |");
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
                Console.WriteLine("|                                    FINISH HIM                                 |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Oh, não! Os sereianos são muitos e você acaba sendo enrolado por eles      |");
                Console.WriteLine("| também. Como será que perceberam sua movimentação tão rápido? Só havia você e |");
                Console.WriteLine("| os outros competidores no lago, ou será que não? Perdeu um ponto e um vida    |");
                Console.WriteLine($"| nessa jogada e não vai ser possível completar a prova. Está com {character.life} pontos      |");
                Console.WriteLine("| de vida!                                                                      |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();
            }

            return character;
        }
        //---------> OPÇÂO 2 <---------
        static Character saveFriends(Character character)
        {

            character.house.scoreHufflePuff += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                           SALVAR TODOS OS REFÉNS                              |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você escolheu tentar salvar todos os reféns! Será que você tem ar          |");
            Console.WriteLine("|  suficiente? Jogue os dados para descobrir!                                   |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");


            if (diceValue >= 11)
            {
                character.house.scoreHufflePuff += 1;
                character.score += 1;
                character.life += 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                             UM RESGATE BEM-SUCEDIDO                           |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Confundus! Em uma jogada de mestre, você atordoou os sereianos e conseguiu |");
                Console.WriteLine("| livrar todos os reféns! Parabéns, você recebeu um ponto de vida a mais!       |");
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
                Console.WriteLine("|                                UMA TENTATIVA FALHA                            |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Oh, oh! Os sereianos ficaram bravos com você, apenas um amigo pode ser     |");
                Console.WriteLine("| salvo! Você foi mandando de volta pro início do lago! Acabou o tempo antes de |");
                Console.WriteLine($"| chegar aos reféns. Está com {character.life} pontos de vida!                                 |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

            }

            return character;
        }

        //---------> OPÇÂO 3 <---------
        static Character wooMerpeople(Character character)
        {

            character.house.scoreSlytherin += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                            PERSUADIR OS SEREIANOS                             |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você escolheu persuadir os sereianos a libertar seu amigo! Role os dados e |");
            Console.WriteLine("| veja o quão persuasivo você é!                                                |");
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
                character.house.scoreSlytherin += 1;
                character.score += 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                  BOM DE PAPO                                  |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Você escolheu atacar com diálogo e seu movimento foi super efetivo! Usando |");
                Console.WriteLine("| a lábia, conseguiu convencer os sereianos a te deixar libertar seu amigo!     |");
                Console.WriteLine("| Parabéns, receba um ponto pela ótima conversa!                                |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

            }
            else
            {
                character.house.scoreSlytherin += 1;
                character.score -= 1;
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                  TOMOU UM TOCO                                |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|   Muito ruim de papo! Os sereianos ficaram entediados com você! Infelizmente, |");
                Console.WriteLine("| sua lábia foi fraca e você só perdeu tempo! Os sereianos ficam irritados e    |");
                Console.WriteLine($"| você sai nadando o mais rápido possível! Está com {character.life} pontos de vida!           |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

            }
            return character;
        }

        //---------> OPÇÂO 4 <---------
        static Character enchantMerpeople(Character character)
        {

            character.house.scoreRavenclaw += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                           ENFEITIÇAR OS SEREIANOS                             |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você escolheu enfeitiçar os sereianos!! Role o dado e descubra se o        |");
            Console.WriteLine("| feitiço foi efetivo!                                                          |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue >= 11)
            {
                character.house.scoreRavenclaw += 1;
                character.score += 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                              UMA IDEIA BRILHANTE                              |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Incrível! Você conseguiu distrair os sereianos usando um novo feitiço.     |");
                Console.WriteLine("| Usando a sua varinha, você emitiu uma luz na direção oposta e atraiu os       |");
                Console.WriteLine("| sereianos para o outro lado, deixando o caminho livre para libertar os        |");
                Console.WriteLine("| reféns! Ganhou um ponto pela esperteza!                                       |");
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
                Console.WriteLine("|                                QUE CHEIRO É ESSE?                             |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Vish! Seu plano não deu certo, um dos sereianos ouviu um barulho próximo   |");
                Console.WriteLine("| de você e acabou percebendo o seu movimento com a varinha! Você estranha ter  |");
                Console.WriteLine("| sido descoberto desse jeito. Algo não cheira bem e não são os peixes!         |");
                Console.WriteLine("| Não tem como você ter sido descoberto sem sabotagem externa!                  |");
                Console.WriteLine($"| Está com {character.life} pontos de vida!                                                    |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

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
            Console.WriteLine("|              Finalmente encerra-se a segunda parte do desafio.                |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|     Porém, alguns campeões tiveram dificuldades em cumprir sua parte do       |");
            Console.WriteLine("| desafio. Preocupados com a possível sabotagem, decidiram investigar por conta |");
            Console.WriteLine("| própria, antes da etapa seguinte. Cada campeão decide investir seu tempo de   |");
            Console.WriteLine("| forma diferente. Enquanto uns decidem procurar pistas sobre os rumores,       |");
            Console.WriteLine("| outros preparam-se para o próximo desafio.                                    |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Pressione Enter para continuar");
            Console.ReadLine();
            RPG.Tune.enter();

            for (int i = 0; i < character.Count; i++)
            {
                if (character[i].isBlocked == true)
                {
                    Console.WriteLine($"{character[i].name}, após o final do desafio você finalmente consegue escapar da pegadinha!");
                    character[i].isBlocked = false;
                }

                if (character[i].isAlive)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                              O QUE FAZER AGORA?                               |");
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
                    Console.WriteLine("Você foi desclassificado! Infelizmente o Torneio acabou para você, nade mais rápido da próxima vez!");

                }
            }

            RPG.ChessChallenge.wizardChessChallenge(character);
        }

        //---------> OPÇÂO 1 <---------
        static Character takeRest(Character character)
        {

            character.house.scoreSlytherin += 2;
            character.life -= 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                          DESCANSAR NO SALÃO COMUNAL                           |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Você escolheu descansar! Cansado, decidiu poupar as energias para o dia      |");
            Console.WriteLine("| seguinte. Nada como beber suco de abóbora junto aos seus amigos.              |");
            Console.WriteLine($"| Está com {character.life} pontos de vida!                                                    |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");


            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            RPG.Tune.enter();

            return character;

        }

        //---------> OPÇÂO 2 <---------
        static Character investigate(Character character)
        {
            character.house.scoreGryffindor += 1;
            character.house.scoreRavenclaw += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                           INVESTIGAR INTERFERÊNCIAS                           |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você escolheu investigar! A partir de agora role o dado para descobrir     |");
            Console.WriteLine("| alguma pista!                                                                 |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
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
                Console.WriteLine("|                                QUAL O DESFECHO?                               |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|   Encucado com os relatos estranhos durante a última prova, você decide       |");
                Console.WriteLine("| iniciar sua investigação nos terrenos ao redor do lago. Você acaba            |");
                Console.WriteLine("| encontrando pegadas próximas ao píer, em um barranco enlameado. Muito longe   |");
                Console.WriteLine("| das arquibancadas para que possam ter sido feitas por alguém que estivesse    |");
                Console.WriteLine("| assistindo à prova. Além disso, você encontra o mesmo tipo de cascalho        |");
                Console.WriteLine("| do fundo do lago, assim como alguns pedaços de algas, longe demais das        |");
                Console.WriteLine("| profundezas para ser coincidência. Você decide investigar mais.               |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"{character.name}, pressione ENTER para jogar o dado.");
                Console.ReadLine();
                diceValue = RPG.Dice.throwDice();
                RPG.Tune.diceSound(diceValue);
                Console.WriteLine($"O Valor do dado é {diceValue}");

                if (diceValue > 15)
                {
                    character.house.scoreRavenclaw += 1;
                    character.hasMap = true;
                    character.score += 4;

                    RPG.Tune.item();

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                        AUMENTAR RAIO DE INVESTIGAÇÃO                          |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|   Incrível! Durante o restante da sua investigação, você decide voltar para o |");
                    Console.WriteLine("| castelo e investigar na biblioteca ocorrências nos últimos torneios,          |");
                    Console.WriteLine("| você acaba encontrando o Mapa do Maroto! Ele pode te ajudar a descobrir       |");
                    Console.WriteLine("| quem está por trás das sabotagens.                                            |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();

                }

                else
                {
                    character.house.scoreGryffindor += 1;
                    character.score -= 1;
                    character.life -= 1;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                FOI POR POUCO!                                 |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|   Você procurou por mais pistas, mas sem sucesso. Melhor ir descansar e se    |");
                    Console.WriteLine("| preparar para o desafio de amanhã. Talvez tenha mais sorte no dia seguinte... |");
                    Console.WriteLine($"| Está com {character.life} pontos de vida!                                                    |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();

                }
            }

            else
            {
                character.score -= 1;
                character.life -= 1;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                               VOCÊ DESCOBRIU ALGO?                            |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Eita, infelizmente sua investigação não levou a nada. Você só perdeu tempo!  |");
                Console.WriteLine("|  Boa sorte tentando não ficar cansado para a prova de amanhã...               |");
                Console.WriteLine($"|  Está com {character.life} pontos de vida!                                                   |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                RPG.Tune.enter();

            }
            return character;
        }

        //---------> OPÇÂO 3 <---------
        static Character tellStories(Character character)
        {
            character.house.scoreHufflePuff += 2;
            character.life += 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                 CONTAR HISTÓRIAS                              |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você decide passar um tempo com seus amigos, contando do seu embate com os |");
            Console.WriteLine("| sereianos, do perrengue de nadar contra o tempo. A conversa foi divertida e   |");
            Console.WriteLine("| você se sente com mais disposição para o dia seguinte! Ganhou um ponto de     |");
            Console.WriteLine($"| vida! Está com {character.life} pontos de vida!                                              |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            RPG.Tune.enter();

            return character;
        }
    }
}
