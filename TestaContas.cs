namespace aula02
{
    public class TestaContas
    {
        public  void Main()
        {
            Contas C1 = new Contas();
            C1.NumeroConta = 1234;
            C1.Saldo = 2000;
            C1.Limite = 10000;

            Console WriteLine(C1.NumeroConta);
            Console WriteLine(C1.Saldo);

        }
    }
} 