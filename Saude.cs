using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace V1_ControlePagamentos
{
    internal class Saude : Pagamentos
    {
        private string estabelecimento;
        private double valorFaturaSaude;

        public string Estabelecimento { get => estabelecimento; set => estabelecimento = value; }
        public double ValorFaturaSaude { get => valorFaturaSaude; set => valorFaturaSaude = value; }

        public Saude() { }

        public double Faturar()
        {
            ValorFaturaSaude = Valor + (Valor * 12) / 100;
            return ValorFaturaSaude;
        }

        public void InserirDadosSaude() 
        {
            Console.WriteLine("Nome do estabelecimento: ");
            Estabelecimento = Console.ReadLine();
        }
    }
}
