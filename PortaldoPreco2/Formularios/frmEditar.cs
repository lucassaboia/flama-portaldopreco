using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MaterialSkin;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using CustomAlertBoxDemo;

namespace PortaldoPreco2
{
    public partial class frmEditar : Form
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password=; database=portaldopreco");

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public frmEditar()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }
        public frmEditar(string preco, string descricao, string id)
        {

            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            txtPreco.Texts = preco;
            txtDescricao.Texts = descricao;
            txtId.Text = id;
        }
        private const int CS_DropShadow = 0x0035000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void customButton4_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?",
                     "Portal do Preço",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmEditar_Load(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            txtPreco.Texts = "";
            txtDescricao.Texts = "";
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja atualizar o anúncio?", "Registro de Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conexao.Open();                
                string sqlAtualizarVenda = $"UPDATE `anuncio` SET `preco` = @preco, descricao = @descricao WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sqlAtualizarVenda,conexao);
                cmd.Parameters.AddWithValue("@preco", txtPreco.Texts);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Texts);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.ExecuteNonQuery();
                this.Alert("Usuário atualizado com sucesso", Form_Alert.enmType.Success);
                this.Hide();
                

                //CarregarVendas();

            }
        }

        private void customButton2_Enter(object sender, EventArgs e)
        {

        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                this.Alert("Apenas números", Form_Alert.enmType.Virgula);
            }

        }
    }
}
