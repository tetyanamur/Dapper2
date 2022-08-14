using System;
using System.Collections.Generic;
using System.Text;

namespace DapperInClass
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;
        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }
    }
}