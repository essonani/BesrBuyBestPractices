using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesrBuyBestPractices
{
    public interface IDbConnection_conn
    {
        public IEnumerable<Department> GetAllDepartments();
    }
}
