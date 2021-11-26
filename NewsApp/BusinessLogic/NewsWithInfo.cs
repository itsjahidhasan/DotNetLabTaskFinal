using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public class NewsWithInfo
    {
        public int id { get; set; }
        public string news { get; set; }
        public string date { get; set; }
        public int categoryId { get; set; }
        public List<string> comments { get; set; }
        public List<string> reacts { get; set; }
    }
}
