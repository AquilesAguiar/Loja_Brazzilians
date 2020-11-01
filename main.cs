using System;
using System.Globalization;
using System.Collections.Generic;

//As Regras de Negócios podem Ser Encontradas pela Tag []

class MainClass {
  public static void Main (string[] args) {

/*-------------------------------------------------------*///Instanciando as Classes
/*-------------------------------------------------------*/  
    Loja produtos = new Loja();

    /*Cliente NovoCliente = new Cliente("Aquiles","Laranjeiras","joão@gmail.com","Masculino",27940028922,12343254376,18); //Classe cliente (Construtor Completo)*/

    Cliente NovoCliente = new Cliente("aquiles",2333333);//Construtor Teste

    carrinho_compra NovoCarrinho = new carrinho_compra("Pão",2,0.76,0); //Classe Carrinho_Compra

    simuPag pagamento = new simuPag();

    //Instanciando as Listas
   
    List<Cliente> ListaClientes = new List<Cliente>(); //Lista Clientes

    List<carrinho_compra> ListaCarrinho = new List<carrinho_compra>(); //Lista Carrinho_Compra

/*-------------------------------------------------------*///Funcionamento da Loja
/*-------------------------------------------------------*/   
    //Definindo Variaveis
    string NomeC,endereco,email,sexo,deleta,pagar;
    double cpf,tele,idade,total = 0,decis = 0;
    int codigo, quantRet;

    //mensagem de boas vindas

    Console.WriteLine(@"                             Loja Brazillians
Loja feita por Brasileiros para Brasileiros,na nossa Loja você irá encotrar tudo que precisa,boatos dizem que Havan e Americanas tem medo da gente, e é pra ter mesmo.

Porque aqui é o Brasillll !!!!


Aperte qualquer Tecla Para continuar");

Console.ReadLine();
Console.Clear();

    //Criando Novo Cliente
    
    //inserção de dados pelo usuario
    Console.Write("Insira seu Nome >>");
    NomeC = Console.ReadLine();
    Console.Write("Insira seu CPF >>");
    cpf = double.Parse(Console.ReadLine());
    /*
    Console.Write("Insira seu Endereço >>");
    endereco = Console.ReadLine();
    Console.Write("Insira seu Telefone>>");
    tele = double.Parse(Console.ReadLine());

    Console.Write("Insira seu Email >>");
    email = Console.ReadLine();
    Console.Write("Insira sua Idade >>");
    idade = double.Parse(Console.ReadLine());

    Console.Write("Insia seu Sexo >>");
    sexo = Console.ReadLine();
    
    //Adicionando o Cliente na Lista
    NovoCliente = new Cliente(NomeC,endereco,email,sexo,tele,cpf,idade);
    ListaClientes.Add(NovoCliente);*/

    //Adicionando o Cliente na Lista (Teste)
    NovoCliente = new Cliente(NomeC,cpf);
    ListaClientes.Add(NovoCliente);

    Console.Clear();//Limpa Terminal

   //Funcionamento Da loja
    while(decis != 5){

      Console.Write("Escolha o que deseja Fazer\n 1 - Mostrar Catálogo de Produtos\n 2 - Comprar Itens\n 3 - Mostrar Carrinho de Compras\n 4 - Retirar Itens do Carrinho\n 5 - Finalizar Compra\n >>");

      decis = int.Parse(Console.ReadLine());

      Console.Clear();

      //Mostra Catálogo
      if(decis == 1){
        //Mostrando Itens da Loja
        Console.WriteLine(@"             Lista De Produtos Brazillians ");
        for(int x = 0; x < produtos.get_NomeProdutos().Count; x++){
        Console.WriteLine($@"
Código >> {produtos.get_CodProdutos()[x]}   |   Produto >> {produtos.get_NomeProdutos()[x]}  |   Preço >>  {produtos.get_PrecoProdutos()[x]} | ");
        }
      }
      
      // Compra Itens
      if(decis == 2){

        //Codigo do Produto
        Console.Write("Insira o Código do Produto que deseja adquirir >>");
        codigo = int.Parse(Console.ReadLine());

      
        //Quantidade que será retirada do estoque
        Console.Write("Insira a quantidade do Produto que deseja adquirir >>");
        quantRet = int.Parse(Console.ReadLine());
        
        // Vai rodar até achar o índice certo.
        for(int x = 0; x < produtos.get_QtdProdutos().Count; x++) {
        
          // Se o código for igual ao código do produto
          if (codigo == produtos.get_CodProdutos()[x]){
            
            // Se estoque estiver disponivel adiciona na lista
            if(quantRet <= produtos.get_QtdProdutos()[x] ){
              
              //Adicionando itens no Construtor Carrinho
              NovoCarrinho = new carrinho_compra(produtos.get_NomeProdutos()[x],quantRet,produtos.get_PrecoProdutos()[x],produtos.get_CodProdutos()[x]);

              // Adicionando na Lista carrinho
              ListaCarrinho.Add(NovoCarrinho);
              Console.WriteLine("Itens adicionado no Carrinho");
            }
            
            // Se não printa uma mensagem de erro [RN - 01 Cliente não pode escolher quantidade de produto abaixo do estoque]
            else{
              Console.WriteLine("Quantidade de Estoque abaixo do esperado");
            }
          }
        }
      }

      //Mostra Carrinho
      if(decis == 3){
        total = 0;
      
        //Printa o Carrinho para o cliente
        Console.WriteLine($@"                       Carrinho de Compra");
        for(int x = 0; x < ListaCarrinho.Count;x++ ){
          Console.WriteLine($@"                       
  ----------------------------------------------------------

  Código >> {ListaCarrinho[x].get_cod()}
  Produto >> {ListaCarrinho[x].get_produto()}
  Valor Por Quantidade >> R${ListaCarrinho[x].get_valor()} X {ListaCarrinho[x].get_quantidade()} = R${NovoCarrinho.calcula_valor(ListaCarrinho[x].get_valor(),ListaCarrinho[x].get_quantidade())}
  ");   
        //Realiza o Caculo para o Total da compra realizada
        total = total+NovoCarrinho.calcula_valor(ListaCarrinho[x].get_valor(),ListaCarrinho[x].get_quantidade());
        }
        Console.WriteLine($"\nTotal da Compra >> R${total}");       
      }

      //Retira Itens do Carrinho
      if(decis == 4){

         //Deve se passa o código do produto que deseja apagar
        Console.Write("Insira o código que deseja apagar >>");
        codigo = int.Parse(Console.ReadLine());

          //Um for irá percorrer a Lista
          for(int x = 0; x < ListaCarrinho.Count;x++ ){
            
            //Quando achar o código do produto
            if(codigo  == ListaCarrinho[x].get_cod() ){

                //Remove em todos os itens daquele indice da lista

                Console.WriteLine("Apagando....");
                ListaCarrinho.RemoveAt(x);
                
                //[RN - 02 Remove os itens do estoque]
                produtos.get_QtdProdutos()[x] = produtos.get_QtdProdutos()[x] - ListaCarrinho[x].get_quantidade();
            }
          }
      }

      //Finaliza Compra
      if(decis == 5){

        Console.WriteLine("Carrinho De Compra");

        for(int x = 0; x < ListaCarrinho.Count;x++ ){
            Console.WriteLine($@"                       
    ----------------------------------------------------------

    Código >> {ListaCarrinho[x].get_cod()}
    Produto >> {ListaCarrinho[x].get_produto()}
    Valor Por Quantidade >> R${ListaCarrinho[x].get_valor()} X {ListaCarrinho[x].get_quantidade()} = R${NovoCarrinho.calcula_valor(ListaCarrinho[x].get_valor(),ListaCarrinho[x].get_quantidade())}
    ");    
        }
          //[RN - 03 Simulação de pagamento]
          //Simulação de pagamento
        Console.WriteLine($"Total da Compra >> R${total}");
        
        Console.Write("\nComo deseja pagar ? Boleto/cartao >>");
        pagar = Console.ReadLine();
          
        cpf = ListaClientes[0].get_cpf();

        if (pagar.ToLower() == "boleto"){
          Console.WriteLine(pagamento.PagarBoleto(total,cpf));
        }
            
        else if (pagar.ToLower() == "cartao"){
          Console.Write("Insira o valor do seu cartão >>");
          double valorcart =  double.Parse(Console.ReadLine());

          Console.WriteLine(pagamento.PagarCartao(total,valorcart,cpf));
          }
      }
    } 
  }
}
