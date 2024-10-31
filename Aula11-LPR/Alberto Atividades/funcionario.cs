using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alberto_Atividades
{
    internal class funcionario
    {

        string nome;
        double salariobruto;

        public funcionario(string nome, float salariobruto)
        {
            this.nome = nome;
            this.salariobruto = salariobruto;
        }

        public void GetDado() 
        {
            switch (salariobruto)
            {

                case <=2000:

                    Console.WriteLine($"Nome:{nome}. Salário Bruto: {salariobruto * 0.9}");

                    break;

                case <= 3000:
                    Console.WriteLine($"Nome:{nome}. Salário Bruto: {salariobruto * 0.85}");

                    break;

                default:

                    Console.WriteLine($"Nome:{nome}. Salário Bruto: {salariobruto * 0.8}");

                    break;
            }
            
        }
        public void AumentarSalario(double percentual)
        {
            salariobruto= salariobruto+ salariobruto*percentual/100;


        }
    }
}
