using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Aula01Manha.Model
{
    [Table("PedidosModel")]
    public class PedidoModel
    {
        [Key]
        public int PedidoID { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public string Fornecedor { get; set; }
    }
}
