using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryObregonBiblioteca
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void bibliotecaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBiblioteca frm = new frmBiblioteca();
            frm.ShowDialog();
        }
    }
}
