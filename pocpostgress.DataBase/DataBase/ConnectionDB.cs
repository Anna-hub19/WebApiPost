using Microsoft.Extensions.Configuration;


namespace PocPostgress.DataBase.DataBase
{
    public class ConnectionDB 
    {  // pega a connection string
        private readonly string _DbConnectionString;
       
        public ConnectionDB(IConfiguration configuration) {
            _DbConnectionString = configuration.GetSection("ConnectionStrings").GetSection("BancoDeDados").Value;

        }
        public string GetString()
        {
            return _DbConnectionString;
        }

    }
            
}
        

     

    

