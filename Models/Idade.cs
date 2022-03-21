using static System.Console;
namespace TESTE_2_GFT.Models
{
    public class Idade
    {
        public int DataNasc;
        
        public int AnoAtual;

    public void Mensagem ()
    {
        WriteLine("Digite o ano atual: ");
        AnoAtual = int.Parse(Console.ReadLine());
        WriteLine("Insira sua data de nascimento:");
        DataNasc = int.Parse(ReadLine());
    }
    public void Resposta()
    {
       var Resultado =  AnoAtual - DataNasc;
       WriteLine($"A sua idade  é {Resultado} anos.");
    }
}
}
