using System.Collections.Generic;

namespace Constructed.Interface
{
    public interface IRepo<T, Tid>
    {
        List<T> GetAll();
        T GetViewModelById(Tid id);
        T Create(T data);
        T Update(T data, Tid id, string userId);

    }
}