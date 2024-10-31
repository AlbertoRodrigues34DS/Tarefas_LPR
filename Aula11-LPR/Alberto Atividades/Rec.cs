using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alberto_Atividades
{
    internal class Rec
    {
        double Altura;
        double Largura;

        public Rec(double altura, double largura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }
       public double calcArea() { return Altura * Largura; }
       public double calcPerimetro() { return (Altura * 2) + (Largura * 2); }
    }
}
