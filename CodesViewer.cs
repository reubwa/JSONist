using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JSONist
{
    public partial class CodesViewer : Form
    {
        public CodesViewer()
        {
            InitializeComponent();
        }

        private void CodesViewer_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            loadCodes();
        }

        public void loadCodes()
        {
            this.Cursor = Cursors.WaitCursor;
            listBox1.Items.Clear();
            startsWithText.Clear();
            matchListText.Clear();
            foreach (var tl in Form1.loadedFile.Tiplocs)
            {
                foreach (var code in tl.Codes)
                {
                    if (!listBox1.Items.Contains(code))
                    {
                        listBox1.Items.Add(code);
                    }
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            loadCodes();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            listBox1.Items.Clear();
            if (tabControl1.SelectedTab == tabPage1 && startsWithText.Text != "")
            {
                foreach (var tl in Form1.loadedFile.Tiplocs)
                {
                    foreach (var code in tl.Codes)
                    {
                        if (!listBox1.Items.Contains(code) && code.StartsWith(startsWithText.Text))
                        {
                            listBox1.Items.Add(code);
                        }
                    }
                }
            }

            if (tabControl1.SelectedTab == tabPage2 && matchListText.Text != "")
            {
                var split = matchListText.Text.Split(Environment.NewLine);
                foreach (var tl in Form1.loadedFile.Tiplocs)
                {
                    foreach (var code in tl.Codes)
                    {
                        if (!listBox1.Items.Contains(code) && split.Contains(code))
                        {
                            listBox1.Items.Add(code);
                        }
                    }
                }
            }
            this.Cursor = Cursors.Default;
            if (listBox1.Items.Count < 0)
            {
                MessageBox.Show("No matches found!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{listBox1.Items.Count} items visible";
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "JSONist matchbooks|*.jsonistmatchbook|All files|*.*";
            ofd.Title = "Import a matchbook";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var loadedDict = new Dictionary<string, string>();
                var lines = File.ReadAllLines(ofd.FileName);

                foreach (var line in lines)
                {
                    var parts = line.Split('=', 2); // Split only on first '='

                    if (parts.Length == 2)
                    {
                        string key = parts[0];
                        string value = parts[1];

                        // SAFETY CHECK: Ensure key isn't already added
                        if (!loadedDict.ContainsKey(key))
                        {
                            loadedDict.Add(key, value);
                        }
                    }
                }

                Form1.codebook = loadedDict;
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "JSONist matchbooks|*.jsonistmatchbook|All files|*.*";
            sfd.Title = "Export the matchbook";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var linesToWrite = Form1.codebook.Select(kvp => $"{kvp.Key}={kvp.Value}");
                File.WriteAllLines(sfd.FileName, linesToWrite);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            listBox1.Items.Clear();
            foreach (var tl in Form1.loadedFile.Tiplocs)
            {
                foreach (var code in tl.Codes)
                {
                    if (!listBox1.Items.Contains(code) && Form1.codebook.ContainsKey(code))
                    {
                        listBox1.Items.Add(code);
                    }
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            listBox1.Items.Clear();
            foreach (var tl in Form1.loadedFile.Tiplocs)
            {
                foreach (var code in tl.Codes)
                {
                    if (!listBox1.Items.Contains(code) && !Form1.codebook.ContainsKey(code))
                    {
                        listBox1.Items.Add(code);
                    }
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void viewValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            if (Form1.codebook.ContainsKey((string)listBox1.SelectedItem))
            {
                MessageBox.Show($"{Form1.codebook[(string)listBox1.SelectedItem]}", $"Value associated with {(string)listBox1.SelectedItem}", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Oh dear!", "No value associated with selected item");
            }
        }

        private void assignValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            var val = Interaction.InputBox("Enter Associated Value");
            Form1.codebook.Add((string)listBox1.SelectedItem, val);
        }

        private void removeValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Form1.codebook.Remove((string)listBox1.SelectedItem);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, listBox1.Items.Cast<string>());
            }
        }
    }
}
