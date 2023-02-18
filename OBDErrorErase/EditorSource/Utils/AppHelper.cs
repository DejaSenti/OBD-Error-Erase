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
    }
}
