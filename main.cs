using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Cliente NovoClinte = new Cliente();
    Console.WriteLine(NovoClinte.get_sexo());
  }
}