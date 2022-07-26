﻿using FastTransfer.Telas;
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
            if (IsFormOpen(typeof (frmClient)))
            {

            }
            if (!IsFormOpen(typeof(frmClient)))
            {
                Form frmEnviar = new frmClient();
                frmEnviar.Show();
            }            
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(frmServer)))
            {

            }
            if (!IsFormOpen(typeof(frmServer)))
            {
                Form frmReceber = new frmServer();
                frmReceber.Show();
            }
        }
    }
}
