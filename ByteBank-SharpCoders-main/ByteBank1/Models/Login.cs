namespace ByteBank1.Models
{
    public class LoginInicial
    {
        public LoginInicial(string nomeDeLoginInicial, string senhaDeLoginInicial)
        {
            if (nomeDeLoginInicial == string.Empty || senhaDeLoginInicial == string.Empty)
            {
                throw new ArgumentException("Os campos não podem ser vazios.");
            }
        }
    }

    public class LoginFinal
    {
        public async Task ConfereLoginInicialComLoginFinal(string nomeDeLoginInicial, string senhaDeLoginInicial, string nomeDeLoginFinal, string senhaDeLoginFinal)
        {
            if (nomeDeLoginFinal.Equals(nomeDeLoginInicial, StringComparison.Ordinal) && senhaDeLoginFinal.Equals(senhaDeLoginInicial, StringComparison.Ordinal))
            {
                Console.WriteLine("Login efetuado com sucesso!");
                await Task.Delay(2000);
            }
            else
            {
                throw new ArgumentException("Os dados não coincidem.");
            }
        }
    }
}