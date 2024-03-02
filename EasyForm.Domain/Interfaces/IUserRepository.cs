using EasyForm.Domain.Entities;

namespace EasyForm.Domain.Interfaces;

public interface IUserRepository
{
    public Task<User?> GetByIdAsync(Guid userId);
}