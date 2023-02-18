using System.Text.RegularExpressions;

namespace OBDErrorErase.EditorSource.AppControl
{
    public class ProfileListController
    {
        private string[]? currentFilterWords;

        private IReadOnlyList<string> profileIDsRef;

        public string SelectedProfileID { get; set; } = "";

        private List<(ListBox profileList, TextBox filter, Action profileChangedCallback)> controlsTuples = new List<(ListBox, TextBox, Action)>();

        public ProfileListController(IReadOnlyList<string> profileIDsRef)
        {
            this.profileIDsRef = profileIDsRef;
        }

        public void SubscribeControls(TextBox filterTextField, ListBox profileList, Action profileSelectionChange)
        {
            controlsTuples.Add((profileList, filterTextField, profileSelectionChange));

            AddControlListeners(profileList, filterTextField);

            UpdateProfilesList(profileList);
        }

        private void AddControlListeners(ListBox profileList, TextBox filter)
        {
            filter.TextChanged += OnFilterTextFieldChanged;
            profileList.SelectedIndexChanged += OnSelectionChanged;
        }

        private void RemoveControlListeners(ListBox profileList, TextBox filter)
        {
            filter.TextChanged -= OnFilterTextFieldChanged;
            profileList.SelectedIndexChanged -= OnSelectionChanged;
        }

        private void OnSelectionChanged(object? sender, EventArgs e)
        {
            if (sender == null)
                return;

            ListBox list = (ListBox)sender;

            if (list.SelectedIndex == -1)
                return;

            var desiredProfileID = (string)list.Items[list.SelectedIndex];

            if (desiredProfileID == SelectedProfileID)
                return;

            SelectedProfileID = desiredProfileID;

            foreach (var kvp in controlsTuples)
            {
                kvp.profileChangedCallback();
            }
        }

        private void OnFilterTextFieldChanged(object? sender, EventArgs e)
        {
            if (sender == null) 
                return;

            TextBox textBox = (TextBox)sender;

            // change filter words
            currentFilterWords = Regex.Split(textBox.Text, @"\s+");

            // change text on all fields
            foreach (var kvp in controlsTuples)
            {
                RemoveControlListeners(kvp.profileList, kvp.filter);

                if (kvp.filter != textBox)
                {
                    kvp.filter.Text = textBox.Text;
                }

                // update all lists
                UpdateProfilesList(kvp.profileList);

                if (!string.IsNullOrEmpty(SelectedProfileID) && kvp.profileList.Items.Contains(SelectedProfileID))
                    kvp.profileList.SelectedItem = SelectedProfileID;

                AddControlListeners(kvp.profileList, kvp.filter);
            }
        }

        public void UpdateProfilesList(ListBox profileList)
        {
            profileList.Items.Clear();

            foreach (var profileID in profileIDsRef)
            {
                if (ProfileIDMatchesFilter(profileID))
                    profileList.Items.Add(profileID);
            }

            profileList.SelectedItem = SelectedProfileID;
        }

        private bool ProfileIDMatchesFilter(string profileID)
        {
            if (currentFilterWords == null || currentFilterWords.Length == 0)
                return true;

            int index = 0;
            foreach (string filterWord in currentFilterWords)
            {
                index = profileID.ToLower().IndexOf(filterWord.ToLower(), index);

                if (index == -1)
                    return false;

                index += filterWord.Length;
            }
            return true;
        }
    }
}