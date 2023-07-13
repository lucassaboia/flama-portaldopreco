using PortaldoPreco2.Properties;
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
    public partial class frmLogin : Form
    {
        int mov;
        int movX;
        int movY;

        MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;uid=root;password=;database=portaldopreco");

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
        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple300, Primary.DeepPurple300, Primary.DeepPurple300, Accent.DeepPurple200, TextShade.WHITE);
            
            
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
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?",
                     "Portal do Preço",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void customButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://paineldopreco.lovestoblog.com/registro.php");
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Alert("Usuário logado com sucesso", Form_Alert.enmType.Success);

            frmOverview telaPrincipal = new frmOverview();
            telaPrincipal.Show();
            this.Hide();
            /*try
            {
                MySqlCommand cmd = new MySqlCommand($"select * from loja where cnpj='{txtLogin.Texts}' and senha='{txtSenha.Texts}' ", conexao);
                conexao.Open(); 
                MySqlDataReader reader = cmd.ExecuteReader();
                if ((txtLogin.Text == "Digite seu login") || (txtSenha.Text == "Digite seu CPF") || (string.IsNullOrEmpty(txtSenha.Texts.Trim())) || (string.IsNullOrEmpty(txtLogin.Texts.Trim())))
                {
                    this.Alert("Preencha todos os campos", Form_Alert.enmType.Campos);
                }

                else if (reader.Read())
                {
                    Properties.Settings.Default.usuarioConectado = reader["nome"].ToString();
                    Properties.Settings.Default.telefone = reader["telefone"].ToString();
                    Properties.Settings.Default.estado = reader["estado"].ToString();
                    Properties.Settings.Default.cep = reader["cep"].ToString();
                    Properties.Settings.Default.endereco = reader["endereco"].ToString();
                    Properties.Settings.Default.cidade = reader["cidade"].ToString();
                    Properties.Settings.Default.complemento = reader["complemento"].ToString();
                    Properties.Settings.Default.cnpj = reader["cnpj"].ToString();
                    Properties.Settings.Default.verificado = (int)reader["verificado"];
                    Properties.Settings.Default.id = (int)reader["id"];


                    this.Alert("Usuário logado com sucesso", Form_Alert.enmType.Success);

                    frmOverview telaPrincipal = new frmOverview();
                    telaPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    this.Alert("Usuário incorreto", Form_Alert.enmType.Error);
                }

            }

            finally
            {
                conexao.Close();
            }*/
        }
    }
}
