using Lab3;



while (true)
{
    var dictionary = new StringsDictionary();
    foreach (var line in File.ReadAllLines(@"D:\Tanki Suka\dictionary.txt"))
    {
        var index = line.IndexOf(';');
        dictionary.Add(line.Substring(0, index), line.Substring(index + 1));

    }

    var input = Console.ReadLine().ToUpper();
    Console.WriteLine(dictionary.Get(input));
    Console.WriteLine("Continue: Yes|No");
    var input2 = Console.ReadLine().ToUpper();
    if (input2 == "NO")
    {
        break;
    }

}