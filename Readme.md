<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/LoadPDFDocument/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/LoadPDFDocument/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/LoadPDFDocument/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/LoadPDFDocument/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Load a PDF Document from a Stream 


<p>This example demonstrates how to use the <a href="https://docs.devexpress.com/WPF/DevExpress.Xpf.DocumentViewer.DocumentViewerControl.DocumentSource">DocumentViewerControl.DocumentSource</a> property to load a document from a stream. The stream is obtained from the assembly resources:</p>

```cs
Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
```

<br>
<p>Note that the input stream remains open while the control uses the loaded document (<a href="https://docs.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfViewerControl.DetachStreamOnLoadComplete">PdfViewerControl.DetachStreamOnLoadComplete</a> is <strong>false</strong> by default). This allows the PDF Viewer to render large PDF files faster.</p>

<p><br>See also:<br><a href="https://docs.devexpress.com/WPF/114458/controls-and-libraries/pdf-viewer/examples/file-operations/how-to-load-a-pdf-document-from-a-stream">Load a PDF Document from a Stream</a></p>
