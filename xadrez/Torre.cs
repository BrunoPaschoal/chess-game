using System;
using tabuleiro;

namespace xadrez {
    class Torre : Peca { //Classe rei herda a classe genérica peça

        //CONSTRUTORES
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) { //Passando o contrutor para o da superclasse com base
        }

        //MÉTODOS
        public override string ToString() {
            return "T";
        }
    }
}
