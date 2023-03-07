using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Cache
{
    public static class ProjectCache
    {
        public static int Project_code { get; set; }
        public static string Project_title { get; set; }
        public static string Project_state { get; set; }
        public static int Bug_code { get; set; }
        public static string Bug_description { get; set; }
    }
}
