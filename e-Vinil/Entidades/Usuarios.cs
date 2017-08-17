using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;

namespace e_Vinil.Entidades
{
    public enum Acesso
    {
        Cliente = 0,
        Administrador = 1
    }

    public class Usuarios
    {
        public int UsuariosID { get; set; }
        public string Usuario { get; set; }
        private string email;
        private string senha;
        public Acesso Acesso { get; set; }
        public string Imagem_perfil { get; set; }

        public string Email
        {
            get { return email; }
            set
            {
                bool isEmail = Regex.IsMatch(value, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                if (!isEmail)
                {
                    throw new Exception("Email inválido");
                }
                email = value;
            }
        }

        public void ConfirmaSenha(string _Senha, string _Confirmasenha)
        {
            if (_Senha == _Confirmasenha)
            {
                Senha = _Senha;
            }
        }
        public string Senha
        {
            get { return senha; }
            set
            {
                MD5CryptoServiceProvider hash =
                    new MD5CryptoServiceProvider();

                byte[] senharecebida = Encoding.UTF8.GetBytes(value);
                byte[] senhaHasheada = hash.ComputeHash(senharecebida);

                senha = Convert.ToBase64String(senhaHasheada);
            }
        }

    }

}