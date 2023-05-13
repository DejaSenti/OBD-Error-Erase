using OBDErrorErase.EditorSource.AppControl;
using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.Processors;
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

        private void OnWidthChangeRequest(int mapIndex, string width)
        {
            ChangeBoschMapParameter(BoschMapParameter.WIDTH, width, mapIndex);
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
                    int dtcValueSize = gui.GetMapValueSize(MapBosch.MASK);

                    if (profileManager.CurrentSubProfile == null || dtcValueSize < 1)
                        return;

                    int dtcLocation = gui.GetMapLocation(MapBosch.DTC);
                    int maskLocation = gui.GetMapLocation(MapBosch.MASK);

                    if (dtcLocation == -1 || maskLocation == -1)
                    {
                        gui.TextBoxMapLength.Text = string.Empty;
                        return;
                    }

                    var length = Math.Abs(maskLocation - dtcLocation);

                    ChangeBoschMapParameter(BoschMapParameter.LENGTH, length, 0);
                    gui.TextBoxMapLength.Text = (length * 2 / dtcValueSize).ToString();
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

            gui.RemoveMap(mapIndex);
        }

        private void PopulateFields()
        {
            gui.Clear();

            var subprofile = profileManager.CurrentSubProfile;
            if (profileManager.CurrentProfile == null || subprofile == null)
                return;

            foreach (MapBosch map in subprofile.Maps.Cast<MapBosch>())
            {
                gui.AddMap(map);
            }

            var lengthAlgo = ((BoschErrorProcessor)profileManager.CurrentProfile.Processor).LengthAlgorithm;
            gui.ComboBoxMapLengthAlgorithm.SelectedItem = lengthAlgo;

            switch (lengthAlgo)
            {
                case BoschLengthAlgorithm.BMW:
                    int maskValueSize = gui.GetMapValueSize(MapBosch.MASK);

                    int dtcLocation = profileManager.CurrentSubProfile.GetMapLocation(MapBosch.DTC);
                    int maskLocation = profileManager.CurrentSubProfile.GetMapLocation(MapBosch.MASK);

                    if (dtcLocation == -1 || maskLocation == -1)
                    {
                        gui.TextBoxMapLength.Text = string.Empty;
                        return;
                    }

                    var length = Math.Abs(maskLocation - dtcLocation);

                    gui.TextBoxMapLength.Text = (length * 2 / maskValueSize).ToString();
                    break;
                case BoschLengthAlgorithm.MANUAL:
                default:
                    break;
            }

            gui.TextBoxMapLength.Text = subprofile.MapLength.ToString();
        }

        private void ChangeBoschMapParameter(BoschMapParameter parameter, object value, int mapIndex)
        {
            if (profileManager.CurrentSubProfile == null)
                return;

            if (profileManager.CurrentSubProfile.Maps[mapIndex] is not MapBosch map)
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
                    if (file != null)
                        map.SetSearchWord(map.RawLocation, file);
                    break;

                case BoschMapParameter.NEW_VALUE:
                    string newValue = ValidateHexValueFitsBitWidth((string)value, map.RawWidth);
                    map.NewValue.Clear();
                    map.NewValue.AddRange(Convert.FromHexString(newValue));
                    if (map.Name.ToLower() == MapBosch.MASK.ToLower())
                        TryLengthCalculation();
                    gui.SetNewValueField(mapIndex, newValue);
                    break;

                case BoschMapParameter.LENGTH:
                    profileManager.CurrentSubProfile.MapLength = (int)value;
                    break;

                case BoschMapParameter.WIDTH:
                    map.RawWidth = (string)value;
                    map.NewValue.Clear();
                    gui.SetNewValueField(mapIndex, string.Empty);
                    break;
                default:
                    return;
            }
        }

        private static string ValidateHexValueFitsBitWidth(string value, string rawWidth)
        {
            int width;
            try
            {
                width = Convert.ToInt32(rawWidth);
            }
            catch
            {
                return string.Empty;
            }

            var length = width / 4;

            if (string.IsNullOrEmpty(value))
            {
                value = "0";
            }

            if (value.Length < length)
            {
                value = value.PadRight(length, value[^1]);
            }
            else if (value.Length > length) 
            {
                value = value[..length];
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