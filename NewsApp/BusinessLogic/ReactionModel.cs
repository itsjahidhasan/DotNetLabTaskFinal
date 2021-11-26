using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ReactionModel
    {
        public int id { get; set; }
        public string react { get; set; }
        public int newsId { get; set; }
        public int userId { get; set; }
    }
}
