class Programs
{
    public static void Main()
    {
        ArrayList arrayList = new ArrayList(10);
        LinkedList<int> ints = new LinkedList<int>();
        int x = 100000;
        int y = 1000;
        zapovnennya(x, arrayList, ints);
        dostyp(x, arrayList, ints);
        vstavkastart(y,x, arrayList, ints);
        vstavkaend(y,x, arrayList, ints);
        vstavkacenter(y,x, arrayList, ints);
    }
    public static void zapovnennya(int x, ArrayList arrayList, LinkedList<int> ints)
    {
        Random r = new Random();
        var sw = new Stopwatch();
        var sw1 = new Stopwatch();
        Console.WriteLine("\nЗаповнення списків");
        sw.Start();
        for (int i = 0; i < x; i++)
        {
            arrayList.Add(r.Next(1,x));
        }
        sw.Stop();
        Console.WriteLine(sw.Elapsed.ToString());

        sw1.Start();
        for (int i = 0; i < x; i++)
        {
            ints.AddLast(r.Next(1,x));
        }
        sw1.Stop();
        Console.WriteLine(sw1.Elapsed.ToString());
    }
    public static void dostyp(int x, ArrayList arrayList, LinkedList<int> ints)
    {
        var arrayListindex = new Stopwatch();
        var arrayListiteration = new Stopwatch();
        var linkedListiterator=new Stopwatch();
        Random r = new Random();
        Console.WriteLine("\nДоступ за індексом");
        arrayListindex.Start();
        Console.WriteLine( arrayList[r.Next(0, x)]);
        arrayListindex.Stop();
        Console.WriteLine("ArrayList: " + arrayListindex.Elapsed.ToString());
        Console.WriteLine("LinkedList: неможливий доступ за індексом");
        Console.WriteLine("\nДоступ за ітератером");
        arrayListiteration.Start();
        foreach (int i in arrayList){}
        arrayListiteration.Stop();
        Console.WriteLine("ArrayList: " + arrayListiteration.Elapsed.ToString());
        linkedListiterator.Start();
        foreach (int i in ints){}
        linkedListiterator.Stop();
        Console.WriteLine("LinkedList: " + linkedListiterator.Elapsed.ToString());
    }
    public static void vstavkastart(int y, int x, ArrayList arrayList, LinkedList<int> ints)
    {
        var arrayListstart = new Stopwatch();
        var intsstart = new Stopwatch();
        Random r = new Random();
        Console.WriteLine("\nВставка в начало");
        arrayListstart.Start();
        for (int i = 0; i < y; i++)
        {
            arrayList.Insert(0, r.Next(1, x));
        }
        arrayListstart.Stop();
        Console.WriteLine("ArrayList: " + arrayListstart.Elapsed.ToString());
        intsstart.Start();
        for (int i = 0;i < y; i++)
        {
            ints.AddFirst(r.Next(1, x));
        }
        intsstart.Stop();
        Console.WriteLine("LinkedList: " + intsstart.Elapsed.ToString());
    }
    public static void vstavkacenter(int y, int x, ArrayList arrayList, LinkedList<int> ints)
    {
        var arrayListcenter = new Stopwatch();
        var intscenter = new Stopwatch();
        Random r = new Random();
        Console.WriteLine("\nВставка в середину");
        int centrearrayList = arrayList.Count / 2;
        int centerlinkedList = ints.Count/2;
        arrayListcenter.Start();
        for (int i = 0; i < y; i++)
        {
            arrayList.Insert(centrearrayList, r.Next(1, x));
        }
        arrayListcenter.Stop();
        Console.WriteLine("ArrayList: " + arrayListcenter.Elapsed.ToString());
        int h = 0;
        int ds=0;
        foreach (int item in ints)
        {
            if (h== centerlinkedList)
            {
                ds=item;
            }
            h++;
        }
        LinkedListNode<int> node = ints.Find(ds);
        intscenter.Start();
        for (int i = 0; i < y; i++)
        {
            ints.AddAfter(node, r.Next(1, x));
        }
        intscenter.Stop();
        Console.WriteLine("LinkedList: " + intscenter.Elapsed.ToString());
    }
    public static void vstavkaend(int y, int x, ArrayList arrayList, LinkedList<int> ints)
    {
        var arrayListend = new Stopwatch();
        var intsend = new Stopwatch();
        Random r = new Random();
        Console.WriteLine("\nВставка в кінець");
        arrayListend.Start();
        for (int i = 0; i < y; i++)
        {
            arrayList.Add(r.Next(1, x));
        }
        arrayListend.Stop();
        Console.WriteLine("ArrayList: " + arrayListend.Elapsed.ToString());
        intsend.Start();
        for (int i = 0; i < y; i++)
        {
            ints.AddLast(r.Next(1, x));
        }
        intsend.Stop();
        Console.WriteLine("LinkedList: " + intsend.Elapsed.ToString());
    }
}
