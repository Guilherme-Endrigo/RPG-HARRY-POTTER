using System;

namespace RPG{
    class Program{
        static void Main(string[] args){

            dragonsChallenge();
            breakBeforeNextChallenge();
        }

                //---------> OPÇÂO 1 <---------
        static void searchEgg(string option){
            Console.WriteLine();
            Console.WriteLine("Opção 1 - sucesso");
            //if option 1 && dado > 10

            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                           PROCURAR O OVO  --  SUCESSO                         |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Parece que o ovo estava embaixo da água! Parabéns! Você conseguiu avançar  |");
            Console.WriteLine("| nas investigações, colheu pistas pelo castelo de Hogwarts e está perto de     |");
            Console.WriteLine("| conseguir encontrar o ovo! Jogue o dado novamente para saber se encontrará    |");
            Console.WriteLine("| a última pista para chegar ao ovo!                                            |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            //recebeDado = jogaDado()

                Console.WriteLine();
                Console.WriteLine("Opção 1 - Joga dado novamente -- sucesso");

                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                           PROCURAR O OVO  --  SUCESSO                         |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Parabéns! Você trabalhou duro e conseguiu achar o ovo!                     |");
                Console.WriteLine("| Bônus de 5 pontos por essa conquista                                          |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("Opção 1 - Joga dado novamente -- fracasso");

                Console.WriteLine(" ------------------------------------------------------------------------------- ");
                Console.WriteLine("|                           PROCURAR O OVO  --  FRACASSO                        |");
                Console.WriteLine("|-------------------------------------------------------------------------------|");
                Console.WriteLine("|                                                                               |");
                Console.WriteLine("|    Ih não foi dessa vez. A Murta Que Geme não quis te ajudar e                |");
                Console.WriteLine("| você não conseguiu encontrar o ovo. Você perdeu um ponto e uma vida           |");
                Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Opção 1 - fracasso");

            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                           PROCURAR O OVO  --  FRACASSO                        |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Hmm parece que foi uma busca que não deu em nada, você se perdeu na        |");
            Console.WriteLine("| floresta e nem mesmo chegou a investigar pelo castelo, onde as principais     |");
            Console.WriteLine("| pistas estavam. Infelizmente seu tempo se esgotou, portanto vai ficar com     |");
            Console.WriteLine("| um ponto e uma vida a menos                                                   |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

                        //shift+alt 
        }

        //---------> OPÇÂO 2 <---------
        static void fightDragon(string option){

            Console.WriteLine();
            Console.WriteLine("Opção 2 - sucesso");
            //if option 1 && dado > 10

            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                           ENFRENTAR DRAGÃO  --  SUCESSO                       |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Uau, é preciso muita audácia para enfrentarmos os nossos inimigos, você    |");
            Console.WriteLine("| teve uma batalha árdua e desafiante, mas no final conseguiu derrotar o dragão |");
            Console.WriteLine("| e impressionar os juízes! Para você, a vida não tem graça sem alguns dragões, |");
            Console.WriteLine("| certo? Parabéns! Você ganhou um ponto por isso :D                             |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            
            //se maiorPonto
            Console.WriteLine();
            Console.WriteLine("Opção 2 - MaiorPonto -- sucesso");

            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                       ENFRENTAR DRAGÃO  --  MAIOR PONTO                       |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Incrível! Além da vitória, você ganhou o ovo por ter sido o jogador        |");
            Console.WriteLine("| com maior pontuação. Parabéns! Aqui vão 5 pontos extras por essa conquista    |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Opção 2 - fracasso");

            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                         ENFRENTAR DRAGÃO  --  FRACASSO                        |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Vish, parece que o Dragão cuspiu fogo enquanto você lutava com ele no ar,  |");
            Console.WriteLine("| as chamas o desestabilizaram e arruinaram as cerdas da vassoura… Urgh, foi    |");
            Console.WriteLine("| uma queda feia! Que pena, acabou de perder um ponto e uma vida                |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
 
        }

        //---------> OPÇÂO 3 <---------
        static void avoidDragon(string option){
            
            Console.WriteLine();
            Console.WriteLine("Opção 3 - sucesso");
            //if option 1 && dado > 10

            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                           FUGIR DRAGÃO  --  SUCESSO                           |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Virando à esquerda, depois à direita, dando giros pelas tendas e abrindo   |");
            Console.WriteLine("| espaço pelas arquibancadas… Vuuuuum, sua vassoura corta o ar! Isso, o dragão  |");
            Console.WriteLine("| está longe! Ele não consegue te alcançar! Uau, sua fuga foi bem-sucedida, e   |");
            Console.WriteLine("| suas habilidades furtivas conseguiram impressionar os juízes! Parabéns!       |");
            Console.WriteLine("| Você ganhou um ponto por isso :D                                              |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Opção 3 - fracasso");

            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                          FUGIR DRAGÃO  --  FRACASSO                           |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Ele está se aproximando…Mais rápido! Voe mais rápido….! Ah não, você foi   |");
            Console.WriteLine("| devagar demais e acabou sendo pego pelo dragão! Que pena, parece que acabou   |");
            Console.WriteLine("| de perder um ponto e uma vida                                                 |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");
 
        }
        static void dragonsChallenge(){

            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                                   TORNEIO                                     |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|                              O torneio começou!                               |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|    Todos se encaminharam para o campo de quadribol, a torcida já está nas     |");
            Console.WriteLine("| arquibancadas e é quando na tenda dos participantes você se reúne com os      |");
            Console.WriteLine("| outros participantes, aguardando ansiosamente pelas instruções. Você está     |");
            Console.WriteLine("| empolgado para o seu primeiro desafio, e logo Rony Weasley chega, anunciando  |");
            Console.WriteLine("| que não será um desafio qualquer, você começará com o mesmo desafio que um    |");
            Console.WriteLine("| dia Harry Potter enfrentou, o DESAFIO DOS DRAGÕES.                            |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.WriteLine("Pressione Enter para continuar");
            Console.ReadLine();

            Console.WriteLine(" ------------------------------------------------------------------------------- ");
            Console.WriteLine("|                             DESAFIO DOS DRAGÕES                               |");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| Agora, você tem 3 opções:                                                     |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("| (1) Procurar o ovo                                                            |");
            Console.WriteLine("| (2) Lutar contra o dragão                                                     |");
            Console.WriteLine("| (3) Fugir do dragão                                                           |");
            Console.WriteLine(" ------------------------------------------------------------------------------- ");

            Console.WriteLine();
            Console.Write("Informe a opção desejada para continuar: ");
            string option = Console.ReadLine();

            switch (option){
            case "1":
                searchEgg(option);
                break;
            case "2":
                fightDragon(option);
                break;
            case "3":
                avoidDragon(option);
                break;
            }
        }

        breakBeforeNextChallenge(){
            

        }


      }
    }
    