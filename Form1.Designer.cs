namespace JSONist
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            schemaToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            arraysToolStripMenuItem = new ToolStripMenuItem();
            codesToolStripMenuItem = new ToolStripMenuItem();
            outputToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            exportToTextFileToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            listBox1 = new ListBox();
            saveFileDialog1 = new SaveFileDialog();
            nameToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, schemaToolStripMenuItem, outputToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // schemaToolStripMenuItem
            // 
            schemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem });
            schemaToolStripMenuItem.Name = "schemaToolStripMenuItem";
            schemaToolStripMenuItem.Size = new Size(61, 20);
            schemaToolStripMenuItem.Text = "&Schema";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arraysToolStripMenuItem, nameToolStripMenuItem });
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(180, 22);
            loadToolStripMenuItem.Text = "&Load";
            // 
            // arraysToolStripMenuItem
            // 
            arraysToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { codesToolStripMenuItem });
            arraysToolStripMenuItem.Name = "arraysToolStripMenuItem";
            arraysToolStripMenuItem.Size = new Size(180, 22);
            arraysToolStripMenuItem.Text = "&Arrays";
            // 
            // codesToolStripMenuItem
            // 
            codesToolStripMenuItem.Name = "codesToolStripMenuItem";
            codesToolStripMenuItem.Size = new Size(180, 22);
            codesToolStripMenuItem.Text = "&Codes";
            codesToolStripMenuItem.Click += codesToolStripMenuItem_Click;
            // 
            // outputToolStripMenuItem
            // 
            outputToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem, exportToTextFileToolStripMenuItem });
            outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            outputToolStripMenuItem.Size = new Size(57, 20);
            outputToolStripMenuItem.Text = "&Output";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            clearToolStripMenuItem.Size = new Size(206, 22);
            clearToolStripMenuItem.Text = "&Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // exportToTextFileToolStripMenuItem
            // 
            exportToTextFileToolStripMenuItem.Name = "exportToTextFileToolStripMenuItem";
            exportToTextFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            exportToTextFileToolStripMenuItem.Size = new Size(206, 22);
            exportToTextFileToolStripMenuItem.Text = "&Export to Text File";
            exportToTextFileToolStripMenuItem.Click += exportToTextFileToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "JSON files|*.json|All files|*.*";
            openFileDialog1.Title = "Choose a JSON File";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 24);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(800, 426);
            listBox1.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Title = "Export";
            // 
            // nameToolStripMenuItem
            // 
            nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            nameToolStripMenuItem.Size = new Size(180, 22);
            nameToolStripMenuItem.Text = "&Name";
            nameToolStripMenuItem.Click += nameToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "JSONist";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ListBox listBox1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem schemaToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem arraysToolStripMenuItem;
        private ToolStripMenuItem codesToolStripMenuItem;
        private ToolStripMenuItem outputToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exportToTextFileToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem nameToolStripMenuItem;
    }
}
