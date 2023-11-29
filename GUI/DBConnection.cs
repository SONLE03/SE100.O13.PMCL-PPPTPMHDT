using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public abstract class DbConnection
    {
        private readonly string connectionString;

        public DbConnection()
        {
            connectionString = @"metadata=res://*/Coffee.csdl|res://*/Coffee.ssdl|res://*/Coffee.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.\sqlexpress;initial catalog=CF;integrated security=True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

public class SQLConnection
{
    public string strcon;
    public SqlConnection con;
    public SQLConnection()
    {

        try
        {
            strcon = @"metadata=res://*/Coffee.csdl|res://*/Coffee.ssdl|res://*/Coffee.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.\sqlexpress;initial catalog=CF;integrated security=True";
        }
        catch
        {
            return;
        }
        con = new SqlConnection(strcon);
    }
    public void OpenConnection()
    {
        try
        {
            con.Open();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void CloseConnection()
    {
        con.Close();
    }
}

