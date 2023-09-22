using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class Resturant : Form
    {
        Add_Item AdI;Edit_Item EI;Delete_Item DI; New_User NU; Delete_User DU; Change_Password cngPass;
        View_Users VU; Bill_Master BM; Bill_Trans BT;View_Bill VB;
        private int childFormNumber = 0;

        public Resturant()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menAddItem_Click(object sender, EventArgs e)
        {
            if (AdI == null|| AdI.IsDisposed)
            {
                AdI = new Add_Item();
                AdI.MdiParent = this;
            }
            AdI.Show();

        }

        private void menEditItem_Click(object sender, EventArgs e)
        {
            if (EI == null|| EI.IsDisposed)
                EI = new Edit_Item();
                EI.MdiParent = this;
            EI.Show();
        }

        private void menDeleteItem_Click(object sender, EventArgs e)
        {
            if (DI == null|| DI.IsDisposed)
                DI = new Delete_Item();
                DI.MdiParent = this;
            DI.Show();
        }

        private void menAdUser_Click(object sender, EventArgs e)
        {
            if(NU==null|| NU.IsDisposed)
                NU = new New_User();
                NU.MdiParent = this;
            NU.Show();
        }

        private void menDeleteUser_Click(object sender, EventArgs e)
        {
            if(DU==null|| DU.IsDisposed)
                DU = new Delete_User();
                DU.MdiParent = this;
            DU.Show();
        }

        private void menCngPass_Click(object sender, EventArgs e)
        {
            if (cngPass == null || cngPass.IsDisposed)
                cngPass = new Change_Password();
                cngPass.MdiParent = this;
            cngPass.Show();
        }

        private void menViewUser_Click(object sender, EventArgs e)
        {   
            if (VU == null || VU.IsDisposed)
                VU = new View_Users();
                VU.MdiParent = this;
            VU.Show();
        }

        private void menExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menNewBill_Click(object sender, EventArgs e)
        {   
            if(BM == null || BM.IsDisposed)
                BM = new Bill_Master();
                BM.MdiParent = this;
            BM.Show();
            
        }

        private void menViewBill_Click(object sender, EventArgs e)
        {
            if (VB == null || VB.IsDisposed)
                VB = new View_Bill();
                VB.MdiParent = this;
            VB.Show();
        }
    }
}
