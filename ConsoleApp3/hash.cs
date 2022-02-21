namespace Lab3;

public class StringsDictionary
{
    private const int InitialSize = 1000;

    private LinkedList[] _buckets = new LinkedList[InitialSize];

    public void Add(string key, string value)
    {
        var bucketss = CalculateHash(key) % _buckets.Length;
        while (_buckets[bucketss] == null)
        {
            _buckets[bucketss] = new LinkedList();
        }
        _buckets[bucketss].Add( new KeyValuePair(key, value));
    }

    public void Remove(string key)
    {
        var bucket = CalculateHash(key) % _buckets.Length;
        while (_buckets[bucket] != null)
        {
            _buckets[bucket].RemoveByKey(key);
        }
    }

    public string Get(string key)
    {
        var bucketss = CalculateHash(key) % _buckets.Length;
        while (_buckets[bucketss] != null)
        {
            var input = _buckets[bucketss].GetItemWithKey(key);
            if (input == null)
                throw new Exception("Dictionary doesn't have description for this word!!!");
            return input.Value;
        }
        
        return null;
    }


    private int CalculateHash(string key)
    {
        var newArray = key.ToCharArray();
        var hash = 0;
        for (int i = 0; i < newArray.Length; i++)
        {
            hash += newArray[i]^3;
        }

        hash %= 666;
        return hash + 19;
    }
}