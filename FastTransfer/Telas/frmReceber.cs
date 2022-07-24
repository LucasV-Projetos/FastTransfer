using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace FastTransfer.Telas
{
    public partial class frmReceber : Form
    {
        public frmReceber()
        {
            InitializeComponent();
            txbCaminho.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void btnAlterarCaminho_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dlg = new CommonOpenFileDialog();
            dlg.IsFolderPicker = true;
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txbCaminho.Text = dlg.FileName;
            }



         
        }
    }
}
