using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_gastos
{
    public class FrontEnd
    {
        string produto = "";                  //Nome do produto
        double valorDoProduto = 0.0;          //Valor do Produto individual
        int quantidade = 0;                   //Quantidade de produtos
        double valorTotalDoProduto = 0.0;     //Valor total do produto
        string confirmacao = "";              //Confirmação para lançar para o BD

        public FrontEnd()
        {
        }

        public FrontEnd(string produto, double valorDoProduto, int quantidade, double valorTotalDoProduto, string confirmacao)
        {
            this.produto = produto;
            this.valorDoProduto = valorDoProduto;
            this.quantidade = quantidade;
            this.valorTotalDoProduto = valorTotalDoProduto;
            this.confirmacao = confirmacao;
        }
        
        public void Consulta()
        {
            BancoDeDados bd = new BancoDeDados();
            string consulta = Convert.ToString(bd.Consultar());



            
        }

        public void InserirDados()
        {
            do
            {
                Console.WriteLine("Qual o nome do novo produto comprado?");
                produto = Console.ReadLine();

            } while (produto == ""); //Inserir nome do produto

            do
            {
                Console.WriteLine("Quanto custa uma unidade do produto " + produto);
                valorDoProduto = Convert.ToDouble(Console.ReadLine());

            } while (valorTotalDoProduto == 0.0); //Inserir valor unitário do produto

            do
            {
                Console.WriteLine("Quantas unidades foram compradas?");
                quantidade = Convert.ToInt32(Console.ReadLine());

            } while (quantidade == 0); //Inserir quantidade
            
            valorTotalDoProduto = valorDoProduto * quantidade;  //Calcular valor total

            Console.WriteLine
                ("Nome do produto: " + produto +
                "/nValor unitário: " + valorDoProduto +
                "/nUnidades: " + quantidade +
                "/nValor total: " + valorTotalDoProduto);   //Mostrar dados inseridos para confirmação

            do 
            {
                Console.WriteLine("Confirmar? (s) ou (n)");
                confirmacao = Console.ReadLine();

            } while (confirmacao != "s" && confirmacao != "n"); //Confirmação

            if (confirmacao == "s") 
            {
                BancoDeDados bd = new BancoDeDados();


            } //Aceitar confirmação

            else if(confirmacao == "n")
            {
                produto = "nulo";              
                valorDoProduto = 0.0;          
                quantidade = 0;                   
                valorTotalDoProduto = 0.0;     
                confirmacao = "";            
                
                Console.WriteLine("Operação cancelada");
            } //Negar confirmação
        } 

        
    }
}
