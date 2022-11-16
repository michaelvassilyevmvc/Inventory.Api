using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Products
{
    public class Create
    {
        public class Command: IRequest<int>
        {
            public string Name { get; set; }

        }

        public class Handler : IRequestHandler<Command, int>
        {
            public Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }

    }


}
