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
    public partial class FFilles : Form
    {
        private string monNom;
        private FMere maMere;
        public FFilles(FMere meMere, int numero)
        {
            InitializeComponent();
            this.Text = "Fille";
            this.Text = "Fille n°" + numero;
            this.monNom = this.Text;
            this.maMere = maMere;
            this.Load += new EventHandler(FFilles_Load);
        }

        private void FFilles_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            MessageBox.Show("Evenement Load sur " + this.monNom);
        }

        private void textFille_TextChanged(object sender, EventArgs e)
        {
            string nouveauNom;
        }

        private void btnChanger_Click(object sender, EventArgs e)
        {
       
        }
    }
}
