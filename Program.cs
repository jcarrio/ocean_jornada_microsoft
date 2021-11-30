using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comentário
            // Console.WriteLine("Hello World!");
/*            
            string nomeCompleto = "Julio Carrió";
            // Console.WriteLine($"Hello {nomeCompleto}!");
            // Console.WriteLine(string.Format("Hello {0}!",nomeCompleto));
            foreach (var parte in nomeCompleto.Split(' '))
                Console.WriteLine(parte);
            string nome = "Julio";
            string sobrenome = "Carrió";
            // Console.WriteLine($"{nome} {sobrenome} {{"); // Escapar chaves nesse caso
            Console.WriteLine($"{nome} {sobrenome}");
            Console.Write("\nDigite seu nome: ");
            string nome2 = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}!");
*/
/*
            var nome = "Julio";
            var idade = 10;
            var altura = 1.23;

            Console.WriteLine($"Olá, {nome}, você possui {idade} anos de idade e mede {altura}cm.");

            // Operações matemáticas
            var soma = 10 + 5;
            var subtracao = 10 - 5;
            var multiplicacao = 10 * 2;
            var divisao = 10 / 3.0;  // Precisa coloca .0 senão vira inteiro

            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Substraçã: {subtracao}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");
            // Console.WriteLine($"Divisão: {divisao:C}");  // Formata como moeda, currency
            Console.WriteLine($"Divisão: {divisao:0.00}");  // Google: c# string interpolation decimal 2 digits
*/
            // Desafio 1
            // Calculadora dos 10% do garçom
            var valorConta = 45.35;
            // Resultado de 45.35 + 10% deve dar: 49.885
            var porcentagemGarcom = 10;
            var valorTotal = valorConta;

            valorTotal += valorConta*porcentagemGarcom/100;

            Console.WriteLine($"Valor da conta foi de R{valorConta:C}."); // Currency
            Console.WriteLine($"Porcentagem do garçom foi de R{porcentagemGarcom:C}."); // Currency
            Console.WriteLine($"Valor do garçom foi de R{valorTotal:C}."); // Currency
/*
Desafio para depois:

Nome: Catapulta
Objetivo: Receber o número de baterias e duração da bateria e calcular a quantidade de pedras que a catapulta irá soltar.
Dificuldade: Principiante

1 - Uma catapulta lançou 300 pedras em 5 baterias de 15 minutos, cada.

2 - Quantas pedras ela lançaria em 8 baterias de 7 minutos, cada?

3 - Crie um programa que receba os valores base para que a aplicação funcione de forma que, se alterarmos o número de baterias e a duração de cada bateria, o programa funcione sem precisar de mais modificações.
*/            
            var pedras = 300;
            var baterias = 5;
            var tempo = 15;
            var 
        }
    }
}
