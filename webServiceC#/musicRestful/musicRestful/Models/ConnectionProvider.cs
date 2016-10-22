using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace musicRestful.Models
{
    public class ConnectionProvider
    {

        public SqlConnection myConnection2 = new SqlConnection();


        public ConnectionProvider()
        {
            this.myConnection2.ConnectionString = @"Data Source=;Initial Catalog=alodev;Integrated Security=False;User Id=;Password=;";

        }

    }

}
