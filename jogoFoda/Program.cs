using jogoFoda.Lib;

namespace jogoFoda
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new jogo(new Jogador1("Gordão"), new Jogador2());
            jogo.iniciarJogo();
        }
    }

}
