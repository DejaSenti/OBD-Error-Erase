using System.Text.RegularExpressions;

namespace OBDErrorErase.EditorSource.Utils
{
    public class UniqueNameContainer
    {
        private readonly string baseName;
        private readonly string suffixFormat;

        private List<string> takenNames;

        public UniqueNameContainer(string baseName, string suffixFormat = "_{1}")
        {
            this.baseName = baseName;
            this.suffixFormat = suffixFormat;

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

        public void ReleaseName(string name)
        {
            takenNames.Remove(name);
        }

        private string GetValidInternal(string desiredName)
        {
            if (!takenNames.Contains(desiredName))
            {
                return desiredName;
            }

            string newDesiredName;

            var rawName = GetWithoutSuffix(desiredName);

            var nameNumber = 0;

            do
            {
                newDesiredName = GetFormatted(rawName, nameNumber);
                nameNumber++;
            }
            while (takenNames.Contains(newDesiredName));

            return newDesiredName;
        }

        private string GetFormatted(string desiredName, int desiredNameNumber)
        {
            return desiredNameNumber == 0 ? desiredName : desiredName + desiredNameNumber;
        }

        private string GetWithoutSuffix(string s)
        {
            var match = Regex.Match(s, @".*\d+$");
            return match.Success ? match.Value : s;
        }
    }
}