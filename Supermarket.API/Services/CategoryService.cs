using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repos;

        public CategoryService(ICategoryRepository repos)
        {
            _repos = repos;
        }

        public async Task<IEnumerable<Category2>> ListAsync()
        { 
            return await _repos.ListAsync();
        }
    }
}
