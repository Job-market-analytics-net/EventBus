﻿global using System.Net.Sockets;
global using System.Text;
global using System.Text.Json;
global using JobMarketAnalytics.BuildingBlocks.EventBus;
global using JobMarketAnalytics.BuildingBlocks.EventBus.Abstractions;
global using JobMarketAnalytics.BuildingBlocks.EventBus.Events;
global using JobMarketAnalytics.BuildingBlocks.EventBus.Extensions;
global using Microsoft.Extensions.Logging;
global using Polly;
global using Polly.Retry;
global using RabbitMQ.Client;
global using RabbitMQ.Client.Events;
global using RabbitMQ.Client.Exceptions;
