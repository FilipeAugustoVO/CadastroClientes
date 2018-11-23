namespace CadastroClientes
{
    partial class Form1
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
            this.btnPessoaFisica = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPessoaJuridica = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPessoaFisica
            // 
            this.btnPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPessoaFisica.Location = new System.Drawing.Point(29, 12);
            this.btnPessoaFisica.Name = "btnPessoaFisica";
            this.btnPessoaFisica.Size = new System.Drawing.Size(75, 41);
            this.btnPessoaFisica.TabIndex = 0;
            this.btnPessoaFisica.Text = "Pessoa Física";
            this.btnPessoaFisica.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(9, 76);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(400, 20);
            this.txtNome.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 162);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(468, 179);
            this.textBox2.TabIndex = 3;
            // 
            // btnPessoaJuridica
            // 
            this.btnPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPessoaJuridica.Location = new System.Drawing.Point(212, 12);
            this.btnPessoaJuridica.Name = "btnPessoaJuridica";
            this.btnPessoaJuridica.Size = new System.Drawing.Size(75, 41);
            this.btnPessoaJuridica.TabIndex = 0;
            this.btnPessoaJuridica.Text = "Pessoa Jurídica";
            this.btnPessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(373, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 41);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(9, 103);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(72, 15);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(9, 128);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(31, 15);
            this.lblRG.TabIndex = 1;
            this.lblRG.Text = "RG:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 2;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(276, 128);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 15);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(325, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 20);
            this.textBox4.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(492, 353);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPessoaJuridica);
            this.Controls.Add(this.btnPessoaFisica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPessoaFisica;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPessoaJuridica;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox textBox4;
    }
}

