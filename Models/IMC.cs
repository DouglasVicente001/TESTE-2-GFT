using static System.Console;
namespace TESTE_2_GFT.Models
{
    public class IMC
    {
       public double Peso;
       public double Altura;

       public double Resultado;

       public void Mensagem()
       {
        WriteLine("Insira seu peso:");
        Peso = double.Parse(ReadLine());
        WriteLine("Insira sua altura");
        Altura = double.Parse(ReadLine());
       }
       public void Resposta()
       {
        Resultado = Peso/(Altura*Altura);
        WriteLine($"O seu índice de massa corporal [IMC] é: {Resultado}");
       }
    }
}