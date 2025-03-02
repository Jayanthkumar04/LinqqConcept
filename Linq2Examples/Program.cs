using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2Examples
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************WELCOME TO EMPLOYEE MANAGEMENT SYSTEM*********************");
            EmpHandler empHandler = new EmpHandler();

            Console.WriteLine("choose the option to continue");

            while (true)
            {

                Console.WriteLine("1)Get all employees\n 2)Get Employee By Id \n3)Get Employee By Name\n4)Update Employee\n" +
                    "5)delete Employee By Id\n 6)Add new Employee\n7)exit");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                       var result = empHandler.GetAllEmps();
                        Console.WriteLine("ID\t\tName\t\tDesignation\t\tSalary\t\tDoj");
                        foreach(var i in result)
                        {
                            Console.WriteLine(i.Id+"\t\t"+i.Name+"\t\t"+i.Designation+"\t\t"+i.Salary+"\t\t"+i.DOJ);

                        }
                        break;
                    case 2:
                        Console.WriteLine("enter the Employee Id");
                        int id = int.Parse(Console.ReadLine());
                        Emp em = empHandler.GetEmpById(id);

                        Console.WriteLine("ID\t\tName\t\tDesignation\t\tSalary\t\tDoj");

                        Console.WriteLine(em.Id + "\t\t" + em.Name + "\t\t" + em.Designation + "\t\t" + em.Salary + "\t\t" + em.DOJ);

                        break;
                    case 3:
                        Console.WriteLine("enter the Employee name");
                        string name = Console.ReadLine();

                        Console.WriteLine("ID\t\tName\t\tDesignation\t\tSalary\t\tDoj");

                        Emp em2 = empHandler.GetEmpByName(name);
                        Console.WriteLine(em2.Id + "\t\t" + em2.Name + "\t\t" + em2.Designation + "\t\t" + em2.Salary + "\t\t" + em2.DOJ);

                        break;
                    case 4:
                        Emp emp = new Emp();
                        Console.WriteLine("Enter employee details");
                        Console.WriteLine("Enter Id");
                        emp.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter name");
                        emp.Name = Console.ReadLine();
                        Console.WriteLine("enter designation");
                        emp.Designation = Console.ReadLine();
                        Console.WriteLine("enter salary");
                        emp.Salary = double.Parse(Console.ReadLine());


                        Console.WriteLine("enter doj");
                        emp.DOJ = DateTime.Parse(Console.ReadLine());

                        empHandler.UpdateEmp(emp);

                        break;

                    case 5:
                        Console.WriteLine("enter the Employee Id");
                        int id2 = int.Parse(Console.ReadLine());

                        empHandler.DeleteEmp(id2);
                        break;
                    case 6:
                        Emp emp2 = new Emp();
                        Console.WriteLine("Enter employee details");
                        Console.WriteLine("Enter Id");
                        emp2.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter name");
                        emp2.Name = Console.ReadLine();
                        Console.WriteLine("enter designation");
                        emp2.Designation = Console.ReadLine();
                        Console.WriteLine("enter salary");
                        emp2.Salary = double.Parse(Console.ReadLine());


                        Console.WriteLine("enter doj");
                        emp2.DOJ = DateTime.Parse(Console.ReadLine());

                        empHandler.CreateEmp(emp2);

                        break;

                    case 7:
                        Console.WriteLine("closed");
                        break;

                }


            }
        }

    }

}

