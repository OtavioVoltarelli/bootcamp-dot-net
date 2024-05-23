using ExemploExplorando.Models;
using Models;
using Newtonsoft.Json;


















// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritorio", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licenca de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas,json", serializado);

// Console.WriteLine(serializado);















// try
// {

//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// } 
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma excecao genérica. {ex.Message}");
// }















// Pessoa p1 = new Pessoa(nome: "Otavio", sobrenome: "Voltarelli");
// Pessoa p2 = new Pessoa(nome: "Franciely", sobrenome: "Rueda");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();