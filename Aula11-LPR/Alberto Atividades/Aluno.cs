using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Alberto_Atividades
{
    internal class Aluno
    {

        string Nome;
        int Matricula;
        int Notaprova1;
        int Notaprova2;
        int Notatrabalho;


        public Aluno(string nome, int matricula, int notaprova1, int notaprova2, int notatrabalho)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.Notaprova1 = notaprova1;
            this.Notaprova2 = notaprova2; 
            this.Notatrabalho = notatrabalho;

        }
       
        public string Getnome()
        {
            return Nome;

        }
        public int Getmatricula()
        {
            return Matricula;
        }
        public void Setnotaprova(int Notaprova1) { 
       
            
            
            if (Notaprova1 > 0)
            {
                this.Notaprova1 = Notaprova1;

            }

        }


        public void Setnotaprova2(int Notaprova2) 
        {
            this.Notaprova2 = Notaprova2;
        }
        public void Setnotatrabalho(int Notatrabalho)
        {
            this.Notatrabalho = Notatrabalho;
        }

        public int CalcMedia(int notaprova1, int notaprova2, int notatrabalho)
        {
            int media =notaprova1 + notaprova2+ notatrabalho/3;
            return media;
        }

    }
}
