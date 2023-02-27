using OBDErrorErase.EditorSource.Maps;

namespace OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors
{
    public class BoschProfileEditorGUI : IProfileEditorGUI
    {
        public event Action? RequestAddMap;
        public event Action<int>? RequestMapRemoveEvent;
        public event Action<int, BoschMapEditorContent>? RequestContentChangeEvent;

        public UserControl UserControl => control;
        private EditorBoschControl control;

        public BoschProfileEditorGUI()
        {
            control = new EditorBoschControl();

            AddGUIListeners();
        }

        private void AddGUIListeners()
        {
            control.ContentChanged += OnContentChanged;
            control.MapRemoved += OnMapRemoved;
            control.ButtonAddMap.Click += OnAddMapClick;
        }

        private void RemoveGUIListeners()
        {
            control.ContentChanged -= OnContentChanged;
            control.MapRemoved -= OnMapRemoved;
            control.ButtonAddMap.Click -= OnAddMapClick;
        }

#region Event Listeners
        private void OnAddMapClick(object? sender, EventArgs e)
        {
            RequestAddMap?.Invoke();
        }

        private void OnMapRemoved(int mapIndex)
        {
            RequestMapRemoveEvent?.Invoke(mapIndex);
        }

        private void OnContentChanged(int index, BoschMapEditorContent mapEditorContent)
        {
            RequestContentChangeEvent?.Invoke(index, mapEditorContent);
        }
        #endregion

        public void ClearControl()
        {
            control.Clear();
        }

        public void Dispose()
        {
            ClearControl();
            RemoveGUIListeners();

            control.Dispose();
        }

        internal void AddMap(MapBosch map)
        {
            control.AddRow(map.Name, Convert.ToHexString(map.NewValue.ToArray()));
        }

        internal void RemoveMapRow(int index)
        {
            control.RemoveRow(index);
        }
    }
}