using MediatR;
using ApplicationsServices.Wrappers;
using ApplicationsServices.Interfaces;
using DomainClass.Entity;
using AutoMapper;
using DomainClass.Common;
using Ardalis.Specification;

namespace ApplicationsServices.Features.Commands.CreateCommands
{
    public class CreatePhotographerCommand : IRequest<Response<long>>
    {
        public string? Name { get; set; }

        public string? LastName { get; set; }

        public string? QualityPhoto { get; set; }

        public string? SizePhoto { get; set; }

        public long UserRol { get; set; }
        public string? Email { get; set; }


    }
    public class CreatePhotographerCommandHandler : IRequestHandler<CreatePhotographerCommand, Response<long>>
    {
        private readonly IRepository<Photographer> _repository;
        private readonly IMapper _mapper;

        public CreatePhotographerCommandHandler(IRepository<Photographer> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<long>> Handle(CreatePhotographerCommand request, CancellationToken cancellationToken)
        {
           
            var newRegister = _mapper.Map<Photographer>(request);
            var data = await _repository.AddAsync(newRegister);

            return new Response<long>(data.Id);
        }
    }
}
