using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void Add(Blog t)
        {
            using var c= new Context();
            c.Add(t);
            c.SaveChanges();
        }

        //15.ders

        public void Delete(Blog t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public Blog GetByID(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }

        public List<Blog> GetListAll()
        {
            using var c = new Context();
            return c.Blogs.ToList();    
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
