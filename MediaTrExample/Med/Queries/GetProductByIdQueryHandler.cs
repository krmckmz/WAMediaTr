using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediaTrExample.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequest<GetProductByIdQuery,GetProductViewModel>
    {
        public Task<GetProductByIdViewModel> Handle(GetProductByIdQuery request,CancellationToken cancellationToken)
        {
            var viewModel = new GetProductByIdViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };
           
           return Task.FromResult(viewModel);


            //Get product from repository
        }
    }
}