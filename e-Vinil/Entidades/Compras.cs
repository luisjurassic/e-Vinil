using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_Vinil.Entidades
{
    public class Compras
    {
        public int ComprasId { get; set; }
        public DateTime Data_Compra { get; set; }
        public int Usuario_id { get; set; }
        public string Meio_Entrega { get; set; }
        public double Valor_Total { get; set; }
    }
}