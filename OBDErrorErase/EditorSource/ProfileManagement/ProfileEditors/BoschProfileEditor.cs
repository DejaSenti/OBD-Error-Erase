using OBDErrorErase.EditorSource.AppControl;

namespace OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors
{
    internal class BoschProfileEditor : IProfileEditorController
    {
        private BoschProfileEditorGUI gui;
        private ProfileManager profileManager;

        public BoschProfileEditor()
        {
            profileManager = ServiceContainer.GetService<ProfileManager>();
        }

        public void SetGUI(IProfileEditorGUI profileEditorGUI)
        {
            gui = (BoschProfileEditorGUI)profileEditorGUI;

            PopulateFields();
        }

        private void PopulateFields() // todo call this when a new profile is loaded
        {
            // remove listeners?
            gui.Clear();

            var subprofile = profileManager.CurrentSubProfile;
            if (subprofile == null)
                return;

            foreach (var map in subprofile.Maps)
            {
                gui.AddMap(map);
                // add listeners?
            }
        }

        public void Dispose()
        {
            // remove listeners
            gui.Clear();
            gui.Dispose();
        }
    }
}