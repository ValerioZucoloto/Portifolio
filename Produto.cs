using System.Globalization;

class Produto {
  private string nome;
  private double preco;
  private int quantidadeEmEstoque;

  public string getNome () {
    return this.nome;
  }

  public void setNome (string nome) {
     this.nome = nome;
  }

  public double getPreco () {
    return this.preco;
  }

  public void setPreco (double preco){
    this.preco = preco;
  }

  public int getquantidadeEmEstoque () {
    return this.quantidadeEmEstoque;
  }


  public Produto (string nome, double preco, int quantidadeEmEstoque) {
    this.nome = nome;
    this.preco = preco;
    this.quantidadeEmEstoque = quantidadeEmEstoque;
  }

  public double valorTotalEmEstoque(){
    return preco*quantidadeEmEstoque;
  }
  public void realizarEntrada (int quantidade) {
    quantidadeEmEstoque = quantidadeEmEstoque + quantidade;
  }

  public void realizarSaida (int quantidade) {
    quantidadeEmEstoque = quantidadeEmEstoque - quantidade;
  }

  public override string ToString () {
    return nome + " , " + preco.ToString ("F2", CultureInfo.InvariantCulture) + " , " + quantidadeEmEstoque;
  }





}