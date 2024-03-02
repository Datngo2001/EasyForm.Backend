using EasyForm.Domain.Entities;
using EasyForm.Domain.Interfaces;
using MediatR;

namespace EasyForm.Application.Users.Queries.GetUser;

public class GetUserQuery : IRequest<User?>
{
    public Guid UserId { get; set; }
}

public class GetUserQueryHandler : IRequestHandler<GetUserQuery, User?>
{
    private readonly IUserRepository _userRepository;

    public GetUserQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<User?> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        return _userRepository.GetByIdAsync(request.UserId, cancellationToken);
    }
}