using System;

namespace aula02
{
    class Program
    {
        static void Main()
        {
           
            Contas C1 = new Contas();
            C1.NumeroConta = 1234;
            C1.Saldo = 2000;
            C1.Limite = 10000;
            

            Console. WriteLine(C1.NumeroConta);
            Console. WriteLine(C1.Saldo);

            Clientes C3 = new Clientes();
            C3.Nome = "Pedro da Silva";
            C3.Cod = 12345;

            Clientes C4 = new Clientes();
            C4.Nome = "Ana Maria";
            C4.Cod = 67869;
            

            Console. WriteLine(C3.Nome);
            Console. WriteLine(C3.Cod);

            Console. WriteLine(C4.Nome);
            Console. WriteLine(C4.Cod);



    
     

            Console.WriteLine("bom dia");

            Console.ReadLine();
        }
    }
}
    

