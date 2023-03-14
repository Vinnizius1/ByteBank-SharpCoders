namespace ByteBank1.Models
{
    public class Login
    {
        public Login(string nomeDeLoginInicial, string senhaDeLoginInicial, string nomeDeLoginFinal, string senhaDeLoginFinal)
        {

            if (nomeDeLoginInicial == "" || senhaDeLoginInicial == "")
            {
                throw new ArgumentException("Os campos não podem ser vazios.");
            }

            if (nomeDeLoginFinal.ToLower() != nomeDeLoginInicial.ToLower() || senhaDeLoginFinal.ToLower() != senhaDeLoginInicial.ToLower())
            {
                throw new ArgumentException("Os dados não coincidem.");
            }

        }
    }
}