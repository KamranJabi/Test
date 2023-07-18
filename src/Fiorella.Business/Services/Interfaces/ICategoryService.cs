using Fiorella.Core.Entities;

namespace Fiorella.Business.Services.Interfaces;

public interface ICategoryService
{
    Task<List<Category>> GetAllAsync();
}
