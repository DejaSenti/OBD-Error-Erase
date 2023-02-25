namespace OBDErrorErase.EditorSource.Utils
{
    public static class AppHelper
    {
        public static List<T> GetElementsAtIndexes<T>(this List<T> originalList, List<int> indexes)
        {
            List<T> result = new List<T>();

            foreach (int index in indexes)
            {
                if (index >= 0 && index < originalList.Count)
                {
                    result.Add(originalList[index]);
                }
            }

            return result;
        }

        public static void PreviewFile(DataGridView view, int displayMapLocation, byte[] displayBytes)
        {
            List<(string address, string value)> rows = new List<(string, string)>();

            for (int i = 0; i < displayBytes.Length - 2; i++, displayMapLocation += 2)
            {
                rows.Add((Convert.ToString(displayMapLocation, 16), Convert.ToHexString(displayBytes[i..(i + 2)])));
            }

            view.DataSource = rows;
        }
    }
}
