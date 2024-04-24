#include <iostream>
#include <string>
#include <algorithm>

// Função para inverter a ordem dos números
std::string inverterOrdem(int numero) {
    // Convertendo o número para uma string
    std::string str_numero = std::to_string(numero);
    
    // Invertendo a string
    std::reverse(str_numero.begin(), str_numero.end());
    
    return str_numero;
}

int main() {
    int numero;
    std::cout << "Digite um número: ";
    std::cin >> numero;
    
    // Chamando a função para inverter a ordem dos números
    std::string numero_invertido = inverterOrdem(numero);
    
    // Exibindo o resultado
    std::cout << "Número invertido: " << numero_invertido << std::endl;
    
    return 0;
}
