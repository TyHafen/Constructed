using System;

namespace Constructed.Interface
{
    public interface IRepoItem<T>
    {
        public T Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}