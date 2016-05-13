using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavWindowApp.Controllers
{
    public class Controller
    {
        public Controller()
        {

        }
        localhost.WebService1 service = new localhost.WebService1();
        public List<NavWindowApp.Model.QuerySelector> GetQueries()
        {
            var dataSource = new List<NavWindowApp.Model.QuerySelector>();
            dataSource.Add(new NavWindowApp.Model.QuerySelector() { Name = "Get All Tables", Value = service.GetAllTables().ToList() });
            dataSource.Add(new NavWindowApp.Model.QuerySelector() { Name = "Get All Tables 2", Value = service.GetAllTables2().ToList() });
            dataSource.Add(new NavWindowApp.Model.QuerySelector() { Name = "Get Constraints", Value = service.GetConstraints().ToList() });
            dataSource.Add(new NavWindowApp.Model.QuerySelector() { Name = "Get Employee Absence", Value = service.GetEmployeeAbsence().ToList() });
            dataSource.Add(new NavWindowApp.Model.QuerySelector() { Name = "Get all Employees", Value = service.GetEmployees().ToList() });
            dataSource.Add(new NavWindowApp.Model.QuerySelector() { Name = "Get all Employees Meta", Value = service.GetEmployeesMeta().ToList() });
            dataSource.Add(new NavWindowApp.Model.QuerySelector() { Name = "Get Employees Meta 2", Value = service.GetEmployeesMeta2().ToList() });
            dataSource.Add(new NavWindowApp.Model.QuerySelector() { Name = "Get Indexes", Value = service.GetIndexes().ToList() });
            dataSource.Add(new NavWindowApp.Model.QuerySelector() { Name = "Get Keys", Value = service.GetKeys().ToList() });
            dataSource.Add(new NavWindowApp.Model.QuerySelector() { Name = "Get Relative", Value = service.GetRelative().ToList() });
            dataSource.Add(new NavWindowApp.Model.QuerySelector() { Name = "Get Sickest Employee", Value = service.GetSickestEmployee().ToList() });

            return dataSource;
        }
    }

    
}
