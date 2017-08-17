using e_Vinil.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Vinil.Interface
{
    interface ICompra_Produto<T>
    {
        void Inserir(Compras item);
        void Excluir(Compras item);
        List<Compras> ComprasRealizadas();
    }
}
