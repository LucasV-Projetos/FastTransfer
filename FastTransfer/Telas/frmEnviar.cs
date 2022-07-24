using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastTransfer.Telas
{
    public partial class frmEnviar : Form
    {
        public frmEnviar()
        {
            InitializeComponent();
        }


        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            {
                opd.InitialDirectory = "C:\\";
                opd.RestoreDirectory = true;
                opd.Multiselect = false;
                opd.FilterIndex = 1;
                opd.Filter = "Todos os arquivos (*.*)|*.*|" +
                    "Arquivos de texto (*.txt)|*.txt|" +
                    "Imagens (*.BMP;*.JPG;*.GIF;*.PNG;*.WEBP)|*.BMP;*.JPG;*.GIF;*.PNG;*.WEBP|" +
                    "Vídeos (*.MP4;*.AVI;*.WMV;*.WEBM)|*.MP4;*.AVI;*.WMV;*.WEBM";
            }
            if (opd.ShowDialog() == DialogResult.OK)
            {
                txbArquivos.Text = opd.FileName;
            }
        }
    }
}
