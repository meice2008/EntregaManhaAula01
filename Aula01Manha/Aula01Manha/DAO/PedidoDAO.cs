using Aula01Manha.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula01Manha.DAO 
{
    public class PedidoDAO
    {        
        static List<PedidoModel> Pedidos = new List<PedidoModel>();

        public static void Cadastrar(PedidoModel pedido)
        {
            try
            {
                Pedidos.Add(pedido);
                Console.WriteLine("Cadastrado com sucesso! \n");                
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("ERRO: "+e);               
            }
            
        }

        public static void Listar()
        {
            foreach (PedidoModel p in Pedidos)
            {
                Console.WriteLine(p.PedidoID +"\t"+ p.Produto +"\t"+ p.Quantidade +"\t"+ p.Data + "\t" +p.Fornecedor + "\t" );
            }
        }

        public static void Alterar(PedidoModel pedido)
        {
            for (int i=0; i<Pedidos.Count;i++)
            {
                if (pedido.PedidoID == Pedidos[i].PedidoID)
                {
                    Pedidos[i].PedidoID = pedido.PedidoID;
                    Pedidos[i].Produto = pedido.Produto;
                    Pedidos[i].Quantidade = pedido.Quantidade;
                    Pedidos[i].Valor = pedido.Valor;
                    Pedidos[i].Data = DateTime.Now;
                    Pedidos[i].Fornecedor = pedido.Fornecedor;
                    Console.WriteLine("Alterado com sucesso! \n");
                }                
            }
        }

        //Na descrição da atv dizia para buscar por nome, mas como não tem nome no Pedido busquei por produto        
        public static void Buscar(String produto)
        {
            List<PedidoModel> PedidosAchados = new List<PedidoModel>();
            for (int i = 0; i < Pedidos.Count; i++)
            {
                if (Pedidos[i].Produto == produto)
                {
                    PedidosAchados.Add(Pedidos[i]);
                }
            }

            foreach (PedidoModel p in PedidosAchados)
            {
                Console.WriteLine(p.PedidoID + "\t" + p.Produto + "\t" + p.Quantidade + "\t" + p.Data + "\t" + p.Fornecedor + "\t");
            }

        }

        public static void Remover(int id)
        {
            for (int i=0; i<Pedidos.Count;i++)
            {
                if (Pedidos[i].PedidoID == id)
                {
                    Pedidos.RemoveAt(i);
                    Console.WriteLine("Removido! \n");
                }                
            }
        }
    }
}
