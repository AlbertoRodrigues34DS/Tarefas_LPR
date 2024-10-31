using System.Xml;

namespace Alberto_Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 0; i < 10 ; i++) { 
            
            Rec r1 = new Rec(i+2, i+1);
                Console.WriteLine("Area do retângulo:" + r1.calcArea());
               
            }
        
        List<funcionario>listafuncionarios = new();

           listafuncionarios.Add(new funcionario("Alberto",3200));
           listafuncionarios.Add(new funcionario("Yann", 1900));


            foreach(var funcionario in listafuncionarios)
            {
                funcionario.AumentarSalario(25);
                funcionario.GetDado();
            }
        }

        Aluno[] notalunos = new Aluno[3];

        notalunos[0] = 

    }
}
