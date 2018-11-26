using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtCadastroPessoaFisica.Visible = true;
            txtCadastroPessoaJuridica.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                txtCadastroPessoaFisica.Text = Properties.Settings.Default.TextoPessoasFisicas;
                txtCadastroPessoaJuridica.Text = Properties.Settings.Default.TextoPessoasJuridicas;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class PessoaFisica
        {
            //criação dos metodos. Encapsulamento da variável, tornando-a privada e acessando por metodos. Propriedades auto-implementadas
            public string Nome { get; set; }
            public string Endereco { get; set; }
            public string km { get; set; }

            public override string ToString()
            {
                return modelo + "\t";
            }
        }

        public class PessoaJuridica : PessoaFisica
        {
            public string eixo { get; set; }
        }

        private void btnPessoaFisica_Click(object sender, EventArgs e)
        {
            txtCadastroPessoaFisica.Visible = true;
            txtCadastroPessoaJuridica.Visible = false;
            lblDocumento1.Text = "RG";
            lblDocumento2.Text = "CPF";
        }

        private void btnPessoaJuridica_Click(object sender, EventArgs e)
        {
            txtCadastroPessoaFisica.Visible = false;
            txtCadastroPessoaJuridica.Visible = true;
            lblDocumento1.Text = "CNPJ";
            lblDocumento2.Text = "IE";
        }

        private void Limpar()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtDocumento1.Clear();
            txtDocumento2.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Properties.Settings.Default.TextoPessoasFisicas = txtCadastroPessoaFisica.Text;
                Properties.Settings.Default.TextoPessoasJuridicas = txtCadastroPessoaJuridica.Text;
                Properties.Settings.Default.Save();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
    }
}
