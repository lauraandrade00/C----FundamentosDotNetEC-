using ExemploFundamentos.Models;

DateTime dataAtual = DateTime.Now;

string apresentacao = "Olá, seja bem-vindo";

int quantidade = 1;
quantidade = 10;

double altura = 1.60;

decimal preco = 1.80M;

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);

Pessoa p = new Pessoa();

p.Nome = "Laura";
p.Idade = 23;
p.Apresentar();