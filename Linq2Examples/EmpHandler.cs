using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2Examples
{
    public class EmpHandler : IEmpHandler
    {
        private static List<Emp> employees = new List<Emp>()
        {
                     new Emp(){Id=1,Name="jay",Salary=98500.33,DOJ=new DateTime(day:07,month:10,year:2024),Designation="Manager"},
             new Emp(){Id=2,Name="yash",Salary=99666.33,DOJ=new DateTime(day:26,month:2,year:2025),Designation="HR"},
          new Emp(){Id=3,Name="harinivas",Salary=88500.33,DOJ=new DateTime(day:11,month:10,year:2023),Designation="Tester"},
      new Emp(){Id=4,Name="ganesh",Salary=98500.33,DOJ=new DateTime(day:12,month:12,year:2020),Designation="Developer"},
             new Emp(){Id=5,Name="yadavalli rajyalaxmi",Salary=996634.33,DOJ=new DateTime(day:26,month:2,year:2025),Designation="Manager"},
          new Emp(){Id=6,Name="harinivas",Salary=88500.33,DOJ=new DateTime(day:11,month:10,year:2023),Designation="Tester"},
      new Emp(){Id=10,Name="ganesh",Salary=98500.33,DOJ=new DateTime(day:12,month:12,year:2020),Designation="Developer"},


        };
        public void CreateEmp(Emp emp)
        {
            employees.Add(emp);

            Console.WriteLine("employee created successfully");

        }

        public void DeleteEmp(int id)
        {
            Emp emp = employees.SingleOrDefault(e => e.Id == id);

            if(emp != null)
            {
                employees.Remove(emp);
            }
            else
            {
                Console.WriteLine("no such record exists to delete...................");
            }
        }

        public IEnumerable<Emp> GetAllEmps()
        {
            return employees;
        }

        public Emp GetEmpById(int id)
        {
            Emp emp = employees.SingleOrDefault(e => e.Id == id);

            return emp;
        }

        public Emp GetEmpByName(string name)
        {
            Emp emp = employees.FirstOrDefault(e => e.Name == name);
            return emp;
        }

        public void UpdateEmp(Emp emp)
        {
            var extEmployee = GetEmpById(emp.Id);
            if(extEmployee != null)
            {
                extEmployee.Name = emp.Name;
                extEmployee.Salary = emp.Salary;
                extEmployee.Designation = emp.Designation;
                extEmployee.DOJ = emp.DOJ;
                Console.WriteLine("employee updated successfully .......................");
            }
            else
            {
                Console.WriteLine($"No such employee exist");
            }
        }
    }
}
