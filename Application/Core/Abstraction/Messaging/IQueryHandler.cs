using MediatR;

namespace Application.Core.Abstraction.Messaging;

/// <summary>
/// Represent the query handler interface.
/// </summary>
/// <typeparam name="TQuery">The query request.</typeparam>
/// <typeparam name="TResponse">The query response.</typeparam>
internal interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, TResponse> 
    where TQuery : IQuery<TResponse>;
