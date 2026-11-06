public class CustomList<T>
{
    private int _resizeSize = 4;
    private T[] _items = new T[4];
    public int Count { get; private set; }

    public void Add(T item)
    {
        if (Count == _items.Length)
        {
            T[] tempItems = _items;
            _items = new T[_items.Length + _resizeSize];
            for (int i = 0; i < tempItems.Length; i++)
            {
                _items[i] = tempItems[i];
            }
        }

        _items[Count] = item;
        Count++;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= Count)
                throw new ArgumentException(nameof(index));
            return _items[index];
        }
    }
}
