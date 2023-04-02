using System.Collections;
using System.Security.Cryptography;

namespace CustomList.Collections;

public class MyList<T>:IEnumerable<T>
{
    public int Count { get; private set; }
    private int _capacity;
    public int Capacity 
    {
        get => _capacity;
        set
        {
            if (value < Count)
            {
                throw new ArgumentOutOfRangeException("capacity was less than the current size.");
            }
            _capacity = value;
            Array.Resize(ref array, _capacity);
        }
    }
    private T[] array;
    public MyList()
    {
        Count = 0;
        _capacity = 0;
        array = new T[_capacity];
    }
    public T this[int index] { 
        get
        {
            if (index >= Count) 
            { 
                throw new ArgumentOutOfRangeException(); 
            }
            return array[index];
        } 
        set
        {
            if (index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            array[index] = value;
        } 
    }

    public void Add(T obj)
    {
        if (_capacity == 0)
        {
            _capacity = 4;
            Array.Resize(ref array, _capacity);
        }
        if (_capacity == Count)
        {
            _capacity *= 2;
            Array.Resize(ref array, _capacity);
        }
        array[Count]=obj;
        Count++;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return array[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(T obj)
    {
        for (int i = 0; i < Count; i++)
        {
            if (obj.Equals(array[i]))
            {
                return true;
            }
        }
        return false;
    }

    public T? Find(Predicate<T> predicate)
    {
        for (int i = 0; i < Count; i++)
        {
            if (predicate(array[i]))
            {
                return array[i];
            }
        }
        return default;
    }
   
    public  bool CustomExist(Predicate<T> predicate)
    {
        for (int i = 0; i < Count; i++)
        {
            if (predicate(array[i]))
            {
                return true;
            }
        }
        return false;
    }
    public bool CustomRemove(T obj)
    {
        for (int i = 0; i < Count; i++)
        {
            if (obj.Equals(array[i]))
            {
                array[i] = default;
                break;
            }
        }
        return false;
    }
    public void CustomAddRange(IEnumerable<T> values)
    {
        foreach (var item in values)
        {
            Add(item);
        }
    }
    public void CustomClear()
    {
        for (int i = 0; i < Count; i++)
        {
            array[i] = default;
            Count = 0;

        }
    }
    public void CustomReverse()
    {
        int StartIndex = 0;
        int EndIndex = Count;
        T temp;
        while (StartIndex<EndIndex)
        {
            temp = array[StartIndex];
            array[StartIndex] = array[EndIndex];
            array[EndIndex]= temp;
            StartIndex++;
            EndIndex--;
        }
    }

 

}

