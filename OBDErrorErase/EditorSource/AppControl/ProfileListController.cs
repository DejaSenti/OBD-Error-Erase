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


            UpdateProfilesList(profileList);
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