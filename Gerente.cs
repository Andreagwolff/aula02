namespace aula02
{
    public class Gerente
    {
        string nome = "André Guilherme Wolff";
 double salario = 1500;
  
 void aumentarSalario(){
      
     this.salario += this.salario * 0.1;
      
 }
     
    void aumentarSalarioVariavel (double taxa){
         
        this.salario += this.salario * taxa;
    }
     
}
    }
