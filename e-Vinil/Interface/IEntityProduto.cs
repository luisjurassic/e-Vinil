using System.Collections.Generic;

namespace e_Vinil.Interface
{
    interface IEntityProduto<T>
    {
         int Inserir(T item);
         int Atualizar(T item);
         void AtualizarCapa(string local, int id);
         List<T> BuscarTodosColuna();
         void Excluir(int id);
    }
}
