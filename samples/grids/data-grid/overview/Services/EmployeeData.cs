using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Samples
{
    public class Employee : INotifyPropertyChanged
    {
        public string ID { get; set; }
        public string Address { get; set; }
        public double Age { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Generation { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        public double Salary { get; set; }
        public double Sales { get; set; }
        public string Website { get; set; }
        public string Income { get; set; }

        public DateTime Birthday { get; set; }
        public List<Productivity> Productivity { get; set; }

        private string _Country;
        public string Country
        {
            get { return _Country; }
            set { if (_Country != value) { OnCountryChanged(value); } }
        }
        private string _CountryFlag;
        public string CountryFlag
        {
            get { return _CountryFlag; }
            set { if (_CountryFlag != value) { _CountryFlag = value; } }
        }

        protected void OnCountryChanged(string countryName)
        {
            //Console.WriteLine("OnCountryChanged " + countryName);
            // syncronizing country name and country flag
            this._Country = countryName;
            this._CountryFlag = DataGenerator.GetCountryFlag(countryName);
            OnPropertyChanged("Country");
            OnPropertyChanged("CountryFlag");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Productivity
    {
        public double Value { get; set; }
        public int Week { get; set; }
    }

    public static class EmployeeData
    {
        public static List<Employee> Create(int? count, bool? useProductivity)
        {
            if (count == null) count = 100;

            var employees = new List<Employee>();
            for (int i = 0; i < count; i++)
            {
                var age = Math.Round(DataGenerator.GetNumber(20, 40));
                var gender = DataGenerator.GetGender();
                var firstName = DataGenerator.GetNameFirst(gender);
                var lastName = DataGenerator.GetNameLast();
                var street = DataGenerator.GetStreet();
                var country = DataGenerator.GetCountry();
                var city = DataGenerator.GetCity(country);
                var generation = Math.Floor(age / 10) * 10 + "s";
                var email = firstName.ToLower() + "@" + DataGenerator.GetEmail();
                var website = firstName.ToLower() + DataGenerator.GetWebsite();

                var photoPath = DataGenerator.GetPhoto(gender);

                var employee = new Employee
                {
                    Address = street + ", " + city,
                    Age = age,
                    Birthday = DataGenerator.GetBirthday(),
                    City = DataGenerator.GetCity(country),
                    Email = email,
                    Gender = DataGenerator.GetGender(),
                    Generation = generation,
                    ID = DataGenerator.Pad(1001 + i, 4),
                    FirstName = firstName,
                    LastName = lastName,
                    Name = firstName + " " + lastName,
                    Photo = photoPath,
                    Phone = DataGenerator.GetPhone(),
                    Street = DataGenerator.GetStreet(),
                    Salary = DataGenerator.GetNumber(40, 200) * 1000,
                    Sales = DataGenerator.GetNumber(200, 980) * 1000,
                    Website = website,
                };
                employee.Country = country;

                employee.Income = DataGenerator.GetIncomeRange(employee.Salary);
                if (useProductivity.HasValue && useProductivity.Value)
                {
                    employee.Productivity = GetProductivity(52);
                }
                employees.Add(employee);
            }

            return employees;
        }

        public static List<Productivity> GetProductivity(int weekCount)
        {
            var productivity = new List<Productivity>();

            for (var w = 1; w <= weekCount; w++)
            {
                var value = DataGenerator.GetNumber(-50, 50);
                var prod = new Productivity
                {
                    Value = value,
                    Week = w
                };
                //Console.WriteLine("productivity " + w + " " + value);
                productivity.Add(prod);
            };

            return productivity;
        }
    }
}