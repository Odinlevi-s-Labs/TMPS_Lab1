using System.Collections;

namespace TMPS_Lab1
{
    public class AnimalCollection : IAnimalCollection
    {
        private ArrayList _items = new ArrayList();

        public IAnimalIterator CreateIterator()
        {
            return new AnimalIterator(this);
        }

        // Gets jelly bean count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}