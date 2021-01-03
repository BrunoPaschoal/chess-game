using tabuleiro; 

namespace xadrez {
    class PosicaoXadrez {
        //cada casinha do xadrez é representada por um endereço de uma letra e um número inteiro
        //Os atributos dessa classe irão reprensetar isso
        public char Coluna { get; set; }
        public int Linha { get; set; }

        //Construtor
        public PosicaoXadrez(char coluna, int linha) {
            Coluna = coluna;
            Linha = linha;
        }

        //Método que converte a posição da casa para posição da matriz
        public Posicao toPosicao() {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString() {
            return "" + Coluna + Linha;
        }
    }
}
