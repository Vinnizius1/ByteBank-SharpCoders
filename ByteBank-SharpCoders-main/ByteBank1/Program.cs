using System.Reflection.Metadata.Ecma335;
namespace ByteBank1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            static void fazerLogin()
            {
                Console.WriteLine("Olá! Seja bem-vindo ao seu Banco!\n\n" +
                    "Por favor, primeiro digite o seu nome para fazer login: ");
                string nomeDeLoginTemporario = Console.ReadLine();
                Console.WriteLine("E a sua senha: ");
                string senhaDeLoginTemporaria = Console.ReadLine();

                // Verificação se as informações não são vazias
                if (nomeDeLoginTemporario == "" || senhaDeLoginTemporaria == "")
                {
                    Console.WriteLine("O campo de nome ou da senha não podem ser vazios.\n");
                    Console.WriteLine("-----------------\n");
                    fazerLogin();
                }

                Console.WriteLine("Pronto!\nAgora é só digitar o seu nome e depois a senha novamente para logar :)");
                string nomeDeLoginFinal = Console.ReadLine();
                string senhaDeLoginFinal = Console.ReadLine();

                // Verificação se as informações são iguais
                bool nomeESenhasParaLogar = (nomeDeLoginTemporario == nomeDeLoginFinal) && (senhaDeLoginTemporaria == senhaDeLoginFinal);

                if (nomeESenhasParaLogar) { ShowMenu(); return; }

                Console.WriteLine("Estou encerrando o programa...");
                Environment.Exit(0);

            }

            static void ShowMenu()
            {
                Console.WriteLine("O que você deseja fazer: ");
                Console.WriteLine("1 - Inserir novo usuário");
                Console.WriteLine("2 - Deletar um usuário");
                Console.WriteLine("3 - Listar todas as contas registradas");
                Console.WriteLine("4 - Detalhes de um usuário");
                Console.WriteLine("5 - Quantia armazenada no banco");
                Console.WriteLine("6 - Manipular a conta");
                Console.WriteLine("0 - Para sair do programa");
                Console.Write("Digite a opção desejada: ");
            }

            OperacoesBancarias operacoesBancarias = new OperacoesBancarias();

            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();
            List<double> saldos = new List<double>();
            int option;

            do
            {
                // ShowMenu();
                fazerLogin();
                option = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------");

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Estou encerrando o programa...");
                        break;
                    case 1:
                        operacoesBancarias.RegistrarNovoUsuario(cpfs, titulares, senhas, saldos);
                        // ShowMenu();
                        break;
                    case 2:
                        operacoesBancarias.DeletarUsuario(cpfs, titulares, senhas, saldos);
                        break;
                    case 3:
                        operacoesBancarias.ListarTodasAsContas(cpfs, titulares, saldos);
                        break;
                    case 4:
                        operacoesBancarias.ApresentarUsuario(cpfs, titulares, saldos);
                        break;
                    case 5:
                        ShowMenu();
                        break;
                }
                Console.WriteLine("-----------------");

            } while (option != 0);
        }
    }
}