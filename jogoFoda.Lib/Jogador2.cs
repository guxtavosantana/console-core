using jogoFoda.Interface;

namespace jogoFoda.Lib
{
    public class Jogador2 : interfaceJogador
    {
        public string Chuta()
        {
            return "Horácio está Chutando.\n";
        }

        public string Corre()
        {
            return "Horácio está Correndo.\n";
        }

        public string Passa()
        {
            return "Horácio está Passando.\n";
        }
    }
}