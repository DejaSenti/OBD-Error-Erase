namespace OBDErrorErase.EditorSource.Maps
{
    [Serializable]
    public class MapBosch : BaseProfileMap
    {
        private string newValue;
        public string NewValue { get => newValue; set { newValue = value; isDirty = true; } }

        public MapBosch(string newValue)
        {
            NewValue = newValue;
        }
    }
}