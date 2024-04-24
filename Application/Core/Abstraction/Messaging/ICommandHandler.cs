using MediatR;

namespace Application.Core.Abstraction.Messaging;

/// <summary>
/// Represents the command handler interface.
/// </summary>
/// <typeparam name="TCommand">The command request.</typeparam>
/// <typeparam name="TResponse">The command response</typeparam>
internal interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>;


