using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CustomAlertBoxDemo;

namespace PortaldoPreco2
{
    public partial class frmProdutos : UserControl
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;uid=root;password=;database=portaldopreco");
        public frmProdutos()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            int nivel = Properties.Settings.Default.verificado;
            if (nivel != 0)
            {
                verificado1.Visible = true;
                
            }
            else
            {
                lblNome.Location = new Point (208, 92);
                verificado1.Visible = false;
            }

            lblNome.Text = Properties.Settings.Default.usuarioConectado;
            lblTelefone.Text = Properties.Settings.Default.telefone;
            lblComplemento.Text = Properties.Settings.Default.estado;
            lblEndereco.Text = Properties.Settings.Default.cep;
            lblCidade.Text = Properties.Settings.Default.endereco;
            lblCEP.Text = Properties.Settings.Default.cep;
            lblEstado.Text = Properties.Settings.Default.estado;
            CarregarProdutos();
           

        }
         private void CarregarProdutos()
       {

            MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;uid=root;password=;database=portaldopreco");
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT an.preco as 'Preco', an.descricao as 'Descrição',pdt.nome as 'Nome',  FROM `loja` as lj INNER JOIN anuncio as an ON lj.id = an.lojaId INNER JOIN produto as pdt ON an.produtoId = pdt.id WHERE lj.cnpj =  " + Properties.Settings.Default.cnpj, conexao);

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
            }
            catch
            {

            }
            finally
            {
                conexao.Close();
            }
        }
        private void CarregarInformacoes()
        {

        }
    }
       }

