﻿namespace WinFormsApp2
{
    partial class frmCalculoEscolar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btoSair = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoCalcular = new System.Windows.Forms.Button();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(320, 122);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(107, 36);
            this.btoSair.TabIndex = 19;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(320, 81);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(107, 36);
            this.btoLimpar.TabIndex = 18;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoCalcular
            // 
            this.btoCalcular.Location = new System.Drawing.Point(320, 42);
            this.btoCalcular.Name = "btoCalcular";
            this.btoCalcular.Size = new System.Drawing.Size(107, 36);
            this.btoCalcular.TabIndex = 17;
            this.btoCalcular.Text = "Calcular";
            this.btoCalcular.UseVisualStyleBackColor = true;
            this.btoCalcular.Click += new System.EventHandler(this.btoCalcular_Click);
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(243, 42);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(71, 36);
            this.txtN4.TabIndex = 16;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(166, 42);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(71, 36);
            this.txtN3.TabIndex = 15;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(89, 42);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(71, 36);
            this.txtN2.TabIndex = 14;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(12, 42);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(71, 36);
            this.txtN1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "N4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "N3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "N2";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblStatus.Location = new System.Drawing.Point(89, 81);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(225, 78);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "0";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMedia
            // 
            this.lblMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMedia.Location = new System.Drawing.Point(12, 81);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(71, 78);
            this.lblMedia.TabIndex = 12;
            this.lblMedia.Text = "0";
            this.lblMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "N1";
            // 
            // frmCalculoEscolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 173);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoLimpar);
            this.Controls.Add(this.btoCalcular);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmCalculoEscolar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btoSair;
        private Button btoLimpar;
        private Button btoCalcular;
        private TextBox txtN4;
        private TextBox txtN3;
        private TextBox txtN2;
        private TextBox txtN1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblStatus;
        private Label lblMedia;
        private Label label1;
    }
}