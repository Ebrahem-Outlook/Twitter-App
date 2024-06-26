﻿using MediatR;

namespace Application.Core.Abstraction.Messaging;

/// <summary>
/// Represents the command interface.
/// </summary>
/// <typeparam name="TResponse">The command response type.</typeparam>
internal interface ICommand<out TResponse> : IRequest<TResponse>;


