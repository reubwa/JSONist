using System.Text.Json;

namespace JSONist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public TIPLOCSchemaProvider.Jfile loadedFile;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
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
                }
                catch (IOException ioException)
                {
                    MessageBox.Show(ioException.Message);
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void codesToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        }

        private void exportToTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, listBox1.Items.Cast<string>());
            }
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var tl in loadedFile.Tiplocs)
            {
                if (!listBox1.Items.Contains(tl.Name))
                {
                    listBox1.Items.Add(tl.Name);
                }
            }
        }
    }
}
