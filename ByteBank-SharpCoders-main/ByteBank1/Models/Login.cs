namespace ByteBank1.Models
{
    public class Login1
    {
        public Login1(string nomeDeLoginInicial, string senhaDeLoginInicial)
        {
            if (nomeDeLoginInicial == string.Empty || senhaDeLoginInicial == string.Empty)
            {
                throw new ArgumentException("Os campos não podem ser vazios.");
            }
        }
    }

    public class Login2
    {
        public Login2(string nomeDeLoginInicial, string senhaDeLoginInicial, string nomeDeLoginFinal, string senhaDeLoginFinal)
        {
            if (nomeDeLoginFinal.Equals(nomeDeLoginInicial, StringComparison.Ordinal) || senhaDeLoginFinal.Equals(senhaDeLoginInicial, StringComparison.Ordinal))
            {
                throw new ArgumentException("Os dados não coincidem.");
            }
        }
    }
}