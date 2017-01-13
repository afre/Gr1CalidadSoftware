﻿using MvcMusicStore.Domain.Interfaces.Validation;

namespace MvcMusicStore.Domain.Entities.Specifications.OrderSpecs
{
    public class OrderLastNameLengthMustBeLowerThan160Spec : ISpecification<Order>
    {
        public bool IsSatisfiedBy(Order order)
        {
            return order.LastName.Length <= 160;
        }
    }
}
