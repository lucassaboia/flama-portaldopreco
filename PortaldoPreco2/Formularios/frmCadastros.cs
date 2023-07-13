using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomAlertBoxDemo;
using MySql.Data.MySqlClient;

namespace PortaldoPreco2
{
    public partial class frmCadastros : UserControl
    {
        private OpenFileDialog ofd = new OpenFileDialog();
        
        MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password=; database=portaldopreco");
        public frmCadastros()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            txtcadastro1.Texts = "";
            txtCategoria.Texts = "";
            txtDescricao.Texts = "";
            txtMarca.Texts = "";
            txtCategoria.Enabled = false;
            txtDescricao.Enabled = false;
            txtMarca.Enabled = false;
            this.Alert("Todos os campos do formulário foram resetados.", Form_Alert.enmType.Campos);

        }

        private void txtcadastro1_Leave(object sender, EventArgs e)
        {

        }

        private void txtcadastro1_Load(object sender, EventArgs e)
        {

        }

        private void txtcadastro1__TextChanged(object sender, EventArgs e)
        {

        }


        private void frmCadastros_Load(object sender, EventArgs e)
        {

        }

        private void txtcadastro1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtcadastro1.Texts == "")
            {
                this.Alert("Digite um produto não existente.", Form_Alert.enmType.Campos);
                return;

            }

            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT nome FROM `produto` WHERE nome LIKE '{txtcadastro1.Texts}%' ", conexao);
                //cmd.Parameters.AddWithValue("@nome",txtcadastro1.Texts);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    this.Alert("Este produto já existe", Form_Alert.enmType.Virgula);
                    conexao.Close();
                }
                else
                {
                    txtCategoria.Enabled = true;
                    txtDescricao.Enabled = true;
                    txtMarca.Enabled = true;
                    conexao.Close();
                    CarregarCategorias();
                    this.Alert("Campos liberados.", Form_Alert.enmType.Virgula);


                }

            }
            catch
            {

            }
            finally
            {

            }
        }
        private void CarregarCategorias()
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT nome FROM `categorias`", conexao);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                txtCategoria.DataSource = dt;
                txtCategoria.DisplayMember = "nome";
                txtCategoria.ValueMember = "nome";



            }
            catch (Exception erro)
            {

            }
            finally
            {
                conexao.Close();
            }


        }
        private void txtCategoria_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cadastrar?", "Registro de Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("insert into produto (nome,descricao,foto,lojaCriadora,marca,tags,categoria) values (@nome,@descricao,@foto,@lojaCriadora,@marca,@tags,@categoria)", conexao);
                //PARÂMETROS DO COMANDO
                cmd.Parameters.AddWithValue("@nome", txtcadastro1.Texts);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Texts);
                cmd.Parameters.AddWithValue("@foto", ofd.FileName);
                cmd.Parameters.AddWithValue("@lojaCriadora", Properties.Settings.Default.id);
                cmd.Parameters.AddWithValue("@marca", txtMarca.Texts);
                cmd.Parameters.AddWithValue("@tags", "");
                cmd.Parameters.AddWithValue("@categoria", txtCategoria.Texts);
                //EXECUÇÃO DO COMANDO SQL
                cmd.ExecuteNonQuery();
                this.Alert("Produto cadastrado.", Form_Alert.enmType.Success);
                txtcadastro1.Texts = "";
                txtCategoria.Texts = "";
                txtDescricao.Texts = "";
                txtMarca.Texts = "";
                txtCategoria.Enabled = false;
                txtDescricao.Enabled = false;
                txtMarca.Enabled = false;

                conexao.Close();
            }
            else
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
