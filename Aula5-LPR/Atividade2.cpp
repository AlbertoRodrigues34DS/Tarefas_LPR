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
    int numero;
    int numero2;
    cout<<"Olá usuário, por favor digite dois números para dizermos se eles são múltiplos ou não:"<<endl;
    cin>>numero;
    cin>>numero2;
    if(numero%numero2==0){
        cout<<"Os números: "<<numero<<" e "<<numero2 <<" digitados são: Múltiplos"<<endl;
        
    }
    else{
    cout<<"Os números: "<<numero<<", "<<numero2<<"digitados não são múltiplos"<<endl;
    }
    return 0;
    
}