// See https://aka.ms/new-console-template for more information
using TestBank.Entidades;
using TestBank.SistemaInterno;
using TestBank.Utilitarios;
using TestBank.Utilitarios.Calculadora;

void CalcularComissao()
{
    Vendedor elaine = new("13607557721", "Elaine Saith", 1500);
    Console.WriteLine("Comissão de " + elaine.nome + ": " + elaine.CalcularComissao());

    Supervisor ana = new("12345678900", "Ana Livia", 2700);
    ana.percentualComissao = 0.25;
    Console.WriteLine("Comissão de " + ana.nome + ": " + ana.CalcularComissao());

    Diretor kira = new("99999999999", "Kira Saith", 5000);
    Console.WriteLine("Comissão de " + kira.nome + ": " + kira.CalcularComissao());

    GerenciadorComissoes gerenciador = new();
    gerenciador.Registrar(elaine);
    gerenciador.Registrar(ana);
    gerenciador.Registrar(kira);

    Console.WriteLine("Resultado total de comissões: " + gerenciador.TotalComissao());
    Console.WriteLine("Total de funcionários: " + Funcionario.numeroTotalFuncionarios);

    elaine.AumentarSalario();
    Console.WriteLine("Novo salário de " + elaine.nome + ": " + elaine.salario);

    ana.AumentarSalario();
    Console.WriteLine("Novo salário de " + ana.nome + ": " + ana.salario);

    kira.AumentarSalario();
    Console.WriteLine("Novo salário de " + kira.nome + ": " + kira.salario);
}

void UsarSistema()
{
    SistemaInterno sistema = new();
    Diretor elaine = new("13607557721", "Elaine Saith", 4500);

    sistema.Logar(elaine, "@#13607557721!");
}

Console.WriteLine("Bem vindo ao TestBank!");
UsarSistema();
//CalcularComissao();




//double valor1 = 0;
//double valor2 = 0;

//Console.WriteLine("Digite o primeiro valor:");
//valor1 = Double.Parse(Console.ReadLine());

//Console.WriteLine("Digite o segundo valor:");
//valor2 = Double.Parse(Console.ReadLine());

//Operacoes operacoes = new();
//Console.WriteLine("Resultado da soma: " + operacoes.soma.Calcular(valor1, valor2));
//Console.WriteLine("Resultado da subtração: " + operacoes.subtracao.Calcular(valor1, valor2));
//Console.WriteLine("Resultado da multiplicação: " + operacoes.multiplicacao.Calcular(valor1, valor2));
//Console.WriteLine("Resultado da divisão: " + operacoes.divisao.Calcular(valor1, valor2));