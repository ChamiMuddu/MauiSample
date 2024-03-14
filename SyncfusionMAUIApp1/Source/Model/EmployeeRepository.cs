using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionMAUIApp1.Source.Model
{
    public class EmployeeRepository
    {
        public EmployeeRepository()
        {

        }

        internal ObservableCollection<EmployeeInfo> GetEmployeeList()
        {
            var listEmpInfo = new ObservableCollection<EmployeeInfo>();
            listEmpInfo.Add(new EmployeeInfo() { Name = "Jalil", Experience_years = 13 });
            listEmpInfo.Add(new EmployeeInfo() { Name = "Sourabh", Experience_years = 10 });
            listEmpInfo.Add(new EmployeeInfo() { Name = "Subhashish", Experience_years = 16 });
            listEmpInfo.Add(new EmployeeInfo() { Name = "Randhir", Experience_years = 16 });
            return listEmpInfo;
        }
    }
}
