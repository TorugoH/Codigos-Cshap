using FaturaTeste;
using System;
class FaturaTestes
{
    static void Main(string[] args){
        Fatura fatura = new Fatura();
        
        Console.WriteLine("Digite a descricao do produto");
        fatura.setDescricao(Console.ReadLine());
        
        Console.WriteLine("Digite o preço do produto");
        fatura.setPrecoitem(double.Parse(Console.ReadLine()));
        
        Console.WriteLine("Digite a quantidade que deseja do produto");
        fatura.setQTIntem(int.Parse(Console.ReadLine()));

        fatura.getfatura();
            
    }
}