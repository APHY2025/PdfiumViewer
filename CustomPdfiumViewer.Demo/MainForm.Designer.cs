using System;
using System.Collections.Generic;
using System.Text;

namespace CustomPdfiumViewer.Demo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            printMultiplePagesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripSeparator();
            renderToBitmapsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            cutMarginsWhenPrintingToolStripMenuItem = new ToolStripMenuItem();
            shrinkToMarginsWhenPrintingToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            deleteCurrentPageToolStripMenuItem = new ToolStripMenuItem();
            rotateCurrentPageToolStripMenuItem = new ToolStripMenuItem();
            rotate0ToolStripMenuItem = new ToolStripMenuItem();
            rotate90ToolStripMenuItem = new ToolStripMenuItem();
            rotate180ToolStripMenuItem = new ToolStripMenuItem();
            rotate270ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            showRangeOfPagesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripSeparator();
            informationToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            _page = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            _zoom = new ToolStripTextBox();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            _fitWidth = new ToolStripButton();
            _fitHeight = new ToolStripButton();
            _fitBest = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            _rotateLeft = new ToolStripButton();
            _rotateRight = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            _showToolbar = new ToolStripButton();
            _showBookmarks = new ToolStripButton();
            _getTextFromPage = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            _pageToolStripLabel = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            _coordinatesToolStripLabel = new ToolStripStatusLabel();
            pdfViewer = new PdfViewer();
            btnZoomBottomRight = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1022, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripMenuItem1, printPreviewToolStripMenuItem, printMultiplePagesToolStripMenuItem, toolStripMenuItem3, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(180, 22);
            printPreviewToolStripMenuItem.Text = "Print Preview";
            printPreviewToolStripMenuItem.Click += printPreviewToolStripMenuItem_Click;
            // 
            // printMultiplePagesToolStripMenuItem
            // 
            printMultiplePagesToolStripMenuItem.Name = "printMultiplePagesToolStripMenuItem";
            printMultiplePagesToolStripMenuItem.Size = new Size(180, 22);
            printMultiplePagesToolStripMenuItem.Text = "Print Multiple Pages";
            printMultiplePagesToolStripMenuItem.Click += printMultiplePagesToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findToolStripMenuItem, toolStripMenuItem7, renderToBitmapsToolStripMenuItem, toolStripMenuItem2, cutMarginsWhenPrintingToolStripMenuItem, shrinkToMarginsWhenPrintingToolStripMenuItem, toolStripMenuItem4, deleteCurrentPageToolStripMenuItem, rotateCurrentPageToolStripMenuItem, toolStripMenuItem5, showRangeOfPagesToolStripMenuItem, toolStripMenuItem6, informationToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            findToolStripMenuItem.Size = new Size(243, 22);
            findToolStripMenuItem.Text = "&Find";
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(240, 6);
            // 
            // renderToBitmapsToolStripMenuItem
            // 
            renderToBitmapsToolStripMenuItem.Name = "renderToBitmapsToolStripMenuItem";
            renderToBitmapsToolStripMenuItem.Size = new Size(243, 22);
            renderToBitmapsToolStripMenuItem.Text = "&Render to Bitmaps";
            renderToBitmapsToolStripMenuItem.Click += renderToBitmapsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(240, 6);
            // 
            // cutMarginsWhenPrintingToolStripMenuItem
            // 
            cutMarginsWhenPrintingToolStripMenuItem.Name = "cutMarginsWhenPrintingToolStripMenuItem";
            cutMarginsWhenPrintingToolStripMenuItem.Size = new Size(243, 22);
            cutMarginsWhenPrintingToolStripMenuItem.Text = "Cut margins when printing";
            cutMarginsWhenPrintingToolStripMenuItem.Click += cutMarginsWhenPrintingToolStripMenuItem_Click;
            // 
            // shrinkToMarginsWhenPrintingToolStripMenuItem
            // 
            shrinkToMarginsWhenPrintingToolStripMenuItem.Name = "shrinkToMarginsWhenPrintingToolStripMenuItem";
            shrinkToMarginsWhenPrintingToolStripMenuItem.Size = new Size(243, 22);
            shrinkToMarginsWhenPrintingToolStripMenuItem.Text = "Shrink to margins when printing";
            shrinkToMarginsWhenPrintingToolStripMenuItem.Click += shrinkToMarginsWhenPrintingToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(240, 6);
            // 
            // deleteCurrentPageToolStripMenuItem
            // 
            deleteCurrentPageToolStripMenuItem.Name = "deleteCurrentPageToolStripMenuItem";
            deleteCurrentPageToolStripMenuItem.Size = new Size(243, 22);
            deleteCurrentPageToolStripMenuItem.Text = "Delete Current Page";
            deleteCurrentPageToolStripMenuItem.Click += deleteCurrentPageToolStripMenuItem_Click;
            // 
            // rotateCurrentPageToolStripMenuItem
            // 
            rotateCurrentPageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rotate0ToolStripMenuItem, rotate90ToolStripMenuItem, rotate180ToolStripMenuItem, rotate270ToolStripMenuItem });
            rotateCurrentPageToolStripMenuItem.Name = "rotateCurrentPageToolStripMenuItem";
            rotateCurrentPageToolStripMenuItem.Size = new Size(243, 22);
            rotateCurrentPageToolStripMenuItem.Text = "Rotate Current Page";
            // 
            // rotate0ToolStripMenuItem
            // 
            rotate0ToolStripMenuItem.Name = "rotate0ToolStripMenuItem";
            rotate0ToolStripMenuItem.Size = new Size(134, 22);
            rotate0ToolStripMenuItem.Text = "Rotate 0°";
            rotate0ToolStripMenuItem.Click += rotate0ToolStripMenuItem_Click;
            // 
            // rotate90ToolStripMenuItem
            // 
            rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem";
            rotate90ToolStripMenuItem.Size = new Size(134, 22);
            rotate90ToolStripMenuItem.Text = "Rotate 90°";
            rotate90ToolStripMenuItem.Click += rotate90ToolStripMenuItem_Click;
            // 
            // rotate180ToolStripMenuItem
            // 
            rotate180ToolStripMenuItem.Name = "rotate180ToolStripMenuItem";
            rotate180ToolStripMenuItem.Size = new Size(134, 22);
            rotate180ToolStripMenuItem.Text = "Rotate 180°";
            rotate180ToolStripMenuItem.Click += rotate180ToolStripMenuItem_Click;
            // 
            // rotate270ToolStripMenuItem
            // 
            rotate270ToolStripMenuItem.Name = "rotate270ToolStripMenuItem";
            rotate270ToolStripMenuItem.Size = new Size(134, 22);
            rotate270ToolStripMenuItem.Text = "Rotate 270°";
            rotate270ToolStripMenuItem.Click += rotate270ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(240, 6);
            // 
            // showRangeOfPagesToolStripMenuItem
            // 
            showRangeOfPagesToolStripMenuItem.Name = "showRangeOfPagesToolStripMenuItem";
            showRangeOfPagesToolStripMenuItem.Size = new Size(243, 22);
            showRangeOfPagesToolStripMenuItem.Text = "Show range of pages";
            showRangeOfPagesToolStripMenuItem.Click += showRangeOfPagesToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(240, 6);
            // 
            // informationToolStripMenuItem
            // 
            informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            informationToolStripMenuItem.Size = new Size(243, 22);
            informationToolStripMenuItem.Text = "Information";
            informationToolStripMenuItem.Click += informationToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, _page, toolStripSeparator1, toolStripButton1, toolStripButton2, toolStripSeparator2, toolStripLabel2, _zoom, toolStripSeparator7, toolStripButton4, toolStripButton3, toolStripSeparator3, _fitWidth, _fitHeight, _fitBest, toolStripSeparator5, _rotateLeft, _rotateRight, toolStripSeparator6, _showToolbar, _showBookmarks, _getTextFromPage, btnZoomBottomRight });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1022, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(36, 22);
            toolStripLabel1.Text = "Page:";
            // 
            // _page
            // 
            _page.Name = "_page";
            _page.Size = new Size(100, 25);
            _page.KeyDown += _page_KeyDown;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "<";
            toolStripButton1.Click += toolStripButton1_Click_1;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = ">";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(41, 22);
            toolStripLabel2.Text = "Zoom:";
            // 
            // _zoom
            // 
            _zoom.Name = "_zoom";
            _zoom.Size = new Size(80, 25);
            _zoom.KeyDown += _zoom_KeyDown;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 25);
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 22);
            toolStripButton4.Text = "+";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "-";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // _fitWidth
            // 
            _fitWidth.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _fitWidth.Image = (Image)resources.GetObject("_fitWidth.Image");
            _fitWidth.ImageTransparentColor = Color.Magenta;
            _fitWidth.Name = "_fitWidth";
            _fitWidth.Size = new Size(59, 22);
            _fitWidth.Text = "Fit Width";
            _fitWidth.Click += _fitWidth_Click;
            // 
            // _fitHeight
            // 
            _fitHeight.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _fitHeight.Image = (Image)resources.GetObject("_fitHeight.Image");
            _fitHeight.ImageTransparentColor = Color.Magenta;
            _fitHeight.Name = "_fitHeight";
            _fitHeight.Size = new Size(63, 22);
            _fitHeight.Text = "Fit Height";
            _fitHeight.Click += _fitHeight_Click;
            // 
            // _fitBest
            // 
            _fitBest.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _fitBest.Image = (Image)resources.GetObject("_fitBest.Image");
            _fitBest.ImageTransparentColor = Color.Magenta;
            _fitBest.Name = "_fitBest";
            _fitBest.Size = new Size(49, 22);
            _fitBest.Text = "Fit Best";
            _fitBest.Click += _fitBest_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // _rotateLeft
            // 
            _rotateLeft.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _rotateLeft.Image = (Image)resources.GetObject("_rotateLeft.Image");
            _rotateLeft.ImageTransparentColor = Color.Magenta;
            _rotateLeft.Name = "_rotateLeft";
            _rotateLeft.Size = new Size(68, 22);
            _rotateLeft.Text = "Rotate Left";
            _rotateLeft.Click += _rotateLeft_Click;
            // 
            // _rotateRight
            // 
            _rotateRight.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _rotateRight.Image = (Image)resources.GetObject("_rotateRight.Image");
            _rotateRight.ImageTransparentColor = Color.Magenta;
            _rotateRight.Name = "_rotateRight";
            _rotateRight.Size = new Size(76, 22);
            _rotateRight.Text = "Rotate Right";
            _rotateRight.Click += _rotateRight_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
            // 
            // _showToolbar
            // 
            _showToolbar.CheckOnClick = true;
            _showToolbar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _showToolbar.Image = (Image)resources.GetObject("_showToolbar.Image");
            _showToolbar.ImageTransparentColor = Color.Magenta;
            _showToolbar.Name = "_showToolbar";
            _showToolbar.Size = new Size(82, 22);
            _showToolbar.Text = "Show Toolbar";
            _showToolbar.Click += _hideToolbar_Click;
            // 
            // _showBookmarks
            // 
            _showBookmarks.CheckOnClick = true;
            _showBookmarks.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _showBookmarks.Image = (Image)resources.GetObject("_showBookmarks.Image");
            _showBookmarks.ImageTransparentColor = Color.Magenta;
            _showBookmarks.Name = "_showBookmarks";
            _showBookmarks.Size = new Size(101, 22);
            _showBookmarks.Text = "Show Bookmarks";
            _showBookmarks.Click += _hideBookmarks_Click;
            // 
            // _getTextFromPage
            // 
            _getTextFromPage.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _getTextFromPage.Image = (Image)resources.GetObject("_getTextFromPage.Image");
            _getTextFromPage.ImageTransparentColor = Color.Magenta;
            _getTextFromPage.Name = "_getTextFromPage";
            _getTextFromPage.Size = new Size(53, 22);
            _getTextFromPage.Text = "Get Text";
            _getTextFromPage.ToolTipText = "Get Text From Current Page";
            _getTextFromPage.Click += _getTextFromPage_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, _pageToolStripLabel, toolStripStatusLabel2, _coordinatesToolStripLabel });
            statusStrip1.Location = new Point(0, 517);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1022, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(36, 17);
            toolStripStatusLabel1.Text = "Page:";
            // 
            // _pageToolStripLabel
            // 
            _pageToolStripLabel.Name = "_pageToolStripLabel";
            _pageToolStripLabel.Size = new Size(41, 17);
            _pageToolStripLabel.Text = "(page)";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(73, 17);
            toolStripStatusLabel2.Text = "Coordinates:";
            // 
            // _coordinatesToolStripLabel
            // 
            _coordinatesToolStripLabel.Name = "_coordinatesToolStripLabel";
            _coordinatesToolStripLabel.Size = new Size(77, 17);
            _coordinatesToolStripLabel.Text = "(coordinates)";
            // 
            // pdfViewer1
            // 
            pdfViewer.Dock = DockStyle.Fill;
            pdfViewer.Location = new Point(0, 49);
            pdfViewer.Margin = new Padding(5, 3, 5, 3);
            pdfViewer.Name = "pdfViewer1";
            pdfViewer.Size = new Size(1022, 468);
            pdfViewer.TabIndex = 0;
            // 
            // btnZoomBottomRight
            // 
            btnZoomBottomRight.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnZoomBottomRight.Image = (Image)resources.GetObject("btnZoomBottomRight.Image");
            btnZoomBottomRight.ImageTransparentColor = Color.Magenta;
            btnZoomBottomRight.Name = "btnZoomBottomRight";
            btnZoomBottomRight.Size = new Size(23, 22);
            btnZoomBottomRight.Text = "toolStripButton5";
            btnZoomBottomRight.Click += btnZoomBottomRight_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 539);
            Controls.Add(pdfViewer);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Form1";
            Shown += MainForm_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private global::CustomPdfiumViewer.PdfViewer pdfViewer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderToBitmapsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox _page;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cutMarginsWhenPrintingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shrinkToMarginsWhenPrintingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton _fitWidth;
        private System.Windows.Forms.ToolStripButton _fitHeight;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox _zoom;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton _rotateLeft;
        private System.Windows.Forms.ToolStripButton _rotateRight;
        private System.Windows.Forms.ToolStripButton _fitBest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton _showToolbar;
        private System.Windows.Forms.ToolStripButton _showBookmarks;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateCurrentPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate270ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel _pageToolStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel _coordinatesToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showRangeOfPagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton _getTextFromPage;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem printMultiplePagesToolStripMenuItem;
        private ToolStripButton btnZoomBottomRight;
    }
}

