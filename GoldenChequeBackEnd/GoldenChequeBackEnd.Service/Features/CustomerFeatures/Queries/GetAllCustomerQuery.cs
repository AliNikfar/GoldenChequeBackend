using GoldenChequeBackEnd.Domain.Entities;
using GoldenChequeBackEnd.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GoldenChequeBackEnd.Service.Features.CustomerFeatures.Queries
{
    public class GetAllCustomerQuery : IRequest<IEnumerable<Customer>>
    {

        public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, IEnumerable<Customer>>
        {
            //private readonly IApplicationDbContext _context;
            //public GetAllCustomerQueryHandler(IApplicationDbContext context)
            //{
            //    _context = context;
            //}
            //public async Task<IEnumerable<Customer>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
            //{
            //    var customerList = await _context.Customers.ToListAsync();
            //    if (customerList == null)
            //    {
            //        return null;
            //    }
            //    return customerList.AsReadOnly();
            //}
            public Task<IEnumerable<Customer>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
