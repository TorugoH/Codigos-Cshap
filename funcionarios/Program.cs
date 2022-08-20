using System;
using funcionarios;
class FuncionarioTeste
{
    static void Main(string[] args) {
        Funcionario funcionario1 = new Funcionario();
        Funcionario funcionario2 = new Funcionario();

        Console.WriteLine("Digite o nome do funcionario");
        funcionario1.setNome(Console.ReadLine());
        Console.WriteLine("Digite o sobre nome do funcionario");
        funcionario1.setSobrenome(Console.ReadLine());
        Console.WriteLine("Digite o salario do funcionario");
        funcionario1.setSalario(double.Parse(Console.ReadLine()));

        Console.WriteLine("Digite os dados do segundo funcionario");

        Console.WriteLine("Digite o nome do funcionario");
        funcionario2.setNome(Console.ReadLine());
        Console.WriteLine("Digite o sobre nome do funcionario");
        funcionario2.setSobrenome(Console.ReadLine());
        Console.WriteLine("Digite o salario do funcionario");
        funcionario2.setSalario(double.Parse(Console.ReadLine()));

        //Função resposavel por limpar o console
        Console.Clear();

        funcionario1.dadosFuncionario();
        funcionario1.NovoSalario();
        
        funcionario2.dadosFuncionario();
        funcionario2.NovoSalario();



    }
}