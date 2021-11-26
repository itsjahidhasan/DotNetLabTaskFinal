using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class NewsModel
    {
        public int id { get; set; }
        public string news { get; set; }
        public string date { get; set; }
        public int categoryId { get; set; }
        public int userId { get; set; }
    }
}
