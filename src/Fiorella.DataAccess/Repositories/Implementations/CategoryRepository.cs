using Fiorella.Core.Entities;
using Fiorella.DataAccess.Contexts;
using Fiorella.DataAccess.Repositories.Interfaces;

namespace Fiorella.DataAccess.Repositories.Implementations;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {
    }
}
