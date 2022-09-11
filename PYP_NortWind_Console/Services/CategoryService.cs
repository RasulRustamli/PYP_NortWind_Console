using PYP_NortWind_Console.Abstractions.Services;
using PYP_NortWind_Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_NortWind_Console.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly NorthwindContext _context;

        public CategoryService(NorthwindContext context)
        {
            _context = context;
        }

       
        public async Task<Category> Add(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async void DeleteCategoryById(int id)
        {
            Category category =  _context.Categories.FirstOrDefault(x=>x.CategoryId==id);
            if (category == null)
            {
                throw new Exception("We dont have category");
                
            }
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

        }

        public  List<Category> GetAllCategories() =>  _context.Categories.ToList();
      

        public Category GetCategoryById(int id)
        {
            Category category = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
            if (category == null)
            {
                throw new Exception("We dont have category");

            }
            return category;
        }

        public async Task<Category> Update(int id,Category category)
        {
            Category dbcategory = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
            if (category != null)
            {
                dbcategory.Picture = category.Picture;
                dbcategory.Description=category.Description;
                dbcategory.CategoryName= category.CategoryName;
                _context.Categories.Update(dbcategory);
                _context.SaveChangesAsync();
                return dbcategory;
            }
            throw new NotImplementedException();

        }

      
    }
}
