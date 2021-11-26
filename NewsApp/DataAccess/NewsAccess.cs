using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class NewsAccess
    {
        static Database db;
        static NewsAccess()
        {
            db = new Database();
        }

        public static void add(News news)
        {
            db.News.Add(news);
            db.SaveChanges();
        }

        public static News getNews(int id)
        {
            var entity = (from e in db.News
                          where e.id == id
                          select e).FirstOrDefault();
            return entity;
        }

        public static void update(News n)
        {
            var entity = getNews(n.id);
            entity.news1 = n.news1;
            db.SaveChanges();
        }

        public static void delete(News n)
        {
            var entity = getNews(n.id);
            db.News.Remove(entity);
            db.SaveChanges();
        }

        public static List<News> getAllNews()
        {
            var entity = (from e in db.News
                          select e).ToList();
            return entity;
        }

        public static List<News> getNewsByDate(string date)
        {
            var entity = (from e in db.News
                          where e.date == date
                          select e).ToList();
            return entity;
        }

        public static List<News> getNewsByCategory(int categoryId)
        {
            var entity = (from e in db.News
                          where e.categoryId == categoryId
                          select e).ToList();
            return entity;
        }

        public static List<News> getNewsByCategoryAndDate(int categoryId, string date)
        {
            var entity = (from e in db.News
                          where e.date == date && e.categoryId == categoryId
                          select e).ToList();
            return entity;
        }

        public static void addComment(Comment c)
        {
            db.Comments.Add(c);
            db.SaveChanges();
        }

        public static void addReaction(Reaction r)
        {
            db.Reactions.Add(r);
            db.SaveChanges();
        }
    }
}
