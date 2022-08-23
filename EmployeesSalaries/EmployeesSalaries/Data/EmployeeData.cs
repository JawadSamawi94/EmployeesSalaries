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
                LastName = "Guardiola" 
            },

            new Sales { 
                FirstName = "Carlos",
                Id = 1,
                LastName = "Haney", 
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
                Supervisor = new Manager { 
                    FirstName = "Arnold",
                    Id = 0,
                    LastName = "Guardiola" } },

            new Dev { 
                FirstName = "Andreas",
                Id = 8,
                LastName = "Misk", 
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
