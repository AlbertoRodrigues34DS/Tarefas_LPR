/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
   bool boas=true;
   bool loop=true;
   while(loop)
   {
       if(boas){
           Console.WriteLine("Olá jogador, bem vindo ao mundo de Holf, por favor escolhe a classe para ser o melhor Holfliano que existirá!");
       }
           Console.WriteLine("1->Necromântico");
           Console.WriteLine("2->Bárbaro");
           Console.WriteLine("3->Atirador");
           Console.WriteLine("4->Sair do jogo");
          int escolha;
           if(!int.TryParse(Console.ReadLine(), out escolha)){
               Console.WriteLine("Escolha incorreta jogador, por favor escolhe uma dessas 4 classes para jogar.");
             break;
               
           }
           switch(escolha){
               case 1:
               Console.WriteLine("Com a escolha do necromântico, terá as seguintes funçõies:");
               Console.WriteLine("1->Necrose: Atq básico mágico que pode ser acertado até 30 fts de distância, e dando ao inimigo um dano contínuo de necrose de 1d4 por 2 turnos");
               Console.WriteLine("2->Ressureição de seu exército:Poderá ressuscitar os membros mortos ou inimigos mortos para lutar ao seu lado, porém n com a força total, apenas a metade de seus status.");
               Console.WriteLine("3->Nada pode me parar: Buff geral para o personagem e suas tropas de +10 em todos atributos, além de que será avançado o turno de todos os aliados ressucitado.");
               Console.WriteLine("Você tem certeza de sua escolha?(S/N)");
                   string escolha3 = Console.ReadLine();
                   if(escolha3!="N" && escolha3 != "n"){
                       Console.WriteLine("Que escolha Honrável meu caro jogador, por favor divirta-se nesse mundo vasto de Holf.");
                       loop = false;
                   }
                   else{
                       Console.WriteLine("Então por favor pense bem para fazer a escolha certa para a sua jornada.");
                       boas=false;
                       
                   }
               break;
               case 2:
               Console.WriteLine("Com a escolha do Bárbaro, você terá as seguintes funções:");
               Console.WriteLine("1-> ataque brutal: atq básico dado até 10fts do inimigo, que causa 5d4 com um dano contínuo de sangramento de 1d4 por 2 turnos.");
               Console.WriteLine("2-> Berserker: Aumenta sua fortitude e força em +15 e ser um inimigo dá um atq letal não matará-lo nesse modo, além de um bônus de dano de 1d4 em seu atq básico");
               Console.WriteLine("3-> Eu sou a muralha: Sua resistência para todos debuffs é aumentado em +5 e pode ser utilizado fora de campo de combate.");
               Console.WriteLine("Você tem certeza de sua escolha?(S/N)");
                   string escolha4 = Console.ReadLine();
                   if(escolha4!="N" && escolha4 != "n"){
                       Console.WriteLine("Que escolha honrosa meu caro jogador, por favor divirta-se neste mundo vasto de Holf.");
                       loop = false;
                   }
                       else{
                       Console.WriteLine("Então por favor pense bem para fazer a escolha certa para a sua jornada.");
                       boas=false;
                       }
               break;
               case 3:
               Console.WriteLine("Com a escolha do atirador, você terá as seguintes funções:");
               Console.WriteLine("1->Você está na minha mira: Pode desferir um tiro de até 60 fts num inimigo e dá a penalidade de ferido, com um dano inicial de 3d2 que perdera um dano constante de 1d4 até ser curado.");
               Console.WriteLine("2->Meu treino fez efeito: Aumenta o dano crítico e acerto sobre um inimigo.");
               Console.WriteLine("3->Jamais minha arma se apartará da guerra: Você dá um dano bonus de 2d4 sobre um inimigo e dá a penalidade de desnorteado, onde atrasará o turno do seu adversário e deixará ele vulnerável a danos críticos.");
               
               Console.WriteLine("Você tem certeza de sua escolha?(S/N)");
                   string escolha5 = Console.ReadLine();
                   if(escolha5!="N" && escolha5 != "n"){
                       Console.WriteLine("Que escolha honrosa meu caro jogador, por favor divirta-se neste mundo vasto de Holf.");
                       loop = false;
                   }
                   else{
                       Console.WriteLine("Então por favor pense bem para fazer a escolha certa para a sua jornada.");
                       boas=false;
                   }
               break;
               
               case 4:
                   Console.WriteLine("Obrigado por visitar o nosso mundo belo, por favor jogador volte novamente para desfrutar dessa jornada bela.");
                 loop=false;  
                 
               
               default:
               Console.WriteLine("Escolha inválida. Por favor, escolha uma das opções disponíveis.");
                break;
               }
           }
       
   }
  }
 