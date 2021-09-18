// -----------------------------------------------------------------------
// 
//      Solution=PdfReader
//      Project=PdfReader
//      File=Form1.cs
//      Created=18-09-2021, 13:05
//      Modified=18-09-2021, 14:35
//      Author: Bob Noordam
//      Copyright (c) De Roode Roos Holding BV. All rights reserved.
// 
// -----------------------------------------------------------------------
using System;
using System.Windows.Forms;
using DevExpress.XtraPdfViewer;

namespace PdfReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonLoad_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog() {
                Filter = @"pdf (*.pdf)|*.pdf"
            };
            if (dlg.ShowDialog() != DialogResult.OK) {
                return;
            }
            DocumentLoadService loader = new DocumentLoadService(pdfViewer1);
            loader.Load(dlg.FileName);
            this.Text = dlg.FileName;
        }

        private void buttonPrint_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(pdfViewer1.DocumentFilePath)) {
                return;
            }
            pdfViewer1.Print();
        }

        private void buttonSaveAs_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(pdfViewer1.DocumentFilePath)) {
                return;
            }
            SaveFileDialog dlg = new SaveFileDialog() {
                Filter = @"pdf (*.pdf)|*.pdf",
                FileName = pdfViewer1.DocumentFilePath
            };
            if (dlg.ShowDialog() != DialogResult.OK) {
                return;
            }
            pdfViewer1.SaveDocument(dlg.FileName);
        }

        private void buttonZoomPage_Click(object sender, EventArgs e) {
            pdfViewer1.ZoomMode = PdfZoomMode.PageLevel;
        }

        private void buttonZoomPageWidth_Click(object sender, EventArgs e) {
            pdfViewer1.ZoomMode = PdfZoomMode.ActualSize;
        }

        private void Form1_Shown(object sender, EventArgs e) {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length == 2) {
                DocumentLoadService loader = new DocumentLoadService(pdfViewer1);
                loader.Load(args[1]);
                this.Text = args[1];
            }
        }
    }
}