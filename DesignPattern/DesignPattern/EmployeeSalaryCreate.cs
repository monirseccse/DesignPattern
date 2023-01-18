namespace Adapter
{
    public class EmployeeSalaryCreate 
    {
        private readonly ISalaryCreate _salaryCreate;
        public EmployeeSalaryCreate(ISalaryCreate salaryCreate)
        {
            _salaryCreate = salaryCreate;   
        }
        public void ProcessSalary(string[,] employeelist)
        {
            _salaryCreate.ProcessSalary(employeelist);
        }
    }
}