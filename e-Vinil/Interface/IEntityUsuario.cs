using e_Vinil.Entidades;
using e_Vinil.Model;
using System.Collections.Generic;

namespace e_Vinil.Interface
{
    interface IEntityUsuario<T>
    {
        int Inserir(T item);
        void Atualizar(T item);
        Usuarios EnviarSenhaEmail(string item);
        bool Autenticar(Usuarios item);
        List<T> BuscarTodos();
        T BuscarUsuario(int item);
        void Excluir(int id);
        void ConvertToModel(Usuarios user);
    }
}
