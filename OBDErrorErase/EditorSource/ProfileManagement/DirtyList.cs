namespace OBDErrorErase.EditorSource.ProfileManagement
{
    public class DirtyList<T> : List<T>, IDirty
    {
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

        public new void Clear()
        {
            base.Clear();
            IsDirty = true;
        }
    }
}