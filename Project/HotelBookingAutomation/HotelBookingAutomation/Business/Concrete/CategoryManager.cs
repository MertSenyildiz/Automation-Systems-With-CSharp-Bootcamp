using HotelBookingAutomation.Business.Abstract;
using HotelBookingAutomation.DataAcess.Abstract;
using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
           _categoryDal = categoryDal;
        }

        public async Task DeleteCategoryAsync(Category category)
        {
            try
            {
               await _categoryDal.DeleteAsync(category);
            }catch (Exception ex) { }
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            try
            {
                return await _categoryDal.GetAllAsync();
            }
            catch (Exception ex) { }
            return null;
        }

        public async Task<Category> GetCategoryByIdAsync(Guid id)
        {
            try
            {
                return await _categoryDal.GetByIdAsync(id);
            }
            catch (Exception ex) { }
            return null;
        }

        public async Task InsertCategoryAsync(Category category)
        {
            try
            {
                await _categoryDal.InsertAsync(category);
            }
            catch (Exception ex) { }
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            try
            {
                await _categoryDal.UpdateAsync(category);
            }
            catch (Exception ex) { }
        }
    }
}
