namespace WeirdDocumentEditor
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
            this.docTitleTextBox = new System.Windows.Forms.TextBox();
            this.docAuthorTextBox = new System.Windows.Forms.TextBox();
            this.docTypeTextBox = new System.Windows.Forms.TextBox();
            this.docTitleLabel = new System.Windows.Forms.Label();
            this.docAuthorLabel = new System.Windows.Forms.Label();
            this.docTypeLabel = new System.Windows.Forms.Label();
            this.mainDocumentPanel = new System.Windows.Forms.Panel();
            this.sectionDocumentPanel = new System.Windows.Forms.Panel();
            this.removeSectionButton = new System.Windows.Forms.Button();
            this.sectionStaticLabel = new System.Windows.Forms.Label();
            this.paragraphDocumentPanel = new System.Windows.Forms.Panel();
            this.removeParagraphButton = new System.Windows.Forms.Button();
            this.paragraphStaticLabel = new System.Windows.Forms.Label();
            this.addParagraphButton = new System.Windows.Forms.Button();
            this.paragraphRichTextBox = new System.Windows.Forms.RichTextBox();
            this.paragraphTitleLabel = new System.Windows.Forms.Label();
            this.paragraphTitleTextBox = new System.Windows.Forms.TextBox();
            this.sectionTitleLabel = new System.Windows.Forms.Label();
            this.sectionTitleTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainDocumentPanel.SuspendLayout();
            this.sectionDocumentPanel.SuspendLayout();
            this.paragraphDocumentPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // docTitleTextBox
            // 
            this.docTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.docTitleTextBox.Location = new System.Drawing.Point(12, 37);
            this.docTitleTextBox.Name = "docTitleTextBox";
            this.docTitleTextBox.Size = new System.Drawing.Size(578, 26);
            this.docTitleTextBox.TabIndex = 0;
            this.docTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // docAuthorTextBox
            // 
            this.docAuthorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.docAuthorTextBox.Location = new System.Drawing.Point(12, 77);
            this.docAuthorTextBox.Name = "docAuthorTextBox";
            this.docAuthorTextBox.Size = new System.Drawing.Size(578, 26);
            this.docAuthorTextBox.TabIndex = 1;
            this.docAuthorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // docTypeTextBox
            // 
            this.docTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.docTypeTextBox.Location = new System.Drawing.Point(12, 116);
            this.docTypeTextBox.Name = "docTypeTextBox";
            this.docTypeTextBox.Size = new System.Drawing.Size(578, 26);
            this.docTypeTextBox.TabIndex = 2;
            this.docTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // docTitleLabel
            // 
            this.docTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.docTitleLabel.AutoSize = true;
            this.docTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.docTitleLabel.Location = new System.Drawing.Point(261, 40);
            this.docTitleLabel.Name = "docTitleLabel";
            this.docTitleLabel.Size = new System.Drawing.Size(103, 20);
            this.docTitleLabel.TabIndex = 1;
            this.docTitleLabel.Text = "docTitleLabel";
            this.docTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // docAuthorLabel
            // 
            this.docAuthorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.docAuthorLabel.AutoSize = true;
            this.docAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.docAuthorLabel.Location = new System.Drawing.Point(261, 80);
            this.docAuthorLabel.Name = "docAuthorLabel";
            this.docAuthorLabel.Size = new System.Drawing.Size(122, 20);
            this.docAuthorLabel.TabIndex = 1;
            this.docAuthorLabel.Text = "docAuthorLabel";
            this.docAuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // docTypeLabel
            // 
            this.docTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.docTypeLabel.AutoSize = true;
            this.docTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.docTypeLabel.Location = new System.Drawing.Point(261, 119);
            this.docTypeLabel.Name = "docTypeLabel";
            this.docTypeLabel.Size = new System.Drawing.Size(108, 20);
            this.docTypeLabel.TabIndex = 1;
            this.docTypeLabel.Text = "docTypeLabel";
            this.docTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainDocumentPanel
            // 
            this.mainDocumentPanel.AutoScroll = true;
            this.mainDocumentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainDocumentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainDocumentPanel.Controls.Add(this.sectionDocumentPanel);
            this.mainDocumentPanel.Location = new System.Drawing.Point(0, 155);
            this.mainDocumentPanel.Name = "mainDocumentPanel";
            this.mainDocumentPanel.Size = new System.Drawing.Size(602, 572);
            this.mainDocumentPanel.TabIndex = 2;
            // 
            // sectionDocumentPanel
            // 
            this.sectionDocumentPanel.AutoScroll = true;
            this.sectionDocumentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sectionDocumentPanel.Controls.Add(this.removeSectionButton);
            this.sectionDocumentPanel.Controls.Add(this.sectionStaticLabel);
            this.sectionDocumentPanel.Controls.Add(this.paragraphDocumentPanel);
            this.sectionDocumentPanel.Controls.Add(this.sectionTitleLabel);
            this.sectionDocumentPanel.Controls.Add(this.sectionTitleTextBox);
            this.sectionDocumentPanel.Location = new System.Drawing.Point(3, 3);
            this.sectionDocumentPanel.Name = "sectionDocumentPanel";
            this.sectionDocumentPanel.Size = new System.Drawing.Size(569, 231);
            this.sectionDocumentPanel.TabIndex = 0;
            // 
            // removeSectionButton
            // 
            this.removeSectionButton.Location = new System.Drawing.Point(518, 17);
            this.removeSectionButton.Name = "removeSectionButton";
            this.removeSectionButton.Size = new System.Drawing.Size(25, 23);
            this.removeSectionButton.TabIndex = 2;
            this.removeSectionButton.Text = "-";
            this.removeSectionButton.UseVisualStyleBackColor = true;
            // 
            // sectionStaticLabel
            // 
            this.sectionStaticLabel.AutoSize = true;
            this.sectionStaticLabel.Location = new System.Drawing.Point(257, 1);
            this.sectionStaticLabel.Name = "sectionStaticLabel";
            this.sectionStaticLabel.Size = new System.Drawing.Size(43, 13);
            this.sectionStaticLabel.TabIndex = 3;
            this.sectionStaticLabel.Text = "Section";
            // 
            // paragraphDocumentPanel
            // 
            this.paragraphDocumentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paragraphDocumentPanel.Controls.Add(this.removeParagraphButton);
            this.paragraphDocumentPanel.Controls.Add(this.paragraphStaticLabel);
            this.paragraphDocumentPanel.Controls.Add(this.addParagraphButton);
            this.paragraphDocumentPanel.Controls.Add(this.paragraphRichTextBox);
            this.paragraphDocumentPanel.Controls.Add(this.paragraphTitleLabel);
            this.paragraphDocumentPanel.Controls.Add(this.paragraphTitleTextBox);
            this.paragraphDocumentPanel.Location = new System.Drawing.Point(3, 46);
            this.paragraphDocumentPanel.Name = "paragraphDocumentPanel";
            this.paragraphDocumentPanel.Size = new System.Drawing.Size(540, 178);
            this.paragraphDocumentPanel.TabIndex = 1;
            // 
            // removeParagraphButton
            // 
            this.removeParagraphButton.Location = new System.Drawing.Point(476, 10);
            this.removeParagraphButton.Name = "removeParagraphButton";
            this.removeParagraphButton.Size = new System.Drawing.Size(25, 23);
            this.removeParagraphButton.TabIndex = 2;
            this.removeParagraphButton.Text = "-";
            this.removeParagraphButton.UseVisualStyleBackColor = true;
            // 
            // paragraphStaticLabel
            // 
            this.paragraphStaticLabel.AutoSize = true;
            this.paragraphStaticLabel.Location = new System.Drawing.Point(8, 0);
            this.paragraphStaticLabel.Name = "paragraphStaticLabel";
            this.paragraphStaticLabel.Size = new System.Drawing.Size(56, 13);
            this.paragraphStaticLabel.TabIndex = 3;
            this.paragraphStaticLabel.Text = "Paragraph";
            // 
            // addParagraphButton
            // 
            this.addParagraphButton.Location = new System.Drawing.Point(507, 10);
            this.addParagraphButton.Name = "addParagraphButton";
            this.addParagraphButton.Size = new System.Drawing.Size(25, 23);
            this.addParagraphButton.TabIndex = 2;
            this.addParagraphButton.Text = "+";
            this.addParagraphButton.UseVisualStyleBackColor = true;
            // 
            // paragraphRichTextBox
            // 
            this.paragraphRichTextBox.Location = new System.Drawing.Point(3, 43);
            this.paragraphRichTextBox.Name = "paragraphRichTextBox";
            this.paragraphRichTextBox.Size = new System.Drawing.Size(529, 128);
            this.paragraphRichTextBox.TabIndex = 1;
            this.paragraphRichTextBox.Text = "";
            // 
            // paragraphTitleLabel
            // 
            this.paragraphTitleLabel.AutoSize = true;
            this.paragraphTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.paragraphTitleLabel.Location = new System.Drawing.Point(8, 17);
            this.paragraphTitleLabel.Name = "paragraphTitleLabel";
            this.paragraphTitleLabel.Size = new System.Drawing.Size(136, 17);
            this.paragraphTitleLabel.TabIndex = 0;
            this.paragraphTitleLabel.Text = "paragraphTitleLabel";
            // 
            // paragraphTitleTextBox
            // 
            this.paragraphTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.paragraphTitleTextBox.Location = new System.Drawing.Point(3, 14);
            this.paragraphTitleTextBox.Name = "paragraphTitleTextBox";
            this.paragraphTitleTextBox.Size = new System.Drawing.Size(263, 23);
            this.paragraphTitleTextBox.TabIndex = 0;
            // 
            // sectionTitleLabel
            // 
            this.sectionTitleLabel.AutoSize = true;
            this.sectionTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sectionTitleLabel.Location = new System.Drawing.Point(228, 20);
            this.sectionTitleLabel.Name = "sectionTitleLabel";
            this.sectionTitleLabel.Size = new System.Drawing.Size(115, 17);
            this.sectionTitleLabel.TabIndex = 0;
            this.sectionTitleLabel.Text = "sectionTitleLabel";
            this.sectionTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sectionTitleTextBox
            // 
            this.sectionTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sectionTitleTextBox.Location = new System.Drawing.Point(3, 17);
            this.sectionTitleTextBox.Name = "sectionTitleTextBox";
            this.sectionTitleTextBox.Size = new System.Drawing.Size(540, 23);
            this.sectionTitleTextBox.TabIndex = 0;
            this.sectionTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSectionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addSectionToolStripMenuItem
            // 
            this.addSectionToolStripMenuItem.Name = "addSectionToolStripMenuItem";
            this.addSectionToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.addSectionToolStripMenuItem.Text = "Add Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(602, 727);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainDocumentPanel);
            this.Controls.Add(this.docTypeLabel);
            this.Controls.Add(this.docAuthorLabel);
            this.Controls.Add(this.docTitleLabel);
            this.Controls.Add(this.docTypeTextBox);
            this.Controls.Add(this.docAuthorTextBox);
            this.Controls.Add(this.docTitleTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainDocumentPanel.ResumeLayout(false);
            this.sectionDocumentPanel.ResumeLayout(false);
            this.sectionDocumentPanel.PerformLayout();
            this.paragraphDocumentPanel.ResumeLayout(false);
            this.paragraphDocumentPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox docTitleTextBox;
        private System.Windows.Forms.TextBox docAuthorTextBox;
        private System.Windows.Forms.TextBox docTypeTextBox;
        private System.Windows.Forms.Label docTitleLabel;
        private System.Windows.Forms.Label docAuthorLabel;
        private System.Windows.Forms.Label docTypeLabel;
        private System.Windows.Forms.Panel mainDocumentPanel;
        private System.Windows.Forms.Panel sectionDocumentPanel;
        private System.Windows.Forms.Label sectionTitleLabel;
        private System.Windows.Forms.TextBox sectionTitleTextBox;
        private System.Windows.Forms.Panel paragraphDocumentPanel;
        private System.Windows.Forms.Label paragraphTitleLabel;
        private System.Windows.Forms.TextBox paragraphTitleTextBox;
        private System.Windows.Forms.Button removeSectionButton;
        private System.Windows.Forms.Button removeParagraphButton;
        private System.Windows.Forms.Button addParagraphButton;
        private System.Windows.Forms.RichTextBox paragraphRichTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSectionToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sectionStaticLabel;
        private System.Windows.Forms.Label paragraphStaticLabel;
    }
}

