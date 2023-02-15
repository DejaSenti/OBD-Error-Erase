using System.Text.RegularExpressions;

namespace OBDErrorErase.EditorSource.Utils
{
    public class UniqueNameContainer
    {
        private readonly string baseName;
        private readonly string numberSuffixFormat;

        private List<string> takenNames;

        public UniqueNameContainer(string baseName, string suffixFormat = "_{0}")
        {
            this.baseName = baseName;
            this.numberSuffixFormat = suffixFormat;

            takenNames = new List<string>();
        }

        public string TakeNextValidDefault()
        {
            return TakeNextValid(baseName);
        }

        public string TakeNextValid(string desiredName)
        {
            desiredName = GetValidInternal(desiredName);
            takenNames.Add(desiredName);
            return desiredName;
        }

        public void TakeNames(params string[] names)
        {
            foreach (var name in names)
            {
                if (takenNames.Contains(name))
                    throw new Exception($"Cannot take name {name} as it is already taken");

                takenNames.Add(name);
            }
        }

        public void ReleaseNames(params string[] names)
        {
            foreach (var name in names)
                takenNames.Remove(name);
        }

        private string GetValidInternal(string desiredName)
        {
            if (!takenNames.Contains(desiredName))
                return desiredName;

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
            return desiredNameNumber == 0 ? desiredName : desiredName + string.Format(numberSuffixFormat, desiredNameNumber);
        }

        private string GetWithoutSuffix(string s)
        {
            var match = Regex.Match(s, @".*\d+$");
            return match.Success ? match.Value : s;
        }
    }
}