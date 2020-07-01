using Aula01Manha.DAO;
using Aula01Manha.Model;
using System;
using System.Collections.Generic;

namespace Aula01Manha.View
{
    class Program
    {
        //NOME: MEICE SILVA DE JESUS
        static void Main(string[] args)
        {
            Context cx = new Context();
            List<PedidoModel> Pedidos = new List<PedidoModel>();
            PedidoModel pedido = new PedidoModel();
            Console.WriteLine("Entre com a op");
            int op = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (op)
                {
                    case 1:
                        pedido = new PedidoModel();
                        Console.WriteLine("Informe o ID:");
                        pedido.PedidoID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o Produto:");
                        pedido.Produto = Console.ReadLine();
                        Console.WriteLine("Informe a quantidade: ");
                        pedido.Quantidade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o Valor:");
                        pedido.Valor = Convert.ToInt32(Console.ReadLine());
                        pedido.Data = DateTime.Now;
                        Console.WriteLine("Informe o Fornecedor:");
                        pedido.Fornecedor = Console.ReadLine();

                        PedidoDAO.Cadastrar(pedido);
                        break;

                    case 2:
                        PedidoDAO.Listar();
                        break;

                    case 3:
                        Console.WriteLine("Informe o produto");
                        string produto = Console.ReadLine();
                        PedidoDAO.Buscar(produto);
                        break;
                    case 4:
                        Console.Write("Informe o ID:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        PedidoDAO.Remover(id);
                        break;
                    case 5:
                        pedido = new PedidoModel();
                        Console.WriteLine("Informe o ID:");
                        pedido.PedidoID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o Produto:");
                        pedido.Produto = Console.ReadLine();
                        Console.WriteLine("Informe a quantidade: ");
                        pedido.Quantidade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o Valor:");
                        pedido.Valor = Convert.ToInt32(Console.ReadLine());
                        pedido.Data = DateTime.Now;
                        Console.WriteLine("Informe o Fornecedor:");
                        pedido.Fornecedor = Console.ReadLine();
                        PedidoDAO.Alterar(pedido);
                        break;
                }
                Console.WriteLine("Entre com a op");
                op = Convert.ToInt32(Console.ReadLine());
            } while (op > 0);
        }
    }
}
