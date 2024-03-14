using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionMAUIApp1.Source.ViewModel
{
    public class EmpLayoutViewModel
    {
        public EmpLayoutViewModel()
        {
            GenerateSource();
        }

        public ObservableCollection<EmployeeInfo> listDetails { get; set; }

        private void GenerateSource()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            listDetails = employeeRepository.GetEmployeeList();
        }
    }
}
