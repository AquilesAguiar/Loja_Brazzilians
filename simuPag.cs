using System;
class simuPag{
  public string PagarBoleto(total,cpf){
    Randon rdn= new Randon();
    return $@"O utilizador do cpf {cpf} Teve um Boleto no valor de {total} gerado com sucesso !!!!
Utilize este código para realizar o pagametno bancario >> {rdn.Next(1000000000000000000,9999999999999999999);} ";
  }
  public string PagarCartao (total,valorcart,cpf){

  }
  
}