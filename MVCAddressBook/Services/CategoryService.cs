using System;
using MVCAddressBook.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAddressBook.Services.Interfaces
{
    public interface ICategoryService
    {
        Task AddContactToCategoryAsync(int categoryId, int contactId);

        Task RemoveContactFromCategoryAsync(int categoryId, int contactId);

        Task<ICollection<Category>> GetContactCategoriesAsync(int contactId);

        Task<int> GetContactCountForCategoryAsync(int categoryId);
    }
}
