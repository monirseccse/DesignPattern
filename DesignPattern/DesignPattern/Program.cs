using Adapter;
using Microsoft.Extensions.DependencyInjection;

//setup our DI
var serviceProvider = new ServiceCollection()
    .AddSingleton<ISalaryCreate, EmployeeAdapter>()
    .AddSingleton<EmployeeSalaryCreate>()
    .BuildServiceProvider();

string[,] employeesArray = new string[5, 4]
          {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
          };

var salaryCreate=serviceProvider.GetService<EmployeeSalaryCreate>();
salaryCreate.ProcessSalary(employeesArray);
