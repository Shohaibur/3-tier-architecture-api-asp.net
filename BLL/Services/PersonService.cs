using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PersonService //todo : public = accessable from AL
    {
        public static string GetName(int id) {
            id += 100;
            var data = PersonRepo.Get(id);
            return data;
        }
    }
}
