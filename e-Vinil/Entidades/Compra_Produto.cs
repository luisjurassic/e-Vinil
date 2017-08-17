using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_Vinil.Entidades
{
    public class Compra_Produto
    {
        public int Compra_id { get; set; }
        public int Produto_id { get; set; }
        public DateTime Data_Compra { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public decimal Desconto { get; set; }
    }
}