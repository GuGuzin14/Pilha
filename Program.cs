using System;

namespace Aula{

    class Program{
        static void Main(string[] args){


            //EX 1A, EX 1B, EX 1D
             Pilha pilha = new();
            // Pilha pilha2 = new();
            // Pilha pilha3 = new();


             pilha.push(10);
             pilha.push(5);
             pilha.push(-50);
             pilha.push(200);
            
             pilha.imprimir();
             pilha.pop();
             pilha.imprimir();
            
            //EX 1C
            // int valor = 10;
            // No noAtual;
            // noAtual = null;

            // Boolean verif = pilha.consulta(valor, ref noAtual);

            // if(verif == true)Console.WriteLine("A busca encontrou!");
            // else Console.WriteLine("A busca não encontrou!");


            //ex 1D
            

            //EX 2
            // pilha.vericaqtde();


            //EX 3
            // pilha.contaImpares();

            //EX 4
            // pilha.separaPositivosNegativos(pilha2, pilha3);

            // Console.WriteLine("\nPilha com valores positivos:");
            // pilha2.imprimir();

            // Console.WriteLine("\nPilha com valores negativos:");
            // pilha3.imprimir();

         


    //EX 5
    //     Pilha pilhaLetras = new();

    // pilhaLetras.push("A");
    // pilhaLetras.push("B");
    // pilhaLetras.push("C");
    // pilhaLetras.push("D");

    // Console.WriteLine("Pilha original:");
    // pilhaLetras.imprimir();  // Mostra a pilha original

    // // Chama a função para inverter a ordem das letras
    // pilhaLetras.inverterPilha();

    // Console.WriteLine("\nPilha invertida:");
    // pilhaLetras.imprimir();  
    // }

          //EX 6
//     Pilha pilhaLetras = new();

//     pilhaLetras.push("N");
//     pilhaLetras.push("A");
//     pilhaLetras.push("D");
//     pilhaLetras.push("A");


//     Console.WriteLine("Pilha original:");
//     pilhaLetras.imprimir();

//     // Chama a função para verificar se a palavra formada na pilha é um palíndromo
//     if (pilhaLetras.Palindromo()) {
//         Console.WriteLine("\nA palavra formada na pilha é um palíndromo.");
//     } else {
//         Console.WriteLine("\nA palavra formada na pilha não é um palíndromo.");
//     }
// }

    
    // Pilha pilha2 = new();  // Pilha de destino

    // pilha.push(10);
    // pilha.push(20);
    // pilha.push(30);

    // Console.WriteLine("Pilha1 original:");
    // pilha.imprimir();

    // // Chama a função para transferir os elementos de Pilha1 para Pilha2
    // pilha.transferirPilha(pilha2);

    // Console.WriteLine("\nPilha2 após transferência (ordem mantida):");
    // pilha2.imprimir();



         }
        
    }

}

