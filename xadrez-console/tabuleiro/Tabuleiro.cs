namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; // matriz de peças

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas  = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos) {
            pecas[pos.coluna, pos.linha] = p;
            p.posicao = pos;
        }
    }
}
