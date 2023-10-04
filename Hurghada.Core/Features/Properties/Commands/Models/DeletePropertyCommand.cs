﻿using Hurghada.Core.Bases;
using MediatR;

namespace Hurghada.Core.Features.Properties.Commands.Models
{
    public class DeletePropertyCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public DeletePropertyCommand(int id)
        {
            Id = id;
        }
    }
}
