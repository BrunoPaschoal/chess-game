using System;
using tabuleiro;

namespace xadrez {
    class Rei : Peca { //Classe rei herda a classe genérica peça

        //CONSTRUTORES
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { //Passando o contrutor para o da superclasse com base
        }

        //MÉTODOS
        public override string ToString() {
            return "R";
        }
    }
}
