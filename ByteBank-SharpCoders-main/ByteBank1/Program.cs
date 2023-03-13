using System.Reflection.Metadata.Ecma335;
using ByteBank1.Models;




Console.WriteLine("Olá! Seja bem-vindo ao seu Banco!\n\n" +
    "Por favor, primeiro digite o seu nome para fazer login: ");
string nomeDeLoginTemporario = Console.ReadLine();

Console.WriteLine("E a sua senha: ");
string senhaDeLoginTemporaria = Console.ReadLine();

// Login login = new Login(nomeDeLoginTemporario, senhaDeLoginTemporaria);

Console.WriteLine("Pronto! Agora é só digitar o seu nome primeiro e depois\n" +
    "a senha novamente para logar: ");
string nomeDeLoginFinal = Console.ReadLine();

Console.WriteLine("Agora a sua senha senha: ");
string senhaDeLoginFinal = Console.ReadLine();

Login login = new Login(nomeDeLoginTemporario, senhaDeLoginTemporaria, nomeDeLoginFinal, senhaDeLoginFinal);


OperacoesBancarias op = new OperacoesBancarias();

// Verificação se as informações são iguais
bool usuarioEstaLogado = true;

while (usuarioEstaLogado)
{
    Console.Clear();
    Console.WriteLine("O que você deseja fazer: ");
    Console.WriteLine("1 - Inserir novo usuário");
    Console.WriteLine("2 - Deletar um usuário");
    Console.WriteLine("3 - Listar todas as contas registradas");
    Console.WriteLine("4 - Detalhes de um usuário");
    Console.WriteLine("5 - Quantia armazenada no banco");
    Console.WriteLine("6 - Manipular a conta");
    Console.WriteLine("0 - Para sair do programa");
    Console.Write("Digite a opção desejada: ");


    // OperacoesBancarias operacoesBancarias = new OperacoesBancarias();

    List<string> cpfs = new List<string>();
    List<string> titulares = new List<string>();
    List<string> senhas = new List<string>();
    List<double> saldos = new List<double>();

    /* do
    {
        // ShowMenu();
        // fazerLogin();
        option = int.Parse(Console.ReadLine());
        Console.WriteLine("-----------------"); */

    switch (Console.ReadLine())
    {
        case "0":
            Console.WriteLine("Estou encerrando o programa...");
            usuarioEstaLogado = false;
            break;
        case "1":
            op.RegistrarNovoUsuario(cpfs, titulares, senhas, saldos);
            // ShowMenu();
            break;
        case "2":
            op.DeletarUsuario(cpfs, titulares, senhas, saldos);
            break;
        case "3":
            op.ListarTodasAsContas(cpfs, titulares, saldos);
            break;
        case "4":
            op.ApresentarUsuario(cpfs, titulares, saldos);
            break;
        case "5":
            // ShowMenu();
            break;
    }
    Console.WriteLine("-----------------");

    /* } while (option != 0); */
}


