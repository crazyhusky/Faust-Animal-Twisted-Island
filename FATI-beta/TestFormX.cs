using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FATIbeta.src.UI;

namespace FATIbeta
{
    public partial class TestFormX : Form
    {
        public winformLink winformInterface;
        public TestFormX()
        {
            InitializeComponent();
            winformInterface = new winformLink(this);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBoxSub_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

        }

        private void btnOptions_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        public void SetworldText(string text)
        {
            this.richTextBoxMain.Text = text;
        }

        public void SetPlayerText(string text)
        {
            this.richTextBoxSub.Text = text;
        }

        public void UpdatePlayerHealth(float newhealth, float maxhealth)
        {
            this.labelHP.Text = newhealth.ToString();
            this.progressBarHP.Maximum = (int) maxhealth;
            this.progressBarHP.Value = (int) newhealth;
        }
        public void UpdatePlayerFatigue(float newFatique, float maxfatique)
        {
            this.labelfatigue.Text = newFatique.ToString();
            this.progressBarfatigue.Maximum = (int) maxfatique;
            this.progressBarHP.Value = (int) newFatique;
        }
        public void UpdatePlayerLust(float newLust, float maxLust)
        {
            this.labelLust.Text = newLust.ToString();
            this.progressBarLust.Maximum = (int)maxLust;
            this.progressBarLust.Value = (int)newLust;
        }
    }
}
