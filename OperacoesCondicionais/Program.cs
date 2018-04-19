using System;

namespace OperacoesCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
        //Comentario in-line(em linha)
        /*
        Comentario in-block(em bloco)
         */
         //declaração da variavel operação. Ela será dp tipo inteira
         
         int operacao;
          
          //declaração das variaveis n1 e n2 elas serão do tipo double
          
          double n1, n2;
          
          /* Para limpar a tela de comando a cada execução utilizaremos o comando clear();
          obs.: Clear limpar
          */
          
          Console.Clear();
          Console.WriteLine("Escolha uma das operações abaixo:");
          
          /* Para as exibição das opçoes de operaçoes, vamos usar o comando Console.EriteLine e,
           nele usaremos um comando de qurebra de linha\n (contra-barra(new line))
          Assim,as opções ficaram uma abaixo da outra          
           */
           Console.WriteLine("1-Soma\n2-Subtrair\n3-Multiplicar\n4-Dividir");
           
           operacao = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite um numero:");
           n1 = double.Parse(Console.ReadLine());
           Console.WriteLine("Digite outro numero");
           
        }
    }
}
