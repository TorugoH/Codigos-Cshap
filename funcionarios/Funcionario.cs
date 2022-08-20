using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionarios
{
    class Funcionario {
        private string nome;
        private string sobrenome;
        private double salario;

        public string getNome() { return nome; }
        public void setNome(string Nome) { nome = Nome; }
        public string getSobrenome() { return sobrenome; }
        public void setSobrenome(string Sobrenome) { sobrenome = Sobrenome; }
        public double getSalario() { return salario; }
        public void setSalario(double Salario) { salario = Salario; }
        public void dadosFuncionario(){
            Console.WriteLine("Nome: "+nome);

            Console.WriteLine("Sobrenome: "+sobrenome);
            Console.WriteLine("Salario atual:" + salario);
            Console.WriteLine("*********************************");
        }
        public void NovoSalario()
        {
            double novoSalario = salario + (salario * 0.10);
            Console.WriteLine("Caro senhor(a)" + nome + " " + sobrenome);
            Console.WriteLine("Seu novo salario e de " + novoSalario);
            Console.WriteLine("*********************************");
        }
    }
}
