using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository=new EfCategoryRepository();
        }
        

        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Insert(category);
        }


        public void CategoryDalete(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
           return efCategoryRepository.GetByID(id);
        }

        public List<Category> GetList()
        {
           return efCategoryRepository.GetListAll();
        }
    }
}
