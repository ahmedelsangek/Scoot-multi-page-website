using Business_Layer__BL_.Bases;
using Data_Access_Layer__DAL_;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer__BL_.Repositories
{
    class CategoryRepository : BaseRepository<Category>
    {
        private DbContext EC_DbContext;

        public CategoryRepository(DbContext EC_DbContext) : base(EC_DbContext)
        {
            this.EC_DbContext = EC_DbContext;
        }
        #region CRUB

        public List<Category> GetAllOrder()
        {
            return GetAll().ToList();
        }

        public bool InsertOrder(Category category)
        {
            return Insert(category);
        }
        public void UpdateOrder(Category category)
        {
            Update(category);
        }
        public void DeleteOrder(int id)
        {
            Delete(id);
        }

        public bool CheckCategoryExists(Category category)
        {
            return GetAny(l => l.Id == category.Id);
        }
        public Category GetCategoryById(int id)
        {
            return GetFirstOrDefault(l => l.Id == id);
        }
        #endregion
    }
}
