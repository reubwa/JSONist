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
            toolStripSeparator2 = new ToolStripSeparator();
            nameToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            findMatchesToolStripMenuItem = new ToolStripMenuItem();
            sortToolStripMenuItem = new ToolStripMenuItem();
            alphabeticallyToolStripMenuItem = new ToolStripMenuItem();
            outputToolStripMenuItem = new ToolStripMenuItem();
            exportToTextFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            jumpToToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            lINQQueryEditorToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            listBox1 = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            inspectToolStripMenuItem = new ToolStripMenuItem();
            viewAssociatedCodesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            copyAssociatedCodesToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            statusStrip1 = new StatusStrip();
            fileNameLabel = new ToolStripStatusLabel();
            itemLengthLabel = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, schemaToolStripMenuItem, sortToolStripMenuItem, outputToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(2292, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(90, 36);
            fileToolStripMenuItem.Text = "&Input";
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
            schemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, toolStripSeparator3, findMatchesToolStripMenuItem });
            schemaToolStripMenuItem.Name = "schemaToolStripMenuItem";
            schemaToolStripMenuItem.Size = new Size(87, 36);
            schemaToolStripMenuItem.Text = "&Filter";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arraysToolStripMenuItem, toolStripSeparator2, nameToolStripMenuItem });
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(369, 44);
            loadToolStripMenuItem.Text = "&Load";
            // 
            // arraysToolStripMenuItem
            // 
            arraysToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { codesToolStripMenuItem });
            arraysToolStripMenuItem.Name = "arraysToolStripMenuItem";
            arraysToolStripMenuItem.Size = new Size(359, 44);
            arraysToolStripMenuItem.Text = "&Arrays";
            // 
            // codesToolStripMenuItem
            // 
            codesToolStripMenuItem.Name = "codesToolStripMenuItem";
            codesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.C;
            codesToolStripMenuItem.Size = new Size(359, 44);
            codesToolStripMenuItem.Text = "&Codes";
            codesToolStripMenuItem.Click += codesToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(356, 6);
            // 
            // nameToolStripMenuItem
            // 
            nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            nameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.N;
            nameToolStripMenuItem.Size = new Size(359, 44);
            nameToolStripMenuItem.Text = "&Name";
            nameToolStripMenuItem.Click += nameToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(366, 6);
            // 
            // findMatchesToolStripMenuItem
            // 
            findMatchesToolStripMenuItem.Name = "findMatchesToolStripMenuItem";
            findMatchesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            findMatchesToolStripMenuItem.Size = new Size(369, 44);
            findMatchesToolStripMenuItem.Text = "&Find Matches";
            findMatchesToolStripMenuItem.Click += findMatchesToolStripMenuItem_Click;
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
            // outputToolStripMenuItem
            // 
            outputToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportToTextFileToolStripMenuItem, toolStripSeparator1, jumpToToolStripMenuItem, clearToolStripMenuItem, lINQQueryEditorToolStripMenuItem });
            outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            outputToolStripMenuItem.Size = new Size(110, 36);
            outputToolStripMenuItem.Text = "&Output";
            // 
            // exportToTextFileToolStripMenuItem
            // 
            exportToTextFileToolStripMenuItem.Name = "exportToTextFileToolStripMenuItem";
            exportToTextFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            exportToTextFileToolStripMenuItem.Size = new Size(426, 44);
            exportToTextFileToolStripMenuItem.Text = "&Export to Text File";
            exportToTextFileToolStripMenuItem.Click += exportToTextFileToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(423, 6);
            // 
            // jumpToToolStripMenuItem
            // 
            jumpToToolStripMenuItem.Name = "jumpToToolStripMenuItem";
            jumpToToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.J;
            jumpToToolStripMenuItem.Size = new Size(426, 44);
            jumpToToolStripMenuItem.Text = "&Jump to";
            jumpToToolStripMenuItem.Click += jumpToToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            clearToolStripMenuItem.Size = new Size(426, 44);
            clearToolStripMenuItem.Text = "&Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // lINQQueryEditorToolStripMenuItem
            // 
            lINQQueryEditorToolStripMenuItem.Name = "lINQQueryEditorToolStripMenuItem";
            lINQQueryEditorToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            lINQQueryEditorToolStripMenuItem.Size = new Size(426, 44);
            lINQQueryEditorToolStripMenuItem.Text = "&LINQ Query Editor";
            lINQQueryEditorToolStripMenuItem.Click += lINQQueryEditorToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "JSON files|*.json|All files|*.*";
            openFileDialog1.Title = "Choose a JSON File";
            // 
            // listBox1
            // 
            listBox1.ContextMenuStrip = contextMenuStrip1;
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 44);
            listBox1.Margin = new Padding(6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(2292, 1079);
            listBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { inspectToolStripMenuItem, viewAssociatedCodesToolStripMenuItem, toolStripSeparator5, copyAssociatedCodesToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(484, 124);
            // 
            // inspectToolStripMenuItem
            // 
            inspectToolStripMenuItem.Name = "inspectToolStripMenuItem";
            inspectToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.I;
            inspectToolStripMenuItem.Size = new Size(483, 38);
            inspectToolStripMenuItem.Text = "&Inspect";
            inspectToolStripMenuItem.Click += inspectToolStripMenuItem_Click;
            // 
            // viewAssociatedCodesToolStripMenuItem
            // 
            viewAssociatedCodesToolStripMenuItem.Name = "viewAssociatedCodesToolStripMenuItem";
            viewAssociatedCodesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.V;
            viewAssociatedCodesToolStripMenuItem.Size = new Size(483, 38);
            viewAssociatedCodesToolStripMenuItem.Text = "&View Associated Codes";
            viewAssociatedCodesToolStripMenuItem.Click += viewAssociatedCodesToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(480, 6);
            // 
            // copyAssociatedCodesToolStripMenuItem
            // 
            copyAssociatedCodesToolStripMenuItem.Name = "copyAssociatedCodesToolStripMenuItem";
            copyAssociatedCodesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;
            copyAssociatedCodesToolStripMenuItem.Size = new Size(483, 38);
            copyAssociatedCodesToolStripMenuItem.Text = "&Copy Associated Codes";
            copyAssociatedCodesToolStripMenuItem.Click += copyAssociatedCodesToolStripMenuItem_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Title = "Export";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { fileNameLabel, itemLengthLabel });
            statusStrip1.Location = new Point(0, 1101);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(2292, 22);
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
            ClientSize = new Size(2292, 1123);
            Controls.Add(statusStrip1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "Form1";
            Text = "JSONist";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
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
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem inspectToolStripMenuItem;
        private ToolStripMenuItem viewAssociatedCodesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem jumpToToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem lINQQueryEditorToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem copyAssociatedCodesToolStripMenuItem;
    }
}
