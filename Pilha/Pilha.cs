public class Pilha{
    public No topo;

    public Pilha(){
        this.topo = null;
    }

    public Boolean estaVazia(){
        if(this.topo == null){
            return(true);
        }
        return(false);
    }

    public void push(int valor){
        No novoNo = new No(valor);

        if(this.estaVazia() == true){
            this.topo = novoNo;
        }
        else{
            novoNo.prox = this.topo;
            this.topo = novoNo;
        }
    }

    //PUSH PARA STRING
    // public void push(string valor){
    //     No novoNo = new No(valor);

    //     if(this.estaVazia() == true){
    //         this.topo = novoNo;
    //     }
    //     else{
    //         novoNo.prox = this.topo;
    //         this.topo = novoNo;
    //     }
    // }

    public No pop(){
        No aux = null;
        if(this.estaVazia() == true){
            return(aux);
        }
        else{
            aux = this.topo;
            this.topo = this.topo.prox;
            aux.prox = null;
            return(aux);
        }
    }

    public Boolean consulta(int valor, ref No noAtual){
        noAtual = this.topo; //Copia da lista
        while(noAtual != null){ //Percorrer lista
            if(noAtual.valor == valor){
                return(true);
            }
            noAtual = noAtual.prox;
        }
        return(false);
    }

    public void imprimir(){ //percorrer a lista...

        No aux = this.topo; //Copia do inicio da listsa
        
        Console.WriteLine("Elementos: ");
        
        while(aux != null){
            Console.Write(aux.valor + " -> ");
            aux = aux.prox;
        }
    }

    public void vericaqtde(){

         No noAtual = this.topo;
         int qtde = 0;

        while(noAtual != null){
            noAtual = noAtual.prox;
            qtde++;
        }
        Console.WriteLine("valores: " + qtde);
    }

    public void contaImpares(){
    No noAtual = this.topo;
    int qtdeImpares = 0;

    while(noAtual != null){
        if (noAtual.valor % 2 != 0) { // Verifica se o valor é ímpar
            qtdeImpares++;
        }
        noAtual = noAtual.prox;
    }

    Console.WriteLine("Quantidade de valores ímpares: " + qtdeImpares);
}

public void separaPositivosNegativos(Pilha pilha2, Pilha pilha3) {
    No noAtual = this.topo;  // Percorrer a Pilha1

    while (noAtual != null) {
        if (noAtual.valor >= 0) {
            pilha2.push(noAtual.valor);  // Empilhar valores positivos em pilha2
        } else {
            pilha3.push(noAtual.valor);  // Empilhar valores negativos em pilha3
        }
        noAtual = noAtual.prox;
    }
}

public void inverterPilha() {
    Pilha pilhaAux = new();  

    while (!this.estaVazia()) {
        pilhaAux.push(this.pop().valor);  
    }

    this.topo = pilhaAux.topo;  
}

public bool Palindromo() {
    Pilha pilhaAux = new();  // Pilha auxiliar para armazenar os elementos na ordem inversa
    No noAtual = this.topo;
    string palavraOriginal = "";
    string palavraInvertida = "";

    // Preenche a pilha auxiliar e cria a string original
    while (noAtual != null) {
        pilhaAux.push(noAtual.valor);     // Coloca os valores na pilha auxiliar
        palavraOriginal += noAtual.valor; // Cria a string com a palavra original
        noAtual = noAtual.prox;
    }

    // Cria a string invertida desempilhando a pilha auxiliar
    while (!pilhaAux.estaVazia()) {
        palavraInvertida += pilhaAux.pop().valor;  // Cria a string invertida
    }

    // Verifica se a palavra original é igual à palavra invertida
    return palavraOriginal == palavraInvertida;
}

public void transferirPilha(Pilha pilhaDestino) {
    Pilha pilhaAux = new();  // Pilha auxiliar para inverter os elementos

    // Transfere os elementos de Pilha1 para PilhaAux, invertendo a ordem
    while (!this.estaVazia()) {
        pilhaAux.push(this.pop().valor);  // Desempilha da Pilha1 e empilha na PilhaAux
    }

    // Transfere os elementos de PilhaAux para Pilha2, restaurando a ordem original
    while (!pilhaAux.estaVazia()) {
        pilhaDestino.push(pilhaAux.pop().valor);  // Desempilha de PilhaAux e empilha na Pilha2
    }
}









}