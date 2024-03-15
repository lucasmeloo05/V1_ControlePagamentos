using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_ControlePagamentos
{
    internal class Alimentacao:Pagamentos
    {
        private string descricao;
        private double valorFaturaAlimentacao;

        public string Descricao { get => descricao; set => descricao = value; }
        public double ValorFaturaAlimentacao { get => valorFaturaAlimentacao; set => valorFaturaAlimentacao = value; }

        public Alimentacao() { }

        public double Faturar()
        {
            ValorFaturaAlimentacao = Valor +(Valor * 5) / 100;
            return ValorFaturaAlimentacao;
        }
        public void InserirDadosAlimentacao()
        {
            Console.WriteLine("Nome do produto:");
            Descricao = Console.ReadLine();
        }
    }
}
