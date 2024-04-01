#include <iostream>
#include <random>
using namespace std;

int main() {
    int escolha;
    int valor;
    int tentativa = 0;
    
    cout << "Olá usuário, bem vindo ao nosso jogo de advinhação, por favor insira um valor de 1 a 100, para testar sua habilidade em ser sortudo." << endl;
    
    // Inicializando o gerador de números aleatórios
    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1, 100);
    
    do {
        // Gerando um novo número aleatório para cada rodada
        int valorInteiro = distribuicao(numAleatorio);
        
        // Incrementando o contador de tentativas
        tentativa = 0;
        
        while (true) {
            cout << "Tentativa " << (tentativa + 1) << ": ";
            cin >> valor;
            tentativa++;
            
            if (valor == valorInteiro) {
                cout << "Parabéns, você acertou o número em " << tentativa << " tentativas!" << endl;
                break;
            } else if (valor < valorInteiro) {
                cout << "O número é maior. Tente novamente." << endl;
            } else {
                cout << "O número é menor. Tente novamente." << endl;
            }
        }

        cout << "Deseja jogar novamente? Digite 1 para continuar ou qualquer outro número para sair." << endl;
        cin >> escolha;
    } while (escolha == 1);

    cout << "Obrigado por jogar! Até a próxima." << endl;
    
    return 0;
}
