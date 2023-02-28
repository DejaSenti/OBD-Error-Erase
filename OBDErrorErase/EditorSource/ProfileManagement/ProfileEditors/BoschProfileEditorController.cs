using OBDErrorErase.EditorSource.AppControl;
using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;

namespace OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors
{
    internal class BoschProfileEditorController : IProfileEditorController
    {
        private BoschProfileEditorGUI gui;
        private ProfileManager profileManager;

        public BoschProfileEditorController()
        {
            profileManager = ServiceContainer.GetService<ProfileManager>();
        }

        public void SetGUI(IProfileEditorGUI profileEditorGUI)
        {
            gui = (BoschProfileEditorGUI)profileEditorGUI;

            PopulateFields();

            AddListeners();
        }

        private void AddListeners()
        {
            gui.RequestAddMap += OnAddMapRequested;
            gui.RequestMapRemoveEvent += OnRemoveMapRequested;
            gui.RequestContentChangeEvent += OnContentChangeRequested;
        }

        private void RemoveListeners()
        {
            gui.RequestAddMap -= OnAddMapRequested;
            gui.RequestMapRemoveEvent -= OnRemoveMapRequested;
            gui.RequestContentChangeEvent -= OnContentChangeRequested;
        }

        private void OnAddMapRequested()
        {
            if (profileManager.CurrentProfile == null)
                return;

            var map = new MapBosch();

            profileManager.CurrentProfile.AddNewMap(map);

            gui.AddMap(map);
        }

        private void OnRemoveMapRequested(int mapIndex)
        {
            var profile = profileManager.CurrentProfile;
            if (profile == null)
                return;

            if (profile.Subprofiles[0].Maps[mapIndex].Name == MapBosch.ERROR_LIST)
                return;

            profile.RemoveMap(mapIndex);

            gui.RemoveMapRow(mapIndex);
        }
        
        private void OnContentChangeRequested(int index, BoschMapEditorContent newMapData)
        {
            if (profileManager.CurrentSubProfile == null)
                return;

            var map = profileManager.CurrentSubProfile.Maps[index] as MapBosch;

            if (map == null) 
                return;

            if (newMapData.Name != MapBosch.ERROR_LIST)
            {
                map.Name = newMapData.Name;
            }

            var binaryFileManager = ServiceContainer.GetService<BinaryFileManager>();
            var file = binaryFileManager.CurrentFile;

            if (file != null)
            {
                var location = Convert.ToInt32(newMapData.Address);

                var searchWord = map.CreateSearchWord(location, file);

                if (searchWord != map.SearchWord)
                {
                    map.SetSearchWord(searchWord);
                }
            }

            // new value: fits width ? overwrite : match width and overwrite
            var width = 2 ^ (newMapData.Width + 1);
            if (width > newMapData.NewValue.Length)
            {
                newMapData.NewValue = newMapData.NewValue.PadRight(width, newMapData.NewValue[newMapData.NewValue.Length - 1]);
            }
            else if (width < newMapData.NewValue.Length)
            {
                newMapData.NewValue = newMapData.NewValue.Substring(0, width);
            }

            var newValue = Convert.FromHexString(newMapData.NewValue).ToList();

            if (map.NewValue != newValue)
            {
                map.NewValue.Clear();
                map.NewValue.AddRange(newValue);
            }
        } 

        private void PopulateFields() // todo call this when a new profile is loaded
        {
            gui.ClearControl();

            var subprofile = profileManager.CurrentSubProfile;
            if (subprofile == null)
                return;

            foreach (MapBosch map in subprofile.Maps)
            {
                gui.AddMap(map);
            }
        }

        public void Dispose()
        {
            RemoveListeners();
            gui.Dispose();
        }
    }
}