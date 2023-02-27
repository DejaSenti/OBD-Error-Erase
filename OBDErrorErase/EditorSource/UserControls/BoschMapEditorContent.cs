namespace OBDErrorErase
{
    public struct BoschMapEditorContent
    {
        public string Name;
        public string Address;
        public int Width;
        public string NewValue;

        public BoschMapEditorContent(string name, string address, int width, string newValue)
        {
            Name = name;
            Address = address;
            Width = width;
            NewValue = newValue;
        }
    }
}
