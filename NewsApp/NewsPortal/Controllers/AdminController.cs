using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLogic;

namespace NewsPortal.Controllers
{
    public class AdminController : ApiController
    {
        [Route("api/Admin/addNews")]
        [HttpPost]
        public void addNews(NewsModel news)
        {
            NewsService.add(news);
        }

        [Route("api/Admin/updateNews")]
        [HttpPut]
        public void updateNews(NewsModel news)
        {
            NewsService.update(news);
        }

        [Route("api/Admin/deleteNews")]
        [HttpGet]
        public void deleteNews(NewsModel news)
        {
            NewsService.deleteNews(news);
        }

        [Route("api/Admin/getByCategory")]
        [HttpGet]
        public List<NewsModel> getNewsByCategory(NewsModel news)
        {
            return NewsService.getByCategory(news.categoryId);
        }

        [Route("api/Admin/getByDate")]
        [HttpGet]
        public List<NewsModel> getNewsByDate(NewsModel news)
        {
            return NewsService.getByDate(news.date);
        }

        [Route("api/Admin/getByCategoryAndDate")]
        [HttpGet]
        public List<NewsModel> getNewsByCategoryAndDate(NewsModel news)
        {
            return NewsService.getByCategoryAndDate(news.categoryId, news.date);
        }

        
    }
}
