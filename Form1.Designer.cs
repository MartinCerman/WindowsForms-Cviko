namespace FormsCviko {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelTrackBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timerSeconds = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProgressBar = new System.Windows.Forms.Label();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxShiny = new System.Windows.Forms.CheckBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.groupBoxMaterials = new System.Windows.Forms.GroupBox();
            this.radioButtonPlastic = new System.Windows.Forms.RadioButton();
            this.radioButtonWood = new System.Windows.Forms.RadioButton();
            this.radioButtonMetal = new System.Windows.Forms.RadioButton();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otevřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelSummary = new System.Windows.Forms.Label();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxMaterials.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelTrackBar,
            this.labelTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(667, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelTrackBar
            // 
            this.labelTrackBar.Name = "labelTrackBar";
            this.labelTrackBar.Size = new System.Drawing.Size(13, 17);
            this.labelTrackBar.Text = "0";
            // 
            // labelTime
            // 
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(49, 17);
            this.labelTime.Text = "16:35:25";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(408, 216);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timerSeconds
            // 
            this.timerSeconds.Enabled = true;
            this.timerSeconds.Interval = 1000;
            this.timerSeconds.Tick += new System.EventHandler(this.timerSeconds_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(40, 400);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(184, 23);
            this.progressBar1.Step = 4;
            this.progressBar1.TabIndex = 2;
            // 
            // labelProgressBar
            // 
            this.labelProgressBar.AutoSize = true;
            this.labelProgressBar.Location = new System.Drawing.Point(40, 424);
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.Size = new System.Drawing.Size(152, 15);
            this.labelProgressBar.TabIndex = 3;
            this.labelProgressBar.Text = "Instalace probíhá, čekejte... ";
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(400, 80);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(56, 23);
            this.textBoxNum1.TabIndex = 4;
            this.textBoxNum1.TextChanged += new System.EventHandler(this.textBoxNum1_TextChanged);
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(496, 80);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(56, 23);
            this.textBoxNum2.TabIndex = 5;
            this.textBoxNum2.TextChanged += new System.EventHandler(this.textBoxNum2_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(464, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "+";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(400, 160);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(32, 23);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kolik kusů? (max 3)";
            // 
            // checkBoxShiny
            // 
            this.checkBoxShiny.AutoSize = true;
            this.checkBoxShiny.Location = new System.Drawing.Point(400, 128);
            this.checkBoxShiny.Name = "checkBoxShiny";
            this.checkBoxShiny.Size = new System.Drawing.Size(103, 19);
            this.checkBoxShiny.TabIndex = 9;
            this.checkBoxShiny.Text = "Lesklý povrch?";
            this.checkBoxShiny.UseVisualStyleBackColor = true;
            this.checkBoxShiny.CheckedChanged += new System.EventHandler(this.checkBoxShiny_CheckedChanged);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(568, 80);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(32, 23);
            this.buttonResult.TabIndex = 10;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // groupBoxMaterials
            // 
            this.groupBoxMaterials.Controls.Add(this.radioButtonPlastic);
            this.groupBoxMaterials.Controls.Add(this.radioButtonWood);
            this.groupBoxMaterials.Controls.Add(this.radioButtonMetal);
            this.groupBoxMaterials.Location = new System.Drawing.Point(256, 56);
            this.groupBoxMaterials.Name = "groupBoxMaterials";
            this.groupBoxMaterials.Size = new System.Drawing.Size(128, 100);
            this.groupBoxMaterials.TabIndex = 11;
            this.groupBoxMaterials.TabStop = false;
            this.groupBoxMaterials.Text = "Zvolte materiál:";
            // 
            // radioButtonPlastic
            // 
            this.radioButtonPlastic.AutoSize = true;
            this.radioButtonPlastic.Location = new System.Drawing.Point(24, 72);
            this.radioButtonPlastic.Name = "radioButtonPlastic";
            this.radioButtonPlastic.Size = new System.Drawing.Size(58, 19);
            this.radioButtonPlastic.TabIndex = 2;
            this.radioButtonPlastic.TabStop = true;
            this.radioButtonPlastic.Text = "PLAST";
            this.radioButtonPlastic.UseVisualStyleBackColor = true;
            this.radioButtonPlastic.CheckedChanged += new System.EventHandler(this.radioButtonPlastic_CheckedChanged);
            // 
            // radioButtonWood
            // 
            this.radioButtonWood.AutoSize = true;
            this.radioButtonWood.Location = new System.Drawing.Point(24, 48);
            this.radioButtonWood.Name = "radioButtonWood";
            this.radioButtonWood.Size = new System.Drawing.Size(62, 19);
            this.radioButtonWood.TabIndex = 1;
            this.radioButtonWood.TabStop = true;
            this.radioButtonWood.Text = "DŘEVO";
            this.radioButtonWood.UseVisualStyleBackColor = true;
            this.radioButtonWood.CheckedChanged += new System.EventHandler(this.radioButtonWood_CheckedChanged);
            // 
            // radioButtonMetal
            // 
            this.radioButtonMetal.AutoSize = true;
            this.radioButtonMetal.Location = new System.Drawing.Point(24, 24);
            this.radioButtonMetal.Name = "radioButtonMetal";
            this.radioButtonMetal.Size = new System.Drawing.Size(47, 19);
            this.radioButtonMetal.TabIndex = 0;
            this.radioButtonMetal.TabStop = true;
            this.radioButtonMetal.Text = "KOV";
            this.radioButtonMetal.UseVisualStyleBackColor = true;
            this.radioButtonMetal.CheckedChanged += new System.EventHandler(this.radioButtonMetal_CheckedChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "židle",
            "skříň",
            "police"});
            this.comboBoxType.Location = new System.Drawing.Point(40, 160);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(104, 23);
            this.comboBoxType.TabIndex = 12;
            this.comboBoxType.Text = "židle";
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            this.comboBoxType.TextChanged += new System.EventHandler(this.comboBoxType_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Zvolte typ výrobku:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tlačítko pro ukončení nebo stiskni ESC";
            // 
            // button1
            // 
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(72, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 55);
            this.button1.TabIndex = 15;
            this.toolTip1.SetToolTip(this.button1, "Ukončit program");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "kytka.jpg");
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(40, 200);
            this.textBoxFile.Multiline = true;
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(184, 144);
            this.textBoxFile.TabIndex = 16;
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(608, 80);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(21, 23);
            this.labelResult.TabIndex = 17;
            this.labelResult.Text = "0";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nápovědaToolStripMenuItem,
            this.souborToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.nápovědaToolStripMenuItem.Text = "Nápověda";
            this.nápovědaToolStripMenuItem.Click += new System.EventHandler(this.nápovědaToolStripMenuItem_Click);
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otevřítToolStripMenuItem,
            this.uložitToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // otevřítToolStripMenuItem
            // 
            this.otevřítToolStripMenuItem.Name = "otevřítToolStripMenuItem";
            this.otevřítToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.otevřítToolStripMenuItem.Text = "Otevřít";
            this.otevřítToolStripMenuItem.Click += new System.EventHandler(this.otevřítToolStripMenuItem_Click);
            // 
            // uložitToolStripMenuItem
            // 
            this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
            this.uložitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.uložitToolStripMenuItem.Text = "Uložit";
            this.uložitToolStripMenuItem.Click += new System.EventHandler(this.uložitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Všechny soubory|*.*|Textový soubor|*.txt";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(40, 360);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(31, 15);
            this.labelSummary.TabIndex = 19;
            this.labelSummary.Text = "židle";
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Enabled = true;
            this.timerProgressBar.Interval = 200;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(667, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Cerman_zk.Properties.Resources.kytka;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(667, 465);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.groupBoxMaterials);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.checkBoxShiny);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Controls.Add(this.labelProgressBar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Martin Čerman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxMaterials.ResumeLayout(false);
            this.groupBoxMaterials.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelTrackBar;
        private ToolStripStatusLabel labelTime;
        private TrackBar trackBar1;
        private System.Windows.Forms.Timer timerSeconds;
        private ProgressBar progressBar1;
        private Label labelProgressBar;
        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private CheckBox checkBoxShiny;
        private Button buttonResult;
        private GroupBox groupBoxMaterials;
        private RadioButton radioButtonPlastic;
        private RadioButton radioButtonWood;
        private RadioButton radioButtonMetal;
        private ComboBox comboBoxType;
        private Label label3;
        private Label label4;
        private Button button1;
        private ImageList imageList1;
        private TextBox textBoxFile;
        private Label labelResult;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nápovědaToolStripMenuItem;
        private ToolStripMenuItem souborToolStripMenuItem;
        private ToolStripMenuItem otevřítToolStripMenuItem;
        private ToolStripMenuItem uložitToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Label labelSummary;
        private System.Windows.Forms.Timer timerProgressBar;
        private ToolTip toolTip1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
    }
}