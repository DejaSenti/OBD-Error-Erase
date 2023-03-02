using OBDErrorErase.EditorSource.AppControl;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.Utils;
using OBDErrorErase.EditorSource.FileManagement;

namespace OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors
{
    internal partial class DelphiProfileEditorController : IProfileEditorController
    {
        public event Action? AddressChangedEvent;

        private DelphiProfileEditorGUI gui;
        private ProfileManager profileManager;

        public DelphiProfileEditorController()
        {
            profileManager = ServiceContainer.GetService<ProfileManager>();
        }

        public void SetGUI(IProfileEditorGUI profileEditorGUI)
        {
            gui = (DelphiProfileEditorGUI)profileEditorGUI;

            PopulateFields();

            AddListeners();
        }

        private void AddListeners()
        {
            gui.RequestAddressChangeEvent += OnAddressChangeRequested;
            gui.RequestErrorColumnChangeEvent += OnErrorColumnChangeRequested;
            gui.RequestLengthChangeEvent += OnLengthChangeRequested;
            gui.RequestNewValueChangeEvent += OnNewValueChangeRequested;
        }

#region Event Listeners

        private void OnNewValueChangeRequested(string newValue)
        {
            if (!AppHelper.IsHex(newValue))
                return;

            ChangeDelphiMapParameter(DelphiMapParameter.NEW_VALUE, newValue);
        }

        private void OnLengthChangeRequested(string length)
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

            ChangeDelphiMapParameter(DelphiMapParameter.LENGTH, value);
        }

        private void OnErrorColumnChangeRequested(string errorColumn)
        {
            int value;
            try
            {
                value = Convert.ToInt32(errorColumn);
            }
            catch
            {
                return;
            }

            ChangeDelphiMapParameter(DelphiMapParameter.ERROR_COLUMN, value);
        }

        private void OnAddressChangeRequested(string address)
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

            ChangeDelphiMapParameter(DelphiMapParameter.ADDRESS, value);

            AddressChangedEvent?.Invoke();
        }

        private void ChangeDelphiMapParameter(DelphiMapParameter parameter, object value)
        {
            if (profileManager.CurrentSubProfile == null)
                return;

            var map = profileManager.CurrentSubProfile.Maps.FirstOrDefault() as MapDelphi;

            if (map == null)
                return;

            switch (parameter)
            {
                case DelphiMapParameter.ADDRESS:
                    map.RawLocation = (int)value;
                    var binaryFileManager = ServiceContainer.GetService<BinaryFileManager>();
                    var file = binaryFileManager.CurrentFile;
                    if (file == null)
                        return;
                    map.SetSearchWord(map.RawLocation, file);
                    break;
                case DelphiMapParameter.ERROR_COLUMN:
                    map.ErrorColumn = (int)value;
                    break;
                case DelphiMapParameter.LENGTH:
                    profileManager.CurrentSubProfile.MapLength = (int)value;
                    break;
                case DelphiMapParameter.NEW_VALUE:
                    map.NewValue.Clear();
                    map.NewValue.AddRange(Convert.FromHexString((string)value));
                    break;
                default:
                    return;
            }

            profileManager.SaveCurrentProfile();
        }

#endregion

        private void RemoveListeners()
        {
            gui.RequestAddressChangeEvent -= OnAddressChangeRequested;
            gui.RequestErrorColumnChangeEvent -= OnErrorColumnChangeRequested;
            gui.RequestLengthChangeEvent -= OnLengthChangeRequested;
            gui.RequestNewValueChangeEvent -= OnNewValueChangeRequested;
        }

        public void OnCurrentSubprofileChanged()
        {
            PopulateFields();
        }

        private void PopulateFields()
        {
            gui.Clear();

            var subprofile = profileManager.CurrentSubProfile;
            if (subprofile == null || subprofile.Maps.Count == 0)
                return;

            MapDelphi? map = subprofile.Maps.FirstOrDefault() as MapDelphi;

            if (map == null) 
                return;

            string newValue = Convert.ToHexString(map.NewValue.ToArray());

            gui.SetFields(map.RawLocation, map.ErrorColumn.ToString(), subprofile.MapLength, newValue);
        }

        public void Dispose()
        {
            RemoveListeners();
            gui.Dispose();
        }
    }
}