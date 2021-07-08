using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exameen
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void NuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmC = new Form1();
            frmC.MdiParent = this.MdiParent;
            frmC.Show();
        }

        private void Frm_Load(object sender, EventArgs e)
        {

        }
    }
}
