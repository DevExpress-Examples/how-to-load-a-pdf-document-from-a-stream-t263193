Imports System.IO
Imports System.Reflection
Imports System.Windows

Namespace LoadPDFDocument

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim stream As Stream = GetResourceStream("LoadPDFDocument.Demo.pdf")
            Me.Viewer.DocumentSource = stream
        End Sub

        Private Shared Function GetResourceStream(ByVal resourceName As String) As Stream
            Return Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
        End Function
    End Class
End Namespace
