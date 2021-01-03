using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

        }
    }
}





//ANOTAÇÕES

/* O projeto seguirá uma arquitetura de camadas, A primeira camada básica será
 a camda do tabuleiro, onde terá as coisas básicas do tabuleiro (Peças, tabuleirro, posição, cor da peça)

 Acima dessa camada, terá a camada do jogo de xadrez, onde serão implementadas as regras do jogo.

 A camada que está mais a cima, a camada de aplicação, é a camada que vai consumir as duas de baixo e executar o jogo*/
