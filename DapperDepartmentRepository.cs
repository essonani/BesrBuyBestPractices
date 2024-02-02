using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesrBuyBestPractices
{
    public class DapperDepartmentRepository : IDbConnection_conn
    {
        private readonly IDbConnection _conn;
        public DapperDepartmentRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Department> GetAllDepartments()
        {
            return _conn.Query<Department>("SELECT * From departments");
        }
        public void InsertDepartment(string name)
        {
            _conn.Execute("Insert into departments (Name) VALUES (@name)",new {name=name});
        }
    }
}
