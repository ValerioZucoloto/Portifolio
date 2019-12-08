using System;

class Robo{
  private string nome;
  private int idade;
  private double ataque, defesa;
  private string estado;
  
  //Construtor com parametros
  public Robo(string nome, int idade, double ataque, double defesa, string estado){
      this.nome = nome;
      this.idade = idade;
      this.ataque = ataque;
      this.defesa = defesa;
      this.estado = estado;
  }

  //Construtor sem parametros
  public Robo(){
      nome = "Não Informado";
      idade = 0;
      ataque = 0.0;
      defesa = 0.0;
  }

  //Metodos Get e Set
  public void SetNome(string n){
    this.nome = n;
  }

  public string GetNome(){
    return nome;
  }

  public void SetIdade(int nIdade){
    this.idade = nIdade;
  }

  public int GetIdade(){
    return idade;
  }

  public bool RealizarAtaque(Robo outroRobo){
    //Um robô só pode atacar se possuir pelo menos 10% de força de ataque e se estiver no estado Normal ou Fraco.
    if(this.ataque >= 10 && this.estado == "normal" || this.ataque >= 10 && this.estado == "fraco"){
      this.ataque = this.ataque - 5;
      outroRobo.defesa = outroRobo.defesa - 20;

      //Caso sua força de defesa fique abaixo de 40% ele passa para o estado Fraco
      if(outroRobo.defesa <= 40){
       outroRobo.estado = "fraco";
      }

      //caso fique abaixo de 0% ele passa para o estado Indefeso
      if(outroRobo.defesa <= 0){
        outroRobo.estado = "indefeso";
      }

      return true;

    }
    return false;
  }

  public void DoarForcaDefesa(Robo roboRecebedor, double percentual){
    //O robô doador só pode doar força de defesa se ele estiver no estado Normal e se a quantidade a ser doada não alterar esse estado
    if(this.estado == "normal" && this.defesa - percentual >= 40 ){
      //O método deve receber como parâmetro o robô de destino e o percentual a ser doado
      this.defesa = this.defesa - percentual;
      roboRecebedor.defesa = roboRecebedor.defesa + percentual;
      Console.WriteLine("Doação Realizada com Sucesso");
      Console.WriteLine("Força de Defesa do Doador: " + this.defesa + "%");
      Console.WriteLine("Força de Defesa do Recebedor: " + roboRecebedor.defesa + "%");
    }else{
      Console.WriteLine("Não foi possível doar força de Defesa");
    }
  }

}