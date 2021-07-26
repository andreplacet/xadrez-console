namespace projeto_xadrez.tabuleiro
{
    public class Tabuleiro
    {
        public int colunas { get; set; }
        public int linhas { get; set; }
        public Peca[,] peca { get; set; }

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;

            peca = new Peca[linhas, colunas];
        }
    }
}