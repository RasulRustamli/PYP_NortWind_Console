using PYP_NortWind_Console.Abstractions.Services;
using PYP_NortWind_Console.Models;
using PYP_NortWind_Console.Services;

NorthwindContext context = new NorthwindContext();
 ICategoryService categoryService = new CategoryService(context);


var dbCategory=categoryService.GetAllCategories();


Category category =new Category();
category.Description = "adsdsadsa";
category.CategoryName="Test";

var newCategory =categoryService.Update(1, category);
dbCategory.ForEach(x => global::System.Console.WriteLine(x.CategoryName));

