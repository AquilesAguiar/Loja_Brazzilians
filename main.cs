using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

/*-------------------------------------------------------*///Instanciando as Classes
/*-------------------------------------------------------*/  
    Loja produtos = new Loja();

    Cliente NovoClinte = new Cliente("Aquiles","Laranjeiras","joão@gmail.com","Masculino",27940028922,12343254376,18); //Classe cliente

    carrinho_compra NovoCarrinho = new carrinho_compra("Pão",2,0.76); //Classe Carrinho_Compra

    //Instanciando as Listas
    List<Cliente> ListaClientes = new List<Cliente>(); //Lista Clientes

    List<carrinho_compra> ListaCarrinho = new List<carrinho_compra>(); //Lista Carrinho_Compra

/*-------------------------------------------------------*///Funcionamento da Loja
/*-------------------------------------------------------*/

    //Criando Novo Cliente

    //Criando Var
    string NomeC,endereco,email,sexo;
    double cpf,tele,idade;

    //inserção de dados pelo usuario
    Console.Write("Insira seu Nome >>");
    NomeC = Console.ReadLine();
    Console.Write("Insira seu CPF >>");
    cpf = double.Parse(Console.ReadLine());

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
    NovoClinte = new Cliente(NomeC,endereco,email,sexo,tele,cpf,idade);
    ListaClientes.Add(NovoClinte);

    
    //Criando Carrinho_Compras

    //definindo Var
    string decis = "S";

    while(decis == "S"){
      Console.Write("CONTINUAR? S/N");
      decis = Console.ReadLine();
    }

  }
}