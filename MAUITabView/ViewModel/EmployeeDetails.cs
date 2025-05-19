using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITabView
{
    public class EmployeeDetails : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Employee>? employeeDetails;
        public ObservableCollection<Employee>? EmployeeDetailsList
        {
            get { return employeeDetails; }
            set
            {
                employeeDetails = value;
                OnPropertyChanged("EmployeeDetailsList");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public EmployeeDetails()
        {
            EmployeeDetailsList = new ObservableCollection<Employee>();
            EmployeeDetailsList.Add(new Employee() { Name = "Alexandar" });
            EmployeeDetailsList.Add(new Employee() { Name = "Gabriella" });
            EmployeeDetailsList.Add(new Employee() { Name = "Clara" });
            EmployeeDetailsList.Add(new Employee() { Name = "Tye" });
            EmployeeDetailsList.Add(new Employee() { Name = "Nora" });
            EmployeeDetailsList.Add(new Employee() { Name = "Sebastian" });
            EmployeeDetailsList.Add(new Employee() { Name = "Michael" });
            EmployeeDetailsList.Add(new Employee() { Name = "Sophia" });
            EmployeeDetailsList.Add(new Employee() { Name = "James" });
            EmployeeDetailsList.Add(new Employee() { Name = "Olivia" });
            EmployeeDetailsList.Add(new Employee() { Name = "Liam" });
            EmployeeDetailsList.Add(new Employee() { Name = "Emma" });
            EmployeeDetailsList.Add(new Employee() { Name = "Noah" });
            EmployeeDetailsList.Add(new Employee() { Name = "Ava" });
            EmployeeDetailsList.Add(new Employee() { Name = "Isabella" });
            EmployeeDetailsList.Add(new Employee() { Name = "Lucas" });
            EmployeeDetailsList.Add(new Employee() { Name = "Mia" });
            EmployeeDetailsList.Add(new Employee() { Name = "Ethan" });

        }

    }
}
