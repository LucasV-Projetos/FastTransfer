using FastTransfer.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastTransfer
{
    public partial class frmPrincpal : Form
    {
        public frmPrincpal()
        {
            InitializeComponent();
        }     

        private bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                    return true;
            return false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof (frmEnviar)))
            {

            }
            if (!IsFormOpen(typeof(frmEnviar)))
            {
                Form frmEnviar = new frmEnviar();
                frmEnviar.Show();
            }            
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(frmReceber)))
            {

            }
            if (!IsFormOpen(typeof(frmReceber)))
            {
                Form frmReceber = new frmReceber();
                frmReceber.Show();
            }
        }
    }
}
