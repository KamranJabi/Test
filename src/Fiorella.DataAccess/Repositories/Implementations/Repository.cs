using Fiorella.Core.Intefaces;
using Fiorella.DataAccess.Contexts;
using Fiorella.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.DataAccess.Repositories.Implementations;

public class Repository<T> : IRepository<T> where T : class, IEntity, new()
{
    private readonly AppDbContext _context;

    public Repository(AppDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table=>_context.Set<T>();
    public IQueryable<T> GetAll()
    {
        return Table.AsQueryable();
    }
}
