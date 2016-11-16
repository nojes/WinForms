using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_MDIIEnterface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childForm = new ChildForm { MdiParent = this };
            childForm.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cascadeWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileWindowsHorisontalyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileWindowsVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren) {
                child.Close();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
//            Form activeForm = this.ActiveMdiChild;
//            if (activeForm != null)
//            {
//                RichTextBox richTextBox = (RichTextBox)activeForm.ActiveControl;
//                if (richTextBox != null)
//                {
//                    Clipboard.SetDataObject(richTextBox.SelectedText);
//                }
//            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
//            Form activeForm = this.ActiveMdiChild;
//            if (activeForm != null)
//            {
//                RichTextBox richTextBox = (RichTextBox)Clipboard.GetDataObject();
//                if (richTextBox != null)
//                {
//                    richTextBox.SelectedText = richTextBox.SelectedText;
//                }
//            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
