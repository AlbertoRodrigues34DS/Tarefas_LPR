/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
#include <iostream>
using namespace std;
int main()
{
    int quantidade, valores, soma = 0, contador = 0, escolha = 1, boas = 1;
    double media;
     if(boas==1){
     cout<<"Olá usuário, por favor insira quantos valores você irá colocar para fazermos a média aritmética dos números pares."<<endl;
     }
    while(true){
    cin>>quantidade;
    cout<<"agora os valores para fazermos a média aritmética."<<endl;
    while(contador < quantidade){
       cin>>valores;
        if(valores % 2 ==0){
            soma+=valores;
            contador++;
        }
    }
    if(contador >0){
        media = soma*1.0/quantidade;
        cout<<"A média aritmética desses valores é de: "<<media<<endl;
    }
    else{
        cout<<"Não há números o suficiente para fazermos a média."<<endl;
    }
    cout<< "deseja continuar a fazer a média? Digite 1 para continuar, se não apenas pressione qualquer letra ou número e enter."<<endl;
    cin>>escolha;
    if(escolha==1){
        cout<<"Então por favor, insira novamente a quantidade de valores."<<endl;
        boas=0;
        soma =0;
        contador=0;

    }
    else{
        cout<<"Obrigado por utilizar nosso programa, volte sempre!"<<endl;
        break;
    }
    
    }
    return 0;
    }

    

    
