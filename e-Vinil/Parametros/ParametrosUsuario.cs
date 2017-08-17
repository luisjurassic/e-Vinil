using e_Vinil.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_Vinil.Model
{
    public class ParametrosUsuario
    {
        public static int UsuariosID { get; set; }
        public static string Usuario { get; set; }
        public static string Email { get; set; }
        public static string Senha { get; set; }
        public static Acesso Acesso { get; set; }
        public static string Imagem_perfil { get; set; }
    }
}