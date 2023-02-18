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

            PopulateErrorPresets();

            AddGUIListeners();
        }

        private void AddGUIListeners()
        {
            eraserGUI.PresetOpenClicked += OnPresetOpenClicked;
            eraserGUI.PresetDeleteClicked += OnPresetDeleteClicked;
            eraserGUI.PresetListRefreshClicked += PopulateErrorPresets;
            eraserGUI.RunClicked += OnErrorEraseRequested;
        }

        private void PopulateErrorPresets()
        {
            var errorPresetFiles = AppFileHelper.GetAllFilesInAppSubFolder(AppFolderNames.PRESETS, AppFileExtension.txt);

            presetNames = errorPresetFiles.Select(fileInfo => Path.GetFileNameWithoutExtension(fileInfo.Name)).ToList();
            eraserGUI.PopulateErrorPresetList(presetNames);
        }

        private void OnPresetDeleteClicked(int id)
        {
            AppFileHelper.RemoveFile(AppFolderNames.PRESETS, presetNames[id], AppFileExtension.txt);
        }

        private void OnPresetOpenClicked(int id)
        {
            var process = new Process();

            process.StartInfo = new ProcessStartInfo(AppFileHelper.GetFilePath(AppFolderNames.PRESETS, presetNames[id], AppFileExtension.txt))
            {
                UseShellExecute = true
            };
            process.Start();
        }

        public void OnProfileSelected(string id)
        {
            var newProfile = profileManager.LoadProfile(id);

            if (newProfile == null)
                return;

            profileManager.SetCurrentProfile(newProfile);

            UpdateSubprofile();
        }

        public void OnBinaryFileLoadRequested(string path)
        {
            var file = binaryFileManager.LoadBinaryFile(path);

            if (file == null)
                return;

            binaryFileManager.SetCurrentFile(file);
            eraserGUI.OnCurrentBinaryFileChanged(path);

            UpdateSubprofile();
        }

        private void UpdateSubprofile()
        {
            SubprofileData? subprofile = null;

            if (binaryFileManager.CurrentFile == null || profileManager.CurrentProfile == null)
                return;

            subprofile = profileManager.CurrentProfile.GetMatchingSubprofile(binaryFileManager.CurrentFile);

            if (subprofile == null)
            {
                // TODO notify preview about no match

                return;
            }
			
            profileManager.CurrentProfile.SetSubprofile(subprofile);
			
            // TODO notify preview about match
        }

        public void OnErrorEraseRequested()
        {
            var errorList = GetErrorList();

            if (!IsErasingValid() || errorList.Count == 0)
            {
                // notify GUI about lack of needed pieces to start process
                return;
            }

            int totalErased = profileManager.CurrentProfile.Process(binaryFileManager.CurrentFile, errorList);

            // notify GUI about total erased and error list count
            // save new file
        }

        private bool IsErasingValid()
        {
            return binaryFileManager.CurrentFile != null &&
                profileManager.CurrentProfile != null && profileManager.CurrentProfile.CurrentSubprofile != null;
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

        private void RemoveGUIListeners() 
        {
            throw new NotImplementedException();
        }
    }
}