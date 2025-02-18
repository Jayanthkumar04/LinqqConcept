using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Emp> emps = new List<Emp>()
            {
               new Emp(){Id=1,Name="jay",Salary=98500.33,DOJ=new DateTime(day:07,month:10,year:2024),Designation="Manager"},
             new Emp(){Id=2,Name="yash",Salary=99666.33,DOJ=new DateTime(day:26,month:2,year:2025),Designation="HR"},
          new Emp(){Id=3,Name="harinivas",Salary=88500.33,DOJ=new DateTime(day:11,month:10,year:2023),Designation="Tester"},
      new Emp(){Id=4,Name="ganesh",Salary=98500.33,DOJ=new DateTime(day:12,month:12,year:2020),Designation="Developer"},
             new Emp(){Id=5,Name="yadavalli rajyalaxmi",Salary=996634.33,DOJ=new DateTime(day:26,month:2,year:2025),Designation="Manager"},
          new Emp(){Id=6,Name="harinivas",Salary=88500.33,DOJ=new DateTime(day:11,month:10,year:2023),Designation="Tester"},
      new Emp(){Id=10,Name="ganesh",Salary=98500.33,DOJ=new DateTime(day:12,month:12,year:2020),Designation="Developer"},

            };


            var query = emps.Where(e => e.Id >= 5);
            foreach(Emp emp in query)
            {
                Console.WriteLine(emp.Id+"->"+emp.Name+"->"+emp.Salary+"->"+emp.Designation+"->"
                    +emp.Designation+"->"+emp.DOJ.ToShortDateString());


            }

            Console.WriteLine("Enter designation to find out details");

            string desg = Console.ReadLine();

            var query2 = emps.Where(e => e.Designation == desg);

            Console.WriteLine($"*******************************List of {desg} *****************************");

            foreach(Emp emp in query2)
            {
                Console.WriteLine(emp.Id + "->" + emp.Name + "->" + emp.Salary + "->" 
                    + emp.Designation + "->" + emp.DOJ.ToShortDateString());


            }
            
                        try
                        {
                            int id;
                        Console.WriteLine("enter Id to find out employee details");
                        id = int.Parse(Console.ReadLine());
                        Emp emp2 = emps.SingleOrDefault(e => e.Id == id);


                            if (emp2 != null)
                            {
                                Console.WriteLine("record found details are as follows!!!!!");
                                Console.WriteLine(emp2.Id + "->" + emp2.Name + "->" + emp2.Salary + "->"
                                    + emp2.Designation + "->" + emp2.DOJ.ToShortDateString());

                            }
                            else
                            {
                                Console.WriteLine($"no such employee id {id} exists");
                            }
                        }

                        catch(Exception ex)
                        {
                            Console.WriteLine("error!!!!!! "+ex.Message);
                        }

                        finally
                        {
                            Console.WriteLine("end of program");

                            Console.ReadKey();
                        }


                        

            try
            {
                string name;
                Console.WriteLine("enter name to find out employee details");
                name = Console.ReadLine();
                Emp emp2 = emps.FirstOrDefault(e => e.Name == name);

                var emp3 = emps.Where(e => e.Name == name).ToList();

                if (emp2 != null)
                {
                    Console.WriteLine($"record found for name {name} details are as follows!!!!!");
                    Console.WriteLine(emp2.Id + "->" + emp2.Name + "->" + emp2.Salary + "->"
                        + emp2.Designation + "->" + emp2.DOJ.ToShortDateString());

                }
                else
                {
                    Console.WriteLine($"no such employee name {name} exists");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("error!!!!!! " + ex.Message);
            }

            finally
            {
                Console.WriteLine("end of program");

                Console.ReadKey();
            }


            string namee;

            Console.WriteLine("enter name to find out employee details");

            namee = Console.ReadLine();

            var result = emps.OrderBy(emp => emp.Name).ToList();

            Console.WriteLine("in order of name");

            foreach (Emp emp in result)
            {
                Console.WriteLine(emp.Id + "->" + emp.Name + "->" + emp.Salary + "->" + emp.Designation + "->"
                    + emp.Designation + "->" + emp.DOJ.ToShortDateString());
            }

            var result2 = emps.OrderByDescending(emp => emp.Name).ToList();

            Console.WriteLine("in order of name in reverse order");

            foreach (Emp emp in result2)
            {
                Console.WriteLine(emp.Id + "->" + emp.Name + "->" + emp.Salary + "->" + emp.Designation + "->"
                    + emp.Designation + "->" + emp.DOJ.ToShortDateString());
            }


        }
    }
}
