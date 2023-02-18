using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    [Serializable]
    public class DirtyList<T> : List<T>, IDirty
    {
        [JsonIgnore]
        public bool IsDirty { get; private set; }

        public DirtyList() { }

        public DirtyList(IEnumerable<T> list) 
        {
            AddRange(list);
        }

        public void ClearDirty(bool deep = true)
        {
            IsDirty = false;
        }

        public new void Add(T item)
        {
            base.Add(item);
            IsDirty = true;
        }

        public new void Remove(T item)
        {
            base.Remove(item);
            IsDirty = true;
        }

        public new void RemoveAt(int index)
        {
            base.RemoveAt(index);
            IsDirty = true;
        }

        public new void AddRange(IEnumerable<T> items)
        {
            base.AddRange(items);
            IsDirty = true;
        }

        public new void RemoveAll(Predicate<T> match)
        {
            base.RemoveAll(match);
            IsDirty = true;
        }

        public new void RemoveRange(int index, int count)
        {
            base.RemoveRange(index, count);
            IsDirty = true;
        }

        public new void Insert(int index, T item)
        {
            base.Insert(index, item);
            IsDirty = true;
        }

        public new void InsertRange(int index, IEnumerable<T> items)
        {
            base.InsertRange(index, items);
            IsDirty = true;
        }

        public new void Clear()
        {
            base.Clear();
            IsDirty = true;
        }
    }
}