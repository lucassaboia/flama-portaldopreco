using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CustomAlertBoxDemo;

namespace PortaldoPreco2
{
    public partial class frmSobre : UserControl
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password=; database=portaldopreco");
        public frmSobre()
        {
            InitializeComponent();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://paineldopreco.lovestoblog.com/lojas-verificadas.php");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Process.Start("http://paineldopreco.lovestoblog.com/?length=all");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://paineldopreco.lovestoblog.com/perguntas-frequentes.php");
        }

        private void CarregarProdutos()
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT id,nome FROM `produto`", conexao);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                txtProduto.DataSource = dt;
                txtProduto.DisplayMember = "nome";
                txtProduto.ValueMember = "id";



            }
            catch (Exception erro)
            {

            }
            finally
            {
                conexao.Close();
            }


        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Texts == "" || txtPreco.Texts=="" || txtProduto.Texts=="")
            {
                this.Alert("Preencha todos os campos.", Form_Alert.enmType.Campos);
            }
            else
            { 
            if (MessageBox.Show("Deseja realmente cadastrar?", "Registro de Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conexao.Open();
                //MySqlCommand cmd = new MySqlCommand("insert into produto (nome,descricao,foto,lojaCriadora,marca,tags,categoria) values (@nome,@descricao,@foto,@lojaCriadora,@marca,@tags,@categoria)", conexao);
                MySqlCommand cmd = new MySqlCommand("insert into anuncio (lojaId,produtoId,criacao,preco,descricao) values (@lojaId,@produtoId,@criacao,@preco,@descricao)", conexao);
                //PARÂMETROS DO COMANDO
                cmd.Parameters.AddWithValue("@lojaId", Properties.Settings.Default.id);
                cmd.Parameters.AddWithValue("@produtoId", ((System.Data.DataRowView)txtProduto.SelectedItem).Row.ItemArray[0]);
                cmd.Parameters.AddWithValue("@criacao",DateTime.Now);
                cmd.Parameters.AddWithValue("@preco",txtPreco.Texts);
                cmd.Parameters.AddWithValue("@descricao",txtDescricao.Texts );
                //EXECUÇÃO DO COMANDO SQL
                cmd.ExecuteNonQuery();
                this.Alert("Anúncio registrado.", Form_Alert.enmType.Success);
                conexao.Close();
            }
        }
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void txtProduto_Enter(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            txtDescricao.Texts = "";
            txtPreco.Texts = "";
            txtProduto.Texts = "";
            this.Alert("Todos os campos foram limpos.", Form_Alert.enmType.Campos);

        }
    }
}
