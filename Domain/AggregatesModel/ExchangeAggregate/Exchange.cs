using System;
using System.Collections.Generic;
using System.Linq;
using ExchangeApi.Services.Exchange.Domain.Seedwork;

namespace ExchangeApi.Services.Exchange.Domain.AggregatesModel.ExchangeAggregate
{
public class Exchange
        : Entity, IAggregateRoot
    {
                private DateTime _orderDate;
                public Exchange(){
                    _orderDate = DateTime.UtcNow;
                }
    }
}