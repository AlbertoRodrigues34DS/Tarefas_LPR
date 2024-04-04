using System;

class HelloWorld {
    static void Main() {
        float horas = 0;
        float quantsemana = 0;
        float quanttotal = 0;
        float mes = 0;
        float dia = 0;
        float ano = 0;
        bool continuar = true;
        
        while (continuar) {
            Console.WriteLine("Olá aprendiz, por favor insira a quantidade de horas para mostrar quantos dias, meses e anos para se tornar um jedai:");
            horas = float.Parse(Console.ReadLine());
            quantsemana = horas * 5;
            dia = 1000 / quantsemana * 5;
            mes = 1000 / quantsemana / 4.5f;
            ano = 1000 / quantsemana / 52.143f;
            
            Console.WriteLine($"Para alcançar o nível Jedai que exige 1000 horas de treinamento, treinando {quantsemana} horas por semana, demorará:");
            Console.WriteLine($"Em dias: {dia:F2}");
            Console.WriteLine($"Em meses: {mes:F2}");
            Console.WriteLine($"Em anos: {ano:F2}");

            Console.WriteLine("Deseja continuar? Se sim, digite 1.");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1) {
                Console.WriteLine("Então que comece a introdução novamente.");
            } else {
                Console.WriteLine("Obrigado pequeno Jedai, espero que tenha ajudado a ti. Volte sempre quando precisar.");
                continuar = false;
            }
        }
    }
}
