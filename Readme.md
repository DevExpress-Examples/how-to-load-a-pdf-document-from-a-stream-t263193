<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/LoadPDFDocument/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/LoadPDFDocument/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/LoadPDFDocument/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/LoadPDFDocument/MainWindow.xaml))
<!-- default file list end -->
# How to: Load a PDF Document from a Stream 


<p>This example shows how to load a document from the <strong>Stream</strong> using the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfDocumentViewerDocumentViewerControl_DocumentSourcetopic">DocumentViewerControl.DocumentSource</a> property. The stream is obtained from the assembly resources:</p>


```cs
Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
```


<br>
<p>Note the input stream will not be closed until the control uses the loaded document (<a href="https://documentation.devexpress.com/WPF/DevExpressXpfPdfViewerPdfViewerControl_DetachStreamOnLoadCompletetopic.aspx">PdfViewerControl.DetachStreamOnLoadComplete</a> is set to <strong>false</strong> by default). This allows the PDF Viewer to render a large PDF file quickly.</p>
<p><br>See also:<br><a href="https://documentation.devexpress.com/#WPF/CustomDocument114332">Loading a Document</a></p>


<h3>Description</h3>

To do this:<br />- Add the <strong>Demo.pdf</strong> file to the application assembly as an embedded resource.<br />- Get a <strong>Stream</strong> object representing this file.<br />&nbsp;- Assign this stream object to the <a href="http://larix/ReferenceBrowserMain_15_1/LoadItem.aspx?Member=P%3aDevExpress.Xpf.DocumentViewer.DocumentViewerControl.DocumentSource&amp;Template=MemberPropertyTopic">DocumentViewerControl.DocumentSource</a> property.<br /><br />Note that when you load a document, the input stream will not be closed before the control finishes using a document (<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPdfViewerPdfViewerControl_DetachStreamOnLoadCompletetopic">PdfViewerControl.DetachStreamOnLoadComplete&nbsp;</a> is set to <strong>false</strong> by default). This allows the PDF Viewer to render a large PDF quickly.

<br/>


