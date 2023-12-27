using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class PersonRepo
    {
        public static List<string> Get()
        {
            return null;
        }
        public static string Get(int id)
        {
            return id == 109? "Shoaib":"Not found";
        }
    }
}
