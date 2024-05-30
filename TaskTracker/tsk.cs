using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    internal class taskManager
    {
        public void loadTasks(string filepath, userData user, ListView lV)
        {
            lV.Items.Clear();
            foreach (task t in user.tasks)
            lV.Items.Add(t.nomeTask);
        }

        public void addTask(string filepath, task newTask,)
        {

        }
    }
}
