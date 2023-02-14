namespace OBDErrorErase.EditorSource.Utils
{
    public class UniqueNameContainer
    {
        private readonly string baseName;
        private readonly string nameFormat;

        private List<string> takenNames;

        public UniqueNameContainer(string baseName, string nameFormat = "{0}_{1}")
        {
            this.baseName = baseName;
            this.nameFormat = nameFormat;

            takenNames = new List<string>();
        }

        public string GetValidDefault()
        {
            return GetValid(baseName);
        }

        public string GetValid(string desiredName)
        {
            desiredName = GetValidInternal(desiredName);
            takenNames.Add(desiredName);
            return desiredName;
        }

        private string GetValidInternal(string desiredName)
        {
            if (!takenNames.Contains(desiredName))
            {
                return desiredName;
            }

            string newDesiredName;

            var nameNumber = SplitNameNumber(desiredName, out var rawName);

            for (int i = 0; i < nameNumber; i++)
            {
                newDesiredName = rawName + i;

                if (!takenNames.Contains(newDesiredName))
                    return newDesiredName;
            }

            newDesiredName = rawName + (nameNumber + 1);
            return newDesiredName;
        }

        public void ReleaseName(string name)
        {
            takenNames.Remove(name);
        }

        private int SplitNameNumber(string desiredName, out string rawName)
        {
            var startIndex = desiredName.IndexOf(@"(\d+)$");
            var numberStr = desiredName.Substring(startIndex);
            rawName = desiredName.Substring(startIndex, desiredName.Length - startIndex);
            return numberStr.Length > 0 ? int.Parse(numberStr) : 0;
        }
    }
}