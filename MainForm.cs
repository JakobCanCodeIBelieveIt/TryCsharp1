using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCsharp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCheckGenome_Click(object sender, EventArgs e)
        {
            GenomeCheckerForm genomeCheckerForm = new GenomeCheckerForm();
            genomeCheckerForm.Show();
            this.Hide();
        }

        private void btnSimulation_Click(object sender, EventArgs e)
        {
            SimulationForm simulationForm = new SimulationForm();
            simulationForm.Show();
            this.Hide();
        }
    }
}
