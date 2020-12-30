

namespace tabuleiro {
    class Posicao {
        //Criando atributos da posição
        public int Linha { get; set; }
        public int Coluna { get; set; }

        //CONSTUTORES
        public Posicao(int linha, int coluna) {
            Linha = linha;
            Coluna = coluna;
        }

        //MÉTODOS
        //Método para converter para string quando o objeto instanciado por exibido na tela
        public override string ToString() {
            return Linha
                + ", "
                + Coluna;
        }
    }
}
