using System;
class simuPag{
  public string PagarBoleto(double total, double cpf){
    Random rdn= new Random();
    int numR = rdn.Next(10000000,99999999);

    string texto = $@"O utilizador do cpf {cpf} Teve um Boleto no valor de {total} gerado com sucesso !!!!
Utilize este código para realizar o pagametno bancario >> {numR} ";

    return texto;
  }
  
  public string PagarCartao (double total,double valorcart, double cpf){
    if (valorcart < total){
      return $"Transação do cpf {cpf} não Aprovada,Valor do Cartão abaixo do valor da compra de R${total}";
    }
    else{
      double resultado = valorcart - total;

      return $"Transação do cpf {cpf} aprovada com sucesso.\nValor da compra >> R${total}\nSaldo Restande no Cartão >> R${resultado}";
    }
    
  }
  
}