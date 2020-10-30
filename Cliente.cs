class Cliente{
  //Definindo atributos do Client
  string nome,endereco,email,sexo;
  double telefone,cpf,idade;
  
  //Construtor Vazio da Classe Cliente
  /*public Cliente(){
    nome = "João";
    endereco = "Rua dos Bobos";
    email = "joao_a@gmail.com";
    sexo = "Questionando";
    telefone = 2732282927;
    cpf = 12376523412;
    idade = 18;
  }*/

  //Construtor completo da Classe Cliente
  public Cliente(string n,string e,string em,string s,double t,double c,double i){
    nome = n;
    endereco = e;
    email = em;
    sexo = s;
    telefone = t;
    cpf = c;
    idade = i;
  }

  //Construtor Para teste

  public Cliente(string n,double c){
    nome = n;
    cpf = c;
  }

  //Getters dos atributos do Cliente

  public string get_nome(){
    return nome;
  }
   public string get_endereco(){
    return endereco;
  }
   public string get_email(){
    return email;
  }
   public string get_sexo(){
    return sexo;
  }
   public double get_telfone(){
    return telefone;
  }
  public double get_cpf(){
    return cpf;
  }
  public double get_idade(){
    return idade;
  }

}