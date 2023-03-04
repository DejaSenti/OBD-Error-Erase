using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.GUI;
using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.Utils;
using System.Diagnostics;

namespace OBDErrorErase.EditorSource.AppControl
{

    public class EraserController
    {
        readonly char[] ERROR_DELIMITERS = new char[]{ ',', '.', ' ', '\n', '\r' };
        private EraserGUI eraserGUI;

        private ProfileManager profileManager;
        private BinaryFileManager binaryFileManager;
        private List<string> presetNames;

        public EraserController(EraserGUI eraserGUI)
        {
            this.eraserGUI = eraserGUI;
            profileManager = ServiceContainer.GetService<ProfileManager>();
            binaryFileManager = ServiceContainer.GetService<BinaryFileManager>();

            RefreshPresetList();

            if (profileManager.CurrentSubProfile != null)
            {
                eraserGUI.PopulateMapList(profileManager.CurrentSubProfile.GetMapNameList());
            }

            AddGUIListeners();
        }

        private void AddGUIListeners()
        {
            eraserGUI.PresetOpenClicked += OnPresetOpenClicked;
            eraserGUI.PresetDeleteRequested += OnPresetDeleteRequested;
            eraserGUI.PresetListRefreshClicked += RefreshPresetList;

            eraserGUI.RunClicked += OnErrorEraseRequested;
        }

        private void RefreshPresetList()
        {
            var errorPresetFiles = AppFileHelper.GetAllFilesInAppSubFolder(AppFolderNames.PRESETS, AppFileExtension.txt);

            presetNames = errorPresetFiles.Select(fileInfo => Path.GetFileNameWithoutExtension(fileInfo.Name)).ToList();
            eraserGUI.PopulateErrorPresetList(presetNames);
        }

        private void OnPresetDeleteRequested(int id)
        {
            AppFileHelper.RemoveFile(AppFolderNames.PRESETS, presetNames[id], AppFileExtension.txt);
        }

        private void OnPresetOpenClicked(int id)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo(AppFileHelper.GetFilePath(AppFolderNames.PRESETS, presetNames[id], AppFileExtension.txt))
                {
                    UseShellExecute = true
                }
            };
            process.Start();
        }

        public void OnErrorEraseRequested()
        {
            var errorList = GetErrorList();

            if (errorList.Count == 0 || 
                binaryFileManager.CurrentFile == null ||
                profileManager.CurrentProfile == null || 
                profileManager.CurrentSubProfile == null)
            {
                eraserGUI.OnInvalidErasingAttempt();
                return;
            }

            var mapIndices = eraserGUI.GetMapIndices();

            int totalErased = profileManager.CurrentProfile.Process(binaryFileManager.CurrentFile, errorList, profileManager.CurrentSubProfileIndex, mapIndices);

            eraserGUI.OnProcessComplete(totalErased, errorList.Count);

            binaryFileManager.SaveBinaryFile();
        }

        private List<string> GetErrorList()
        {
            var result = new List<string>();

            var textboxErrorList = eraserGUI.GetTextboxErrorList();
            AddErrorsFromStringToList(textboxErrorList, result);

            var presetIDs = eraserGUI.GetSelectedPresetIDs();
            var selectedPresets = presetNames.GetElementsAtIndexes(presetIDs);

            foreach(var preset in selectedPresets)
            {
                var fileContents = AppFileHelper.LoadStringFile(AppFolderNames.PRESETS, preset, AppFileExtension.txt);
                AddErrorsFromStringToList(fileContents, result);
            }
            
            result = result.Distinct().ToList();

            return result;
        }

        private void AddErrorsFromStringToList(string errors, List<string> list)
        {
            var splitErrors = errors.Split(ERROR_DELIMITERS, StringSplitOptions.RemoveEmptyEntries);
            list.AddRange(splitErrors);
        }

        internal void OnNewProfileLoaded()
        {
            if (profileManager.CurrentSubProfile == null)
                return;

            eraserGUI.PopulateMapList(profileManager.CurrentSubProfile.GetMapNameList());

            eraserGUI.UpdateMapSelectorStatus(IsMultimapProfileType());
        }

        private bool IsMultimapProfileType()
        {
            var profile = profileManager.CurrentProfile;

            if (profile == null)
                return false;

            return profile.Type switch
            {
                ProfileType.BOSCH => true,
                ProfileType.DELPHI => false,
                _ => false
            };
        }

        internal void OnProfileUnloaded()
        {
            eraserGUI.SetEraseButtonEnabled(false);
            eraserGUI.ClearMapControls();
        }

        internal void OnEraseAvailable()
        {
            eraserGUI.SetEraseButtonEnabled(true);
        }
    }
}