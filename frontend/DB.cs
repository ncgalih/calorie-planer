using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend
{
    internal class DB
    {
        public static string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=CaloriePlaner";
        public static NpgsqlConnection conn = new NpgsqlConnection(connstring);
    }
}
