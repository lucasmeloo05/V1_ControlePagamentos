using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_ControlePagamentos
{
    internal class Pagamentos
    {
        private double cpf;
        private int codigo;
        private double valor;

        public double Cpf { get => cpf; set => cpf = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public double Valor { get => valor; set => valor = value; }

        public Pagamentos() { }

        public void InserirDadosPagamentos()
        {
            Console.WriteLine("Digite o CPF: ");
            Cpf = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o código: ");
            Codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor: ");
            Valor = Convert.ToDouble(Console.ReadLine());
        }
    }
}
