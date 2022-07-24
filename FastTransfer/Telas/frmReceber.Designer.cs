using System;

namespace FastTransfer.Telas
{
    partial class frmReceber
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
            this.numericUpDownPorta = new System.Windows.Forms.NumericUpDown();
            this.btnAbrirConexao = new System.Windows.Forms.Button();
            this.txbCaminho = new System.Windows.Forms.TextBox();
            this.btnAlterarCaminho = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a porta:";
            // 
            // numericUpDownPorta
            // 
            this.numericUpDownPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPorta.Location = new System.Drawing.Point(179, 35);
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
            this.numericUpDownPorta.Size = new System.Drawing.Size(77, 27);
            this.numericUpDownPorta.TabIndex = 1;
            this.numericUpDownPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPorta.Value = new decimal(new int[] {
            777,
            0,
            0,
            0});
            // 
            // btnAbrirConexao
            // 
            this.btnAbrirConexao.Location = new System.Drawing.Point(272, 33);
            this.btnAbrirConexao.Name = "btnAbrirConexao";
            this.btnAbrirConexao.Size = new System.Drawing.Size(90, 29);
            this.btnAbrirConexao.TabIndex = 2;
            this.btnAbrirConexao.Text = "Abrir Conexão";
            this.btnAbrirConexao.UseVisualStyleBackColor = true;
            // 
            // txbCaminho
            // 
            this.txbCaminho.Enabled = false;
            this.txbCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCaminho.Location = new System.Drawing.Point(17, 103);
            this.txbCaminho.Name = "txbCaminho";
            this.txbCaminho.Size = new System.Drawing.Size(239, 26);
            this.txbCaminho.TabIndex = 3;
            // 
            // btnAlterarCaminho
            // 
            this.btnAlterarCaminho.Location = new System.Drawing.Point(272, 103);
            this.btnAlterarCaminho.Name = "btnAlterarCaminho";
            this.btnAlterarCaminho.Size = new System.Drawing.Size(90, 29);
            this.btnAlterarCaminho.TabIndex = 4;
            this.btnAlterarCaminho.Text = "Alterar";
            this.btnAlterarCaminho.UseVisualStyleBackColor = true;
            this.btnAlterarCaminho.Click += new System.EventHandler(this.btnAlterarCaminho_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Receber arquivos neste diretoório:";
            // 
            // frmReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 162);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAlterarCaminho);
            this.Controls.Add(this.txbCaminho);
            this.Controls.Add(this.btnAbrirConexao);
            this.Controls.Add(this.numericUpDownPorta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReceber";
            this.Text = "Receber Arquivos";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPorta;
        private System.Windows.Forms.Button btnAbrirConexao;
        private System.Windows.Forms.TextBox txbCaminho;
        private System.Windows.Forms.Button btnAlterarCaminho;
        private System.Windows.Forms.Label label2;
    }
}