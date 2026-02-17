namespace JSONist
{
    partial class CodesViewer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodesViewer));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            startsWithText = new TextBox();
            tabPage2 = new TabPage();
            matchListText = new TextBox();
            listBox1 = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            assignValueToolStripMenuItem = new ToolStripMenuItem();
            viewValueToolStripMenuItem = new ToolStripMenuItem();
            removeValueToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            saveFileDialog1 = new SaveFileDialog();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton5, toolStripSeparator1, toolStripDropDownButton1, toolStripButton3, toolStripButton4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1178, 42);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(60, 36);
            toolStripButton1.Text = "Run";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(158, 36);
            toolStripButton2.Text = "Reset Output";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(168, 36);
            toolStripButton5.Text = "Export Output";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 42);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(157, 36);
            toolStripDropDownButton1.Text = "Matchbook";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(218, 44);
            importToolStripMenuItem.Text = "&Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(218, 44);
            exportToolStripMenuItem.Text = "&Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(234, 36);
            toolStripButton3.Text = "Show Only Matched";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(263, 36);
            toolStripButton4.Text = "Show Only Unmatched";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 845);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1178, 42);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(169, 32);
            toolStripStatusLabel1.Text = "0 Items Visible";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 42);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listBox1);
            splitContainer1.Size = new Size(1178, 803);
            splitContainer1.SplitterDistance = 174;
            splitContainer1.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1178, 174);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(startsWithText);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1162, 120);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Starts With";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // startsWithText
            // 
            startsWithText.Dock = DockStyle.Fill;
            startsWithText.Location = new Point(3, 3);
            startsWithText.Name = "startsWithText";
            startsWithText.Size = new Size(1156, 39);
            startsWithText.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(matchListText);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1162, 120);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Match List";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // matchListText
            // 
            matchListText.Dock = DockStyle.Fill;
            matchListText.Location = new Point(3, 3);
            matchListText.Multiline = true;
            matchListText.Name = "matchListText";
            matchListText.ScrollBars = ScrollBars.Vertical;
            matchListText.Size = new Size(1156, 114);
            matchListText.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.ContextMenuStrip = contextMenuStrip1;
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1178, 625);
            listBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { assignValueToolStripMenuItem, viewValueToolStripMenuItem, removeValueToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(240, 118);
            // 
            // assignValueToolStripMenuItem
            // 
            assignValueToolStripMenuItem.Name = "assignValueToolStripMenuItem";
            assignValueToolStripMenuItem.Size = new Size(239, 38);
            assignValueToolStripMenuItem.Text = "&Assign Value";
            assignValueToolStripMenuItem.Click += assignValueToolStripMenuItem_Click;
            // 
            // viewValueToolStripMenuItem
            // 
            viewValueToolStripMenuItem.Name = "viewValueToolStripMenuItem";
            viewValueToolStripMenuItem.Size = new Size(239, 38);
            viewValueToolStripMenuItem.Text = "&View Value";
            viewValueToolStripMenuItem.Click += viewValueToolStripMenuItem_Click;
            // 
            // removeValueToolStripMenuItem
            // 
            removeValueToolStripMenuItem.Name = "removeValueToolStripMenuItem";
            removeValueToolStripMenuItem.Size = new Size(239, 38);
            removeValueToolStripMenuItem.Text = "&Remove Value";
            removeValueToolStripMenuItem.Click += removeValueToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Title = "Export Output";
            // 
            // CodesViewer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 887);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "CodesViewer";
            Text = "Codes Viewer";
            Load += CodesViewer_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox listBox1;
        private TextBox startsWithText;
        private TextBox matchListText;
        private ToolStripButton toolStripButton2;
        private System.Windows.Forms.Timer timer1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem assignValueToolStripMenuItem;
        private ToolStripMenuItem viewValueToolStripMenuItem;
        private ToolStripMenuItem removeValueToolStripMenuItem;
        private ToolStripButton toolStripButton5;
        private SaveFileDialog saveFileDialog1;
    }
}