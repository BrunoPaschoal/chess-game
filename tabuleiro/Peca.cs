

namespace tabuleiro {
    class Peca {
        //Atributo posição está associada com a classe procisão, assim como a cor
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; } //Atributo pode ser modificada só pela mesma classe e pelas subclasses dela
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        //CONSTRUTORES
        public Peca(Tabuleiro tab, Cor cor) {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            //Quantidade de movimento, no início do jogo, será iniciado com zero
            QtdMovimentos = 0;
        }

        //Incrementa a qualidade de movimentos
        public void incrementarQtdMovimentos() {
            QtdMovimentos++;
        }
    }
}
