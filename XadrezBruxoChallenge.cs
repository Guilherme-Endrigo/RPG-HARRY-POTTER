using System;
using System.Collections.Generic;

namespace RPG
{
    class ChessChallenge
    {
        static int diceValue;

        public static void wizardChessChallenge(List<Character> character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                   XADREZ BRUXO                                |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|                      Começou um novo dia e Vamos ao jogo!                     |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Em meio ao caos, as luzes se acendem e você está em um grande tabuleiro    |");
            Console.WriteLine("| de xadrez. Do outro lado do tabuleiro há uma porta, porém para chegar         |");
            Console.WriteLine("| até ela e descobrir seus mistérios, temos que jogar o Xadrez Bruxo.           |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| As pessoas são peões em um tabuleiro de xadrez. Guiadas por mãos desconhecidas|");
            Console.WriteLine("| servem apenas para serem sacrificadas por um objetivo maior.                  |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|                    Suba na sua peça e vamos ao jogo!                          |");
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
                Console.WriteLine("|                             XADREZ DE BRUXO!                                  |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| Agora, você tem 3 opções:                                                     |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| (1) Cavalo do Rei                                                             |");
                Console.WriteLine("| (2) Torre da Rainha                                                           |");
                Console.WriteLine("| (3) Bispo Negro                                                               |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

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
                        character[i] = kingHorse(character[i]);
                        break;
                    case "2":
                        character[i] = queenTower(character[i]);
                        break;
                    case "3":
                        character[i] = blackBishop(character[i]);
                        break;
                }
            }

            RPG.Dragon.breakAfterDragonsChallenge(character);
        }

        //--------> OPÇÃO 1 <----------
        static Character kingHorse(Character character)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                 CAVALO DO REI                                 |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|  Cavalo do rei uma escolha de sorte e coragem                                 |");
            Console.WriteLine("| você se sacrificou para vencer o jogo!                                        |");
            Console.WriteLine("| Após o lance que move o cavalo para a h3                                      |");
            Console.WriteLine("| o bispo poderá se encaminhar para o xeque-mate graças a sua jogada            |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado: ");
            Console.ReadLine();

            character.house.scoreRavenclaw += 1;

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
                Console.WriteLine("|                           CAVALO DO REI  --  SUCESSO                          |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Magnífico, é preciso muita coragem e lealdade,                             |");
                Console.WriteLine("| para se sacrificar para um bem maior, você teve um jogo digno de grande mestre|");
                Console.WriteLine("| como dizia um Grande Mestre:                                                  |");
                Console.WriteLine("|      -Não há nenhum grande mestre de xadrez que seja normal, diferenciam-se   |");
                Console.WriteLine("| apenas pela magnitude da loucura.                                             |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|              Ganhou dois ponto por isso :D                                    |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.score += 2;

                if (character.name == "Rony Wesley")
                {

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                           ESTER EGG ENCONTRADO                                 |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|     Shazam! Por ter o mesmo nome que o corajoso Ronald Bilius Weasley,        |");
                    Console.WriteLine("| você ganhou mais um ponto de vida.                                            |");
                    Console.WriteLine("| Parabéns! Aqui vão 5 pontos extras por essa conquista                         |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    character.score += 5;
                    character.life++;

                }
            }
            else
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                           CAVALO DO REI   --  FRACASSO                        |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Lindo xeque no rei, mas não foi o suficiente, a Rainha do adversário       |");
                Console.WriteLine("| acabou com você te reduzindo a pó, está fora do jogo de xadrez!               |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|  Que pena acabou de perder um ponto e uma vida”                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
            }

            character.score++;
            character.life++;

            return character;
        }

        //---------> OPÇÃO 2 <---------
        static Character queenTower(Character character)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|   Torre da rainha uma escolha de garantia.                                    |");
            Console.WriteLine("| você ficou observando o jogo sem correr grande perigo até o momento!          |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            character.house.scoreHufflePuff += 1;


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
                Console.WriteLine("|                           TORRE DA RAINHA  --  SUCESSO                        |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|   Após o lance cavalo na h3, uma jogada de honra, sacrificando-o              |");
                Console.WriteLine("| para vencer o jogo, você se manteve no lugar,                                 |");
                Console.WriteLine("| lembrando que está em um tabuleiro e que todo o movimento conta!              |");
                Console.WriteLine("| Parabéns! Você ganhou um ponto por isso :D                                    |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.score += 1;

            }
            else
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                        TORRE DA RAINHA --  FRACASSO                           |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Vish, parece que ao ver o sacrifício do cavalo na h3,                      |");
                Console.WriteLine("| você correu até lá para ajudar, além de ter feito uma jogada em vão,          |");
                Console.WriteLine("| sniff sniff, acabou de perder um ponto e uma vida”                            |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.score -= 1;
                character.life -= 1;
            }

            return character;
        }

        //---------> OPÇÃO 3 <---------
        static Character blackBishop(Character character)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                    BISPO NEGRO                                |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|   Bispo Negro, após o sacrificio de cavalo h3, uma jogada de honra e coragem  |");
            Console.WriteLine("|  o XEQUE MATE ficou por sua conta!                                            |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine();

            character.house.scoreGryffindor += 1;
            character.house.scoreSlytherin += 1;

            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            if (diceValue >= 6)
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" -------------------------------------------------------------------------------");
                Console.WriteLine("|                             BISPO NEGRO - BEM PENSADO                         |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Com muita sabedoria você conteve a torre da rainha no seu devido lugar,    |");
                Console.WriteLine("| e assim podendo efetuar seu lance!                                            |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| Jogue o dado novamente para tentar o xeque mate!”                             |");
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
                    Console.WriteLine("|                           BISPO NEGRO  --  SUCESSO                            |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Parabéns! Seu xeque mate foi magnífico, deixando seu adversário em pedaços |");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|   URRUL! Bônus de 5 pontos por essa conquista,  e também um ponto de vida”    |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    character.score += 5;
                    character.life += 1;
                }
                else
                {

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                           BISPO NEGRO  --  FRACASSO                           |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Ih não foi dessa vez. Você avançou o número de casas de maneira errada,    |");
                    Console.WriteLine("| e foi decapitado pela rainha,  perdeu um ponto e um ponto de vida             |");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    character.score -= 1;
                    character.life -= 1;
                }

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                           BISPO NEGRO  --  FRACASSO                           |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    “Grrr parece que a torre da rainha se movimentou na sua vez,               |");
                Console.WriteLine("| o adversário além de derrotar a torre, conseguiu se defender do xeque mate.   |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| menos três pontos e uma vida a menos                                          |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.score -= 3;
                character.life -= 1;
            }

            return character;
        }


        //---------> BREAK <-----------
        public static void breakAfterXadrezBruxoChallenge(List<Character> character)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                   DESCANSO                                    |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|                     O Xadrez de bruxo chegou ao seu fim                       |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Onde rolou muita emoção! Agora você precisa descansar,                     |");
            Console.WriteLine("| Após esse grande desafio, voce poderá escolher algo para fazer,               |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|                     Bom vamos lá para as suas opções.                         |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Pressione Enter para continuar");
            Console.ReadLine();

            for (int i = 0; i < character.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                    DESCANSO                                   |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| Faça uma escolha:                                                             |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("| (1) Fazer uma festa no Salão Principal com os irmãos Weasley                  |");
                Console.WriteLine("| (2) Tirar cochilo                                                             |");
                Console.WriteLine("| (3) Relaxar na estufa da Prof. Sprout                                         |");
                Console.WriteLine("| (4) Ir visitar Hagrid                                                         |");
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
                        character[i] = mainHallParty(character[i]);
                        break;
                    case "2":
                        character[i] = nap(character[i]);
                        break;
                    case "3":
                        character[i] = relaxInTheGreenHouse(character[i]);
                        break;
                    case "4":
                        character[i] = visitHagrid(character[i]);
                        break;
                }
            }
            RPG.Lake.lakeChallenge(character);
        }
        //---------> OPÇÃO 1 <---------
        static Character mainHallParty(Character character)
        {

            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");


            if (diceValue >= 6)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" -------------------------------------------------------------------------------- ");
                Console.WriteLine("|                          FESTA NO SALÃO PRINCIPAL  --  SUCESSO                 |");
                Console.WriteLine("|-------------------------------------------------------------------------------- |");
                Console.WriteLine("|                                                                                 |");
                Console.WriteLine("| Conseguiu novas amizades com essa festa, tempos difíceis revelam grandes amigos |");
                Console.WriteLine("|                                                                                 |");
                Console.WriteLine(" -------------------------------------------------------------------------------- ");

                character.house.scoreRavenclaw += 1;
                character.life += 1;


            }
            else
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                          FESTA NO SALÃO PRINCIPAL  --  FRACASO                |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Você não fez nenhuma amizade, porém já dizia o ditado não                  |");
                Console.WriteLine("|                  ”não a pior inimigo que falso amigo”                         |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreRavenclaw += 1;
            }
            return character;
        }

        //---------> OPÇÃO 2 <---------
        static Character nap(Character character)
        {



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
                Console.WriteLine("|                      TIRAR COCHILO  --  SUCESSO                               |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Que sono revigorante, e teve um sonho,                                     |");
                Console.WriteLine("| através dele você aprendeu a como abrir o Oráculo dos sonhos!                 |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreSlytherin += 1;
                character.life += 1;
            }
            else
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                      TIRAR COCHILO  --  FRACASSO                              |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    “Acho que alguém dormiu muito, ZzzzZzZ, te deram a poção do morto vivo”    |");
                Console.WriteLine("|        não conseguiu realizar nenhuma ação e dormiu por dias.                 |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreSlytherin += 1;
                character.score -= 1;
            }
            return character;
        }

        //---------> OPÇÃO 3 <---------
        static Character relaxInTheGreenHouse(Character character)
        {

            Console.WriteLine();
            Console.WriteLine($"{character.name}, Pressione ENTER para jogar o dado.");
            Console.ReadLine();
            diceValue = RPG.Dice.throwDice();
            Console.WriteLine($"O Valor do dado é {diceValue}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                     RELAXAR NA ESTUDA DA PROF SPROUT                          |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Na estufa da prof Sprout, podemos encontrar desde as plantas mais estranhas|");
            Console.WriteLine("| e os fungos do mundo mágico                                                   |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            character.house.scoreHufflePuff += 1;

            if (diceValue >= 6)
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                     RELAXAR NA ESTUDA DA PROF SPROUT - SUCESSO                |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|              “Você achou uma poção para reverter quem foi petrificado.”       |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreHufflePuff += 1;
                character.score += 1;

            }
            else
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                     RELAXAR NA ESTUDA DA PROF SPROUT - FRACASSO               |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Shazam! Você foi petrificado pelo Basilisco de Salazar Slytherin, que azar |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreHufflePuff += 1;
                character.score -= 1;
                character.life -= 1;

            }
            return character;
        }

        //---------> OPÇÃO 4 <---------
        static Character visitHagrid(Character character)
        {

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
                Console.WriteLine("|                          IR VISITAR HAGRID - SUCESSO                          |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    “Como diz Rúbeo Hagrid: “Eu sou o que sou e eu não tenho vergonha”,        |");
                Console.WriteLine("| você ganhou um delicioso bolo feito com muito amor <3.                        |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreGryffindor += 1;
                character.score += 1;
                character.life += 1;

            }
            else
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                          IR VISITAR HAGRID - FRACASSO                         |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    “Xiiii, Hagrid te levou para a floresta proibida                           |");
                Console.WriteLine("| e para seu azar o zelador te viu e te levou a diretoria”                      |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                character.house.scoreGryffindor += 1;
                character.score -= 1;
                character.life -= 1;

            }
            return character;
        }
    }
}



