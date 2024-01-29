using Domain.Common.Events;

namespace Domain.Common.Contracts;

public interface IEntity
{
    List<DomainEvent> DomainEvents { get; }
}

public interface IEntity<TId> : IEntity
{
    public TId Id { get; set; }
}