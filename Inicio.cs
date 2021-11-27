using System;

namespace Contador_de_gastos
{
    class ContadorDeGastos
    {        

        static void Main(string[] args) //Inicia o programa
        {
            FrontEnd fe = new FrontEnd();
            BancoDeDados bd = new BancoDeDados();

            do
            {
                string conectado = bd.Testar();    //Testar conexão com o BD
                
                if (conectado == "Conectado")
                {
                    break;
                }
                else if (conectado == "Desconectado")
                {
                    Console.WriteLine("Erro ao tentar conectar ao BD, quer tentar novamente? aperte s ou qualquer outra tecla para sair");
                    string escolha = Console.ReadLine();

                    if (escolha == "s")
                    {
                        Console.WriteLine("Começando nova tentativa");
                    }
                    else if (escolha == "n")
                    {
                        Environment.Exit(0);
                    }
                }

            } while (true);

            fe.Consulta();

            fe.InserirDados();  //Inicia as perguntas
        }
    }
}
