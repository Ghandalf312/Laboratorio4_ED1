using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomGenerics;
using System.Web;
namespace Laboratorio4_ED1.Models
{
    public class Developer
    {


        public static int ID { get; set; }
        public int Id { get; set; }
        public string User { get; set; }
        public PriorityQueue<string> Tasks { get; set; }
        public TasksModel CurrentTask { get; set; }

        public Developer()
        {
            Id = ID;
        }


    }
}
