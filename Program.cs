using System;

namespace DesafioRookie
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("O JOGO VAI COMEÇAR:");
            Console.WriteLine();
            Console.WriteLine("Serão 3 desafios, a regra é: escolha a passagem correta.");
            Console.WriteLine("Caso contrario voce será eliminado!");

            Console.WriteLine("Pode esolher somenta A (direita) ou B (esquerda)");
            Console.WriteLine("");
            Console.WriteLine("JOGADOR 01 É A SUA VEZ DE PARTICIPAR");
            Console.WriteLine("Digite 1 para: A");
            Console.WriteLine(" OU 2 para: B ");
            Console.WriteLine("SE VOCE ESCOLHER UM NUMERO QUE NAO SEJA 1 OU 2, TERA ESCOLHIDO SER ELIMINADO!");

            var resposta1 = int.Parse(Console.ReadLine());

            if (resposta1 >= 2)
                Console.WriteLine("CAIIIUUUU");


            if (resposta1 < 1)
                Console.WriteLine("CAIIIUUUU"); ;



            if (resposta1 < 2)//1
            {
                if (resposta1 >= 1)
                    Console.WriteLine("CORRETO!");
                Console.WriteLine("");

                {
                    ///////////////////////////////////////////////////
                    Console.WriteLine("SEGUNDA PASSAGEM"); //2
                    Console.WriteLine("Escolha uma das passagens: A ou B");
                    Console.WriteLine("Digite 1 para: A");
                    Console.WriteLine(" OU 2 para: B ");
                    var resposta2 = int.Parse(Console.ReadLine());

                    if (resposta2 >= 3)
                        Console.WriteLine("CAIIIUUUU"); ;
                    if (resposta2 <= 1)
                        Console.WriteLine("CAIIIUUUU"); ;


                    if (resposta2 < 3)
                    {
                        if (resposta2 > 1)
                            Console.WriteLine("CORRETO!");
                        Console.WriteLine("");



                        //////////////////////////////////////////////////////
                        Console.WriteLine("TERCEIRA PASSAGEM");//3
                        Console.WriteLine("Escolha uma das passagens: A ou B");
                        Console.WriteLine("Digite 1 para: A" );
                        Console.WriteLine(" OU 2 para: B");
                        var resposta3 = int.Parse(Console.ReadLine());

                        if (resposta3 >= 3)
                            Console.WriteLine("CAIIIUUUU"); ;
                        if (resposta3 <= 1)
                            Console.WriteLine("CAIIIUUUU"); ;


                        if (resposta3 < 3)
                        {
                            if (resposta3 > 1)
                                Console.WriteLine("CORRETO!");
                            Console.WriteLine("VOCE PASSOU PARA PROXIMA FASE!");


                        }
                    }


                }
            }
        }
    }
}
















/////////////////////////////////////////////////////////////////////////////


















































