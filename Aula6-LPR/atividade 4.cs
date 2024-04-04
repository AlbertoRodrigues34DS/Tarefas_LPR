
using System;
class HelloWorld {
  static void Main() {
   int numero=0;
   int quadrado = 0;
   int soma=0;
   bool continua = true;
   bool ola = true;
   while(continua){
       
        
       while(ola){
     Console.WriteLine("Olá usuário, por favor insere um número inteiro para fazermos a soma dos seus algarismos após elevar ele ao quadrado:");
     numero = int.Parse(Console.ReadLine());
     
     
     Console.WriteLine("Enquanto fazermos o cálculo, poderia nos avaliar? de 1 a 5 o que você acha do nosso programa?");
     
     int avalia = int.Parse(Console.ReadLine());
          if(avalia >= 4){
         Console.WriteLine("Obrigado pela nota alta usuário, sua sastifação é a nossa felicidade :).");
         ola= false;
     }
         else if(avalia == 3){
         Console.WriteLine("Que pena que não suprimos mais além da média da sua expectativa usuário, depois entre em nosso site www.somadorfacil.com.br e nos diga o que faltou para melhorarmos o nosso serviço.");
         ola= false;
       }
           else {
           Console.WriteLine("Peçamos perdão pela má experiência, espero que numa próxima podemos melhorar nosso desempenho com o(a) senhor(a).");
           ola = false;
       }
       
       }
        
        quadrado = numero*numero;
        
   while(quadrado > 0){
       soma+= quadrado %10;
       quadrado/= 10; 
   }
   
   Console.WriteLine("O resultado da soma dos dígitos do quadrado de "+ numero +" foi de: "+ soma);
   
   Console.WriteLine("Deseja continuar? digite 1 para continuar.");
   int escolha = int.Parse(Console.ReadLine());
   if(escolha==1){
       Console.WriteLine("Então, por favor insira novamente um número.");
       soma=0;
       quadrado=0;
       ola=false;
       numero = int.Parse(Console.ReadLine());
        quadrado = numero*numero;
   }
   
   else{
       Console.WriteLine("Obrigado por usar o nosso programa, volte sempre!!");
       continua = false;
   }
   
   }
  }
}