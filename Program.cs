using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            
           //int conf = 0;

            //coleta de dados
            Console.WriteLine("\nDigite seu user: ");
            //declaração de variaveis e coleta de dados
            var user = Console.ReadLine();

            Console.WriteLine("\nDigite sua senha: ");
            //declaração de variaveis e coleta de dados
            var senha = Console.ReadLine();
                        
            Console.WriteLine("\nDigite sua senha novamente: ");
            //declaração de variaveis e coleta de dados
            var senha2 = Console.ReadLine();

           
            //declarando condição
            if (senha == senha2)
            {
                //declarando variaveis
                int conf=0;
                //informando cadastro
                Console.WriteLine($"\nOla, {user} voce foi cadastrado <3 <3");
                //Coletando dados
                Console.WriteLine("\nAperte 1 para se logar, se nao aperte qualquer outra tecla para sair");
                //convertendo de string para int
                conf=int.Parse(Console.ReadLine());
               
                 //declarando condição                 
                if(1 == conf)
                {
                    //coleta de dados
                    Console.WriteLine("\nDigite seu user: ");
                    var userv = Console.ReadLine();
                    //coleta de dados
                    Console.WriteLine("\nDigite sua senha: ");            
                    var senhav = Console.ReadLine();
                      //declarando condição
                    if(senhav == senha2)
                    {
                        Console.WriteLine($"\nOla, {user} voce foi logado <3 <3");
                        Console.WriteLine("\nPressione qualquer tecla para sair");
                        //tecla de escape
                        Console.ReadKey(true);
                    }
                    //tratativa de erro
                    else
                    {
                        Console.WriteLine("\nLogin invalido, quem  é voce se indentifique porra >:(");
                        Console.WriteLine("\nPressione qualquer tecla para sair");
                        Console.ReadKey(true);
                    }
                
                }
                //tratativa de erro
                else
                {
                    Console.WriteLine("\nAperte ""s"" para sair");
                    Console.ReadKey(true);
                }
            }
            //tratativa de erro
            else
            {
                Console.WriteLine("\nCadastro Invalido verifique sua senha >:(");
                Console.WriteLine("\nPressione qualquer tecla para sair");
                Console.ReadKey(true);
            }
        }
    }
}
