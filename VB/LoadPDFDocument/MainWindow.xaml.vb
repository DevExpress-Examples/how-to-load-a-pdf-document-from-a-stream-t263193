Imports System.IO
Imports System.Reflection
Imports System.Windows

Namespace LoadPDFDocument

    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            Dim stream As Stream = GetResourceStream("LoadPDFDocument.Demo.pdf")
            Viewer.DocumentSource = stream
        End Sub
        Private Shared Function GetResourceStream(ByVal resourceName As String) As Stream
            Return System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
        End Function
    End Class
End Namespace
