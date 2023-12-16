using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class Helper
    {
        private static Models.Entitiesq s_Entities;
        public static Models.Entitiesq GetContext()
        {
            if (s_Entities == null)
            {
                s_Entities = new Models.Entitiesq();
            }
            return s_Entities;
        }

        public void CreateUsers(Models.Users users, Models.employers employers)
        {
            s_Entities.Users.Add(users);
            s_Entities.employers.Add(employers);
            s_Entities.SaveChanges();
        }
        public void UpdateUsers(Models.Users users, Models.employers employers)
        {
            s_Entities.Entry(users).State = System.Data.Entity.EntityState.Modified;
            s_Entities.Entry(employers).State = System.Data.Entity.EntityState.Modified;
            s_Entities.SaveChanges();
        }
        public void RemoveUsers(int IDUsers, int IDEmployer)
        {
            var users = s_Entities.Users.Find(IDUsers);
            var employers = s_Entities.employers.Find(IDEmployer);
            s_Entities.Users.Remove(users);
            s_Entities.employers.Remove(employers);
            s_Entities.SaveChanges();
        }
        public void FiltUsers()
        {
            var employers = s_Entities.employers.Where(x => x.imya.StartsWith("М") || x.imya.StartsWith("А"));
        }
        public void SortUsers()
        {
            var employers = s_Entities.employers.OrderBy(x => x.imya);
        }
    }
}

