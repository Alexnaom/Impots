using System.Diagnostics.Metrics;

namespace TAX_Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(0);
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            // raz formulaire
            labelImpot.Text = "";
            numericUpDownEnfants.Value = 0;
            textSalaire.Text = "";
            radioButtonNon.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // état bouton [Calculer]
            buttonCalculer.Enabled = textSalaire.Text.Trim() != "";
        }
    }
}