using PYP_NortWind_Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_NortWind_Console.Abstractions.Services
{
    public interface ICategoryService
    {
        public Task<Category> Add(Category category);
        public Task<Category> Update(int id,Category category);
        public Category GetCategoryById(int id);
        public List<Category> GetAllCategories();
        public void DeleteCategoryById(int id);



    }
}
