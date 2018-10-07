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
            this.docPanel = new System.Windows.Forms.Panel();
            this.sectionPanel = new System.Windows.Forms.Panel();
            this.removeSectionButton = new System.Windows.Forms.Button();
            this.paragraphPanel = new System.Windows.Forms.Panel();
            this.removeParagraphButton = new System.Windows.Forms.Button();
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
            this.docPanel.SuspendLayout();
            this.sectionPanel.SuspendLayout();
            this.paragraphPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // docTitleTextBox
            // 
            this.docTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.docTitleTextBox.Location = new System.Drawing.Point(12, 33);
            this.docTitleTextBox.Name = "docTitleTextBox";
            this.docTitleTextBox.Size = new System.Drawing.Size(578, 26);
            this.docTitleTextBox.TabIndex = 0;
            this.docTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // docAuthorTextBox
            // 
            this.docAuthorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.docAuthorTextBox.Location = new System.Drawing.Point(12, 65);
            this.docAuthorTextBox.Name = "docAuthorTextBox";
            this.docAuthorTextBox.Size = new System.Drawing.Size(578, 26);
            this.docAuthorTextBox.TabIndex = 0;
            this.docAuthorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // docTypeTextBox
            // 
            this.docTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.docTypeTextBox.Location = new System.Drawing.Point(12, 97);
            this.docTypeTextBox.Name = "docTypeTextBox";
            this.docTypeTextBox.Size = new System.Drawing.Size(578, 26);
            this.docTypeTextBox.TabIndex = 0;
            this.docTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // docTitleLabel
            // 
            this.docTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.docTitleLabel.AutoSize = true;
            this.docTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.docTitleLabel.Location = new System.Drawing.Point(261, 36);
            this.docTitleLabel.Name = "docTitleLabel";
            this.docTitleLabel.Size = new System.Drawing.Size(103, 20);
            this.docTitleLabel.TabIndex = 1;
            this.docTitleLabel.Text = "docTitleLabel";
            // 
            // docAuthorLabel
            // 
            this.docAuthorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.docAuthorLabel.AutoSize = true;
            this.docAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.docAuthorLabel.Location = new System.Drawing.Point(261, 68);
            this.docAuthorLabel.Name = "docAuthorLabel";
            this.docAuthorLabel.Size = new System.Drawing.Size(122, 20);
            this.docAuthorLabel.TabIndex = 1;
            this.docAuthorLabel.Text = "docAuthorLabel";
            // 
            // docTypeLabel
            // 
            this.docTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.docTypeLabel.AutoSize = true;
            this.docTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.docTypeLabel.Location = new System.Drawing.Point(261, 100);
            this.docTypeLabel.Name = "docTypeLabel";
            this.docTypeLabel.Size = new System.Drawing.Size(108, 20);
            this.docTypeLabel.TabIndex = 1;
            this.docTypeLabel.Text = "docTypeLabel";
            // 
            // docPanel
            // 
            this.docPanel.Controls.Add(this.sectionPanel);
            this.docPanel.Location = new System.Drawing.Point(12, 129);
            this.docPanel.Name = "docPanel";
            this.docPanel.Size = new System.Drawing.Size(578, 587);
            this.docPanel.TabIndex = 2;
            // 
            // sectionPanel
            // 
            this.sectionPanel.Controls.Add(this.removeSectionButton);
            this.sectionPanel.Controls.Add(this.paragraphPanel);
            this.sectionPanel.Controls.Add(this.sectionTitleLabel);
            this.sectionPanel.Controls.Add(this.sectionTitleTextBox);
            this.sectionPanel.Location = new System.Drawing.Point(3, 3);
            this.sectionPanel.Name = "sectionPanel";
            this.sectionPanel.Size = new System.Drawing.Size(572, 230);
            this.sectionPanel.TabIndex = 0;
            // 
            // removeSectionButton
            // 
            this.removeSectionButton.Location = new System.Drawing.Point(445, 205);
            this.removeSectionButton.Name = "removeSectionButton";
            this.removeSectionButton.Size = new System.Drawing.Size(121, 23);
            this.removeSectionButton.TabIndex = 2;
            this.removeSectionButton.Text = "removeSectionButton";
            this.removeSectionButton.UseVisualStyleBackColor = true;
            // 
            // paragraphPanel
            // 
            this.paragraphPanel.Controls.Add(this.removeParagraphButton);
            this.paragraphPanel.Controls.Add(this.addParagraphButton);
            this.paragraphPanel.Controls.Add(this.paragraphRichTextBox);
            this.paragraphPanel.Controls.Add(this.paragraphTitleLabel);
            this.paragraphPanel.Controls.Add(this.paragraphTitleTextBox);
            this.paragraphPanel.Location = new System.Drawing.Point(3, 39);
            this.paragraphPanel.Name = "paragraphPanel";
            this.paragraphPanel.Size = new System.Drawing.Size(566, 163);
            this.paragraphPanel.TabIndex = 1;
            // 
            // removeParagraphButton
            // 
            this.removeParagraphButton.Location = new System.Drawing.Point(507, 6);
            this.removeParagraphButton.Name = "removeParagraphButton";
            this.removeParagraphButton.Size = new System.Drawing.Size(25, 23);
            this.removeParagraphButton.TabIndex = 2;
            this.removeParagraphButton.Text = "-";
            this.removeParagraphButton.UseVisualStyleBackColor = true;
            // 
            // addParagraphButton
            // 
            this.addParagraphButton.Location = new System.Drawing.Point(538, 6);
            this.addParagraphButton.Name = "addParagraphButton";
            this.addParagraphButton.Size = new System.Drawing.Size(25, 23);
            this.addParagraphButton.TabIndex = 2;
            this.addParagraphButton.Text = "+";
            this.addParagraphButton.UseVisualStyleBackColor = true;
            // 
            // paragraphRichTextBox
            // 
            this.paragraphRichTextBox.Location = new System.Drawing.Point(3, 32);
            this.paragraphRichTextBox.Name = "paragraphRichTextBox";
            this.paragraphRichTextBox.Size = new System.Drawing.Size(560, 128);
            this.paragraphRichTextBox.TabIndex = 1;
            this.paragraphRichTextBox.Text = "";
            // 
            // paragraphTitleLabel
            // 
            this.paragraphTitleLabel.AutoSize = true;
            this.paragraphTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.paragraphTitleLabel.Location = new System.Drawing.Point(8, 6);
            this.paragraphTitleLabel.Name = "paragraphTitleLabel";
            this.paragraphTitleLabel.Size = new System.Drawing.Size(136, 17);
            this.paragraphTitleLabel.TabIndex = 0;
            this.paragraphTitleLabel.Text = "paragraphTitleLabel";
            // 
            // paragraphTitleTextBox
            // 
            this.paragraphTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.paragraphTitleTextBox.Location = new System.Drawing.Point(3, 3);
            this.paragraphTitleTextBox.Name = "paragraphTitleTextBox";
            this.paragraphTitleTextBox.Size = new System.Drawing.Size(263, 23);
            this.paragraphTitleTextBox.TabIndex = 0;
            // 
            // sectionTitleLabel
            // 
            this.sectionTitleLabel.AutoSize = true;
            this.sectionTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sectionTitleLabel.Location = new System.Drawing.Point(247, 13);
            this.sectionTitleLabel.Name = "sectionTitleLabel";
            this.sectionTitleLabel.Size = new System.Drawing.Size(115, 17);
            this.sectionTitleLabel.TabIndex = 0;
            this.sectionTitleLabel.Text = "sectionTitleLabel";
            // 
            // sectionTitleTextBox
            // 
            this.sectionTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sectionTitleTextBox.Location = new System.Drawing.Point(3, 10);
            this.sectionTitleTextBox.Name = "sectionTitleTextBox";
            this.sectionTitleTextBox.Size = new System.Drawing.Size(563, 23);
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
            this.addSectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addSectionToolStripMenuItem.Text = "Add Section";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 727);
            this.Controls.Add(this.docPanel);
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
            this.docPanel.ResumeLayout(false);
            this.sectionPanel.ResumeLayout(false);
            this.sectionPanel.PerformLayout();
            this.paragraphPanel.ResumeLayout(false);
            this.paragraphPanel.PerformLayout();
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
        private System.Windows.Forms.Panel docPanel;
        private System.Windows.Forms.Panel sectionPanel;
        private System.Windows.Forms.Label sectionTitleLabel;
        private System.Windows.Forms.TextBox sectionTitleTextBox;
        private System.Windows.Forms.Panel paragraphPanel;
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
    }
}

