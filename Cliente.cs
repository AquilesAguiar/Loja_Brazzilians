class Cliente{
  //Definindo atributos do Client
  string nome,endereco,email,sexo;
  int telefone,cpf;
  
  //Construtor Vazio da Classe Cliente
  public Cliente(){
    nome = "João";
    endereco = "Rua dos Bobos";
    email = "joao_a@gmail.com";
    sexo = "Questionando";
    telefone = 2732282927;
    cpf = 12376523412;
  }

  //Construtor completo da Classe Cliente
  public Cliente(string n,string e,string em,string s,int t,int c){
    nome = n;
    endereco = e;
    email = em;
    sexo = s;
    telefone = t;
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
    return nome;
  }
   public int get_telfone(){
    return telefone;
  }
  public int get_cpf(){
    return cpf;
  }

}