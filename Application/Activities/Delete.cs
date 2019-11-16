using MediatR;
using Presistense;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Activities
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext dataContext)
            {
                _context = dataContext;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var activityFromDb = await _context.Activities.FindAsync(request.Id);

                if (activityFromDb == null)
                    throw new Exception("No activity found");

                _context.Activities.Remove(activityFromDb);

                var success = await _context.SaveChangesAsync() > 0;
                if (success) return Unit.Value;
                throw new Exception("Problem saving changes of activity");
            }
        }

    }
}
