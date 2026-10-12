using Npgsql;
using System.Data;

public class DapperContext
{
    public string _form941Connection;
    public DapperContext(IConfiguration configuration)
    {
        if(configuration != null)
        {
            _form941Connection=configuration.GetConnectionString("Form941Connection");
    }
    
}
public IDbConnection CreateConnection()
    {
       return new NpgsqlConnection(_form941Connection);
    }
}