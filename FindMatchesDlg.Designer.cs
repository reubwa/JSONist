namespace JSONist
{
    partial class FindMatchesDlg
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
            label1 = new Label();
            selectCbx = new ComboBox();
            label2 = new Label();
            whereCbx = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            freeformNullRDB = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Select";
            // 
            // selectCbx
            // 
            selectCbx.FormattingEnabled = true;
            selectCbx.Items.AddRange(new object[] { "Stanox", "CRS", "Nalco", "UIC", "Zone", "BPlan_TimingPoint", "TPS_StationType", "TPS_StationCategory", "ForceLPB" });
            selectCbx.Location = new Point(113, 49);
            selectCbx.Name = "selectCbx";
            selectCbx.Size = new Size(639, 40);
            selectCbx.TabIndex = 1;
            selectCbx.SelectedIndexChanged += selectCbx_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 2;
            label2.Text = "Where Value is";
            // 
            // whereCbx
            // 
            whereCbx.Enabled = false;
            whereCbx.FormattingEnabled = true;
            whereCbx.Location = new Point(190, 138);
            whereCbx.Name = "whereCbx";
            whereCbx.Size = new Size(562, 40);
            whereCbx.TabIndex = 3;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(602, 268);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 4;
            button1.Text = "&Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(446, 268);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 5;
            button2.Text = "&Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(190, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(562, 39);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // freeformNullRDB
            // 
            freeformNullRDB.AutoSize = true;
            freeformNullRDB.Enabled = false;
            freeformNullRDB.Location = new Point(190, 273);
            freeformNullRDB.Name = "freeformNullRDB";
            freeformNullRDB.Size = new Size(89, 36);
            freeformNullRDB.TabIndex = 7;
            freeformNullRDB.TabStop = true;
            freeformNullRDB.Text = "Null";
            freeformNullRDB.UseVisualStyleBackColor = true;
            // 
            // FindMatchesDlg
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 333);
            Controls.Add(freeformNullRDB);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(whereCbx);
            Controls.Add(label2);
            Controls.Add(selectCbx);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FindMatchesDlg";
            Text = "Find Matches";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox selectCbx;
        private Label label2;
        private ComboBox whereCbx;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private RadioButton freeformNullRDB;
    }
}