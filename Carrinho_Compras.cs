class carrinho_compra{
  string produto;
  double quantidade,valor;

  public carrinho_compra(string p,double q,double v){
    produto = p;
    quantidade = q;
    valor = v;
  }

  public double calcula_valor(){
    return valor*quantidade;
  }

  public string get_produto(){
    return produto;
  }

  public double get_quantidade(){
    return quantidade;
  }

  public double get_valor(){
    return valor;
  }

}