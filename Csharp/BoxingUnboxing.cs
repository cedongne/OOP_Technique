using System.Collections;

interface IAcceptance
{
    void PutObject(string objectName);
}

struct Bookshelf : IAcceptance
{
    int size;
    string bookType;
    string[] book = new string[3];

    public Bookshelf(){
        size = 0;
        bookType = "Everything";
    }

    public Bookshelf(string _bookType, string[] _book)
    {
        size = _book.Length;
        bookType = _bookType;
        for(int index = 0; index < _book.Length; index++)
        {
            book[index] = _book[index];
        }
    }

    public void PutObject(string objectName)
    {
        book[size++] = objectName;
    }
}

static class Program
{
    static void Main()
    {
        Bookshelf bookshelf = new Bookshelf("Cook", new string[] { "Korean", "Japanese" });
        IAcceptance container = bookshelf;
        container.PutObject("Chinese");

        int num = 5;
        object obj = num;
        int boxedNum = (int)obj;


        Hashtable hashtable = new Hashtable();

        int keyInt = 40;
        int valueInt = 4;

        hashtable.Add(keyInt, valueInt);

    }
};