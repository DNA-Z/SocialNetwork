using MediatR;
using SocialNetwork.Infrastructure.Data.DummyRepository;

namespace ApplicationLogic.Commands
{
    public static class GetTodoById
    {
        public record Command(int Id) : IRequest<Response>;


        public class Handler : IRequestHandler<Command, Response>
        {
            private readonly Repository repository;

            public Handler(Repository repository)
            {
                this.repository = repository;
            }

            public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
            {
                var todo = repository.PersonInformations.FirstOrDefault(x => x.Id == request.Id);

                return todo == null ? null : new Response(todo.Id, todo.FirstName, todo.LastName, todo.NickName, todo.DateOfBirth, todo.EMailAdress, todo.Password, todo.Completed);
            }
        }

        public record Response(int Id, string FirstName, string LastName, string NickName, DateTime DateOfBirth, string EMailAdress, string Password, bool Completed);
    }
}
