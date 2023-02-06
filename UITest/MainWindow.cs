using System;
using System.Windows.Forms;

namespace UITest

{
    public partial class MainWindow : Form
    {
        private EditorController editorController;
        private EditorGUI editorGUI;

        public MainWindow()
        {
            InitializeServices();
            InitializeComponent();

            editorGUI = new EditorGUI();
            editorController = new EditorController(editorGUI);
        }

        private void InitializeServices()
        {
            ServiceContainer.AddService(new ProfileManager());
            ServiceContainer.AddService(new BinaryFileManager());
        }
    }
}

