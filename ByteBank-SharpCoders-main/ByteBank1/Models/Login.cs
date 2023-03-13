namespace ByteBank1.Models
{
    public class Login
    {
        public Login(string nomeDeLoginTemporario, string senhaDeLoginTemporaria, string nomeDeLoginFinal, string senhaDeLoginFinal)
        {

            if (nomeDeLoginTemporario == "" || senhaDeLoginTemporaria == "")
            {
                throw new ArgumentException("Os campos não podem ser vazios.");
            }

            if (nomeDeLoginFinal.ToLower() != nomeDeLoginTemporario.ToLower() || senhaDeLoginFinal.ToLower() != senhaDeLoginTemporaria.ToLower())
            {
                throw new ArgumentException("Os dados não coincidem.");
            }

        }
    }
}