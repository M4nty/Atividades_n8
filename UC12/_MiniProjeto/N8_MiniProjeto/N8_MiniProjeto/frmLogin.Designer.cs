﻿namespace N8_MiniProjeto
{
    partial class frmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.btoOK = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Senha";
            // 
            // btoOK
            // 
            this.btoOK.Location = new System.Drawing.Point(289, 146);
            this.btoOK.Name = "btoOK";
            this.btoOK.Size = new System.Drawing.Size(81, 34);
            this.btoOK.TabIndex = 2;
            this.btoOK.Text = "OK";
            this.btoOK.UseVisualStyleBackColor = true;
            this.btoOK.Click += new System.EventHandler(this.btoOK_Click);
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(376, 146);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(81, 34);
            this.btoSair.TabIndex = 3;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(12, 37);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(445, 32);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "admin";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(12, 108);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(445, 32);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "123";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btoOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.CancelButton = this.btoSair;
            this.ClientSize = new System.Drawing.Size(467, 197);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Estoque";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btoOK;
        private Button btoSair;
        private TextBox txtUsuario;
        private TextBox txtSenha;
    }
}