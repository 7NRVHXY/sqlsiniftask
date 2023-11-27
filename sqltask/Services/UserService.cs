using ADO.NET.Helpers;
using sqltask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqltask.Services
{
    internal class UserService
    {
        public int Register (User data)
        {
            string query = $"INSERT INTO Artists VALUES (N'{data.Name}', N'{data.Surname}', )";
            return SqlHelper.Exec(query);
        }
        public void Login (string username,string password)
        {

        }
    }
}
