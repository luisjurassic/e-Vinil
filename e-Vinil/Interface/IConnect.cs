using System.Data;
using System.Data.SqlClient;

namespace e_Vinil.Interface
{
    interface IConnect
    {
        void Execute(SqlCommand command);
        int ExecuteOnIdentity(SqlCommand command);
        DataTable Search(SqlCommand command);

        void AttachCommand(SqlCommand command);
        void Abrir();
        void Fechar();
        void Dispose();
    }
}
