using System;

namespace AA.Core.Entities
{
    public interface IEntity<TKey> where TKey : IEquatable<TKey>
    {
        TKey Id { get; }
    }
}
