using System;
using System.Collections.Generic;
using System.Text;
using Realms;

namespace MHRS.Data
{
    public class Employess : RealmObject
    {
        [PrimaryKey]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeAge{ get; set; }
        public string EmployeeCountry{ get; set; }
    }
}
