using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JSONist
{
    public partial class FindMatchesDlg : Form
    {
        public FindMatchesDlg()
        {
            InitializeComponent();
        }
        public KeyValuePair<string, Object?> SelectedData { get; private set; }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selection = selectCbx.Text;
            if (selection == "Stanox" || selection == "CRS" || selection == "Nalco" || selection == "UIC" || selection == "Zone")
            {
                textBox1.Enabled = true;
                whereCbx.Enabled = false;
                freeformNullRDB.Enabled = true;
                this.ActiveControl = textBox1;
                return;
            }
            whereCbx.Items.Clear();
            if (selection == "BPlan_TimingPoint")
            {
                foreach (var val in Enum.GetValues<TIPLOCSchemaProvider.BPTP>())
                {
                    whereCbx.Items.Add(val);
                }
            }

            if (selection == "TPS_StationType")
            {
                foreach (var val in Enum.GetValues<TIPLOCSchemaProvider.StationType>())
                {
                    whereCbx.Items.Add(val);
                }
            }

            if (selection == "TPS_StationCategory")
            {
                foreach (var val in Enum.GetValues<TIPLOCSchemaProvider.StationCategory>())
                {
                    whereCbx.Items.Add(val);
                }
            }

            if (selection == "ForceLPB")
            {
                foreach (var val in Enum.GetValues<TIPLOCSchemaProvider.ForceLPB>())
                {
                    whereCbx.Items.Add(val);
                }
            }

            textBox1.Enabled = false;
            freeformNullRDB.Enabled = false;
            whereCbx.Enabled = true;
            this.ActiveControl = whereCbx;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            freeformNullRDB.Enabled = textBox1.Text == "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedData =  new KeyValuePair<string, object>(selectCbx.Text, textBox1.Enabled ? freeformNullRDB.Checked ? null : textBox1.Text : whereCbx.Text);
            this.Close();
        }
    }
}
