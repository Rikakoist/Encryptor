namespace Encryptor
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
            this.ModeTabControl = new System.Windows.Forms.TabControl();
            this.StringModeTab = new System.Windows.Forms.TabPage();
            this.StringInputTextBox = new System.Windows.Forms.TextBox();
            this.HashResultTextBox = new System.Windows.Forms.TextBox();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.FileModeTab = new System.Windows.Forms.TabPage();
            this.GetHelp = new System.Windows.Forms.HelpProvider();
            this.DragDropRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ModeTabControl.SuspendLayout();
            this.StringModeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.FileModeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModeTabControl
            // 
            this.ModeTabControl.Controls.Add(this.StringModeTab);
            this.ModeTabControl.Controls.Add(this.FileModeTab);
            this.ModeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModeTabControl.Location = new System.Drawing.Point(0, 0);
            this.ModeTabControl.Name = "ModeTabControl";
            this.ModeTabControl.SelectedIndex = 0;
            this.ModeTabControl.Size = new System.Drawing.Size(704, 195);
            this.ModeTabControl.TabIndex = 0;
            // 
            // StringModeTab
            // 
            this.StringModeTab.Controls.Add(this.StringInputTextBox);
            this.StringModeTab.Location = new System.Drawing.Point(4, 24);
            this.StringModeTab.Name = "StringModeTab";
            this.StringModeTab.Padding = new System.Windows.Forms.Padding(3);
            this.StringModeTab.Size = new System.Drawing.Size(696, 167);
            this.StringModeTab.TabIndex = 0;
            this.StringModeTab.Text = "String";
            this.StringModeTab.UseVisualStyleBackColor = true;
            // 
            // StringInputTextBox
            // 
            this.StringInputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GetHelp.SetHelpString(this.StringInputTextBox, "Enter string here to hash them.");
            this.StringInputTextBox.Location = new System.Drawing.Point(3, 3);
            this.StringInputTextBox.Multiline = true;
            this.StringInputTextBox.Name = "StringInputTextBox";
            this.StringInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GetHelp.SetShowHelp(this.StringInputTextBox, true);
            this.StringInputTextBox.Size = new System.Drawing.Size(690, 161);
            this.StringInputTextBox.TabIndex = 0;
            this.StringInputTextBox.TextChanged += new System.EventHandler(this.AutoCalc);
            // 
            // HashResultTextBox
            // 
            this.HashResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GetHelp.SetHelpString(this.HashResultTextBox, "Hash result of the input.");
            this.HashResultTextBox.Location = new System.Drawing.Point(0, 0);
            this.HashResultTextBox.Multiline = true;
            this.HashResultTextBox.Name = "HashResultTextBox";
            this.HashResultTextBox.ReadOnly = true;
            this.HashResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GetHelp.SetShowHelp(this.HashResultTextBox, true);
            this.HashResultTextBox.Size = new System.Drawing.Size(704, 242);
            this.HashResultTextBox.TabIndex = 0;
            this.HashResultTextBox.TabStop = false;
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            this.MainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.ModeTabControl);
            this.MainSplitContainer.Panel1MinSize = 100;
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.HashResultTextBox);
            this.MainSplitContainer.Panel2MinSize = 100;
            this.MainSplitContainer.Size = new System.Drawing.Size(704, 441);
            this.MainSplitContainer.SplitterDistance = 195;
            this.MainSplitContainer.TabIndex = 1;
            // 
            // FileModeTab
            // 
            this.FileModeTab.Controls.Add(this.DragDropRichTextBox);
            this.FileModeTab.Location = new System.Drawing.Point(4, 24);
            this.FileModeTab.Name = "FileModeTab";
            this.FileModeTab.Size = new System.Drawing.Size(694, 187);
            this.FileModeTab.TabIndex = 1;
            this.FileModeTab.Text = "File";
            this.FileModeTab.UseVisualStyleBackColor = true;
            this.FileModeTab.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileHash);
            // 
            // DragDropRichTextBox
            // 
            this.DragDropRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DragDropRichTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetHelp.SetHelpString(this.DragDropRichTextBox, "Drag and drop files here to hash.");
            this.DragDropRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.DragDropRichTextBox.Name = "DragDropRichTextBox";
            this.DragDropRichTextBox.ReadOnly = true;
            this.DragDropRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.GetHelp.SetShowHelp(this.DragDropRichTextBox, true);
            this.DragDropRichTextBox.Size = new System.Drawing.Size(694, 187);
            this.DragDropRichTextBox.TabIndex = 0;
            this.DragDropRichTextBox.Text = "Darg and drop files here!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.MainSplitContainer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.Text = "Hasher";
            this.ModeTabControl.ResumeLayout(false);
            this.StringModeTab.ResumeLayout(false);
            this.StringModeTab.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.FileModeTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl ModeTabControl;
        private System.Windows.Forms.TabPage StringModeTab;
        private System.Windows.Forms.TextBox HashResultTextBox;
        private System.Windows.Forms.TextBox StringInputTextBox;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.TabPage FileModeTab;
        private System.Windows.Forms.HelpProvider GetHelp;
        private System.Windows.Forms.RichTextBox DragDropRichTextBox;
    }
}

