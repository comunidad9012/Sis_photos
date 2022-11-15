using ApplicationsServices.Interfaces;
using ApplicationsServices.Wrappers;
using DomainClass.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;

namespace ApplicationsServices.Features.Commands.DeleteCommands
{
    public class DeletePhotographerCommand : IRequest<Response<long>>
    {
        public long Name { get; set; }
    }
    public class DeletePhotographerCommandHandle : IRequestHandler<DeletePhotographerCommand, Response<long>>
    {
        private readonly IRepository<Photographer> _repository;

        public DeletePhotographerCommandHandle(IRepository<Photographer> repository)
        {
            _repository = repository;
        }

        public async Task<Response<long>> Handle(DeletePhotographerCommand request, CancellationToken cancellationToken)
        {
            
            var register = await _repository.GetByIdAsync(request.Name);
            
            if (register == null)
            {
                throw new KeyNotFoundException($"No se encontro el registro con el Id: {request.Name}");
            }
            else
            {
                await _repository.DeleteAsync(register);
                return new Response<long>(register.Name);
            }



        }
    }
}
