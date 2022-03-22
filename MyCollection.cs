namespace MyClass
{
    public class MyCollection<T>
    {
        List<T> Collection = new();

        public int CollectionLength { 
            get { return Collection.Count; }
        }
        public void Add(T item) {
            Collection.Add(item);
        }

        public T GetItemByIndex(int index)
        {
            return Collection[index];  
        }
    }
}