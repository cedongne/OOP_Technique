using System.Collections;

static class Program
{
    static void Main()
    {
        Hashtable hashtable = new Hashtable();
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        int keyInt = 40;
        int valueInt = 4;

        string keyString = "Hello, ";
        string valueString = "World!";

        hashtable.Add(keyInt, valueInt);
        hashtable.Add(keyString, valueString);

        dictionary.Add(keyInt, valueInt);
        dictionary.Add(keyInt, 13);
        //        dictionary.Add(keyString, valueString);

        foreach (DictionaryEntry pair in hashtable) { 
            Console.WriteLine(pair.Key + "" + pair.Value);
        }

        foreach (KeyValuePair<int, int> pair in dictionary)
        {
            Console.WriteLine(pair.Key + "" + pair.Value);
        }
    }
};