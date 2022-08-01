using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastTransfer.Classes;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace FastTransfer.Telas
{   

    
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
            txbCaminho.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Nova Pasta\";
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

        private void btnAbrirConexao_Click(object sender, EventArgs e)
        {
            Server.OpenPort((int)numericUpDownPorta.Value);
            btnAbrirConexao.Visible = false;
            btnFecharConexao.Visible = true;
            numericUpDownPorta.Enabled = false;
            Server.NameAndSize(txbCaminho.Text);
        }

        private void btnFecharConexao_Click(object sender, EventArgs e)
        {
            Server.ClosePort();
            btnFecharConexao.Visible = false;
            btnAbrirConexao.Visible = true;
            numericUpDownPorta.Enabled = true;
        }
        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Server.ClosePort();
        }

    }
}
