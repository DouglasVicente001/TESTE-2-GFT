using TESTE_2_GFT.Models;
using static System.Console;
namespace Teste_2_GFT
{
  class program 
  {
    public static void Main(string[] args)
    {
      int Opcao,resp;
      while (true) 
      {
      WriteLine("OPÇÕES DO PROGRAMA");
      WriteLine("______________________");
      WriteLine("Descobrir Idade. Pressione [1]");
      WriteLine("Descobrir IMC. Pressione [2] ");
      WriteLine("Sair .Pressione [3]");
      Opcao = int.Parse(ReadLine());

      switch (Opcao)
      {
        case 1:
          Idade p1 = new Idade();
          
          p1.Mensagem();
          p1.Resposta();
          break;

        case 2:
          IMC p2 = new IMC();
          p2.Mensagem();
          p2.Resposta();
          break;
        
        case 3:
          WriteLine("Você saiu:");
          break;

        default:
          WriteLine("Digite uma opção válida!");
          break;
          }
        WriteLine("Deseja sair do programa? [0]sim / [1]nao");
        resp = int.Parse(ReadLine());
        if (resp == 0)
        {
          WriteLine("tchau. Obrigado por usar nossos serviços. :)");
          break;
        }
        }
    }
  }
}