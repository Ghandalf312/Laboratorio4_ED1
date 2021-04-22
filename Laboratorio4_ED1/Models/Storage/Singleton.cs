using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomGenerics.Estructuras;





namespace Laboratorio4_ED1.Models.Storage
{
    public class Singleton
    {
        private static Singleton _instance = null;
        public static Singleton Instance
        {
            get
            {
                if (_instance == null) _instance = new Singleton();
                return _instance;
            }
        }


        public Hash<TasksModel> Hash = new Hash<TasksModel>();
        public List<Developer> Developers = new List<Developer>();
        public string CurrentUser;



    }
}
