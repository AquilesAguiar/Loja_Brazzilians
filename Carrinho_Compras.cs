class carrinho_compra{

  //Definindo Os atributos
  string produto;
  double valor;
  int cod,quantidade;

  //Construtor Completo
  public carrinho_compra(string p,int q,double v,int c){
    produto = p;
    quantidade = q;
    valor = v;
    cod = c;
  }

  //Calcula Valor*quantidade
  public double calcula_valor(double v,double q){
    return v*q;
  }


  //Getters
  public string get_produto(){
    return produto;
  }

  public int get_quantidade(){
    return quantidade;
  }

  public double get_valor(){
    return valor;
  }
  public int get_cod(){
    return cod;
  }

}