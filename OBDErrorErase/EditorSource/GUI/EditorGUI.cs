﻿using System;
using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.GUI
{
    public class EditorGUI
    {
        // listen to GUI events
        // dispatch app events
        internal void OnCurrentProfileChanged(Profile currentProfile)
        {
            // create relevant view 
            throw new NotImplementedException();
        }

        internal void OnCurrentBinaryFileChanged(string path)
        {
            throw new NotImplementedException();
        }

        internal void SetProfileEditorGUI(IProfileEditorGUI profileEditorGUI)
        {
            throw new NotImplementedException();
        }
    }
}