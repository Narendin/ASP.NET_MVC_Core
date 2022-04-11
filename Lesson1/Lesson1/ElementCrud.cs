using System.Collections.Generic;

namespace Lesson1;

internal class ElementCrud<T> : List<T> where T : class
{
    private readonly object _lock = new();

    public new void Add(T item)
    {
        lock (_lock)
            base.Add(item);
    }

    public new void Clear()
    {
        lock (_lock)
            base.Clear();
    }

    public new bool Remove(T item)
    {
        lock (_lock)
            return base.Remove(item);
    }
}