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

        public TIPLOCSchemaProvider.Jfile loadedFile;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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
                            MessageBox.Show("Null exception occured");
                            return;
                        }
                        var res2 = (JsonException)res;
                        MessageBox.Show(res2.Message);
                        return;
                    }

                    loadedFile = (TIPLOCSchemaProvider.Jfile)res;
                    fileNameLabel.Text = $"{openFileDialog1.FileName} loaded,";
                }
                catch (IOException ioException)
                {
                    MessageBox.Show(ioException.Message);
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void codesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedFile == null || loadedFile.Tiplocs == null)
            {
                MessageBox.Show("No file loaded.");
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

        private void exportToTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedFile == null || loadedFile.Tiplocs == null)
            {
                MessageBox.Show("No file loaded.");
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
            if (loadedFile == null || loadedFile.Tiplocs == null)
            {
                MessageBox.Show("No file loaded.");
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
                MessageBox.Show("No file loaded.");
                return;
            }
            var fmd = new FindMatchesDlg();
            fmd.ShowDialog();
            if (fmd.DialogResult != DialogResult.OK)
            {
                return;
            }

            var res = fmd.SelectedData;
            var selection = res.Key;
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
                            MessageBox.Show("No matches found!");
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
                            MessageBox.Show("No matches found!");
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
                            MessageBox.Show("No matches found!");
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
                            MessageBox.Show("No matches found!");
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
                            MessageBox.Show("No matches found!");
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
                            MessageBox.Show("No matches found!");
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
                            MessageBox.Show("No matches found!");
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
                            MessageBox.Show("No matches found!");
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
                            MessageBox.Show("No matches found!");
                        }
                        return;
                    }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            itemLengthLabel.Text = $"{listBox1.Items.Count} items visible";
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
                MessageBox.Show("No file loaded.");
                return;
            }
            if (listBox1.SelectedIndex != -1)
            {
                TIPLOCSchemaProvider.TIPLOCObject selected;
                foreach (var tl in loadedFile.Tiplocs)
                {
                    if (tl.Name == (string)listBox1.SelectedItem)
                    {
                        MessageBox.Show($"TIPLOC: {tl.Tiploc}\n Stanox: {tl.Stanox}\n InBPlan: {tl.InBPlan}\n InTPS: {tl.InTPS}\n IsTIPLOC: {tl.IsTiploc}\n Latitude: {tl.Latitude}\n Longitude: {tl.Longitude}\n BPlan_TimingPoint: {tl.Details.BPlan_TimingPoint}\n TPS_StationType: {tl.Details.TPS_StationType}\n TPS_StationCategory: {tl.Details.TPS_StationCategory}\n CRS: {tl.Details.CRS}\n Nalco: {tl.Details.Nalco}\n Off Network: {tl.Details.OffNetwork}\n ForceLPB: {tl.Details.ForceLPB}\n Compulsory Stop: {tl.Details.CompulsoryStop}\n UIC: {tl.Details.UIC}\n Zone: {tl.Details.Zone}", $"Inspecting: {tl.Name}");
                    }
                }
            }
        }

        private void viewAssociatedCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedFile == null || loadedFile.Tiplocs == null)
            {
                MessageBox.Show("No file loaded.");
                return;
            }
            if (listBox1.SelectedIndex != -1)
            {
                TIPLOCSchemaProvider.TIPLOCObject selected;
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
                MessageBox.Show("No file loaded.");
                return;
            }
            string input = Interaction.InputBox("Enter a value (exactly as it is displayed in the output area)", "Jump To");
            if (!string.IsNullOrEmpty(input))
            {
                if (listBox1.Items.Contains(input))
                {
                    listBox1.SelectedIndex = listBox1.Items.IndexOf(input);
                    listBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Item not found!");
                }
            }
        }
    }
}
