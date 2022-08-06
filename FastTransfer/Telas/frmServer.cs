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
        private bool isOpened;    
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
            isOpened = !isOpened;
            if (isOpened)
            {
                Server.OpenPort((int)numericUpDownPorta.Value);
                btnAbrirConexao.Text = "Fechar conexão";
                numericUpDownPorta.Enabled = false;
                Server.NameAndSize(txbCaminho.Text);
            }
            if (!isOpened)
            {
                btnAbrirConexao.Text = "Abrir conexão";
                numericUpDownPorta.Enabled = true;
                Server.ClosePort();
            }
        }
    }
}
