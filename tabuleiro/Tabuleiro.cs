using System;
using tabuleiro;

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

        //-------------------------
        //MÉTODOS

        //Criando método que dá acesso a uma peça do tabuleiro que é privado para outra classe
        public Peca peca(int linha, int coluna) { //Método retorna uma peça
            return pecas[linha, coluna];
        }

        //Criando uma sobrecarga do método peça
        public Peca peca(Posicao pos) {
            return pecas[pos.Linha, pos.Coluna];
        }

        public bool existePeca(Posicao pos) {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        //Método que coloca peça no cabuleiro
        public void colocarPeca(Peca p, Posicao pos) {
            if (existePeca(pos)) {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }

            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        //Criando um método pra testar se uma posição é válida
        public bool posicaoValida(Posicao pos) {
            if(pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas) {
                return false;
            }

            return true;
        }

        public void validarPosicao(Posicao pos) {
            if (!posicaoValida(pos)) {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
