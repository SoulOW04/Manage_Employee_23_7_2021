using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manage_Employee_23_7_2021.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }
        public string ClientCompany { get; set; }

        public virtual ICollection<AssignTask> AssignTask { get; set; }
    }
}