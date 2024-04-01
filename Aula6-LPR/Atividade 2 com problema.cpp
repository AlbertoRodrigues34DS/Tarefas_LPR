#include <iostream>
#include <random>
using namespace std;

int main() {
    int escolha;
    int valor;
    int tentativa = 0;
    
    cout << "Olá usuário, bem vindo ao nosso jogo de advinhação, por favor insira o valor de 1 a 100, para testar sua habilidade em ser sortudo." << endl;
    
    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1, 100);
    int valorInteiro = distribuicao(numAleatorio);
    
    do {
        // Inicializando valor dentro do loop
        cin >> valor;
        
        if (valor > valorInteiro) {
            cout << "Você chutou um valor acima do número." << endl;
        } else if (valor < valorInteiro) {
            cout << "Você chutou um valor abaixo do número." << endl;
        }
        
        tentativa++;
        
        while (valor != valorInteiro) {
            cin >> valor;
            tentativa++;
            if (valor > valorInteiro) {
                cout << "Você chutou um valor acima do número." << endl;
            } else if (valor < valorInteiro) {
                cout << "Você chutou um valor abaixo do número." << endl;
            }
        }

        cout << "Parabéns, você acertou o número, com a quantidade de: " << tentativa << " tentativa(s)" << endl << "Deseja continuar? Se sim, digite 1" << endl;
        cin >> escolha;
        
        if (escolha == 1) {
            cout << "Então tente a sorte novamente." << endl;
            // Gerando novo número aleatório para a próxima rodada
            valorInteiro = distribuicao(numAleatorio);
            tentativa = 0; // Resetando o contador de tentativas
        } else {
            cout << "Obrigado por participar do jogo, volte sempre!!" << endl;
            escolha = 0;
            break;
        }
    } while (escolha == 1);
    
    return 0;
}
