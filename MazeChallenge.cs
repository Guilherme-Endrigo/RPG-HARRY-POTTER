using System;
using System.Collections.Generic;

namespace RPG
{
    class Maze
    {
      static int dice;

        public static void mazeChallenge(List<Character> characters)
        {

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

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();

          for (int a = 0; a < characters.Count; a++) {
            if (characters[a].hasMap) {
          Console.WriteLine($"JOGADOR ATUAL: {characters[a].name}:");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                   LABIRINTO                                   |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|                                 Mapa do Maroto                                |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine($"|    Ah, que incrível! Você possui o Mapa do Maroto e tem a vantagem de saber  |");
            Console.WriteLine("| qual o melhor caminho do labirinto e onde os seus concorrentes estão! Siga    |");
            Console.WriteLine("| direto para o final ou escolha enfrentar os desafios:                         |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| (1) USAR O MAPA E IR DIRETO PARA O FINAL DO LABIRINTO                         |");
            Console.WriteLine("| (2) ENFRENTAR OS DESAFIOS                                                     |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            int optionMap;
            do {
              Console.Write("Sua escolha é: ");
              optionMap = Int32.Parse(Console.ReadLine());
              if (optionMap != 1 && optionMap != 2) Console.WriteLine("Opção inválida");
            } while (optionMap != 1 && optionMap != 2);
          
          switch (optionMap)
          {
            case 1:
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                   LABIRINTO                                   |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|                                 Mapa do Maroto                                |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Sábia decisão, querido bruxo, você pulou QUASE todos os obstáculos do la-  |");
            Console.WriteLine("| birinto... Infelizmente, nem o Mapa poderia ter previsto a presença da eni-   |");
            Console.WriteLine("| gmática Esfinge ao final do labirinto. Como guerreiro, resta a você enfren-   |");
            Console.WriteLine("| tar esse desafio. Se você está jogando com um ou mais amigos, espere que ele  |");
            Console.WriteLine("| enfrente os desafios e labirinto e, então, vocês enfrentarão o último desafio.|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine($"Pressione ENTER para continuar");
            Console.ReadLine();
          break;
          case 2:
          characters[a].hasMap = false;
          break;
          }
          }
        } 
      mazeDirections(characters);
}

            static void mazeDirections(List<Character> characters)
            {
              for (int i = 0; i < characters.Count; i++) {
                if (!characters[i].hasMap){
                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                   LABIRINTO                                   |");
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
                int optionDirections;
                do
                {
                    Console.Write("Sua resposta é: ");
                    optionDirections = Int32.Parse(Console.ReadLine());
                    if (optionDirections != 1 && optionDirections != 2 && optionDirections != 3) Console.WriteLine("Opção inválida");
                } while (optionDirections != 1 && optionDirections != 2 && optionDirections != 3);

                switch (optionDirections)
                {
                    case 1:
                        characters[i] = devilsSnareMaze(characters[i]);
                        break;
                    case 2:
                        characters[i] = blastEndedSkrewtMaze(characters[i]);
                        break;
                    case 3:
                        characters[i] = boggartMaze(characters[i]);
                        break;
                }


                static Character devilsSnareMaze(Character character)
                {
                  Console.WriteLine($"JOGADOR ATUAL: {character.name}");
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                 VISGO DO DIABO                                |");
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
                    int optionDevilsSnareMaze;
                    do
                    {
                        Console.Write("Sua resposta é: ");
                        optionDevilsSnareMaze = Int32.Parse(Console.ReadLine());
                        if (optionDevilsSnareMaze != 1 && optionDevilsSnareMaze != 2 && optionDevilsSnareMaze != 3) Console.WriteLine("Opção inválida");
                    } while (optionDevilsSnareMaze != 1 && optionDevilsSnareMaze != 2 && optionDevilsSnareMaze != 3);

                    switch (optionDevilsSnareMaze)
                    {
                      case 1:
                          character.house.scoreSlytherin++;
                          character.house.scoreHufflePuff++;
                          character.house.scoreGryffindor++;

                          dice = RPG.Dice.throwDice();
                          Console.WriteLine("DADO LANÇADO!");
                          Console.WriteLine($"Você tirou: {dice}");

                          if (dice >= 6 && dice <= 17) {

                          character.house.scoreRavenclaw++;
                          character.score++;
                          character.life++;

                          Console.WriteLine(" ------------------------------------------------------------------------------- ");
                          Console.WriteLine("|                                 VISGO DO DIABO                                |");
                          Console.WriteLine("|-------------------------------------------------------------------------------|");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine("|  Você conseguiu se livrar do Visgo! Continue seu caminho com +1 vida e ponto. |");
                          Console.WriteLine(" ------------------------------------------------------------------------------- ");
                          
                          } else if (dice >= 18) {

                          character.house.scoreRavenclaw++;
                          character.score += 2;
                          character.life++;

                          Console.WriteLine(" ------------------------------------------------------------------------------- ");
                          Console.WriteLine("|                                 VISGO DO DIABO                                |");
                          Console.WriteLine("|-------------------------------------------------------------------------------|");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine("|Você conseguiu se livrar do Visgo! Continue seu caminho com +1 vida e +2 pontos|");
                          Console.WriteLine(" ------------------------------------------------------------------------------- ");

                          } else {
                            
                          character.house.scoreHufflePuff++;
                          character.score--;
                          character.life--;

                          Console.WriteLine(" ------------------------------------------------------------------------------- ");
                          Console.WriteLine("|                                 VISGO DO DIABO                                |");
                          Console.WriteLine("|-------------------------------------------------------------------------------|");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine("|    Você foi muito corajoso(a/e), mas não conseguiu realizar o feitiço. Tente  |");
                          Console.WriteLine("| outra estratégia:                                                             |");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine("| (1) FICAR PARADO ATÉ O EFEITO PASSAR                                          |");
                          Console.WriteLine("| (2) GRITAR POR AJUDA E TORCER PARA QUE ALGUÉM APAREÇA                         |");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine(" ------------------------------------------------------------------------------- ");

                          Console.WriteLine();
                          int optionDevilsSnareMazeFail;
                          do {
                          Console.Write("Sua resposta é: ");
                          optionDevilsSnareMazeFail = Int32.Parse(Console.ReadLine());
                          if (optionDevilsSnareMazeFail != 1 && optionDevilsSnareMazeFail != 2 && optionDevilsSnareMazeFail != 3) Console.WriteLine("Opção inválida"); 
                          } while (optionDevilsSnareMazeFail != 1 && optionDevilsSnareMazeFail != 2 && optionDevilsSnareMazeFail != 3);

                          switch (optionDevilsSnareMazeFail)
                          {
                          case 1:
                          
                          character.isAlive = false;

                          Console.WriteLine(" ------------------------------------------------------------------------------- ");
                          Console.WriteLine("|                                 VISGO DO DIABO                                |");
                          Console.WriteLine("|-------------------------------------------------------------------------------|");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine("|    O efeito não passa e você é engolido pela planta. Por isso, você é obriga- |");
                          Console.WriteLine("| do a desistir do jogo. Tchauzinho :(                                          |");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine(" ------------------------------------------------------------------------------- ");

                          Console.WriteLine();
                          Console.WriteLine("Pressione ENTER para continuar");
                          Console.ReadLine();
                          break;
                          case 2:

                          dice = RPG.Dice.throwDice();
                          Console.WriteLine("DADO LANÇADO!");
                          Console.WriteLine($"Você tirou: {dice}");

                          if (dice >= 6 && dice <= 17) {
                            
                          character.house.scoreHufflePuff++;
                          character.house.scoreRavenclaw++;
                          character.score++;
                          character.life++;

                          Console.WriteLine(" ------------------------------------------------------------------------------- ");
                          Console.WriteLine("|                                 VISGO DO DIABO                                |");
                          Console.WriteLine("|-------------------------------------------------------------------------------|");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine("|    PUFF! Dobby aparece e atende o seu pedido de ajuda, tirando-te dos tentá-  |");
                          Console.WriteLine("| culos do visgo com um estalo dos dedos. Você ganhou um ponto e uma vida!      |");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine(" ------------------------------------------------------------------------------- ");

                          Console.WriteLine();
                          Console.WriteLine("Pressione ENTER para continuar");
                          Console.ReadLine();

                          } else if (dice >= 18) {

                          character.house.scoreHufflePuff++;
                          character.house.scoreRavenclaw++;
                          character.score += 2;
                          character.life++;

                          Console.WriteLine(" ------------------------------------------------------------------------------- ");
                          Console.WriteLine("|                                 VISGO DO DIABO                                |");
                          Console.WriteLine("|-------------------------------------------------------------------------------|");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine("|    PUFF! Dobby aparece e atende o seu pedido de ajuda, tirando-te dos tentá-  |");
                          Console.WriteLine("| culos do visgo com um estalo dos dedos. Você ganhou 2 pontos e uma vida!      |");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine(" ------------------------------------------------------------------------------- ");

                          Console.WriteLine();
                          Console.WriteLine("Pressione ENTER para continuar");
                          Console.ReadLine();

                          
                          } else {
                            
                          character.score--;
                          character.life--;

                          Console.WriteLine(" ------------------------------------------------------------------------------- ");
                          Console.WriteLine("|                                 VISGO DO DIABO                                |");
                          Console.WriteLine("|-------------------------------------------------------------------------------|");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine("|    PUFF! Dobby aparece e atende o seu pedido de ajuda, tirando-te dos tentá-  |");
                          Console.WriteLine("| culos do visgo com um estalo dos dedos.Mas você perdeu um score e uma life :( |");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine(" ------------------------------------------------------------------------------- ");

                          Console.WriteLine();
                          Console.WriteLine("Pressione ENTER para continuar");
                          Console.ReadLine();
                          }
                          break;
                          }
                        }
                        break;
                      case 2:
                      
                            character.score--;
                            character.life--;
                            character.house.scoreHufflePuff++;

                            Console.WriteLine(" ------------------------------------------------------------------------------- ");
                            Console.WriteLine("|                                 VISGO DO DIABO                                |");
                            Console.WriteLine("|-------------------------------------------------------------------------------|");
                            Console.WriteLine("|                                                                               |");
                            Console.WriteLine("|    O efeito não passa e você é totalmente preso pela planta, ficando sem mo-  |");
                            Console.WriteLine("| vimentos e impossibilitado de sequer fazer um feitiço direcionado à planta.   |");
                            Console.WriteLine("| Sua única saída é emitir o sinalizador vermelho e desistir do jogo. Tchauzi-  |");
                            Console.WriteLine("| nho :(                                                                        |");
                            Console.WriteLine("|                                                                               |");
                            Console.WriteLine(" ------------------------------------------------------------------------------- ");

                            Console.WriteLine();
                            Console.WriteLine("Pressione ENTER para continuar");
                            Console.ReadLine();
                            break;
                      case 3:
                            
                            character.house.scoreHufflePuff++;

                            dice = RPG.Dice.throwDice();
                            Console.WriteLine("DADO LANÇADO!");
                            Console.WriteLine($"Você tirou: {dice}");

                            if (dice >= 6 && dice <= 17) {
                              
                              character.score++;
                              character.life++;

                              Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              Console.WriteLine("|                                 VISGO DO DIABO                                |");
                              Console.WriteLine("|-------------------------------------------------------------------------------|");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine("|    PUFF! Dobby aparece e atende o seu pedido de ajuda, tirando-te dos tentá-  |");
                              Console.WriteLine("| culos do visgo com um estalo dos dedos. Você ganhou um ponto e uma vida!      |");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");

                              Console.WriteLine();
                              Console.WriteLine("Pressione ENTER para continuar");
                              Console.ReadLine();

                            } else if (dice >= 18) {

                            character.score++;
                            character.life++;

                              Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              Console.WriteLine("|                                 VISGO DO DIABO                                |");
                              Console.WriteLine("|-------------------------------------------------------------------------------|");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine("|    PUFF! Dobby aparece e atende o seu pedido de ajuda, tirando-te dos tentá-  |");
                              Console.WriteLine("| culos do visgo com um estalo dos dedos. Você ganhou 2 pontos e uma vida!      |");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");

                              Console.WriteLine();
                              Console.WriteLine("Pressione ENTER para continuar");
                              Console.ReadLine();
                            
                            } else {
                              
                              character.score--;
                              character.life--;

                              Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              Console.WriteLine("|                                 VISGO DO DIABO                                |");
                              Console.WriteLine("|-------------------------------------------------------------------------------|");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine("|    PUFF! Dobby aparece e atende o seu pedido de ajuda, tirando-te dos tentá-  |");
                              Console.WriteLine("| culos do visgo com um estalo dos dedos.Mas você perdeu um score e uma life :( |");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");

                              Console.WriteLine();
                              Console.WriteLine("Pressione ENTER para continuar");
                              Console.ReadLine();
                            }
                            break;
                    }

                    return character;
                }

                static Character blastEndedSkrewtMaze(Character character)
                {
                  Console.WriteLine($"JOGADOR ATUAL: {character.name}");
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
                    int optionBlastEndedSkrewt;
                    do
                    {
                        Console.Write("Sua resposta é: ");
                        optionBlastEndedSkrewt = Int32.Parse(Console.ReadLine());
                        if (optionBlastEndedSkrewt != 1 && optionBlastEndedSkrewt != 2) Console.WriteLine("Opção inválida");
                    } while (optionBlastEndedSkrewt != 1 && optionBlastEndedSkrewt != 2);

                    switch (optionBlastEndedSkrewt)
                    {
                        case 1:
                            dice = RPG.Dice.throwDice();
                            Console.WriteLine("DADO LANÇADO!");
                            Console.WriteLine($"Você tirou: {dice}");

                            if (dice >= 6 && dice <= 17) {
                              
                            character.score++;
                            character.life++;
                            character.house.scoreGryffindor++;
                            character.house.scoreRavenclaw++;
                            character.house.scoreSlytherin++;

                              Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              Console.WriteLine("|                                   EXPLOSIVIM                                  |");
                              Console.WriteLine("|-------------------------------------------------------------------------------|");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine("|    Uau, que batalha, hein? Siga o seu caminho, guerreiro... E ganhe um score  |");
                              Console.WriteLine("| e uma life por isso!                                                          |");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");

                              Console.WriteLine();
                              Console.WriteLine("Pressione ENTER para continuar");
                              Console.ReadLine();

                            } else if (dice >= 18) {

                            character.score += 2;
                            character.life++;
                            character.house.scoreGryffindor++;
                            character.house.scoreRavenclaw++;
                            character.house.scoreSlytherin++;

                              Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              Console.WriteLine("|                                   EXPLOSIVIM                                  |");
                              Console.WriteLine("|-------------------------------------------------------------------------------|");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine("|    Uau, que batalha, hein? Siga o seu caminho, guerreiro... E ganhe 2 pontos  |");
                              Console.WriteLine("| e uma vida por isso!                                                          |");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");

                              Console.WriteLine();
                              Console.WriteLine("Pressione ENTER para continuar");
                              Console.ReadLine();
                            
                            } else {
                              
                            character.score--;
                            character.life--;
                            character.house.scoreHufflePuff++;
                            
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              Console.WriteLine("|                                   EXPLOSIVIM                                  |");
                              Console.WriteLine("|-------------------------------------------------------------------------------|");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine("|    Eita, você não conseguiu petrificar o explosivim e perdeu um score! Mas    |");
                              Console.WriteLine("| pode tentar fugir...                                                          |");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");

                              Console.WriteLine();
                              Console.WriteLine("Pressione ENTER para continuar");
                              Console.ReadLine();

                            dice = RPG.Dice.throwDice();
                            Console.WriteLine("DADO LANÇADO!");
                            Console.WriteLine($"Você tirou: {dice}");

                            if (dice >= 6 && dice <= 17) {
                              
                            character.score++;
                            character.life++;
                            character.house.scoreSlytherin++;

                              Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              Console.WriteLine("|                                   EXPLOSIVIM                                  |");
                              Console.WriteLine("|-------------------------------------------------------------------------------|");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine("|    Você conseguiu fugir do explosivim e ganhou um ponto e uma vida! Boa, bru- |");
                              Console.WriteLine("| xão, continue seu caminho no labirinto!                                       |");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");

                              Console.WriteLine();
                              Console.WriteLine("Pressione ENTER para continuar");
                              Console.ReadLine();

                            } else if (dice >= 18) {

                            character.score += 2;
                            character.life++;
                            character.house.scoreSlytherin++;

                              Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              Console.WriteLine("|                                   EXPLOSIVIM                                  |");
                              Console.WriteLine("|-------------------------------------------------------------------------------|");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine("|    Você conseguiu fugir do explosivim e ganhou 2 pontos e uma vida! Boa, bru- |");
                              Console.WriteLine("| xão, continue seu caminho no labirinto!                                       |");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");

                              Console.WriteLine();
                              Console.WriteLine("Pressione ENTER para continuar");
                              Console.ReadLine();
                            
                            } else {
                              
                              character.isAlive = false;

                              Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              Console.WriteLine("|                                   EXPLOSIVIM                                  |");
                              Console.WriteLine("|-------------------------------------------------------------------------------|");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine("|    Você não foi rápido o suficiente, o explosivim te atacou e você morreu!    |");
                              Console.WriteLine("| Sinto muito :(                                                                |");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");

                              Console.WriteLine();
                              Console.WriteLine("Pressione ENTER para continuar");
                              Console.ReadLine();
                            }
                            }
                            break;
                        case 2:
                            
                            character.score--;

                            dice = RPG.Dice.throwDice();
                            Console.WriteLine("DADO LANÇADO!");
                            Console.WriteLine($"Você tirou: {dice}");

                            if (dice >= 6 && dice <= 17) {
                              
                            character.score++;
                            character.life++;
                            character.house.scoreSlytherin++;

                              Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              Console.WriteLine("|                                   EXPLOSIVIM                                  |");
                              Console.WriteLine("|-------------------------------------------------------------------------------|");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine("|    Você conseguiu fugir do explosivim e ganhou um ponto e uma vida! Continue  |");
                              Console.WriteLine("| no labirinto.                                                                 |");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");

                              Console.WriteLine();
                              Console.WriteLine("Pressione ENTER para continuar");
                              Console.ReadLine();

                            } else if (dice >= 18) {

                            character.score += 2;
                            character.life++;
                            character.house.scoreSlytherin++;

                              Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              Console.WriteLine("|                                   EXPLOSIVIM                                  |");
                              Console.WriteLine("|-------------------------------------------------------------------------------|");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine("|    Você conseguiu fugir do explosivim e ganhou 2 pontos e uma vida! Continue  |");
                              Console.WriteLine("| no labirinto.                                                                 |");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");

                              Console.WriteLine();
                              Console.WriteLine("Pressione ENTER para continuar");
                              Console.ReadLine();

                            } else {
                              
                            character.score--;
                            character.life--;
                            character.house.scoreHufflePuff++;

                              Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              Console.WriteLine("|                                   EXPLOSIVIM                                  |");
                              Console.WriteLine("|-------------------------------------------------------------------------------|");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine("|    Você não conseguiu fugir do explosivim, ele te alcança e você é obrigado a |");
                              Console.WriteLine("| lutar.                                                                        |");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");

                              Console.WriteLine();
                              Console.WriteLine("Pressione ENTER para continuar");
                              Console.ReadLine();

                            dice = RPG.Dice.throwDice();
                            Console.WriteLine("DADO LANÇADO!");
                            Console.WriteLine($"Você tirou: {dice}");

                            if (dice >= 6 && dice <= 17) {
                              
                            character.life++;
                            character.score++;
                            character.house.scoreRavenclaw++;
                            character.house.scoreGryffindor++;

                              Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              Console.WriteLine("|                                   EXPLOSIVIM                                  |");
                              Console.WriteLine("|-------------------------------------------------------------------------------|");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine("|    Uhuul, você venceu esse bicho metade caranguejo-de-fogo e metade Mantícora |");
                              Console.WriteLine("| e ganhou um ponto e uma vida por isso! Siga seu caminho, bruxão!              |");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");

                              Console.WriteLine();
                              Console.WriteLine("Pressione ENTER para continuar");
                              Console.ReadLine();

                            } else if (dice >= 18) {

                            character.life++;
                            character.score += 2;
                            character.house.scoreRavenclaw++;
                            character.house.scoreGryffindor++;

                              Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              Console.WriteLine("|                                   EXPLOSIVIM                                  |");
                              Console.WriteLine("|-------------------------------------------------------------------------------|");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine("|    Uhuul, você venceu esse bicho metade caranguejo-de-fogo e metade Mantícora |");
                              Console.WriteLine("| e ganhou 2 pontos e uma vida por isso! Siga seu caminho, bruxão!              |");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");

                              Console.WriteLine();
                              Console.WriteLine("Pressione ENTER para continuar");
                              Console.ReadLine();
                            
                            } else {
                              
                            character.isAlive = false;

                              Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              Console.WriteLine("|                                   EXPLOSIVIM                                  |");
                              Console.WriteLine("|-------------------------------------------------------------------------------|");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine("|    Oops, você não conseguiu fugir do explosivim, ele te atacou e você morreu. |");
                              Console.WriteLine("| Tente novamente mais tarde!                                                   |");
                              Console.WriteLine("|                                                                               |");
                              Console.WriteLine(" ------------------------------------------------------------------------------- ");

                              Console.WriteLine();
                              Console.WriteLine("Pressione ENTER para continuar");
                              Console.ReadLine();
                            }
                            }
                            break;
                    }
                  return character;
                }
                
                static Character boggartMaze(Character character)
                {
                  Console.WriteLine($"JOGADOR ATUAL: {character.name}");
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
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();

                    Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    Console.WriteLine("|                                   BICHO PAPÃO                                 |");
                    Console.WriteLine("|-------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                               |");
                    Console.WriteLine("|    Após a batalha de Hogwarts, muitos dos dementadores fugiram do controle do |");
                    Console.WriteLine("| Ministério da Magia, e muitas pessoas sentem um medo generalizado deles. Por  |");
                    Console.WriteLine("| isso, hoje, o Bicho Papão que você enfrentará assume a forma de um dementador |");
                    Console.WriteLine("| de Azkaban. O que você deseja fazer para combatê-lo?                          |");
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
                    Console.WriteLine(" ------------------------------------------------------------------------------- ");

                    Console.WriteLine();
                    int optionBoggart;
                    do
                    {
                      Console.Write("Sua resposta é: ");
                      optionBoggart = Int32.Parse(Console.ReadLine());
                      if (optionBoggart != 1 && optionBoggart != 2 && optionBoggart != 3) Console.WriteLine("Opção inválida");
                    } while (optionBoggart != 1 && optionBoggart != 2 && optionBoggart != 3);

                    switch (optionBoggart)
                    {
                        case 1:
                        
                            character.house.scoreRavenclaw++;
                            character.house.scoreSlytherin++;
                            character.house.scoreGryffindor++;

                            character = case1Boggart(character);
                            break;
                        case 2:
                            character = Case2Boggart(character);
                            break;
                        case 3:
                            character = case3Boggart(character);
                            break;
                    }

                    static Character case1Boggart(Character character)
                    {
                      dice = RPG.Dice.throwDice();
                      Console.WriteLine("DADO LANÇADO!");
                      Console.WriteLine($"Você tirou: {dice}");

                      if (dice >= 6 && dice <= 17) {

                        character.score++;
                        character.life++;

                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        Console.WriteLine("|                                    BICHO PAPÃO                                |");
                        Console.WriteLine("|-------------------------------------------------------------------------------|");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine("|    O feitiço funcionou! Você consegue fugir do Bicho Papão e segue no labi-   |");
                        Console.WriteLine("| rinto com mais um ponto e uma vida.                                           |");
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                      
                      } else if (dice >= 18) {

                        character.score+=2;
                        character.life++;

                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        Console.WriteLine("|                                    BICHO PAPÃO                                |");
                        Console.WriteLine("|-------------------------------------------------------------------------------|");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine("|    O feitiço funcionou! Você consegue fugir do Bicho Papão e segue no labi-   |");
                        Console.WriteLine("| rinto com mais 2 pontos score e uma vida.                                     |");
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                      
                      
                      } else {
                        
                        character.score--;
                        character.life--;
                        
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        Console.WriteLine("|                                    BICHO PAPÃO                                |");
                        Console.WriteLine("|-------------------------------------------------------------------------------|");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine("|    O feitiço não funcionou e você perdeu um score e uma vida, mas tente nova- |");
                        Console.WriteLine("| mente.                                                                        |");
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");

                      dice = RPG.Dice.throwDice();
                      Console.WriteLine("DADO LANÇADO!");
                      Console.WriteLine($"Você tirou: {dice}");

                      if (dice >= 6 && dice <= 17) {
                        
                        character.score++;
                        character.life++;
                        character.house.scoreGryffindor++;
                        character.house.scoreHufflePuff++;
                        character.house.scoreRavenclaw++;
                        character.house.scoreSlytherin++;

                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        Console.WriteLine("|                                    BICHO PAPÃO                                |");
                        Console.WriteLine("|-------------------------------------------------------------------------------|");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine("|    O feitiço funcionou! Você consegue fugir do Bicho Papão e segue no labi-   |");
                        Console.WriteLine("| rinto com mais um ponto e uma vida.                                           |");
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                      
                      } else if (dice >= 18) {

                        character.score+=2;
                        character.life++;
                        character.house.scoreGryffindor++;
                        character.house.scoreHufflePuff++;
                        character.house.scoreRavenclaw++;
                        character.house.scoreSlytherin++;

                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        Console.WriteLine("|                                    BICHO PAPÃO                                |");
                        Console.WriteLine("|-------------------------------------------------------------------------------|");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine("|    O feitiço funcionou! Você consegue fugir do Bicho Papão e segue no labi-   |");
                        Console.WriteLine("| rinto com mais 2 pontos e uma vida.                                           |");
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                    
                      } else {
                        
                        character.isAlive = false;

                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        Console.WriteLine("|                                    BICHO PAPÃO                                |");
                        Console.WriteLine("|-------------------------------------------------------------------------------|");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine("|    Você não consegue fugir, é paralisado pelo medo e desmaia. Tchauzinho :(   |");
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                      }
                    }

                    return character;
                    }

                    static Character Case2Boggart(Character character)
                    {
                        character.score--;
                        character.life--;

                        Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        Console.WriteLine("|                                    BICHO PAPÃO                                |");
                        Console.WriteLine("|-------------------------------------------------------------------------------|");
                        Console.WriteLine("|                                                                               |");
                        Console.WriteLine("|    O feitiço não funcionou porque o bicho papão não é um dementador de        |");
                        Console.WriteLine("| verdade e não pode ser derrotado com o Expecto Patronum. Tente outra          |");
                        Console.WriteLine("| estratégia:                                                                   |");
                        Console.WriteLine("| (1) Lançar feitiço Riddikulus                                                 |");
                        Console.WriteLine("| (2) Fugir                                                                     |");
                        Console.WriteLine(" ------------------------------------------------------------------------------- ");

                        Console.WriteLine();
                        int optionBoggartCase2Boggart;
                        do
                        {
                            Console.Write("Sua resposta é: ");
                            optionBoggartCase2Boggart = Int32.Parse(Console.ReadLine());
                            if (optionBoggartCase2Boggart != 1 && optionBoggartCase2Boggart != 2) Console.WriteLine("Opção inválida");
                        } while (optionBoggartCase2Boggart != 1 && optionBoggartCase2Boggart != 2);

                        switch (optionBoggartCase2Boggart)
                        {
                            case 1:
                                dice = RPG.Dice.throwDice();
                                Console.WriteLine("DADO LANÇADO!");
                                Console.WriteLine($"Você tirou: {dice}");

                                if (dice >= 6 && dice <= 17) {

                                character.score++;
                                character.life++;
                                character.house.scoreGryffindor++;
                                character.house.scoreHufflePuff++;
                                character.house.scoreRavenclaw++;
                                character.house.scoreSlytherin++;

                                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                                Console.WriteLine("|                                    BICHO PAPÃO                                |");
                                Console.WriteLine("|-------------------------------------------------------------------------------|");
                                Console.WriteLine("|                                                                               |");
                                Console.WriteLine("|    O feitiço funcionou! Você consegue fugir do Bicho Papão e segue no labi-   |");
                                Console.WriteLine("| rinto com mais um ponto e uma vida.                                           |");
                                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              
                              } else if (dice >= 18) {

                                character.score+=2;
                                character.life++;
                                character.house.scoreGryffindor++;
                                character.house.scoreHufflePuff++;
                                character.house.scoreRavenclaw++;
                                character.house.scoreSlytherin++;

                                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                                Console.WriteLine("|                                    BICHO PAPÃO                                |");
                                Console.WriteLine("|-------------------------------------------------------------------------------|");
                                Console.WriteLine("|                                                                               |");
                                Console.WriteLine("|    O feitiço funcionou! Você consegue fugir do Bicho Papão e segue no labi-   |");
                                Console.WriteLine("| rinto com mais 2 pontos score e uma vida.                                           |");
                                Console.WriteLine(" ------------------------------------------------------------------------------- ");
       
                              } else {
                                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                                Console.WriteLine("|                                    BICHO PAPÃO                                |");
                                Console.WriteLine("|-------------------------------------------------------------------------------|");
                                Console.WriteLine("|                                                                               |");
                                Console.WriteLine("|    Você não consegue fugir, é paralisado pelo medo e desmaia. Tente novamente |");
                                Console.WriteLine("|  mais tarde :(                                                                |");
                                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              }
                            break;
                            case 2:
                              if (dice >= 6 && dice <= 17) {

                                character.score++;
                                character.life++;

                                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                                Console.WriteLine("|                                    BICHO PAPÃO                                |");
                                Console.WriteLine("|-------------------------------------------------------------------------------|");
                                Console.WriteLine("|                                                                               |");
                                Console.WriteLine("|    Você conseguiu fugir do Bicho Papão! Continue seu caminho no labirinto com |");
                                Console.WriteLine("| mais um ponto e uma vida.                                                     |");
                                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              
                              } else if (dice >= 18) {

                                character.score+=2;
                                character.life++;

                                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                                Console.WriteLine("|                                    BICHO PAPÃO                                |");
                                Console.WriteLine("|-------------------------------------------------------------------------------|");
                                Console.WriteLine("|                                                                               |");
                                Console.WriteLine("|    Você conseguiu fugir do Bicho Papão! Continue seu caminho no labirinto com |");
                                Console.WriteLine("| mais 2 pontos e uma vida.                                                     |");
                                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                         

                              } else {
                                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                                Console.WriteLine("|                                    BICHO PAPÃO                                |");
                                Console.WriteLine("|-------------------------------------------------------------------------------|");
                                Console.WriteLine("|                                                                               |");
                                Console.WriteLine("| Você não conseguiu fugir, foi paralisado pelo medo e desmaiou. Sinto muito :( |");
                                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                              }
                            break;
                        }

                    return character;
                    }

                    static Character case3Boggart(Character character)
                    {
                      dice = RPG.Dice.throwDice();
                      Console.WriteLine("DADO LANÇADO!");
                      Console.WriteLine($"Você tirou: {dice}");

                        if (dice>= 6 && dice <=17){
                          
                          character.score++;
                          character.life++;

                          Console.WriteLine(" ------------------------------------------------------------------------------- ");
                          Console.WriteLine("|                                    BICHO PAPÃO                                |");
                          Console.WriteLine("|-------------------------------------------------------------------------------|");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine("|    Você conseguiu fugir do Bicho Papão! Continue seu caminho no labirinto com |");
                          Console.WriteLine("| mais um ponto e uma vida.                                                     |");
                          Console.WriteLine(" ------------------------------------------------------------------------------- ");
                        
                        } else if (dice >= 18) {

                          character.score+=2;
                          character.life++;

                          Console.WriteLine(" ------------------------------------------------------------------------------- ");
                          Console.WriteLine("|                                    BICHO PAPÃO                                |");
                          Console.WriteLine("|-------------------------------------------------------------------------------|");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine("|    Você conseguiu fugir do Bicho Papão! Continue seu caminho no labirinto com |");
                          Console.WriteLine("| mais 2 pontos e uma vida.                                                     |");
                          Console.WriteLine(" ------------------------------------------------------------------------------- ");

                        
                        } else {
                          
                          character.score--;

                          Console.WriteLine(" ------------------------------------------------------------------------------- ");
                          Console.WriteLine("|                                    BICHO PAPÃO                                |");
                          Console.WriteLine("|-------------------------------------------------------------------------------|");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine("|    Você não conseguiu fugir do bicho papão (e perdeu um score), então é obri- |");
                          Console.WriteLine("| gado a enfrentá-lo. Escolha a sua estratégia:                                 |");
                          Console.WriteLine("|                                                                               |");
                          Console.WriteLine("| (1) Lançar feitiço Riddikulus                                                 |");
                          Console.WriteLine("| (2) Lançar o feitiço Expectro Patronum                                        |");
                          Console.WriteLine(" ------------------------------------------------------------------------------- ");

                          Console.WriteLine();
                          int optionBoggartcase3BoggartFail;
                          do
                          {
                              Console.Write("Sua resposta é: ");
                              optionBoggartcase3BoggartFail = Int32.Parse(Console.ReadLine());
                              if (optionBoggartcase3BoggartFail != 1 && optionBoggartcase3BoggartFail != 2) Console.WriteLine("Opção inválida");
                          } while (optionBoggartcase3BoggartFail != 1 && optionBoggartcase3BoggartFail != 2);

                          switch (optionBoggartcase3BoggartFail)
                          {
                              case 1:

                                  dice = RPG.Dice.throwDice();
                                  Console.WriteLine("DADO LANÇADO!");
                                  Console.WriteLine($"Você tirou: {dice}");

                                  if (dice >= 6 && dice <= 17){
                                    
                                  character.score++;
                                  character.life++;
                                  character.house.scoreRavenclaw++;
                                  character.house.scoreHufflePuff++;

                                  Console.WriteLine(" ------------------------------------------------------------------------------- ");
                                  Console.WriteLine("|                                    BICHO PAPÃO                                |");
                                  Console.WriteLine("|-------------------------------------------------------------------------------|");
                                  Console.WriteLine("|                                                                               |");
                                  Console.WriteLine("|    O feitiço funcionou! Você consegue fugir do Bicho Papão e segue no labi-   |");
                                  Console.WriteLine("| rinto com mais um ponto e uma vida.                                           |");
                                  Console.WriteLine(" ------------------------------------------------------------------------------- ");

                                  } else if (dice >= 18) {

                                  character.score+=2;
                                  character.life++;
                                  character.house.scoreRavenclaw++;
                                  character.house.scoreHufflePuff++;

                                  Console.WriteLine(" ------------------------------------------------------------------------------- ");
                                  Console.WriteLine("|                                    BICHO PAPÃO                                |");
                                  Console.WriteLine("|-------------------------------------------------------------------------------|");
                                  Console.WriteLine("|                                                                               |");
                                  Console.WriteLine("|    O feitiço funcionou! Você consegue fugir do Bicho Papão e segue no labi-   |");
                                  Console.WriteLine("| rinto com mais 2 pontos e uma vida.                                           |");
                                  Console.WriteLine(" ------------------------------------------------------------------------------- ");
                                  
                                  } else {

                                  character.isAlive = false;

                                  Console.WriteLine(" ------------------------------------------------------------------------------- ");
                                  Console.WriteLine("|                                    BICHO PAPÃO                                |");
                                  Console.WriteLine("|-------------------------------------------------------------------------------|");
                                  Console.WriteLine("|                                                                               |");
                                  Console.WriteLine("|    Você não consegue fugir, é paralisado pelo medo e desmaia. Tente novamente |");
                                  Console.WriteLine("|  mais tarde :(                                                                |");
                                  Console.WriteLine(" ------------------------------------------------------------------------------- ");
                                  }
                                  break;
                              case 2:

                                  Console.WriteLine(" ------------------------------------------------------------------------------- ");
                                  Console.WriteLine("|                                    BICHO PAPÃO                                |");
                                  Console.WriteLine("|-------------------------------------------------------------------------------|");
                                  Console.WriteLine("|                                                                               |");
                                  Console.WriteLine("|    O feitiço não funcionou porque o bicho papão não é um dementador de        |");
                                  Console.WriteLine("| verdade e não pode ser derrotado com o Expecto Patronum. Você é paralisado    |");
                                  Console.WriteLine("| pelo medo e desmaia. Tente novamente mais tarde :(                            |");
                                  Console.WriteLine(" ------------------------------------------------------------------------------- ");
                                  break;
                          }
                        }
                    return character;
                    }
                    return character;
                  }
                
            }
          }
        sphinxChallenge(characters);        
      }

    static void sphinxChallenge(List<Character> characters)
           {
              List<int> answersSphinx = new List<int>();

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
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();

                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                                   LABIRINTO                                   |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|                              Desafio da Esfinge                               |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Quando o Ministério da Magia começou a categorizar criaturas mágicas, a    |");
                Console.WriteLine("| Esfinge foi colocada na categoria fera e não na categorseria, devido às suas |");
                Console.WriteLine("| tendências violentas. Mas, não se preocupe, aqui você não precisará enfrentar |");
                Console.WriteLine("| a força física dela, mas a sua mente. Será que você dá conta do recado?       |");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();

              for (int i = 0; i < characters.Count; i++) {
                Console.WriteLine($"JOGADOR ATUAL: {characters[i].name}");
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
                int optionSphinx;
                do
                {
                    Console.Write("Sua resposta é: ");
                    optionSphinx = Int32.Parse(Console.ReadLine());
                    if (optionSphinx != 1 && optionSphinx != 2 && optionSphinx != 3 && optionSphinx != 4) Console.WriteLine("Opção inválida");
                } while (optionSphinx != 1 && optionSphinx != 2 && optionSphinx != 3 && optionSphinx != 4);

                answersSphinx.Add(optionSphinx);
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

                for (int i = 0; i < answersSphinx.Count; i++) {
                switch (answersSphinx[i])
                {
                    case 2:
                    
                        characters[i].score++;
                        characters[i].life++;
                        characters[i].house.scoreRavenclaw++;
                        characters[i].house.scoreGryffindor++;
                        characters[i].house.scoreHufflePuff++;
                        characters[i].house.scoreSlytherin++;

                        Console.WriteLine($"{characters[i].name}:");
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

                        Console.WriteLine();
                        Console.WriteLine($"{characters[i].name}, pressione ENTER para continuar");
                        Console.ReadLine();
                        break;
                    case 1:
                    case 3:
                    case 4:
                    
                        characters[i].score--;
                        characters[i].life--;
                        characters[i].house.scoreHufflePuff++;

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

                        Console.WriteLine();
                        Console.WriteLine($"{characters[i].name}, pressione ENTER para continuar");
                        Console.ReadLine();
                        break;
                }
              }
            }

}
}