using OBDErrorErase.EditorSource.AppControl;
using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.Utils;

namespace OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors
{
    internal partial class BoschProfileEditorController : IProfileEditorController
    {
        public event Action? AddressChangedEvent;

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
            gui.RequestLengthChangeEvent += OnChangeMapLengthRequested;
            gui.RequestChangeLengthAlgorithm += OnChangeLengthAlgorithmRequested;

            gui.RequestAddressChangeEvent += OnAddressChangeRequest;
            gui.RequestMapNameChangeEvent += OnMapNameChangeRequest;
            gui.RequestNewValueChangeEvent += OnNewValueChangeRequest;
            gui.RequestWidthChangeEvent += OnWidthChangeRequest;
        }

        private void RemoveListeners()
        {
            gui.RequestAddMap -= OnAddMapRequested;
            gui.RequestMapRemoveEvent -= OnRemoveMapRequested;
            gui.RequestLengthChangeEvent -= OnChangeMapLengthRequested;
            gui.RequestChangeLengthAlgorithm -= OnChangeLengthAlgorithmRequested;

            gui.RequestAddressChangeEvent -= OnAddressChangeRequest;
            gui.RequestMapNameChangeEvent -= OnMapNameChangeRequest;
            gui.RequestNewValueChangeEvent -= OnNewValueChangeRequest;
            gui.RequestWidthChangeEvent -= OnWidthChangeRequest;
        }

        private void OnWidthChangeRequest(int mapIndex, int widthIndex)
        {
            ChangeBoschMapParameter(BoschMapParameter.WIDTH, widthIndex, mapIndex);
        }

        private void OnNewValueChangeRequest(int mapIndex, string newValue)
        {
            if (!AppHelper.IsHex(newValue))
                return;

            ChangeBoschMapParameter(BoschMapParameter.NEW_VALUE, newValue, mapIndex);
        }

        private void OnMapNameChangeRequest(int mapIndex, string mapName)
        {
            ChangeBoschMapParameter(BoschMapParameter.NAME, mapName, mapIndex);
            TryLengthCalculation();
        }

        private void OnAddressChangeRequest(int mapIndex, string address)
        {
            if (!AppHelper.IsHex(address))
                return;

            int value;
            try
            {
                value = Convert.ToInt32(address, 16);
            }
            catch
            {
                return;
            }

            ChangeBoschMapParameter(BoschMapParameter.ADDRESS, value, mapIndex);
            TryLengthCalculation();

            if (mapIndex == 0)
            {
                AddressChangedEvent?.Invoke();
            }
        }

        private void OnChangeMapLengthRequested(string length)
        {
            int value;
            try
            {
                value = Convert.ToInt32(length);
            }
            catch
            {
                return;
            }

            ChangeBoschMapParameter(BoschMapParameter.LENGTH, value, 0);
        }

        private void OnChangeLengthAlgorithmRequested()
        {
            TryLengthCalculation();
        }

        private void TryLengthCalculation()
        {
            BoschLengthAlgorithm algorithm = gui.GetLengthAlgorithm();

            switch (algorithm)
            {
                case BoschLengthAlgorithm.MANUAL:
                    break;
                case BoschLengthAlgorithm.BMW:
                    if (profileManager.CurrentSubProfile == null)
                        return;

                    int dtcLocation = gui.GetMapLocation(MapBosch.DTC);
                    int classLocation = gui.GetMapLocation(MapBosch.CLASS);

                    if (dtcLocation == -1 || classLocation == -1)
                    {
                        gui.TextBoxMapLength.Text = string.Empty;
                        return;
                    }

                    var length = Math.Abs(classLocation - dtcLocation);

                    ChangeBoschMapParameter(BoschMapParameter.LENGTH, length, 0);
                    gui.TextBoxMapLength.Text = length.ToString();
                    break;
                default:
                    return;
            }
        }

        private void OnAddMapRequested()
        {
            if (profileManager.CurrentProfile == null)
                return;

            var map = new MapBosch();

            profileManager.CurrentProfile.AddNewMap(map);

            profileManager.SaveCurrentProfile();

            gui.AddMap(map);
        }

        private void OnRemoveMapRequested(int mapIndex)
        {
            var profile = profileManager.CurrentProfile;
            if (profile == null)
                return;

            if (profile.Subprofiles[0].Maps[mapIndex].Name == MapBosch.DTC)
                return;

            profile.RemoveMap(mapIndex);

            profileManager.SaveCurrentProfile();

            gui.RemoveMap(mapIndex);
        }

        private void PopulateFields()
        {
            gui.Clear();

            var subprofile = profileManager.CurrentSubProfile;
            if (subprofile == null)
                return;

            foreach (MapBosch map in subprofile.Maps)
            {
                gui.AddMap(map);
            }

            gui.TextBoxMapLength.Text = subprofile.MapLength.ToString();
        }

        private void ChangeBoschMapParameter(BoschMapParameter parameter, object value, int mapIndex)
        {
            if (profileManager.CurrentSubProfile == null)
                return;

            var map = profileManager.CurrentSubProfile.Maps[mapIndex] as MapBosch;

            if (map == null)
                return;

            switch (parameter)
            {
                case BoschMapParameter.NAME:
                    map.Name = (string)value;
                    break;

                case BoschMapParameter.ADDRESS:
                    map.RawLocation = (int)value;
                    var binaryFileManager = ServiceContainer.GetService<BinaryFileManager>();
                    var file = binaryFileManager.CurrentFile;
                    if (file == null)
                        break;
                    map.SetSearchWord(map.RawLocation, file);
                    break;

                case BoschMapParameter.NEW_VALUE:
                    string newValue = ValidateNewValue((string)value, map.RawWidth);
                    map.NewValue.Clear();
                    map.NewValue.AddRange(Convert.FromHexString(newValue));
                    gui.SetNewValueField(mapIndex, newValue);
                    break;

                case BoschMapParameter.LENGTH:
                    profileManager.CurrentSubProfile.MapLength = (int)value;
                    break;

                case BoschMapParameter.WIDTH:
                    map.RawWidth = (int)value;
                    map.NewValue.Clear();
                    gui.SetNewValueField(mapIndex, string.Empty);
                    break;
                default:
                    return;
            }

            profileManager.SaveCurrentProfile();
        }

        private string ValidateNewValue(string value, int rawWidth)
        {
            var length = (int)Math.Pow(2, rawWidth + 1);

            if (string.IsNullOrEmpty(value))
            {
                value = "0";
            }

            if (value.Length < length)
            {
                value = value.PadRight(length, value[value.Length - 1]);
            }
            else if (value.Length > length) 
            {
                value = value.Substring(0, length);
            }

            return value;
        }

        public void OnCurrentSubprofileChanged()
        {
            PopulateFields();
        }

        public void Dispose()
        {
            RemoveListeners();
            gui.Dispose();
        }
    }
}