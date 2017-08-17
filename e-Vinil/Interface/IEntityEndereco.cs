using System.Collections.Generic;

namespace e_Vinil.Interface
{
    interface IEntityEndereco<T>
    {
         void Inserir(T item);
         void Atualizar(T item);
         List<T> BuscarTodos();
         T BuscarEndereco(int item);
         void Excluir(int id);
    }
}
