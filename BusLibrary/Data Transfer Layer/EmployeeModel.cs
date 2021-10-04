using System;
using System.Globalization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLibrary.Data_Transfer_Layer
{
    public class EmployeeModel
    {
        public EmployeeModel() { }

        public EmployeeModel(string employeeId, string firstName, string lastName, int age, DateTime startDate, int baseSalary, int currentSalary, DateTime dateOfBirth, string email, string sex)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            StartDate = startDate;
            BaseSalary = baseSalary;
            CurrentSalary = currentSalary;
            DateOfBirth = dateOfBirth.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            Email = email;
            Sex = sex;
        }

        public EmployeeModel(DataRow row)
        {
            EmployeeId = row["employee_id"].ToString();
            FirstName = row["first_name"].ToString();
            LastName = row["last_name"].ToString();
            Age = (int)row["age"];
            StartDate = ((DateTime)row["start_date"]);
            BaseSalary = (int)row["base_salary"];
            CurrentSalary = (int)row["current_salary"];
            DateOfBirth = ((DateTime)row["data_of_birth"]).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            Email = row["email"].ToString();
            Sex = row["sex"].ToString();
        }

        private string employeeId;
        private string firstName;
        private string lastName;
        private int age;
        private DateTime startDate;
        private int baseSalary;
        private int currentSalary;
        private string dateOfBirth;
        private string email;
        private string sex;

        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public int BaseSalary { get => baseSalary; set => baseSalary = value; }
        public int CurrentSalary { get => currentSalary; set => currentSalary = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Email { get => email; set => email = value; }
        public string Sex { get => sex; set => sex = value; }
    }
}
