using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Samples
{
    public class EmployeeJA : INotifyPropertyChanged
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
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        public double Salary { get; set; }
        public double Sales { get; set; }
        public string Income { get; set; }
        public int Index { get; set; }

        public DateTime Birthday { get; set; }
        public List<ProductivityJA> Productivity { get; set; }

        private string _Country;
        public string Country
        {
            get { return _Country; }
            set { if (_Country != value) { OnCountryChanged(value); } }
        }

        public string CountryFlag { get; set; }

        protected void OnCountryChanged(string countryName)
        {
            // syncronizing country name and country flag
            _Country = countryName;
            CountryFlag = DataGeneratorJA.GetCountryFlag(countryName);
            City = DataGeneratorJA.GetCity(countryName);
            OnPropertyChanged("Country");
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

    public class ProductivityJA
    {
        public double Value { get; set; }
        public int Week { get; set; }
    }

    public static class EmployeeDataJA
    {
        public static List<EmployeeJA> Create(int? count, bool? useProductivity)
        {
            if (count == null) count = 100;

            var employees = new List<EmployeeJA>();
            for (int i = 0; i < count; i++)
            {
                var age = Math.Round(DataGeneratorJA.GetNumber(20, 40));
                var gender = DataGeneratorJA.GetGender();
                var firstName = DataGeneratorJA.GetNameFirst(gender);
                var lastName = DataGeneratorJA.GetNameLast();
                var street = DataGeneratorJA.GetStreet();
                var country = DataGeneratorJA.GetCountry();
                var city = DataGeneratorJA.GetCity(country);
                var email = firstName.ToLower() + "@" + DataGeneratorJA.GetEmail();
                var photoPath = DataGeneratorJA.GetPhoto(gender);

                var employee = new EmployeeJA
                {
                    Index = i,
                    Address = street + ", " + city,
                    Age = age,
                    Birthday = DataGeneratorJA.GetBirthday(),
                    City = city,
                    Email = email,
                    Gender = gender,
                    ID = DataGeneratorJA.Pad(1001 + i, 4),
                    FirstName = firstName,
                    LastName = lastName,
                    Name = firstName + " " + lastName,
                    Photo = photoPath,
                    Phone = DataGeneratorJA.GetPhone(),
                    Street = DataGeneratorJA.GetStreet(),
                    Salary = DataGeneratorJA.GetNumber(40, 200) * 1000,
                    Sales = DataGeneratorJA.GetNumber(200, 980) * 1000,
                };
                employee.Country = country;

                employee.Income = DataGeneratorJA.GetIncomeRange(employee.Salary);

                if (useProductivity.HasValue && useProductivity.Value)
                {
                    employee.Productivity = GetProductivity(52);
                }
                employees.Add(employee);
            }

            return employees;
        }

        public static List<ProductivityJA> GetProductivity(int weekCount)
        {
            var productivity = new List<ProductivityJA>();

            for (var w = 1; w <= weekCount; w++)
            {
                var value = DataGeneratorJA.GetNumber(-50, 50);
                var prod = new ProductivityJA
                {
                    Value = value,
                    Week = w
                };
                productivity.Add(prod);
            };

            return productivity;
        }
    }
}