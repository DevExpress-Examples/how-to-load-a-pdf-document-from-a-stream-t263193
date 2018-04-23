using System.IO;
using System.Reflection;
using System.Windows;

namespace LoadPDFDocument {

    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
            Stream stream = GetResourceStream("LoadPDFDocument.Demo.pdf");           
            Viewer.DocumentSource = stream;
        }
        static Stream GetResourceStream(string resourceName) {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
        }
    }
}
