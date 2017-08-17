using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_Vinil.Entidades
{
    public class Produtos
    {
        public int ProdutosID { get; set; }
        public string Codigo_Produto { get; set; }
        public string Capa { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public int Ano { get; set; }
        public string Genero { get; set; }
        public string Gravadora { get; set; }
        public string Informacoes { get; set; }
        public double Preco { get; set; }
    }
}