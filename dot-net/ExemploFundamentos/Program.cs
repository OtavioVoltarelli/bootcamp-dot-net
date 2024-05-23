using System.Diagnostics;
using ExemploFundamentos.Common.Models;
using System;


// class Program
// {
//     static void Main(string[] args)
//     {
//         // Lista para armazenar os itens
//         List<string> itens = new List<string>();

//         // TODO: Solicite os itens ao usuário
//         for(int contador = 0; contador < 3; contador++)
//         {
//             string item = Console.ReadLine();
//             itens.Add(item);
//         }

//         // Exibe a lista de itens
//         Console.WriteLine("Lista de itens:");
//         foreach (string item in itens)
//         {
//             Console.WriteLine($"- {item}");
//         }
//     }
// }






















// class Program
// {
//     static void Main(string[] args)
//     {

//         int saldoTotal = int.Parse(Console.ReadLine());

//         int valorSaque = int.Parse(Console.ReadLine());

//         int saldoDisponivel = saldoTotal;

//         if (saldoTotal != saldoDisponivel)
// {
//     Console.WriteLine("Saldo incorreto. Saque não realizado");
//     return;
// }
//         if (saldoDisponivel < valorSaque)
//         {
//             Console.WriteLine("Saldo insuficiente. Saque nao realizado!");
//             return;
//         }
//         else
//         {
//             saldoDisponivel -= valorSaque;
//             Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {saldoDisponivel}");
//         }
//     }
// }












// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");

// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posicao N {contador} - {listaString[contador]}");
// }


















// string? opcao;

// while(true)
// {
//     Console.Clear();
//     Console.WriteLine("Digite uma opcao");
//     Console.WriteLine("1- Cadastrar cliente");
//     Console.WriteLine("2- Buscar cliente");
//     Console.WriteLine("3- Apagar cliente");
//     Console.WriteLine("4- Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastrando cliente");
//             break;
//         case "2":
//             Console.WriteLine("Buscando cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagando cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrando");
//             Environment.Exit(0);
//             break;
//     }
// }

















// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10,50);
// calc.Multiplicar(15,45);
// calc.Dividir(2, 2);
// calc.Potencia(3,3 );





















// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("vogal");
//         break;
    
//     default:
//         Console.WriteLine("n é vogal");
//         break;
// }



// if (letra == "a" ||
//     letra == "e")
// {
//     Console.WriteLine("é volgal");
// }
// else
// {
//     Console.WriteLine("não é vogal");
// }






// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);


// string apresentacao = "Olá";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " + altura);
// Console.WriteLine("Valor da variavel preco: " + preco);
// Console.WriteLine("Valor da variavel condicao: " + condicao);


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Buta";
// pessoa1.Idade = 26;
// pessoa1.Apresentar();