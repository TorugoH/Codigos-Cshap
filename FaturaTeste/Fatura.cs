using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaTeste
{
    class Fatura
    {
        private string _numero;
        private string _descricao;
        private int _qtIntem;
        private double _precoItem;
        public string getNumero() { return _numero; }
        public void setNumero(string numero) { _numero = numero; }
        public string getDescricao() { return _descricao; }
        public void setDescricao(string descricao) { _descricao = descricao; }
        public int getQTIntem() { return _qtIntem; }
        public void setQTIntem(int qtIntem) { _qtIntem = qtIntem; }
        public double getPrecoitem() { return _precoItem; }
        public void setPrecoitem(double preco) { _precoItem= preco; }
        public void getfatura()
        {

            if (_qtIntem * _precoItem >=0)
            {
                Console.WriteLine("Valor da sua fatura R$ "+_qtIntem * _precoItem);
            }
            else if (_qtIntem * _precoItem<=0)
            {
                Console.WriteLine("Valor da sua fatura R$ " + 0);
            }
        }
    }
}