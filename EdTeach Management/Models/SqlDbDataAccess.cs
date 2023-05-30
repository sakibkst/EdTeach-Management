using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Models
{
    public class SqlDbDataAccess
    {
        private const string V = @"Data Source=DESKTOP-QKT3N4V\SQLEXPRESS;Initial Catalog=EdTechManagement;Integrated Security=True";
        const string Connectionstring = V;


        public SqlCommand GetCommand(string query)
        {
            var connection = new SqlConnection(Connectionstring);
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = connection;
            return cmd;
        }
    }
}
