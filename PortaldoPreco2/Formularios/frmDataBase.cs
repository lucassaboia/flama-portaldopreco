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

    public partial class frmDataBase : UserControl
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password=; database=portaldopreco");
        public frmDataBase()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            int contlinhas = dataGridView1.SelectedRows.Count;
            if (contlinhas > 0)
            { 
            frmEditar editar = new frmEditar(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            editar.ShowDialog();
        }
          else
            {
                this.Alert("Não há produtos para editar", Form_Alert.enmType.Info);
            }
        }

        private void CarregarProdutos()
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT an.id as 'ID', an.preco as 'Preço - R$',an.descricao as 'Descrição',pdt.marca as 'Marca',pdt.categoria as 'Categoria', pdt.nome as 'Nome' FROM `loja` as lj INNER JOIN anuncio as an ON lj.id = an.lojaId INNER JOIN produto as pdt ON an.produtoId = pdt.id WHERE lj.cnpj =  " + Properties.Settings.Default.cnpj, conexao);

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[5].Width = 235;
            }
            catch
            {

            }
            finally
            {
                conexao.Close();
            }
        }

        private void frmDataBase_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int contlinhas = dataGridView1.SelectedRows.Count;
            if (contlinhas > 0)
            { 
            MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password=; database=portaldopreco");

            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("select * from anuncio where id=@id", conexao);
                cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    txtid.Text = reader["id"].ToString();
                }
            }
            catch
            {

            }
        }
    }
        private void customButton1_Click(object sender, EventArgs e)
        {
           if (dataGridView1.RowCount == 0)
            {
                this.Alert("Não há itens no pedido", Form_Alert.enmType.Info);
                return;
            }
            if (MessageBox.Show("Deseja realmente apagar o funcionário?", "Portal do Preço ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand("delete from avaliacoes where id=@id; delete from anuncio where id=@id;", conexao);
                    cmd.Parameters.AddWithValue("@id", txtid.Text);
                    cmd.ExecuteNonQuery();
                    this.Alert("Anúncio e avaliações removidos com sucesso.", Form_Alert.enmType.Success);
                    conexao.Close();
                    CarregarProdutos();
                }
                catch
                {
                    this.Alert("Não há nada para apagar.", Form_Alert.enmType.Info);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
            this.Alert("Produtos carregados.", Form_Alert.enmType.Success);
            
            
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
        }

        private void frmDataBase_Enter(object sender, EventArgs e)
        {
            CarregarProdutos();
        }
    }
}
