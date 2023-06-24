using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba21_OOP
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        public int openDocuments = 0;

        private void новийToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            blank frm = new blank();
            frm.BlankName = "Лист " + ++openDocuments;
            frm.Text = frm.BlankName;
            frm.MdiParent = this;
            frm.Show();
        }

        private void впорядкуватиЗначкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void theHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void theVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}

