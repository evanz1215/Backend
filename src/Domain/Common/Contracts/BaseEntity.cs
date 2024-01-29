using Domain.Common.Events;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Common.Contracts;

public class BaseEntity<TId> : IEntity<TId>
{
    public TId Id { get; set; } = default!;

    [NotMapped]
    public List<DomainEvent> DomainEvents { get; } = new();
}