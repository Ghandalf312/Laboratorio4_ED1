using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CustomGenerics;
using Laboratorio4_ED1.Models.Storage;
using Laboratorio4_ED1.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Laboratorio4_ED1.Controllers
{
    public class TasksController : Controller
    {
        public static int NoOfDeveloper = 0;
        public static string _path = Path.GetFullPath("Laboratorio4_ED1");
        public string FilePath = Path.Combine(_path, "Files");

        public ActionResult Login(int? isFirstTime)
        {
            var firstTime = isFirstTime ?? 1;
            if (firstTime == 1)
            {
                ChargeData();
            }
            return View();
        }

        private void ChargeData()
        {
            if (System.IO.File.Exists(Path.Combine(FilePath, "Users.txt")))
            {
                StreamReader streamReader = new StreamReader(Path.Combine(FilePath, "Users.txt"));
                var line = streamReader.ReadLine();
                if (line != null)
                {
                    var items = line.Split(',');
                    while (line != null)
                    {
                        items = line.Split(',');
                        Singleton.Instance.Developers.Add(new Developer() { Id = int.Parse(items[0]), User = items[1] });
                        line = streamReader.ReadLine();
                    }
                    streamReader.Close();

                    streamReader = new StreamReader(Path.Combine(FilePath, "Tasks.txt"));
                    line = streamReader.ReadLine();
                    while (line != null)
                    {
                        items = line.Split(',');
                        var task = new TasksModel()
                        {
                            AssignedDeveloper = items[0],
                            Priority = int.Parse(items[1]),
                            Title = items[2],
                            Description = items[3],
                            Proyect = items[4],
                            DueDate = DateTime.Parse(items[5])
                        };
                        Singleton.Instance.Hash.Insert(task, task.Title);
                        var developer = Singleton.Instance.Developers.Where(x => x.User == task.AssignedDeveloper).First();
                        if (developer.Tasks == null)
                        {
                            developer.Tasks = new PriorityQueue<string>();
                        }
                        developer.Tasks.AddTask(task.Title, task.DueDate, task.Priority);
                        line = streamReader.ReadLine();
                    }
                }
                streamReader.Close();
            }
        }

        [HttpPost]
        public ActionResult Login(IFormCollection collection)
        {
            try
            {
                Singleton.Instance.CurrentUser = collection["User"];
                var position = collection["Position"];
                if (position == "manager")
                {
                    return RedirectToAction("DevelopersList");
                }
                else
                {
                    var user = Singleton.Instance.Developers.Find(x => x.User == Singleton.Instance.CurrentUser);
                    if (user == null)
                    {
                        var NewUser = new Developer() { User = Singleton.Instance.CurrentUser, Id = NoOfDeveloper };
                        NoOfDeveloper++;
                        Singleton.Instance.Developers.Add(NewUser);
                    }
                    return RedirectToAction("DeveloperProfile");
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateTask()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTask(IFormCollection collection)
        {
            int Priority = 0;
            var priority = collection["Priority"];
            switch (priority)
            {
                case "high":
                    Priority = 1;
                    break;
                case "mid":
                    Priority = 2;
                    break;
                case "low":
                    Priority = 3;
                    break;
            }
            var newTask = new TasksModel();
            if (collection["Title"] == "")
            {
                ModelState.AddModelError("Title", "Please add a name for your task");
                return View("CreateTask");
            }
            try
            {
                newTask = new TasksModel()
                {
                    Title = collection["Title"],
                    Description = collection["Description"],
                    Proyect = collection["Proyect"],
                    Priority = Priority,
                    AssignedDeveloper = Singleton.Instance.CurrentUser,
                    DueDate = DateTime.Parse(collection["DueDate"])
                };
            }
            catch
            {
                ModelState.AddModelError("Title", "Please be sure that you entered all data correctly");
                return View("CreateTask");
            }
            if (Singleton.Instance.Hash.Search(newTask.Title) == null)
            {
                Singleton.Instance.Hash.Insert(newTask, newTask.Title);
                foreach (var developer in Singleton.Instance.Developers)
                {
                    if (developer.User == Singleton.Instance.CurrentUser)
                    {
                        if (developer.Tasks == null)
                        {
                            developer.Tasks = new PriorityQueue<string>();
                        }

                        developer.Tasks.AddTask(newTask.Title, newTask.DueDate, newTask.Priority);
                    }
                }
                return RedirectToAction("DeveloperProfile");
            }
            else
            {
                ModelState.AddModelError("Title", "The name of the task you want to add is already in use, please change its name");
                return View("CreateTask");
            }
        }

        public ActionResult DevelopersList()
        {
            return View(Singleton.Instance.Developers);
        }

        public ActionResult DeveloperProfile(int? change)
        {
            int changeTask = (change ?? 0);
            foreach (var developer in Singleton.Instance.Developers)
            {
                if (developer.User == Singleton.Instance.CurrentUser)
                {
                    if (changeTask == 1)
                    {
                        if (developer.Tasks != null)
                        {
                            if (developer.Tasks.tasksQuantity != 0)
                            {
                                Singleton.Instance.Hash.Delete(developer.Tasks.Root.Key);
                                developer.Tasks.Delete();
                                
                            }
                        }
                    }
                    if (developer.Tasks != null)
                    {
                        if (developer.Tasks.Root != null)
                        {
                            developer.CurrentTask = Singleton.Instance.Hash.Search(developer.Tasks.Root.Key).Value;
                        }
                        else
                        {
                            developer.CurrentTask = null;
                        }
                    }
                    return View(developer);
                }
            }
            return View();
        }

        public ActionResult DeveloperReview(int id)
        {

            var developer = Singleton.Instance.Developers.Where(x => x.Id == id).First();
            var taskList = new List<TasksModel>();
            var developerCopy = new Developer() { Tasks = (PriorityQueue<string>)developer.Tasks.Clone(), User = developer.User };
            for (int i = 0; i < developerCopy.Tasks.tasksQuantity; i++)
            {
                taskList.Add(Singleton.Instance.Hash.Search(developerCopy.Tasks.Delete().Key).Value);
            }
            var dev = new DeveloperForReview() { User = developer.User, Tasks = taskList };

            return View(dev);

        }

        public void SaveUsers()
        {
            var text = "";
            foreach (var developer in Singleton.Instance.Developers)
            {
                text += $"{developer.Id},{developer.User}" + "\r\n";
            }
            string path = Path.Combine(FilePath, "Users.txt");
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.Create(path).Close();
            System.IO.File.WriteAllText(path, text);
            // Solución obtenida en: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file
            // y en :https://stackoverflow.com/questions/4680284/system-io-file-create-locking-a-file




        }

        public void SaveTasks()
        {
            var text = "";
            var tasks = Singleton.Instance.Hash.GetTasksAsNodes();
            foreach (var node in tasks)
            {
                text += node.Value.GetInfoAsText() + "\r\n";
            }
            string path = Path.Combine(FilePath, "Tasks.txt");
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.Create(path).Close();
            System.IO.File.WriteAllText(path, text);

        }

        public ActionResult Exit()
        {
            SaveUsers();
            SaveTasks();
            return View();
        }


    }
}