namespace GenericListApp.Data
{
    using System;
    using System.Linq;
    using System.Text;

    public class GenericList<T>
    {
        private T[] _items;
        private int _count = 0;
        private const int DefaultCapacity = 16;
        private int _capacity;

        public GenericList()
        {
            Capacity = DefaultCapacity;
            _items = new T[Capacity];
        }

        public GenericList(int capacity)
        {
            Capacity = capacity;
            _items = new T[Capacity];
        }

        public int Count => _count;

        public int Capacity
        {
            get { return _capacity; }
            protected set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Capacity should be at least 1!");
                }

                _capacity = value;
            }
        }

        public void Add(T item)
        {
            if (_count == _items.Length)
            {
                Grow();
            }

            _items[_count] = item;
            _count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || _count < index)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), $"Index should be in range [0..{Count}]!");
                }

                var result = _items[index];

                return result;
            }
        }

        public void Remove(int index)
        {
            if (index < 0 || _count < index)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"Index should be in range [0..{Count}!");
            }

            for (var i = 0; i < _count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _count--;
        }

        public void Insert(T item, int index)
        {
            if (_count == _items.Length)
            {
                Grow();
            }
            for (var i = _count; i >= index + 1; i++)
            {
                _items[i] = _items[i - 1];
            }

            _items[index] = item;
            _count++;
        }

        public void Clear()
        {
            _items = new T[16];
            _count = 0;
        }

        public int Find(T item)
        {
            var find = Array.IndexOf(_items, item);

            return find;
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public T Min()
        {
            switch (_count)
            {
                case 0:
                    throw new ArgumentException("Generi list does not have any values!");
                case 1:
                    return _items[_count];
                default:
                    var orderedArray = from min in _items
                                       orderby min ascending
                                       select min;
                    return orderedArray.First();
            }
        }

        public T Max()
        {
            switch (_count)
            {
                case 0:
                    throw new ArgumentException("Generi list does not have any values!");
                case 1:
                    return _items[_count];
                default:
                    var orderedArray = from min in _items
                                       orderby min descending
                                       select min;
                    return orderedArray.First();
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (var i = 0; i < _count; i++)
            {
                result.AppendLine(_items[i].ToString());
            }

            return result.ToString();
        }

        private void Grow()
        {
            var tmp = new T[_items.Length * 2];
            Array.Copy(_items, 0, tmp, 0, _items.Length);
            _items = tmp;

            Capacity *= 2;
        }
    }
}
