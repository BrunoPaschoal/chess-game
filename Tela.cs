using System;
using tabuleiro;

namespace xadrez_console {
    class Tela {
        //Método que imprime a tela baseada na matriz
        public static void imprimirTabuleiro(Tabuleiro tab) {

            //Percorrendo a matriz
            for(int i = 0; i < tab.Linhas; i++) {
                for(int j = 0; j < tab.Colunas; j++) {
                    //Imprime peça que está na respectiva posição
                    //Se não tiver peça, imprime um tracinho
                    if(tab.peca(i,j) == null) {
                        Console.Write("- ");
                    }
                    else {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                                                     
                }
                //Pula linha para escrever a próxima linha da matriz 
                Console.WriteLine();
            }
        }
    }
}
