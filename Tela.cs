using System;
using tabuleiro;

namespace xadrez_console {
    class Tela {
        //Método que imprime a tela baseada na matriz
        public static void imprimirTabuleiro(Tabuleiro tab) {

            //Percorrendo a matriz
            for(int i = 0; i < tab.Linhas; i++) {
                Console.Write(8 - i + " ");

                for(int j = 0; j < tab.Colunas; j++) {
                    //Imprime peça que está na respectiva posição
                    //Se não tiver peça, imprime um tracinho
                    if(tab.peca(i,j) == null) {
                        Console.Write("- ");
                    }
                    else {
                        imprrimirPeca(tab.peca(i, j));
                    }
                                                     
                }
                //Pula linha para escrever a próxima linha da matriz 
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        //Método que define a cor da peça
        public static void imprrimirPeca(Peca peca) {
            if (peca.Cor == Cor.Branca) {
                Console.Write(peca);
            }
            else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
