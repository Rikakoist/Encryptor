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
            this.StringMode = new System.Windows.Forms.TabPage();
            this.StringInputTextBox = new System.Windows.Forms.TextBox();
            this.HashResultTextBox = new System.Windows.Forms.TextBox();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ModeTabControl.SuspendLayout();
            this.StringMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModeTabControl
            // 
            this.ModeTabControl.Controls.Add(this.StringMode);
            this.ModeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModeTabControl.Location = new System.Drawing.Point(0, 0);
            this.ModeTabControl.Name = "ModeTabControl";
            this.ModeTabControl.SelectedIndex = 0;
            this.ModeTabControl.Size = new System.Drawing.Size(702, 215);
            this.ModeTabControl.TabIndex = 0;
            // 
            // StringMode
            // 
            this.StringMode.Controls.Add(this.StringInputTextBox);
            this.StringMode.Location = new System.Drawing.Point(4, 26);
            this.StringMode.Name = "StringMode";
            this.StringMode.Padding = new System.Windows.Forms.Padding(3);
            this.StringMode.Size = new System.Drawing.Size(694, 185);
            this.StringMode.TabIndex = 0;
            this.StringMode.Text = "String";
            this.StringMode.UseVisualStyleBackColor = true;
            // 
            // StringInputTextBox
            // 
            this.StringInputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StringInputTextBox.Location = new System.Drawing.Point(3, 3);
            this.StringInputTextBox.Multiline = true;
            this.StringInputTextBox.Name = "StringInputTextBox";
            this.StringInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StringInputTextBox.Size = new System.Drawing.Size(688, 179);
            this.StringInputTextBox.TabIndex = 0;
            this.StringInputTextBox.TextChanged += new System.EventHandler(this.AutoCalc);
            // 
            // HashResultTextBox
            // 
            this.HashResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HashResultTextBox.Location = new System.Drawing.Point(0, 0);
            this.HashResultTextBox.Multiline = true;
            this.HashResultTextBox.Name = "HashResultTextBox";
            this.HashResultTextBox.ReadOnly = true;
            this.HashResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HashResultTextBox.Size = new System.Drawing.Size(702, 214);
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
            this.MainSplitContainer.Size = new System.Drawing.Size(702, 433);
            this.MainSplitContainer.SplitterDistance = 215;
            this.MainSplitContainer.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.MainSplitContainer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Hasher";
            this.ModeTabControl.ResumeLayout(false);
            this.StringMode.ResumeLayout(false);
            this.StringMode.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl ModeTabControl;
        private System.Windows.Forms.TabPage StringMode;
        private System.Windows.Forms.TextBox HashResultTextBox;
        private System.Windows.Forms.TextBox StringInputTextBox;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
    }
}

