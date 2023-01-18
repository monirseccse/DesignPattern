using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class EmployeeAdapter : ThirdPartyBillingSystem,ITarget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
       
        List<Employee> employees =new List<Employee>();

        public void ProcessSalary(string[,] employeelist)
        {

            for (int i = 0; i < employeelist.GetLength(0); i++)
            {
                Employee employee = new Employee();
                for (int j = 0; j < employeelist.GetLength(1); j++)
                {
                    if (j == 0)
                        employee.Id = Convert.ToInt32(employeelist[i, j]);
                    else if (j == 1)
                        employee.Name = employeelist[i, j];
                    else if (j == 2)
                        employee.Designation = employeelist[i, j];
                    else if (j == 3)
                        employee.Salary = Convert.ToDecimal(employeelist[i,j]);
                   
                }
                employees.Add(employee);
            }

            base.ProcessSalary(employees);
        }
    }
}
