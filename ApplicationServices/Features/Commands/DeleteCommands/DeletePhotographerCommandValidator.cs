﻿using FluentValidation;

namespace ApplicationsServices.Features.Commands.DeleteCommands
{
    public class DeletePhotographerCommandValidator : AbstractValidator<DeletePhotographerCommand>
    {
        public DeletePhotographerCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull();
        }
    }
}
