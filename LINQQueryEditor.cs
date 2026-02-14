using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JSONist
{
    public partial class LINQQueryEditor : Form
    {
        public LINQQueryEditor()
        {
            InitializeComponent();
        }
        public string LINQQuery { get; private set; }

        private async void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Form1.loadedFile == null || Form1.loadedFile.Tiplocs == null)
            {
                MessageBox.Show("Please load a file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var options = ScriptOptions.Default
                    .AddReferences(typeof(System.Linq.Enumerable).Assembly)
                    .AddReferences(typeof(JSONist.TIPLOCSchemaProvider).Assembly)
                    .AddImports("System", "System.Linq", "System.Collections.Generic", "JSONist");

                var globals = Form1.loadedFile;

                var result = await CSharpScript.EvaluateAsync<IEnumerable<TIPLOCSchemaProvider.TIPLOCObject>>(
                    textBox1.Text,
                    options,
                    globals: globals
                );

                listBox1.Items.Clear();
                int count = 0;
                if (result != null)
                {
                    foreach (var item in result)
                    {
                        listBox1.Items.Add(item.Name);
                        count++;
                    }
                }

                if (count == 0)
                {
                    MessageBox.Show("No matches found matching that query.");
                }
            }
            catch (CompilationErrorException compileEx)
            {
                MessageBox.Show($"Query Error:\n{string.Join("\n", compileEx.Diagnostics)}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execution Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Cursor = Cursors.Default;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LINQQuery = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LINQQueryEditor_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{listBox1.Items.Count} Items Visible";
        }
    }
}
