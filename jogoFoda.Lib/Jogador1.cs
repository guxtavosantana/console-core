using jogoFoda.Interface;

namespace jogoFoda.Lib
{
    public class Jogador1 : interfaceJogador
    {
        public readonly string Nome;

        public Jogador1(string nome)
        {
            this.Nome = nome;
        }

        public string Chuta()
        {
            return $"{Nome} está correndo.\n";
        }

        public string Corre()
        {
            return $"{Nome} está correndo.\n";
        }

        public string Passa()
        {
            return $"{Nome} está passando.\n";
        }
    }
}