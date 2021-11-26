using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CommentModel
    {
        public int id { get; set; }
        public string comment { get; set; }
        public int newsId { get; set; }
        public int userId { get; set; }
    }
}
