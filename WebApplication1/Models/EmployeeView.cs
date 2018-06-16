using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EmployeeView
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }

        public int Age { get; set; }
        public string Adress { get; set; }
        public string MaritalStatus { get; set; }
    }
    public class DetaisEmployeeView
    {
        public string Adress { get; set; }
        public string MaritalStatus { get; set; }

    }


}
