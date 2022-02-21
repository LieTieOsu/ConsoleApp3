namespace Lab3;

public class LinkedList
{
    private Node _first;

    private Node _current;

    public void Add(KeyValuePair pair)
    {
        while (_current == null)
        {
            _current = new Node(pair);
            _first = _current;
        }
        _current.Next = new Node(pair);
        _current = _current.Next;
        
    }
    public void RemoveByKey(string key)
    {
        var current = _first;
        while (current.Next != null)
        {
            if (current.Next.Pair.Key == key)
            {
                current.Next = current.Next.Next;
            }
            current = current.Next;
        }
    }
    public KeyValuePair GetItemWithKey(string key)
    {
        var current = _first;
        while (current != null)
        {
            if (current.Pair.Key == key)
            {
                return current.Pair;
            }
            current = current.Next;
        }

        return null;
    }
}

public class KeyValuePair
{
    public string Key { get; }

    public string Value { get; }

    public KeyValuePair(string key, string value)
    {
        Key = key;
        Value = value;
    }
}
public class Node
{
    public KeyValuePair Pair { get; }

    public Node Next { get; set; }

    public Node(KeyValuePair pair, Node next = null)
    {
        Pair = pair;
        Next = next;
    }
}