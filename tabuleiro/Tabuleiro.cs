using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro {
    class Tabuleiro {
        //Um tabuleiro tem um número de linhas e um número de colunas
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        //Um xadrez contém uma matriz do tipo Peça
        private Peca[,] pecas;

        //CONSTRUTOR
        public Tabuleiro(int linhas, int colunas) {
            Linhas = linhas;
            Colunas = colunas;
            //As peças receberão uma nova matriz de peças, com número de linhas e colunas
            pecas = new Peca[linhas, colunas];
        }

        //Criando método que dá acesso a uma peça do tabuleiro que é privado para outra classe
        public Peca peca(int linha, int coluna) { //Método retorna uma peça
            return pecas[linha, coluna];
        }
    }
}
