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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            schemaToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            arraysToolStripMenuItem = new ToolStripMenuItem();
            codesToolStripMenuItem = new ToolStripMenuItem();
            nameToolStripMenuItem = new ToolStripMenuItem();
            findMatchesToolStripMenuItem = new ToolStripMenuItem();
            outputToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            exportToTextFileToolStripMenuItem = new ToolStripMenuItem();
            sortToolStripMenuItem = new ToolStripMenuItem();
            alphabeticallyToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            listBox1 = new ListBox();
            saveFileDialog1 = new SaveFileDialog();
            statusStrip1 = new StatusStrip();
            fileNameLabel = new ToolStripStatusLabel();
            itemLengthLabel = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, schemaToolStripMenuItem, outputToolStripMenuItem, sortToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1486, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 36);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(291, 44);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // schemaToolStripMenuItem
            // 
            schemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, findMatchesToolStripMenuItem });
            schemaToolStripMenuItem.Name = "schemaToolStripMenuItem";
            schemaToolStripMenuItem.Size = new Size(87, 36);
            schemaToolStripMenuItem.Text = "&Filter";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arraysToolStripMenuItem, nameToolStripMenuItem });
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(369, 44);
            loadToolStripMenuItem.Text = "&Load";
            // 
            // arraysToolStripMenuItem
            // 
            arraysToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { codesToolStripMenuItem });
            arraysToolStripMenuItem.Name = "arraysToolStripMenuItem";
            arraysToolStripMenuItem.Size = new Size(212, 44);
            arraysToolStripMenuItem.Text = "&Arrays";
            // 
            // codesToolStripMenuItem
            // 
            codesToolStripMenuItem.Name = "codesToolStripMenuItem";
            codesToolStripMenuItem.Size = new Size(213, 44);
            codesToolStripMenuItem.Text = "&Codes";
            codesToolStripMenuItem.Click += codesToolStripMenuItem_Click;
            // 
            // nameToolStripMenuItem
            // 
            nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            nameToolStripMenuItem.Size = new Size(212, 44);
            nameToolStripMenuItem.Text = "&Name";
            nameToolStripMenuItem.Click += nameToolStripMenuItem_Click;
            // 
            // findMatchesToolStripMenuItem
            // 
            findMatchesToolStripMenuItem.Name = "findMatchesToolStripMenuItem";
            findMatchesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            findMatchesToolStripMenuItem.Size = new Size(369, 44);
            findMatchesToolStripMenuItem.Text = "&Find Matches";
            findMatchesToolStripMenuItem.Click += findMatchesToolStripMenuItem_Click;
            // 
            // outputToolStripMenuItem
            // 
            outputToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem, exportToTextFileToolStripMenuItem });
            outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            outputToolStripMenuItem.Size = new Size(110, 36);
            outputToolStripMenuItem.Text = "&Output";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            clearToolStripMenuItem.Size = new Size(417, 44);
            clearToolStripMenuItem.Text = "&Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // exportToTextFileToolStripMenuItem
            // 
            exportToTextFileToolStripMenuItem.Name = "exportToTextFileToolStripMenuItem";
            exportToTextFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            exportToTextFileToolStripMenuItem.Size = new Size(417, 44);
            exportToTextFileToolStripMenuItem.Text = "&Export to Text File";
            exportToTextFileToolStripMenuItem.Click += exportToTextFileToolStripMenuItem_Click;
            // 
            // sortToolStripMenuItem
            // 
            sortToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alphabeticallyToolStripMenuItem });
            sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            sortToolStripMenuItem.Size = new Size(77, 36);
            sortToolStripMenuItem.Text = "&Sort";
            // 
            // alphabeticallyToolStripMenuItem
            // 
            alphabeticallyToolStripMenuItem.Name = "alphabeticallyToolStripMenuItem";
            alphabeticallyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.A;
            alphabeticallyToolStripMenuItem.Size = new Size(570, 44);
            alphabeticallyToolStripMenuItem.Text = "&Alphabetically (automatic)";
            alphabeticallyToolStripMenuItem.Click += alphabeticallyToolStripMenuItem_Click;
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
            listBox1.Location = new Point(0, 44);
            listBox1.Margin = new Padding(6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1486, 916);
            listBox1.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Title = "Export";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { fileNameLabel, itemLengthLabel });
            statusStrip1.Location = new Point(0, 938);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1486, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // fileNameLabel
            // 
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(0, 12);
            // 
            // itemLengthLabel
            // 
            itemLengthLabel.Name = "itemLengthLabel";
            itemLengthLabel.Size = new Size(0, 12);
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(statusStrip1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "Form1";
            Text = "JSONist";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private ToolStripMenuItem findMatchesToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel fileNameLabel;
        private ToolStripStatusLabel itemLengthLabel;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem sortToolStripMenuItem;
        private ToolStripMenuItem alphabeticallyToolStripMenuItem;
    }
}
