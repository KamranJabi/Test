using Fiorella.Business.Exceptions;
using Fiorella.Business.Services.Interfaces;
using Fiorella.Core.Entities;
using Fiorella.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Business.Services.Implementations;

public class CategoryService : ICategoryService
{
    public readonly ICategoryRepository _repository;

    public CategoryService(ICategoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Category>> GetAllAsync()
    {
        List<Category> categories = await _repository.GetAll().ToListAsync();
        if (categories.Count == 0) throw new NotFoundException("Category not found!!!");
        return categories;
    }
}
