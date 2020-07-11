using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Core.Events
{

    public abstract class Message : IRequest<bool> // returns bool, ,we can make if of any type, in our case is bool
    {
       
        public string MessageType { get; protected set; }
        public Message()
        {
            // MessageType is a property
            // GetType Get object
            MessageType = GetType().Name;

        }
    }
}
