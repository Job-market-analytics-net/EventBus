﻿using JobMarketAnalytics.BuildingBlocks.EventBus.Abstractions;
using System.Threading.Tasks;

namespace EventBus.Tests
{
    public class TestIntegrationOtherEventHandler : IIntegrationEventHandler<TestIntegrationEvent>
    {
        public bool Handled { get; private set; }

        public TestIntegrationOtherEventHandler()
        {
            Handled = false;
        }

        public Task Handle(TestIntegrationEvent @event)
        {
            Handled = true;
            return Task.CompletedTask;
        }
    }
}
