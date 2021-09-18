namespace PdfReader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonZoomPage = new System.Windows.Forms.Button();
            this.buttonZoomPageWidth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.flowLayoutPanel2);
            this.tablePanel1.Controls.Add(this.flowLayoutPanel1);
            this.tablePanel1.Controls.Add(this.pdfViewer1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 64F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Size = new System.Drawing.Size(615, 744);
            this.tablePanel1.TabIndex = 0;
            // 
            // pdfViewer1
            // 
            this.tablePanel1.SetColumn(this.pdfViewer1, 0);
            this.tablePanel1.SetColumnSpan(this.pdfViewer1, 2);
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.Location = new System.Drawing.Point(3, 67);
            this.pdfViewer1.Name = "pdfViewer1";
            this.tablePanel1.SetRow(this.pdfViewer1, 1);
            this.pdfViewer1.Size = new System.Drawing.Size(610, 674);
            this.pdfViewer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.tablePanel1.SetColumn(this.flowLayoutPanel1, 0);
            this.flowLayoutPanel1.Controls.Add(this.buttonLoad);
            this.flowLayoutPanel1.Controls.Add(this.buttonSaveAs);
            this.flowLayoutPanel1.Controls.Add(this.buttonZoomPage);
            this.flowLayoutPanel1.Controls.Add(this.buttonZoomPageWidth);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tablePanel1.SetRow(this.flowLayoutPanel1, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(302, 58);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.tablePanel1.SetColumn(this.flowLayoutPanel2, 1);
            this.flowLayoutPanel2.Controls.Add(this.buttonClose);
            this.flowLayoutPanel2.Controls.Add(this.buttonPrint);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(311, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.tablePanel1.SetRow(this.flowLayoutPanel2, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(302, 58);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.Image = global::PdfReader.Properties.Resources.mo_cancel_48px;
            this.buttonClose.Location = new System.Drawing.Point(245, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(54, 54);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Image = global::PdfReader.Properties.Resources.mo_print_48px;
            this.buttonPrint.Location = new System.Drawing.Point(185, 3);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(54, 54);
            this.buttonPrint.TabIndex = 0;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Image = global::PdfReader.Properties.Resources.mo_document_48px;
            this.buttonLoad.Location = new System.Drawing.Point(3, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(54, 54);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Image = global::PdfReader.Properties.Resources.mo_save_48px;
            this.buttonSaveAs.Location = new System.Drawing.Point(63, 3);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(54, 54);
            this.buttonSaveAs.TabIndex = 1;
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // buttonZoomPage
            // 
            this.buttonZoomPage.Image = global::PdfReader.Properties.Resources.mo_zoom_out_48px;
            this.buttonZoomPage.Location = new System.Drawing.Point(123, 3);
            this.buttonZoomPage.Name = "buttonZoomPage";
            this.buttonZoomPage.Size = new System.Drawing.Size(54, 54);
            this.buttonZoomPage.TabIndex = 2;
            this.buttonZoomPage.UseVisualStyleBackColor = true;
            this.buttonZoomPage.Click += new System.EventHandler(this.buttonZoomPage_Click);
            // 
            // buttonZoomPageWidth
            // 
            this.buttonZoomPageWidth.Image = global::PdfReader.Properties.Resources.mo_zoom_in_48px;
            this.buttonZoomPageWidth.Location = new System.Drawing.Point(183, 3);
            this.buttonZoomPageWidth.Name = "buttonZoomPageWidth";
            this.buttonZoomPageWidth.Size = new System.Drawing.Size(54, 54);
            this.buttonZoomPageWidth.TabIndex = 3;
            this.buttonZoomPageWidth.UseVisualStyleBackColor = true;
            this.buttonZoomPageWidth.Click += new System.EventHandler(this.buttonZoomPageWidth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 744);
            this.Controls.Add(this.tablePanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PdfReader";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonZoomPage;
        private System.Windows.Forms.Button buttonZoomPageWidth;
    }
}

