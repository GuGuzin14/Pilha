public class No{
    public int valor;
    public No prox;

    // public string valor;
  

    public No(int Valor){
        this.valor = Valor;
        this.prox = null;
    }

    //  public No(string Valor){
    //     this.valor = Valor;
    //     this.prox = null;
    // }

    public string imprimir(){
        //Console.WriteLine("Valor: " + this.valor);
        return "Valor: " + this.valor;
    }

}
