using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace Laboratorio4_ED1.Models
{
    public class DeveloperForReview
    {
        public string User { get; set; }
        public List<TasksModel> Tasks { get; set; }

    }
}
