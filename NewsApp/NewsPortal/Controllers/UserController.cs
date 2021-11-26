using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsPortal.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/User/getAll")]
        [HttpGet]
        public List<NewsWithInfo> getAll()
        {
            return NewsService.getAll();
        }

        [Route("api/User/addComment")]
        [HttpPost]
        public void comment(CommentModel cmt)
        {
            NewsService.addComment(cmt);
        }

        [Route("api/User/addReaction")]
        [HttpPost]
        public void react(ReactionModel rm)
        {
            NewsService.addReaction(rm);
        }
    }
}
