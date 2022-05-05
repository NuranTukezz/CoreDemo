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
    public class CategoryRepository : ICategoryDal
    {

        //15.Ders

        Context c = new Context();

        public void Add(Category t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public void Delete(Category t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public Category GetByID(int id)
        {
            return c.Categories.Find( id);
        }

        public List<Category> GetListAll()
        {
            return c.Categories.ToList();
        }

        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }

        public void Update(Category t)
        {
            c.Update(t);
            c.SaveChanges();
        }
    }
}
