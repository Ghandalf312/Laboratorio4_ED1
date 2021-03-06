using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Laboratorio4_ED1.Models
{
    public class TasksModel : IComparable
    {


        public string Title { get; set; }
        public string Description { get; set; }
        public string Proyect { get; set; }
        public int Priority { get; set; }
        public string AssignedDeveloper { get; set; }
        public DateTime DueDate { get; set; }

        public int CompareTo(object obj)
        {
            return this.Title.CompareTo((string)obj);
        }

        public string GetInfoAsText()
        {
            return $"{AssignedDeveloper},{Priority.ToString()},{Title},{Description},{Proyect},{DueDate.ToString()}";
        }
    }
}
