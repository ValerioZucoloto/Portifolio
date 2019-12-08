using System;

class Navio {

  private double carga_atual;
  private double carga_maxima;
  private string nome;
  private string fabricante;


  public Navio () {
    carga_atual = 0;
    carga_maxima = 0;
    nome = "Não informado";
    fabricante = "Não informado";
  }

  public Navio (double carga_atual, double carga_maxima, string nome, string fabricante ) {
    this.carga_atual = carga_atual ;
    this.carga_maxima = carga_maxima;
    this.nome = nome;
    this.fabricante = fabricante;
  }


  // GET set 

  public double Getcarga_atual () {
    return carga_atual;
  }

  public double Setcarga_atual () {
    return carga_atual;
  }

  public double Getcarga_maxima (){
    return carga_maxima;
  }

  public double Setcarga_maxima () {
    return carga_maxima;
  }

  public string Getnome (){
    return nome;
  }

  public string Setnome () {
    return nome;
  }


  public string Getfabricante (){
    return fabricante;
  }




  // Método MaiorCapacidade

  public bool MaiorCapacidade(Navio outro) {
    if (carga_maxima > outro.carga_maxima){
      return true;
    }else{
      return false;
    }
  }

  // Método Embarcar

  public void Embarcar (double qtdCarga) {
    if (qtdCarga < carga_maxima) {
      carga_atual -= qtdCarga;
      Console.WriteLine ("Embarque efetuado !");
    }
  }

   

}