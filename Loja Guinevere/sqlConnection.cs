using System.Data;

namespace Loja_Guinevere
{
    public class sqlConnection
    {
        public string ConnectionString { get; internal set; }
        public ConnectionState State { get; internal set; }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}