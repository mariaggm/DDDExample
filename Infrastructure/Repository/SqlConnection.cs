namespace Infrastructure.Repository
{
    internal class SqlConnection
    {
        private string conexao;

        public SqlConnection(string conexao)
        {
            this.conexao = conexao;
        }
    }
}