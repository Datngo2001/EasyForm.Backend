using EasyForm.Domain.Entities;
using EasyForm.Domain.Interfaces;
using EasyForm.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace EasyForm.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly DataContext _dataContext;

    public UserRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public Task<User?> GetByIdAsync(Guid userId, CancellationToken cancellationToken)
    {
        return _dataContext.Users.FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);
    }
}