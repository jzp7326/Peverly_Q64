class Program
{
    public static void Main()
    {
        Tree<int> tree = new Tree<int>(1, 10);
        tree.InsertLeft(2, 0);
        tree.InsertRight(3, 0);
        tree.InsertLeft(4, 1);
        tree.InsertRight(5, 1);
        tree.InsertLeft(6, 2);
        Console.WriteLine(tree);
    }
}

class Tree<T>
{
    private readonly int _size;
    private readonly T[] _array;
    public Tree(T rootValue, int size) {
        _size = size;
        _array = new T[_size];
        _array[0] = rootValue;
    }
    public void InsertLeft(T value, int rootPosition)
    {
        int position = (rootPosition * 2) + 1;
        if (_array[rootPosition] == null)
        {
            Console.WriteLine("Can't set child at " + position + ", no parent found.");
        }
        else
        {
            _array[position] = value;
        }
    }
    public void InsertRight(T value, int rootPosition)
    {
        int position = (rootPosition * 2) + 2;
        if (_array[rootPosition] == null)
        {
            Console.WriteLine("Can't set child at " + position + ", no parent found.");
        }
        else
        {
            _array[position] = value;
        }
    }
    public override string ToString()
    {
        string s = "";
        for (int i = 0; i < _size; i++)
        {
            if (_array[i] != null)
            {
                s += _array[i]!.ToString();
            }
            else
            {
                s += "-";
            }
        }
        return s;
    }
}