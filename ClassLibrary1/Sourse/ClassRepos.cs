using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Sourse
{
    public class ClassRepos
    {
        public List<ClassApp> listapp;
        public List<ClassTaskList> tasklistapp;
        public List<ClassTask> taskapp;

        public ClassRepos()
        {
            listapp = new List<ClassApp>()
            {
                new ClassApp() {AppID = 1 , AppList = "Application 1"},
                new ClassApp() {AppID = 2 , AppList = "Application 2"},
                new ClassApp() {AppID = 3 , AppList = "Application 3"},
                new ClassApp() {AppID = 4 , AppList = "Application 4"},
                new ClassApp() {AppID = 5 , AppList = "Application 5"}
            };

            tasklistapp = new List<ClassTaskList>()
            {
                new ClassTaskList() {TaskListName = "TaskListName 1", TaskListTasks = "TaskListTask 1"},
                new ClassTaskList() {TaskListName = "TaskListName 2", TaskListTasks = "TaskListTask 2"},
                new ClassTaskList() {TaskListName = "TaskListName 3", TaskListTasks = "TaskListTask 3"},
                new ClassTaskList() {TaskListName = "TaskListName 4", TaskListTasks = "TaskListTask 4"},
                new ClassTaskList() {TaskListName = "TaskListName 5", TaskListTasks = "TaskListTask 5"}
            };

            taskapp = new List<ClassTask>()
            {
                new ClassTask() {TaskDone = false, TaskDue  = "Due 1", TaskTitle = "Title 1"},
                new ClassTask() {TaskDone = false, TaskDue  = "Due 1", TaskTitle = "Title 1"},
                new ClassTask() {TaskDone = false, TaskDue  = "Due 1", TaskTitle = "Title 1"},
                new ClassTask() {TaskDone = false, TaskDue  = "Due 1", TaskTitle = "Title 1"},
                new ClassTask() {TaskDone = false, TaskDue  = "Due 1", TaskTitle = "Title 1"}
            };
        }
        
    }
}
