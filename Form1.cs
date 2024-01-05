using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormsCviko {
    public partial class Form1 : Form {
        private const String numRegEx = @"^-?\d*$";
        private String textBoxNum1Text = "";
        private String textBoxNum2Text = "";
        public Form1() {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e) {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            updateLabelSummary();
        }

        private void nápovìdaToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Toto je nápovìda", "Nápovìda");
        }

        private void otevøítToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            textBoxFile.Text = "";
            using (StreamReader FileStreamR = new(openFileDialog1.FileName)) {
                while (!FileStreamR.EndOfStream) {
                    textBoxFile.AppendText(FileStreamR.ReadLine() + System.Environment.NewLine);
                }
            }
        }

        private void uložitToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            using (StreamWriter fileStreamW = new(saveFileDialog1.FileName)) {
                fileStreamW.Write(textBoxFile.Text);
            };
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }

        private void updateLabelSummary() {
            labelSummary.Text = numericUpDown1.Value.ToString()
                + " "
                + comboBoxType.Text
                + " "
                + (checkBoxShiny.Checked ? "lesklý povrch " : "")
                + getMaterialSelection();

        }

        private string getMaterialSelection() {
            if(radioButtonMetal.Checked) {
                return "kov";
            } else if(radioButtonWood.Checked) {
                return "døevo";
            } else if (radioButtonPlastic.Checked) {
                return "plast";
            }
            return "";
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e) {
            updateLabelSummary();
        }

        private void comboBoxType_TextChanged(object sender, EventArgs e) {
            updateLabelSummary();
        }

        private void radioButtonMetal_CheckedChanged(object sender, EventArgs e) {
            updateLabelSummary();
        }

        private void radioButtonWood_CheckedChanged(object sender, EventArgs e) {
            updateLabelSummary();
        }

        private void radioButtonPlastic_CheckedChanged(object sender, EventArgs e) {
            updateLabelSummary();
        }

        private void checkBoxShiny_CheckedChanged(object sender, EventArgs e) {
            updateLabelSummary();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            updateLabelSummary();
        }

        private int getNumericVal(string s) {
            if (s.Length == 0 || (s.Contains("-") && s.Length == 1)) {
                return 0;
            }
            else {
                return int.Parse(s);
            }
        }

        private void updateLabelResult() {
            int total = getNumericVal(textBoxNum1.Text) + getNumericVal(textBoxNum2.Text);
            if(total > 0) {
                labelResult.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            } else {
                labelResult.Font = new Font("Segoe UI", 9);
            }
            labelResult.Text = total.ToString();
        }

        private void textBoxNum1_TextChanged(object sender, EventArgs e) {
            if (Regex.IsMatch(textBoxNum1.Text, numRegEx)) {
                textBoxNum1Text = textBoxNum1.Text;
            }
            else {
                textBoxNum1.Text = textBoxNum1Text;
            }
        }

        private void textBoxNum2_TextChanged(object sender, EventArgs e) {
            if (Regex.IsMatch(textBoxNum2.Text, numRegEx)) {
                textBoxNum2Text = textBoxNum2.Text;
            }
            else {
                textBoxNum2.Text = textBoxNum2Text;
            }
        }

        private void buttonResult_Click(object sender, EventArgs e) {
            updateLabelResult();
        }

        private void timerProgressBar_Tick(object sender, EventArgs e) {
            progressBar1.PerformStep();
            labelProgressBar.Text = "Instalace probíhá, èekejte... " + ((Double)(progressBar1.Maximum - progressBar1.Value) / 20.0).ToString("0") + " s";
            if (progressBar1.Value == progressBar1.Maximum) {
                timerProgressBar.Stop();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            labelTrackBar.Text = trackBar1.Value.ToString();
        }

        private void timerSeconds_Tick(object sender, EventArgs e) {
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

       
    }
}