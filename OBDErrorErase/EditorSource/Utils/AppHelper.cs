using System.Text.RegularExpressions;

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

        public static void RunIfEnterKey(Keys keyCode, Action method)
        {
            if (keyCode == Keys.Enter || keyCode == Keys.Return)
                method.Invoke();
        }

        public delegate bool Validation(char ch);

        public static void EnforceValidations(List<TextBox> textboxes, List<Validation> validations)
        {
            foreach (var textbox in textboxes)
            {
                textbox.KeyPress += (sender, e) => 
                {
                    bool handled = true;

                    foreach (var action in validations)
                    {
                        if (action(e.KeyChar)) 
                            handled = false; 
                    }

                    e.Handled = handled;
                };
            }
        }

        public static bool IsHex(string input)
        {
            return Regex.IsMatch(input, @"\A\b[0-9a-fA-F]+\b\Z");
        }
    }
}
