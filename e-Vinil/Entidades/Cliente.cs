using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_Vinil.Entidades
{
    public class Cliente
    {
        public int ClientesID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public int Usuario_id { get; set; }
    }
}