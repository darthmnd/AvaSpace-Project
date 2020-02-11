using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AvaSpace.Repository
{
    public class SqlConnectionFactory
    {
        public static SqlConnection Create() 
        {
            return new SqlConnection("Data Source=WIN-INQL80QOGE;Initial Catalog=DB_AVASPACE;Integrated Security=True");
        }
    }
}
