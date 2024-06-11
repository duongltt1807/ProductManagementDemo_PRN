using System;
using System.Collections.Generic;
using DataAccessLayer;
using BusinessObjects;


namespace Repositories
{
    public class CategoryRepository : ICategoryRepository
    {

        public List<Category> GetCategories() => CategoryDAO.GetCategories();
    }
}
