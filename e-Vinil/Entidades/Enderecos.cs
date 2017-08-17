using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_Vinil.Entidades
{
    public class Enderecos
    {
        public int EnderecosID { get; set; }
        public string CEP { get; set; }
        public string Tipo_Residencia { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Cliente_id { get; set; }
    }
}