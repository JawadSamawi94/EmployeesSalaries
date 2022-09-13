using EmployeesSalaries.Models;
using EmployeesSalaries.Models.Employee;
using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Data
{
    public static class EmployeeData
    {
        public static List<IEmployee> Employees => new List<IEmployee>
        {
            new Manager { 
                FirstName = "Arnold",
                Id = 0,
                LastName = "Guardiola",
                SalaryCalc = new ManagerSalary(2100, 1000)
            },

            new Sales { 
                FirstName = "Carlos",
                Id = 1,
                LastName = "Haney",
                SalaryCalc = new SalesSalary(1200, 1000, 1500),
                Supervisor = new Manager { 
                    FirstName = "Arnold",
                    Id = 0,
                    LastName = "Guardiola" 
                } 
            },

            new Sales { 
                FirstName = "David",
                Id = 2,
                LastName = "Silva",
                SalaryCalc = new SalesSalary(1500, 1000, 1500),
                Supervisor = new Manager { 
                    FirstName = "Arnold",
                    Id = 0,
                    LastName = "Guardiola" 
                }  
            },

            new Sales { 
                FirstName = "Sergio",
                Id = 3,
                LastName = "Ramos",
                SalaryCalc = new SalesSalary(1300, 1000, 1500),
                Supervisor = new Manager { 
                    FirstName = "Arnold",
                    Id = 0,
                    LastName = "Guardiola" 
                } 
            },

            new LeadDev { 
                FirstName = "Leo",
                Id = 4,
                LastName = "Messi",
                SalaryCalc = new LeadDevSalary(1500),
                Supervisor = new Manager { 
                    FirstName = "Arnold",
                    Id = 0,
                    LastName = "Guardiola" 
                } 
            },

            new LeadDev { 
                FirstName = "Tamara",
                Id = 5,
                LastName = "Romero",
                SalaryCalc = new LeadDevSalary(1300),
                Supervisor = new Manager { 
                    FirstName = "Arnold",
                    Id = 0,
                    LastName = "Guardiola" 
                } 
            },

            new HR { 
                FirstName = "Kevin",
                Id = 6,
                LastName = "Debruyn",
                SalaryCalc = new HRSalary(1200),
                Supervisor = new Manager { 
                    FirstName = "Arnold",
                    Id = 0,
                    LastName = "Guardiola" 
                }  
            },

            new HR { 
                FirstName = "Christine",
                Id = 7,
                LastName = "Dejong",
                SalaryCalc = new HRSalary(1500),
                Supervisor = new Manager { 
                    FirstName = "Arnold",
                    Id = 0,
                    LastName = "Guardiola" } },

            new Dev { 
                FirstName = "Andreas",
                Id = 8,
                LastName = "Misk",
                SalaryCalc = new DevSalary(1000),
                Supervisor = new LeadDev { 
                    FirstName = "Leo",
                    Id = 4,
                    LastName = "Messi",
                    Supervisor = new Manager { 
                        FirstName = "Arnold",
                        Id = 0,
                        LastName = "Guardiola" 
                    } 
                }
            },

            new Dev { 
                FirstName = "Thomas",
                Id = 9,
                LastName = "Gripe",
                SalaryCalc = new DevSalary(850),
                Supervisor = new LeadDev { 
                    FirstName = "Leo",
                    Id = 4,
                    LastName = "Messi",
                    Supervisor = new Manager { 
                        FirstName = "Arnold",
                        Id = 0,
                        LastName = "Guardiola" 
                    } 
                }
            },

            new Dev { 
                FirstName = "Robert",
                Id = 10,
                LastName = "Franks",
                SalaryCalc = new DevSalary(900),
                Supervisor = new LeadDev { 
                    FirstName = "Tamara",
                    Id = 5,
                    LastName = "Romero",
                    Supervisor = new Manager { 
                        FirstName = "Arnold",
                        Id = 0,
                        LastName = "Guardiola" 
                    } 
                }
            },

            new Dev { 
                FirstName = "Roberto",
                Id = 10,
                LastName = "Manch",
                SalaryCalc = new DevSalary(800),
                Supervisor = new LeadDev { 
                    FirstName = "Tamara",
                    Id = 5,
                    LastName = "Romero",
                    Supervisor = new Manager { 
                        FirstName = "Arnold",
                        Id = 0,
                        LastName = "Guardiola" 
                    } 
                } 
            }

        };

    }
}
