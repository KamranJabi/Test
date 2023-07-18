using Fiorella.Core.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.DataAccess.Repositories.Interfaces;

public interface IRepository<T> where T : class,IEntity,new()
{
    DbSet<T> Table { get;}
    IQueryable<T> GetAll();
}
