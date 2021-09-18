// -----------------------------------------------------------------------
// 
//      Solution=PdfReader
//      Project=PdfReader
//      File=DocumentLoadService.cs
//      Created=18-09-2021, 14:33
//      Modified=18-09-2021, 14:36
//      Author: Bob Noordam
//      Copyright (c) De Roode Roos Holding BV. All rights reserved.
// 
// -----------------------------------------------------------------------
using DevExpress.XtraPdfViewer;

namespace PdfReader {
    internal class DocumentLoadService {
        private readonly PdfViewer _pdfViewer;

        public DocumentLoadService(PdfViewer viewer) {
            _pdfViewer = viewer;
        }

        public void Load(string fileHandle) {
            _pdfViewer.LoadDocument(fileHandle);
            _pdfViewer.NavigationPaneVisibility = PdfNavigationPaneVisibility.Hidden;
            _pdfViewer.ZoomMode = PdfZoomMode.PageLevel;
        }
    }
}