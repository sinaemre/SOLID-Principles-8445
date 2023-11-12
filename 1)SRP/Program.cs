using _1_SRP.BadExample;
using _1_SRP.Entity;
using _1_SRP.GoodExample;

Employee employee = new Employee()
{
    Id = 1,
    FirstName = "Sina Emre",
    LastName = "Bekar",
    HireDate = new DateTime(2023, 02, 20)
};

BadEmployee.CreateEmployee(employee);


GoodLogger.CreateLog(employee.Id);
GoodInsertEmployee.CreateEmployee(employee);
