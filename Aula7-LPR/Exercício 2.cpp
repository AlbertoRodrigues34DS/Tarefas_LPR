#include <iostream>


// Função 1: Calcula a média aritmética dos números pares
void calcularMediaPares() {
    int quantidade, valores, soma = 0, contador = 1, escolha = 1, boas = 1;
    double media;
    if (boas == 1) {
        std::cout << "Olá usuário, por favor insira quantos valores você irá colocar para fazermos a média aritmética dos números pares." << std::endl;
    }
    while (true) {
        std::cin >> quantidade;
        std::cout << "Agora insira os valores para fazer a média aritmética." << std::endl;
        while (contador < quantidade) {
            std::cin >> valores;
            if (valores % 2 == 0) {
                soma += valores;
                contador++;
            }
        }
        if (quantidade > 0) {
            media = soma * 1.0 / quantidade; // Convertendo para double antes de dividir
            std::cout << "A média aritmética desses valores é de: " << media << std::endl;
        }
        else {
            std::cout << "Não há números suficientes para fazer a média." << std::endl;
        }
        std::cout << "Deseja continuar a fazer a média? Digite 1 para continuar, caso contrário, digite qualquer letra ou número e pressione enter." << std::endl;
        std::cin >> escolha;
        if (escolha == 1) {
            std::cout << "Então por favor, insira novamente a quantidade de valores." << std::endl;
            boas = 0;
            soma = 0;
            contador = 0;
        }
        else {
            std::cout << "Obrigado por utilizar nosso programa, volte sempre!" << std::endl;
            break;
        }
    }
}

// Função 2: Calcula a soma dos números ímpares múltiplos de 3 de 50 a 500
void calcularSomaImparesMultiplosTres() {
    int resultado = 0;
    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            resultado += i;
        }
    }
    std::cout << "A soma dos números ímpares múltiplos de 3 de 50 a 500 é: " << resultado << std::endl;

    // Opção para repetir o processo ou voltar ao switch
    char escolha;
    std::cout << "Deseja repetir o processo? (s/n): ";
    std::cin >> escolha;
    if (escolha == 's' || escolha == 'S') {
        calcularSomaImparesMultiplosTres();
    }
}

// Função 3: Calcula a soma dos dígitos do quadrado de um número
void calcularSomaDigitosQuadrado() {
    int numero = 0;
    int quadrado = 0;
    int soma = 0;
    bool continua = true;
    bool ola = true;
    while (continua) {
        while (ola) {
            std::cout << "Olá usuário, por favor insira um número inteiro para fazermos a soma dos seus algarismos após elevar ele ao quadrado:" << std::endl;
            std::cin >> numero;
            std::cout << "Enquanto fazemos o cálculo, poderia nos avaliar? De 1 a 5, o que você acha do nosso programa?" << std::endl;
            int avalia;
            std::cin >> avalia;
            if (avalia >= 4) {
                std::cout << "Obrigado pela nota alta, sua satisfação é a nossa felicidade :)." << std::endl;
                ola = false;
            }
            else if (avalia == 3) {
                std::cout << "Que pena que não superamos mais além da média da sua expectativa. Depois entre em nosso site www.somadorfacil.com.br e nos diga o que faltou para melhorarmos o nosso serviço." << std::endl;
                ola = false;
            }
            else {
                std::cout << "Pedimos perdão pela má experiência. Esperamos que numa próxima possamos melhorar nosso desempenho com você." << std::endl;
                ola = false;
            }
        }
        quadrado = numero * numero;
        while (quadrado > 0) {
            soma += quadrado % 10;
            quadrado /= 10;
        }
        std::cout << "O resultado da soma dos dígitos do quadrado de " << numero << " é: " << soma << std::endl;
        std::cout << "Deseja continuar? Digite 1 para continuar." << std::endl;
        int escolha;
        std::cin >> escolha;
        if (escolha == 1) {
            std::cout << "Então, por favor insira novamente um número." << std::endl;
            soma = 0;
            quadrado = 0;
            ola = false;
            std::cin >> numero;
            quadrado = numero * numero;
        }
        else {
            std::cout << "Obrigado por usar o nosso programa, volte sempre!!" << std::endl;
            continua = false;
        }
    }

    // Opção para repetir o processo ou voltar ao switch
    char repetir;
    std::cout << "Deseja repetir o processo? (s/n): ";
    std::cin >> repetir;
    if (repetir == 's' || repetir == 'S') {
        calcularSomaDigitosQuadrado();
    }
}

int main() {
    int opcao;
    do {
        std::cout << "Escolha uma opção:" << std::endl;
        std::cout << "1. Calcular média aritmética dos números pares" << std::endl;
        std::cout << "2. Calcular soma dos números ímpares múltiplos de 3 de 50 a 500" << std::endl;
        std::cout << "3. Calcular soma dos dígitos do quadrado de um número" << std::endl;
        std::cout << "4. Sair" << std::endl;
        std::cin >> opcao;

        switch (opcao) {
            case 1:
                calcularMediaPares();
                break;
            case 2:
                calcularSomaImparesMultiplosTres();
                break;
            case 3:
                calcularSomaDigitosQuadrado();
                break;
            case 4:
                std::cout << "Obrigado por utilizar nosso programa, volte sempre!" << std::endl;
                break;
            default:
                std::cout << "Opção inválida!" << std::endl;
                break;
        }
    } while (opcao != 4);

    return 0;
}
