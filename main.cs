using System;


class MainClass {
  public static void Main (string[] args) {
        /*ContaUsuario usuario = new ContaUsuario (1080, "Valério", 0.0);
        ContaEmpresa empresa = new ContaEmpresa (1090, "Joaquim", 0.0, 500.0);

        //UPCASTING (Conversão da SUBCLASSE para SUPERCLASSE)

        ContaUsuario usuario1 = empresa;
        ContaUsuario usuario2 = new ContaEmpresa (1003, "Bob", 0.0, 200.0);
        ContaUsuario usuario3 = new ContaPoupanca (1004, "Ana", 0.0, 0.01);

        // DOWCASTING (Conversão da SUPERCLASSE para SUBCLASSE)

        ContaEmpresa usuario4 = (ContaEmpresa) usuario2;
        usuario4.Emprestimo(100.0);

        //ContaEmpresa usuario5 = (ContaEmpresa) usuario3;
        if (usuario3 is ContaEmpresa) {
                //ContaEmpresa usuario5 = (ContaEmpresa) usuario3;
                ContaEmpresa usuario5 = usuario3 as ContaEmpresa ;
                usuario5.Emprestimo (200.0);
                Console.WriteLine ("Empréstimo realizado com sucesso !");
        }

        if (usuario3 is ContaPoupanca) {
               //ContaPoupanca usuario5 = (ContaPoupanca) usuario3;
               ContaPoupanca usuario5 = usuario3 as ContaPoupanca;
               usuario5.SaldoAtualizado();
               Console.WriteLine("Atualizado!");
        }*/

        ContaUsuario acc1 = new ContaUsuario (1050, "Alex", 500.0);
        ContaUsuario acc2 = new ContaPoupanca (1060, "Anna", 500.0, 0.01);

        acc1.Saque (10.0);
        acc2.Saque (10.0);

        Console.WriteLine (acc1.Saldo);
        Console.WriteLine (acc2.Saldo);

  }
}