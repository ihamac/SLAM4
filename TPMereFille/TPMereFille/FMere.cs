 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPMereFille
{
    
    public partial class FMere : Form
        
    {
        private List<FFilles> lesFilles;
        private int nombreFille;
        private string nomMere;

        public FMere()
        {
            InitializeComponent();
            this.Text = "Mère";
            this.nomMere = "Maman";
            lesFilles = new List<FFilles>();
            btnNew.Click += this.BtnNew_Click;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FFilles nouvelleFille;
            nombreFille = nombreFille + 1;
            nouvelleFille = new FFilles(this,nombreFille);
            lesFilles.Add(nouvelleFille);
            lbLesFilles.Items.Add("Fille n°" + this.nombreFille);
        }

        private void btsShow_Click(object sender, EventArgs e)
        {
            if(lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Show();
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Close();
                lbLesFilles.Items.RemoveAt(lbLesFilles.SelectedIndex);
            }

        }

        private void FMere_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {

        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].ShowDialog();
            }

        }

        public void MaFilleChangeDeNom(FFilles fille, string nouveauNom)
        {

        }
    }
}
