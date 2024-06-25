<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128658636/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T263193)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-load-a-pdf-document-from-a-stream-t263193&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-load-a-pdf-document-from-a-stream-t263193&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
