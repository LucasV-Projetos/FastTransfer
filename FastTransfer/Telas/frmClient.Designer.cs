using System.Net;

namespace FastTransfer.Telas
{
    partial class frmClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txbArquivos = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnVerificarConexao = new System.Windows.Forms.Button();
            this.numericUpDownPorta = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.ipaddress = new IPAddressControlLib.IPAddressControl();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione os arquivos:";
            // 
            // txbArquivos
            // 
            this.txbArquivos.Enabled = false;
            this.txbArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbArquivos.Location = new System.Drawing.Point(214, 75);
            this.txbArquivos.Name = "txbArquivos";
            this.txbArquivos.Size = new System.Drawing.Size(240, 29);
            this.txbArquivos.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(208, 114);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(146, 31);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnVerificarConexao
            // 
            this.btnVerificarConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarConexao.Location = new System.Drawing.Point(403, 26);
            this.btnVerificarConexao.Name = "btnVerificarConexao";
            this.btnVerificarConexao.Size = new System.Drawing.Size(152, 28);
            this.btnVerificarConexao.TabIndex = 5;
            this.btnVerificarConexao.Text = "Verificar conexão";
            this.btnVerificarConexao.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPorta
            // 
            this.numericUpDownPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPorta.Location = new System.Drawing.Point(314, 26);
            this.numericUpDownPorta.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPorta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPorta.Name = "numericUpDownPorta";
            this.numericUpDownPorta.Size = new System.Drawing.Size(83, 28);
            this.numericUpDownPorta.TabIndex = 4;
            this.numericUpDownPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPorta.Value = new decimal(new int[] {
            777,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite o IP/porta:";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(460, 75);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(95, 29);
            this.btnSelecionar.TabIndex = 7;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // ipaddress
            // 
            this.ipaddress.AllowInternalTab = false;
            this.ipaddress.AutoHeight = false;
            this.ipaddress.BackColor = System.Drawing.SystemColors.Window;
            this.ipaddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipaddress.Location = new System.Drawing.Point(169, 26);
            this.ipaddress.MinimumSize = new System.Drawing.Size(126, 26);
            this.ipaddress.Name = "ipaddress";
            this.ipaddress.ReadOnly = false;
            this.ipaddress.Size = new System.Drawing.Size(139, 28);
            this.ipaddress.TabIndex = 8;
            this.ipaddress.Text = "127.0.0.1";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 185);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnVerificarConexao);
            this.Controls.Add(this.numericUpDownPorta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txbArquivos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipaddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmClient";
            this.Text = "Enviar arquivo";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbArquivos;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnVerificarConexao;
        private System.Windows.Forms.NumericUpDown numericUpDownPorta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelecionar;
        private IPAddressControlLib.IPAddressControl ipaddress;
    }
}