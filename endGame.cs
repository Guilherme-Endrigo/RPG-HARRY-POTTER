using System;
using System.Collections.Generic;

namespace RPG
{

    class endGame
    {

        static int diceValue;

        public static void epilogue(List<Character> character, List<Character> characterDuel)
        {
            // if (Jogador1.pontos == Jogador2.pontos) ;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                O FIM DO LABIRINTO                             |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Ao chegar no fim do labirinto, vocês percebem que os desafios estavam mais |");
            Console.WriteLine("| perigosos e mortais do que deveriam. Alguns já se perderam até aqui, e        |");
            Console.WriteLine("| outros já foram desclassificados ou estão gravemente feridos. Apenas aqueles  |");
            Console.WriteLine("| com título de maior pontuador no torneio estão próximos! Porém, vocês não     |");
            Console.WriteLine("| estão sozinhos. Uma figura misteriosa se coloca frente a vocês, impedindo que |");
            Console.WriteLine("| que saiam dessa disputa.                                                      |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|   E a figura é...                                                             |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            RPG.Tune.enter();

            for (int i = 0; i < characterDuel.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                 O DESAFIANTE                                  |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Ninguém menos que o pai do Cedrico, Amos Diggory, convencido que a memória |");
                Console.WriteLine("| de seu filho não deve ser esquecida e que ninguém deve receber o título de    |");
                Console.WriteLine("|campeão. Ele realmente está determinado a não deixar haver mais um campeão,    |");
                Console.WriteLine("| mesmo que para isso precise matar alguém.                                     |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Ele rapidamente leva a mão à sua varinha, pronto para um duelo.            |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    No mundo mágico o duelo mágico é a forma mais honrosa de resolver algumas  |");
                Console.WriteLine("| disputas como essa, para manter o princípio da igualdade todas as suas        |");
                Console.WriteLine("| conquistas durante a jornada serão temporariamente esquecidas.                |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Você tem uma escolha importante a tomar:                                   |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|   (1) Você deseja sair correndo?                                              |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|   (2) Você deseja duelar?                                                     |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.Write($"{characterDuel[i].name}, informe a opção desejada para continuar: ");
                string option = Console.ReadLine();
                RPG.Tune.enter();

                while (option != "1" && option != "2" || option == "")
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção inválida, tente novamente");
                    Console.WriteLine();
                    Console.Write($"{characterDuel[i].name}, escolha novamente: ");
                    option = Console.ReadLine();
                    RPG.Tune.enter();
                }
                switch (option)
                {
                    case "1":
                        //se id do characterDuel == character att senão continua
                        characterDuel[i] = tryEscape(characterDuel[i]);
                        for (int j = 0; j >= character.Count; j++)
                        {
                            if (character[j].idChar == characterDuel[i].idChar)
                            {
                                character[j] = characterDuel[i];
                                continue;
                            }
                        }
                        break;

                    case "2":
                        characterDuel[i] = wandChoice(characterDuel[i]);
                        characterDuel[i] = wandDuel(characterDuel[i]);
                        characterDuel[i].isDraw = true;

                        for (int k = 0; k >= character.Count; k++)
                        {
                            if (character[k].idChar == characterDuel[i].idChar)
                            {
                                character[k] = characterDuel[i];
                                continue;
                            }
                        }
                        break;
                }
            }

            RPG.Update.biggestScore(character);
        }

        public static Character wandChoice(Character character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                  A ESCOLHA                                    |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Por favor, escolha qual varinha você deseja utilizar neste duelo, esta     |");
            Console.WriteLine("| será a única vantagem que você possuirá no duelo:                             |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| (1) Varinha de Cerejeira, rígida e feita com coração de Dragão;               |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| (2) Varinha de Castanheira, maleável e feita com núcleo de Unicórnio;         |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| (3) Varinha de Olmo, flexível e feita com pena de Fênix;                      |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| (4) Varinha de Pereira, rígida e feita com cabelo de Veela;                   |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine($"{character.name}, qual varinha você quer escolher?");
            string wand = Console.ReadLine();

            while (wand != "1" && wand != "2" && wand != "3" && wand != "4" || wand == "")
            {
                Console.WriteLine();
                Console.WriteLine("Opção inválida, tente novamente");
                Console.WriteLine();
                Console.Write($"{character.name}, escolha novamente: ");
                wand = Console.ReadLine();
                RPG.Tune.enter();
            }
            switch (wand)
            {
                case "1":
                    character.house.scoreGryffindor += 2;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                              VARINHA DE CEREJEIRA                             |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    A varinha escolhida nunca pode ficar nas mãos de um bruxo que não tenha    |");
                    Console.WriteLine("| excepcional controle sobre suas ações além de uma mente muito bem estruturada.|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();

                    break;

                case "2":
                    character.house.scoreHufflePuff += 2;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                             VARINHA DE CASTANHEIRA                            |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    A varinha escolhida se atrai por bruxos e bruxas que são habilidosos em    |");
                    Console.WriteLine("| domar criaturas mágicas, por aqueles que possuem grande aptidão em Herbologia |");
                    Console.WriteLine("| e os que são voadores natos e justos.                                         |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();

                    break;

                case "3":
                    character.house.scoreSlytherin += 2;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                VARINHA DE OLMO                                |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Acredita-se que apenas puros-sangues podem produzir magia a partir das     |");
                    Console.WriteLine("| varinhas de Olmo, conhecida pelos feitiços mais elegantes.                    |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();
                    break;

                case "4":
                    character.house.scoreRavenclaw += 2;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                               VARINHA DE PEREIRA                              |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Essa varinha de poderes mágicos esplêndidos se dá melhor nas mãos dos      |");
                    Console.WriteLine("| sábios. Donos dessas varinhas são normalmente populares e bem respeitados.    |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                    RPG.Tune.enter();
                    break;
            }

            return character;
        }

        public static Character wandDuel(Character character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                              UM ATAQUE INESPERADO                             |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|     Ele rapidamente levantou sua varinha e você tem que se defender antes de  |");
            Console.WriteLine("| de qualquer coisa.                                                            |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");


            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();

            int diceAmos = RPG.Dice.throwDice();

            int resultScore = diceAmos - diceValue;

            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");
            Console.WriteLine($"{character.name}, você lançou o feitiço...");
            string resultDefense = RPG.Update.spellDefense(diceValue);
            Console.WriteLine(resultDefense);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Amos contra-ataca e lança o feitiço!");
            diceAmos = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceAmos}");
            string resultAttack = RPG.Update.spellAttack(diceAmos);
            Console.WriteLine($"{resultAttack}");
            Console.WriteLine();
            Console.WriteLine();

            resultScore = diceAmos - diceValue;

            Console.WriteLine();
            Console.WriteLine("Rápido! Pressione ENTER para lançar o feitiço de defesa");
            Console.ReadLine();

            RPG.Tune.spell();

            Console.WriteLine();
            Console.WriteLine();
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");
            resultDefense = RPG.Update.spellDefense(diceValue);
            Console.WriteLine($"{character.name}, você lançou o feitiço para se defender...");
            Console.WriteLine(resultDefense);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Os animos estão ruins para o seu lado, Amos parece cada vez mais nervoso e ataca novamente!");
            diceAmos = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceAmos}");
            resultAttack = RPG.Update.spellAttack(diceAmos);
            Console.WriteLine($"{resultAttack}");


            resultScore = diceAmos - diceValue;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para contra-atacar com um feitiço!");
            Console.ReadLine();

            RPG.Tune.spell();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, está cada vez mais complicado para se defender!");
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");
            resultAttack = RPG.Update.spellAttack(diceValue);
            Console.WriteLine($"{resultAttack}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Amos tenta se defender do seu contra-golpe com um feitiço!");
            diceAmos = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceAmos}");
            resultDefense = RPG.Update.spellDefense(diceAmos);
            Console.WriteLine($"{resultDefense}");

            resultScore = diceAmos - diceValue;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para defender-se do feitiço!");
            Console.ReadLine();

            RPG.Tune.spell();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"{character.name}, você sente que o jogo está virando! Lançou o feitiço!");
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");
            resultAttack = RPG.Update.spellAttack(diceValue);
            Console.WriteLine($"{resultAttack}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Amos está ficando cansado, lançou o feitiço bem devagar!");
            diceAmos = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceAmos}");
            resultDefense = RPG.Update.spellDefense(diceAmos);
            Console.WriteLine($"{resultDefense}");

            resultScore = diceAmos - diceValue;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para tentar se defender novamente do feitiço de Amos!");
            Console.ReadLine();

            RPG.Tune.spell();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Em sequencia, lançou um feitiço de ataque pra tentar acabar com o duelo!");
            diceAmos = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceAmos}");
            resultAttack = RPG.Update.spellAttack(diceAmos);
            Console.WriteLine($"{resultAttack}");

            Console.WriteLine();
            Console.WriteLine();
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");
            resultDefense = RPG.Update.spellDefense(diceValue);
            Console.WriteLine($"{character.name}, você se defende!");
            Console.WriteLine(resultDefense);

            resultScore = diceAmos - diceValue;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para lançar um feitiço em Amos!");
            Console.ReadLine();

            RPG.Tune.spell();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{character.name}, com um último golpe você encerrou o duelo!");
            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");
            resultAttack = RPG.Update.spellAttack(diceValue);
            Console.WriteLine($"{resultAttack}");

            Console.WriteLine();
            Console.WriteLine();
            diceAmos = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceAmos}");
            resultDefense = RPG.Update.spellDefense(diceAmos);
            Console.WriteLine("Em uma tentativa final, Amos se defende!");
            Console.WriteLine(resultDefense);

            resultScore = diceAmos - diceValue;

            character.score = resultScore;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            RPG.Tune.enter();

            Console.WriteLine();
            Console.WriteLine($"{character.name}, o que mais te aguarda no fim desse torneio. Vamos esperar o discurso final...");
            Console.ReadLine();

            return character;

        }

        public static Character tryEscape(Character character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                VOCÊ ESCAPOU?                                  |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Você foge por sua vida. Não será lembrado por sua coragem, porém o medo    |");
            Console.WriteLine("| de sair sem vida dessa disputa é maior. Será que você consegue fugir e        |");
            Console.WriteLine("| disputar pelo título?                                                         |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();

            RPG.Tune.spell();

            diceValue = RPG.Dice.throwDice();
            RPG.Tune.diceSound(diceValue);
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue >= 6)
            {
                character.score -= 2;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                           ESSA PASSOU RASPANDO                                |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Você conseguiu fugir por pouco, porém isso não pegou bem na escola, porque |");
                Console.WriteLine("| ninguém soube do real perigo de morte iminente que enfrentou!                 |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

            }
            else
            {
                character.life = 0;
                character.isAlive = false;

                RPG.Tune.die();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                               VOCÊ VIROU ARTE                                 |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|     Você foi atingido pelo Petrificus Totalus Paralyticus, uma versão do      |");
                Console.WriteLine("| feitiço de paralisia com magia negra, capaz de transformar a vítima em pedra! |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Infelizmente, você não será capaz de continuar, porém será eternamente     |");
                Console.WriteLine("| lembrado por todos que verem a obra de arte no jardim que você se tornou      |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

            }

            return character;
        }

        public static void endTheGame(List<Character> character)
        {

            var isSomebodyAlive = character.Find(x => x.isAlive == true);

            if (isSomebodyAlive != null)
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                   O FIM?                                      |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Após esse grande susto, todos voltam até o salão comunal para ouvir dos ex |");
                Console.WriteLine("| alunos as palavras finais do torneio.                                         |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Parabéns a todos os participantes, este torneio foi apenas o começo do que |");
                Console.WriteLine("| sei que será uma jornada extraordinária – começou Neville.                    |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    O êxito da vida não se mede pelo caminho que você conquistou,  mas sim     |");
                Console.WriteLine("| pelas dificuldades superadas no caminho, e  o Torneio Tribruxo é sobre isso.  |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");


                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar ");
                Console.ReadLine();
                RPG.Tune.enter();

                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                            EXISTE VIDA PÓS TORNEIO?                           |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Encerra-se mais um ano letivo memorável em Hogwarts, onde contamos com as  |");
                Console.WriteLine("|  ilustres presenças de todos vocês, campeões, em uma edição histórica do      |");
                Console.WriteLine("|  Torneio Tribruxo. Alguns podem ter chegado ao final, e outros não.           |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  De qualquer forma, agradecemos a todos os professores envolvidos no          |");
                Console.WriteLine("|  desenvolvimento de cada desafio, todos foram cuidadosamente pensados com     |");
                Console.WriteLine("|  muito esmero por nosso corpo docente.                                        |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Cada campeão mostrou-se digno frente aos inúmeros obstáculos, demonstrando   |");
                Console.WriteLine("|  discernimento e clareza na tomada de decisões nas adversidades.              |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Agradecemos pela participação e parabenizamos os vencedores deste ano.       |");
                Console.WriteLine("| Esperamos que tenham aproveitado a sua estadia em Hogwarts, e aguardamos      |");
                Console.WriteLine("| ansiosos pela chegada do próximo Torneio Tribruxo! Até lá, nossas portas      |");
                Console.WriteLine("| estarão sempre abertas a recebê-los.                                          |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| Obrigado por participar!                                                      |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar ");
                Console.ReadLine();
                RPG.Tune.enter();

            }

            selectorHat(character);

            foreach (var player in character)
            {

                string alive = player.isAlive == true ? "Está vivo" : "Está morto/desclassificado";

                if (player.isAlive)
                {
                    Console.WriteLine($"Parabéns! {player.name}");
                    Console.WriteLine($"Casa do participante: {player.house.houseName}");
                    Console.WriteLine($"Sua pontuação no torneio: {player.score}");
                    Console.WriteLine($"Pontos de vida: {player.life}");
                    Console.WriteLine($"Status: {alive}");

                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                }

            }

            var isDead = character.FindAll(x => x.isAlive == false);

            if (isDead.Count != 0)
            {
                RPG.Drawings.tumb();
            }


            foreach (var player in character)
            {

                string alive = player.isAlive == true ? "Está vivo" : "Está morto/desclassificado";


                if (!player.isAlive)
                {
                    Console.WriteLine($"Sinto muito, {player.name}!");
                    Console.WriteLine($"Casa do participante: {player.house.houseName}");
                    Console.WriteLine($"Sua pontuação no torneio: {player.score}");
                    Console.WriteLine($"Pontos de vida: {player.life}");
                    Console.WriteLine($"Status: {alive}");

                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                }

            }

            RPG.Tune.EdwigesTune();


        }

        public static void selectorHat(List<Character> character)
        {

            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                 UMA SURPRESA                                  |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|    Ah! Espera um pouco, temos mais um recado a dar para vocês! Cada escolha   |");
            Console.WriteLine("|  tomada refletiu não apenas em vencer ou perder o torneio, mas serviu para    |");
            Console.WriteLine("| determinar o seu caráter durante os desafios, assim como suas características!|");
            Console.WriteLine("| Ao analisarmos cada um de seus momentos, determinamos que a casa a qual       |");
            Console.WriteLine("| você pertence é:                                                              |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");


            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar ");
            Console.ReadLine();
            RPG.Tune.enter();

            for (int i = 0; i < character.Count; i++)
            {
                character[i].house = RPG.Update.whatHouse(character[i]);
            }

            var hufflePuff = character.FindAll(x => x.house.houseName == "Lufa-lufa");

            if (hufflePuff.Count != 0)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                    LUFA-LUFA                                  |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Por sua gentileza, foram sorteados para a Lufa-lufa! Pacientes e honestos,   |");
                Console.WriteLine("|  trabalhadores e amigos incríveis! Porém, são extremamente ingênuos! Essa     |");
                Console.WriteLine("|  ingenuidade se reflete também nos números, sendo a casa com o menor número   |");
                Console.WriteLine("|  de bruxos das trevas já produzidos na história. Sem a sua compreensão, o     |");
                Console.WriteLine("|  mundo seria mais frio.                                                       |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.Write($"LUFANOS: ");

                foreach (var charHouse in hufflePuff)
                {

                    Console.Write($"{charHouse.name}; ");
                }

                Console.ResetColor();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar ");
                Console.ReadLine();
                RPG.Tune.enter();
            }


            var ravenclaw = character.FindAll(x => x.house.houseName == "Corvinal");

            if (ravenclaw.Count != 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                    CORVINAL                                   |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Como vocês já sabem, foram sorteados para a Corvinal! Se destacam por sua  |");
                Console.WriteLine("|  exímia inteligência, sabedoria e criatividade. Também são conhecidos por sua |");
                Console.WriteLine("|  excentricidade e perfeccionismo. Muitas vezes frios e insensíveis com os     |");
                Console.WriteLine("|  outros. Graças a sua inteligência, muito do que se conhece do mundo bruxo é  |");
                Console.WriteLine("|  devido a essa forma de enxergar o mundo.                                     |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.Write($"CORVINOS: ");

                foreach (var charHouse in ravenclaw)
                {

                    Console.Write($"{charHouse.name}; ");
                }

                Console.ResetColor();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar ");
                Console.ReadLine();
                RPG.Tune.enter();
            }
            //if (gryffindor)

            var gryffindor = character.FindAll(x => x.house.houseName == "Grifinória");

            if (gryffindor.Count != 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                   GRIFINÓRIA                                   |");
                Console.WriteLine("|------------------------------------------------------------------------------- |");
                Console.WriteLine("|                                                                                |");
                Console.WriteLine("|    Para os destemidos de plantão, irão para a Grifinória! São de extrema       |");
                Console.WriteLine("|  coragem, sempre se superando devido ao seu altruísmo! Aventureiros e leais!   |");
                Console.WriteLine("|  Porém, imprudentes e teimosos, alguns diriam egoístas. No entanto, o mundo,   |");
                Console.WriteLine("|  mesmo assim, precisa de coragem e inspiração de bruxos como vocês.            |");
                Console.WriteLine("|                                                                                |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.Write($"GRIFINÓRIOS: ");

                foreach (var charHouse in gryffindor)
                {

                    Console.Write($"{charHouse.name}; ");
                }

                Console.ResetColor();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar ");
                Console.ReadLine();
                RPG.Tune.enter();
            } //if (slytherin)

            var slytherin = character.FindAll(x => x.house.houseName == "Sonserina");

            if (slytherin.Count != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                   SONSERINA                                    |");
                Console.WriteLine("|------------------------------------------------------------------------------- |");
                Console.WriteLine("|                                                                                |");
                Console.WriteLine("|    Vocês que competiram com garra até o final, tentando sempre o seu melhor,   |");
                Console.WriteLine("| irão para a Sonserina! Membros da sonserina como vocês, são, sobretudo,        |");
                Console.WriteLine("| ambiciosos, presunçosos e egoístas. Porém, diferente do que muitos acham,      |");
                Console.WriteLine("| vocês também são grandes alunos, líderes natos, inteligentes e dedicados a     |");
                Console.WriteLine("| expandir e alcançar metas, além de perseguirem sua paixão com uma determinação |");
                Console.WriteLine("| que beira quase à teimosia. E talvez por seu senso de competição, as outras    |");
                Console.WriteLine("| casas não os vejam tão bem.                                                    |");
                Console.WriteLine("|                                                                                |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.Write($"SONSERINOS: ");

                foreach (var charHouse in slytherin)
                {

                    Console.Write($"{charHouse.name}; ");
                }

                Console.ResetColor();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar ");
                Console.ReadLine();
                RPG.Tune.enter();
            }

        }

    }
}

