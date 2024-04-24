using MediatR;

namespace Application.Core.Abstraction.Messaging;

/// <summary>
/// Represent the Query interface.
/// </summary>
/// <typeparam name="TResponse">The query response type.</typeparam>
internal interface IQuery<TResponse> : IRequest<TResponse>;
