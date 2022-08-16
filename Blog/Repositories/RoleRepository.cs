using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Repositories
{
    public class RoleRepository : Repository<Role>
    {
        public RoleRepository(SqlConnection connection) : base(connection)
        {
        }
    }
}