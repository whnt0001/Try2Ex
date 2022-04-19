using ClassLibrary1.Sourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public ClassRepos repos;

        public Class1 (ClassRepos repos2)
        {
            repos = repos2;
        }

        public List<ClassApp> GetAllList()
        {
            return repos.listapp.ToList();
        }
        /*public List<ClassTask> GetList()
        {
            return repos.taskapp.ToList();
        }*/
        public void  DeleteV(ClassApp app)
        {
            ClassApp ap = repos.listapp.First(x => x.AppID == app.AppID);
            repos.listapp.Remove(ap);
        }
        /*public void Delete( app)
        {
            ClassApp ap = repos.listapp.First(x => x.AppID == app.AppID);
            repos.listapp.Remove(ap);
        }*/

    }
}
