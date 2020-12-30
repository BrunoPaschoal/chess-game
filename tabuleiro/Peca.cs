

namespace tabuleiro {
    class Peca {
        //Atributo posição está associada com a classe procisão, assim como a cor
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; } //Atributo pode ser modificada só pela mesma classe e pelas subclasses dela
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        //CONSTRUTORES
        public Peca(Posicao posicao, Tabuleiro tab, Cor cor) {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            //Quantidade de movimento, no início do jogo, será iniciado com zero
            QtdMovimentos = 0;
        }
    }
}
