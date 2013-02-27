﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BalanceSharp.Clients
{
    public interface IEventClient
    {
    }

    public class EventClient : IEventClient
    {
        IBalancedService balanceService;

        public EventClient(IBalancedService balanceService)
        {
            this.balanceService = balanceService;
        }
    }
}