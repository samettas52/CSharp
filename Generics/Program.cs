namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // class methods take their  types  from   that which type the  class has  
            List<string> cities = new List<string>();

            //count is a List property
            cities.Add(" Tekirdag 1");
            cities.Add(" Tekirdag 2");
            cities.Add(" Tekirdag 3");
            cities.Add(" Tekirdag 4");
            cities.Add(" Tekirdag 5");
            Console.WriteLine(cities.Count);
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            //we can't give a type (eg: string) when is our List is empty 
            MyList<string> cities2 = new MyList<string>();

            cities2.Add(" Tekirdag 1");
            cities2.Add(" Tekirdag 2");
            cities2.Add(" Tekirdag 3");
            cities2.Add(" Tekirdag 4");
            cities2.Add(" Tekirdag 5");
            Console.WriteLine(cities2.Count);
            //we can't write this beacuse we don't have a indexer yet
            //we need to  access  to the items of array too . 
            foreach (string city in cities2.items)
            {
                Console.WriteLine(city);
            }
        }
    }
    // "T" specifies which type the class will take.
    class MyList<T>//Generic Class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        // we created a dynamic type
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];

            }
            _array[_array.Length - 1] = item;
        }
        //we created count propertiy
        public int Count
        {
            get { return _array.Length; }
        }
        public T this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
        public T[] items
        {
            get { return _array; }
        }

    }
}
