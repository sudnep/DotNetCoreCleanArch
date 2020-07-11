using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler // sealed class  nobody can extend or add functionality  
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            this._mediator = mediator;
        }
       
        public Task SendCommand<T> (T command) where T: Command
        {
            return _mediator.Send(command);
        }
        
    }

    
}
