using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2Examples
{
    public interface IEmpHandler
    {
        IEnumerable<Emp> GetAllEmps();

        Emp GetEmpById(int id);

        Emp GetEmpByName(string name);

        void UpdateEmp(int id);

        void DeleteEmp(Emp emp);

        void CreateEmp(Emp emp);

    }
}
