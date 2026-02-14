using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.VisualBasic;
using System.Text.Json;

namespace JSONist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
        }

        public static TIPLOCSchemaProvider.Jfile loadedFile;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        public void openFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                try
                {
                    using StreamReader reader = new(openFileDialog1.FileName);
                    string json = reader.ReadToEnd();
                    var conv = new TIPLOCConversionEngine();
                    var res = conv.ds(json);
                    if (res is null || res is JsonException)
                    {
                        if (res is null)
                        {
                            MessageBox.Show("Null exception occured", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }

                        var res2 = (JsonException)res;
                        MessageBox.Show(res2.Message);
                        return;
                    }

                    loadedFile = (TIPLOCSchemaProvider.Jfile)res;
                    fileNameLabel.Text = $"{openFileDialog1.FileName} loaded,";
                    var msgResult = MessageBox.Show("Load names into the output area?", "Prompt",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msgResult == DialogResult.Yes)
                    {
                        loadNames();
                    }

                }
                catch (IOException ioException)
                {
                    MessageBox.Show(ioException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void exportToTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedFile == null || loadedFile.Tiplocs == null)
            {
                MessageBox.Show("No file loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, listBox1.Items.Cast<string>());
            }
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadNames();
        }

        public void loadNames()
        {
            if (loadedFile == null || loadedFile.Tiplocs == null)
            {
                MessageBox.Show("No file loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            listBox1.Items.Clear();
            foreach (var tl in loadedFile.Tiplocs)
            {
                if (!listBox1.Items.Contains(tl.Name))
                {
                    listBox1.Items.Add(tl.Name);
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void findMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedFile == null || loadedFile.Tiplocs == null)
            {
                MessageBox.Show("No file loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fmd = new FindMatchesDlg();
            fmd.ShowDialog();
            if (fmd.DialogResult != DialogResult.OK)
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            var res = fmd.SelectedData;
            var selection = res.Key;
            try
            {
                switch (selection)
                {
                    case "Stanox":
                    {
                        listBox1.Items.Clear();
                        foreach (var tl in loadedFile.Tiplocs)
                        {
                            if (tl.Stanox == (res.Value is null ? null : int.Parse((String)res.Value)))
                            {
                                listBox1.Items.Add(tl.Name);
                            }
                        }

                        if (listBox1.Items.Count == 0)
                        {
                            MessageBox.Show("No matches found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        return;
                    }
                    case "CRS":
                    {
                        listBox1.Items.Clear();
                        foreach (var tl in loadedFile.Tiplocs)
                        {
                            if (tl.Details.CRS == (string?)res.Value)
                            {
                                listBox1.Items.Add(tl.Name);
                            }
                        }

                        if (listBox1.Items.Count == 0)
                        {
                            MessageBox.Show("No matches found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        return;
                    }
                    case "Nalco":
                    {
                        listBox1.Items.Clear();
                        foreach (var tl in loadedFile.Tiplocs)
                        {
                            if (tl.Details.Nalco == (res.Value is null ? null : int.Parse((String)res.Value)))
                            {
                                listBox1.Items.Add(tl.Name);
                            }
                        }

                        if (listBox1.Items.Count == 0)
                        {
                            MessageBox.Show("No matches found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        return;
                    }
                    case "UIC":
                    {
                        listBox1.Items.Clear();
                        foreach (var tl in loadedFile.Tiplocs)
                        {
                            if (tl.Details.UIC == (res.Value is null ? null : int.Parse((String)res.Value)))
                            {
                                listBox1.Items.Add(tl.Name);
                            }
                        }

                        if (listBox1.Items.Count == 0)
                        {
                            MessageBox.Show("No matches found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        return;
                    }
                    case "Zone":
                    {
                        listBox1.Items.Clear();
                        foreach (var tl in loadedFile.Tiplocs)
                        {
                            if (tl.Details.Zone == (res.Value is null ? null : int.Parse((String)res.Value)))
                            {
                                listBox1.Items.Add(tl.Name);
                            }
                        }

                        if (listBox1.Items.Count == 0)
                        {
                            MessageBox.Show("No matches found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        return;
                    }
                    case "BPlan_TimingPoint":
                    {
                        listBox1.Items.Clear();
                        var choice = TIPLOCSchemaProvider.ConvertToBPlan_TimingPoint((string)res.Value);
                        foreach (var tl in loadedFile.Tiplocs)
                        {
                            if (tl.Details.BPlan_TimingPoint == choice)
                            {
                                listBox1.Items.Add(tl.Name);
                            }
                        }

                        if (listBox1.Items.Count == 0)
                        {
                            MessageBox.Show("No matches found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        return;
                    }
                    case "TPS_StationType":
                    {
                        listBox1.Items.Clear();
                        var choice = TIPLOCSchemaProvider.ConvertToTPS_StationType((string)res.Value);
                        foreach (var tl in loadedFile.Tiplocs)
                        {
                            if (tl.Details.TPS_StationType == choice)
                            {
                                listBox1.Items.Add(tl.Name);
                            }
                        }

                        if (listBox1.Items.Count == 0)
                        {
                            MessageBox.Show("No matches found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        return;
                    }
                    case "TPS_StationCategory":
                    {
                        listBox1.Items.Clear();
                        var choice = TIPLOCSchemaProvider.ConvertToTPS_StationCategory((string)res.Value);
                        foreach (var tl in loadedFile.Tiplocs)
                        {
                            if (tl.Details.TPS_StationCategory == choice)
                            {
                                listBox1.Items.Add(tl.Name);
                            }
                        }

                        if (listBox1.Items.Count == 0)
                        {
                            MessageBox.Show("No matches found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        return;
                    }
                    case "ForceLPB":
                    {
                        listBox1.Items.Clear();
                        var choice = TIPLOCSchemaProvider.ConvertToForceLPB((string)res.Value);
                        foreach (var tl in loadedFile.Tiplocs)
                        {
                            if (tl.Details.ForceLPB == choice)
                            {
                                listBox1.Items.Add(tl.Name);
                            }
                        }

                        if (listBox1.Items.Count == 0)
                        {
                            MessageBox.Show("No matches found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        return;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            itemLengthLabel.Text = $"{listBox1.Items.Count} items visible";
            toolStripButton1.Enabled = toolStripTextBox1.Text != "";
        }

        private void alphabeticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alphabeticallyToolStripMenuItem.Checked)
            {
                alphabeticallyToolStripMenuItem.Checked = false;
                listBox1.Sorted = false;
            }
            else
            {
                alphabeticallyToolStripMenuItem.Checked = true;

            }
        }

        private void inspectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedFile == null || loadedFile.Tiplocs == null)
            {
                MessageBox.Show("No file loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBox1.SelectedIndex != -1)
            {
                foreach (var tl in loadedFile.Tiplocs)
                {
                    if (tl.Name == (string)listBox1.SelectedItem)
                    {
                        MessageBox.Show(
                            $"TIPLOC: {tl.Tiploc}\n Stanox: {tl.Stanox}\n InBPlan: {tl.InBPlan}\n InTPS: {tl.InTPS}\n IsTIPLOC: {tl.IsTiploc}\n Latitude: {tl.Latitude}\n Longitude: {tl.Longitude}\n BPlan_TimingPoint: {tl.Details.BPlan_TimingPoint}\n TPS_StationType: {tl.Details.TPS_StationType}\n TPS_StationCategory: {tl.Details.TPS_StationCategory}\n CRS: {tl.Details.CRS}\n Nalco: {tl.Details.Nalco}\n Off Network: {tl.Details.OffNetwork}\n ForceLPB: {tl.Details.ForceLPB}\n Compulsory Stop: {tl.Details.CompulsoryStop}\n UIC: {tl.Details.UIC}\n Zone: {tl.Details.Zone}",
                            $"Inspecting: {tl.Name}");
                    }
                }
            }
        }

        private void viewAssociatedCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedFile == null || loadedFile.Tiplocs == null)
            {
                MessageBox.Show("No file loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBox1.SelectedIndex != -1)
            {
                string codes = "";
                foreach (var tl in loadedFile.Tiplocs)
                {
                    if (tl.Name == (string)listBox1.SelectedItem)
                    {
                        foreach (var code in tl.Codes)
                        {
                            codes += $"{code}\n";
                        }

                        MessageBox.Show(codes, $"Codes Associated with {tl.Name}");
                    }
                }
            }
        }

        private void jumpToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedFile == null || loadedFile.Tiplocs == null)
            {
                MessageBox.Show("No file loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string input = Interaction.InputBox("Enter a value (exactly as it is displayed in the output area)",
                "Jump To");
            if (string.IsNullOrEmpty(input)) return;
            if (listBox1.Items.Contains(input))
            {
                listBox1.SelectedIndex = listBox1.Items.IndexOf(input);
                listBox1.Focus();
            }
            else
            {
                MessageBox.Show("Item not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void lINQQueryEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedFile == null || loadedFile.Tiplocs == null)
            {
                MessageBox.Show("Please load a file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lqe = new LINQQueryEditor();
            await lqe.ShowDialogAsync();
            if (lqe.DialogResult != DialogResult.OK) return;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var options = ScriptOptions.Default
                    .AddReferences(typeof(System.Linq.Enumerable).Assembly)
                    .AddReferences(typeof(JSONist.TIPLOCSchemaProvider).Assembly)
                    .AddImports("System", "System.Linq", "System.Collections.Generic", "JSONist");

                var globals = loadedFile;

                var result = await CSharpScript.EvaluateAsync<IEnumerable<TIPLOCSchemaProvider.TIPLOCObject>>(
                    lqe.LINQQuery,
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
                MessageBox.Show($"Query Error:\n{string.Join("\n", compileEx.Diagnostics)}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execution Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Cursor = Cursors.Default;
        }

        private void copyAssociatedCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedFile == null || loadedFile.Tiplocs == null)
            {
                MessageBox.Show("No file loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBox1.SelectedIndex != -1)
            {
                string codes = "";
                foreach (var tl in loadedFile.Tiplocs)
                {
                    if (tl.Name == (string)listBox1.SelectedItem)
                    {
                        foreach (var code in tl.Codes)
                        {
                            codes += $"{code}\n";
                        }

                        Clipboard.SetText(codes);
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string searchText = toolStripTextBox1.Text;
            int startIndex = listBox1.SelectedIndex;

            int index = listBox1.FindString(searchText, startIndex);

            if (index != -1 && index != startIndex)
            {
                listBox1.SelectedIndex = index;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (loadedFile == null || loadedFile.Tiplocs == null)
            {
                MessageBox.Show("No file loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            listBox1.Items.Clear();
            foreach (var tl in loadedFile.Tiplocs)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Would you like to open a file?", "Prompt", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
            {
                return;
            }

            openFile();
        }

        private void hasCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedFile == null || loadedFile.Tiplocs == null)
            {
                MessageBox.Show("No file loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string input = Interaction.InputBox("Enter a code", "Has Code");
            if (string.IsNullOrEmpty(input)) return;
            this.Cursor = Cursors.WaitCursor;
            listBox1.Items.Clear();
            foreach (var tl in loadedFile.Tiplocs)
            {
                if (tl.Codes.Contains(input) && !listBox1.Items.Contains(tl.Name))
                {
                    listBox1.Items.Add(tl.Name);
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void showItemsWithSameZoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedFile == null || loadedFile.Tiplocs == null)
            {
                MessageBox.Show("No file loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            int zone = 0;
            if (listBox1.SelectedIndex != -1)
            {
                string codes = "";
                foreach (var tl in loadedFile.Tiplocs)
                {
                    if (tl.Name == (string)listBox1.SelectedItem)
                    {
                        if (tl.Details.Zone is not null)
                        {
                            zone = (int)tl.Details.Zone;
                        }
                        else
                        {
                            MessageBox.Show("Zone is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Cursor = Cursors.Default;
                            return;
                        }

                        break;
                    }
                }
                listBox1.Items.Clear();
                foreach (var tl in loadedFile.Tiplocs)
                {
                    if (tl.Details.Zone == zone)
                    {
                        listBox1.Items.Add(tl.Name);
                    }
                }
            }

            this.Cursor = Cursors.Default;
        }
    }
}
