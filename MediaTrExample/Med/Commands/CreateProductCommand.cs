using MediatR;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Threading;

namespace MediaTrExample.Med.Commands
{
    public class CreateProductCommand : IRequest<Guid>
    {
      public string Name { get; set; }
      public int Quantity { get; set; }
      public decimal Value { get; set; }

      public class CreateProductCommandHandler : IRequest<CreateProductCommand,Guid>
      {
         public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
         {
            return Task.FromResult(Guid.NewGuid());
         }
      }
    }
}