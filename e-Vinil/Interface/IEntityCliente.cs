using e_Vinil.Entidades;
using System.Collections.Generic;
using System.Data;

namespace e_Vinil.Interface
{
    interface IEntityCliente<T>
    {
         int Inserir(T item);
         void Atualizar(T item);
         List<T> BuscarTodos();
         T BuscarCliente(int id);
         void Excluir(int id);
    }
}
