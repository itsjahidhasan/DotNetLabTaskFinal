using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class NewsService
    {
        public static void add(NewsModel n)
        {
            News ns = new News();
            ns.news1 = n.news;
            ns.date = n.date;
            ns.userId = n.userId;
            ns.categoryId = n.categoryId;
            NewsAccess.add(ns);
        }

        public static void update(NewsModel n)
        {
            News ns = new News();
            ns.news1 = n.news;
            ns.id = n.id;
            NewsAccess.update(ns);
        }

        public static List<NewsModel> getByCategory(int categoryId)
        {
            var news = NewsAccess.getNewsByCategory(categoryId);
            List<NewsModel> newsList = new List<NewsModel>();
            foreach(var n in news)
            {
                NewsModel ns = new NewsModel();
                ns.id = n.id;
                ns.news = n.news1;
                ns.categoryId = n.categoryId;
                ns.date = n.date;
                ns.userId = n.userId;
                newsList.Add(ns);
            }
            return newsList;

        }

        public static List<NewsModel> getByDate(string date)
        {
            var news = NewsAccess.getNewsByDate(date);
            List<NewsModel> newsList = new List<NewsModel>();
            foreach (var n in news)
            {
                NewsModel ns = new NewsModel();
                ns.id = n.id;
                ns.news = n.news1;
                ns.categoryId = n.categoryId;
                ns.date = n.date;
                ns.userId = n.userId;
                newsList.Add(ns);
            }
            return newsList;

        }

        public static List<NewsModel> getByCategoryAndDate(int categoryId, string date)
        {
            var news = NewsAccess.getNewsByCategoryAndDate(categoryId,date);
            List<NewsModel> newsList = new List<NewsModel>();
            foreach (var n in news)
            {
                NewsModel ns = new NewsModel();
                ns.id = n.id;
                ns.news = n.news1;
                ns.categoryId = n.categoryId;
                ns.date = n.date;
                ns.userId = n.userId;
                newsList.Add(ns);
            }
            return newsList;

        }

        public static void deleteNews(NewsModel news)
        {
            News ns = new News();
            ns.id = news.id;
            NewsAccess.delete(ns);
        }

        public static List<NewsWithInfo> getAll()
        {
            var news = NewsAccess.getAllNews();
            List<NewsWithInfo> newsList = new List<NewsWithInfo>();
            foreach (var n in news)
            {
                NewsWithInfo ns = new NewsWithInfo();
                ns.id = n.id;
                ns.news = n.news1;
                ns.categoryId = n.categoryId;
                ns.date = n.date;
                List<string> cmnts = new List<string>();
                foreach(var com in n.Comments)
                {
                    cmnts.Add(com.comment1);
                }
                ns.comments = cmnts;

                List<string> rcts = new List<string>();
                foreach (var r in n.Reactions)
                {
                    rcts.Add(r.react);
                }
                ns.reacts = rcts;
                newsList.Add(ns);
            }
            return newsList;

        }

        public static void addComment(CommentModel cmt)
        {
            Comment c = new Comment();
            c.comment1 = cmt.comment;
            c.newsId = cmt.newsId;
            c.userId = cmt.userId;
            NewsAccess.addComment(c);
        }

        public static void addReaction(ReactionModel rm)
        {
            Reaction r = new Reaction();
            r.react = rm.react;
            r.newsId = rm.newsId;
            r.userId = rm.userId;
            NewsAccess.addReaction(r);
        }
    }
}
