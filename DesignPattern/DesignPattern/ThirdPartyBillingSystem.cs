using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public static class ThirdPartyBillingSystem
    {
        public static void ProcessSalary(List<Employee> listEmployee)
        {
            foreach (Employee employee in listEmployee)
            {
                Console.WriteLine("Tk." + employee.Salary + " Salary Credited to " + employee.Name + " Account");
            }
        }
    }
}
