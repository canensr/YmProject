using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ActivityManager
    {
        Repository<Activity> repoactivity = new Repository<Activity>();
        public List<Activity> GetAll()
        {
            return repoactivity.List();
        }
        
        public int ActivityAddBL(Activity p)
        {
            //if (p.ActivitySubject == "" || p.ActivityDate == "" || p.ActivityExplanation.Length <= 5 )
            //{
            //    return -1;
            //}
            return repoactivity.Insert(p);
        }

        
    }
}
