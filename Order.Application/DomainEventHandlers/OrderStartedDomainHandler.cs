using MediatR;
using Order.Application.Repository;
using Order.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.DomainEventHandlers
{
    public class OrderStartedDomainHandler : INotificationHandler<OrderStartedDomainEvent>
    {
        private readonly IBuyerRepository buyerRepository;
        public Task Handle(OrderStartedDomainEvent notification, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(notification.Order?.UserName))
            {
                //buyerRepository.Add(new Buyer(notification.UserName))
            }

            return Task.CompletedTask;
        }
    }
}
