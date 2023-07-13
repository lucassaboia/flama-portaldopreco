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

namespace PortaldoPreco2
{
    public partial class frmOverview : Form
    {
        int mov;
        int movX;
        int movY;
        private Button currentButton;

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
        public frmOverview()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
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
        private void btnOverview_Click(object sender, EventArgs e)
        {
            ClicarBotao(sender, btnOverview.Image = Properties.Resources.casabrancapqn);
            btnCadastros.Image = Properties.Resources.cadastrocinzapqn;
            btnProdutos.Image = Properties.Resources.cubocinzapqn;
            btnSobre.Image = Properties.Resources.sobrecinzapqn;
            try
            {
                frmProdutos1.Visible = true;
                frmCadastros1.Visible = false;
                frmDataBase1.Visible = false;
                frmSobre1.Visible = false;
            }
            catch
            {

            }
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmDataBase1.BringToFront();
            /*panelLateral.Height = btnProdutos.Height;
            panelLateral.Top = btnProdutos.Top;
            btnProdutos.ForeColor = Color.White;*/
            ClicarBotao(sender, btnProdutos.Image = Properties.Resources.cubobrancopqn);
            btnCadastros.Image = Properties.Resources.cadastrocinzapqn;
            btnOverview.Image = Properties.Resources.casacinzapqn;
            btnSobre.Image = Properties.Resources.sobrecinzapqn;
            try
            {
                frmProdutos1.Visible = false;
                frmCadastros1.Visible = false;
                frmDataBase1.Visible = true;
                frmProdutos1.Visible = false;
                frmSobre1.Visible = false;
            }
            catch
            {

            }
            

        }
        private void btnCadastros_Click(object sender, EventArgs e)
        {
            ClicarBotao(sender, btnCadastros.Image = Properties.Resources.cadastrobrancopqn);
            btnOverview.Image = Properties.Resources.casacinzapqn;
            btnProdutos.Image = Properties.Resources.cubocinzapqn;
            btnSobre.Image = Properties.Resources.sobrecinzapqn;
            try
            {
                frmProdutos1.Visible = false;
                frmCadastros1.Visible = true;
                frmDataBase1.Visible = false;
                frmProdutos1.Visible = false;
                frmSobre1.Visible = false;
            }
            catch
            {

            }
            
        }        
        
        private void btnSobre_Click(object sender, EventArgs e)
        {
            ClicarBotao(sender, btnSobre.Image = Properties.Resources.sobrebrancopqn);
            btnCadastros.Image = Properties.Resources.cadastrocinzapqn;
            btnProdutos.Image = Properties.Resources.cubocinzapqn;
            btnOverview.Image = Properties.Resources.casacinzapqn;
            try
            {
                frmProdutos1.Visible = false;
                frmCadastros1.Visible = false;
                frmDataBase1.Visible = false;
                frmProdutos1.Visible = false;
                frmSobre1.Visible = true;
            }
            catch
            {

            }
            

        }
        private void ClicarBotao(object btnSender, Image icone)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    SairBotao();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                    panelLateral.Height = currentButton.Height;
                    panelLateral.Top = currentButton.Top;
                }
            }
        }

        private void SairBotao()
        {
            foreach (Control previousBtn in panel2.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.ForeColor = Color.FromArgb(152, 159, 226);
                }
            }
        }
        private void frmOverview_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void frmOverview_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void frmOverview_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void frmOverview_Load(object sender, EventArgs e)
        {
            int nivel = Properties.Settings.Default.verificado;
            if (nivel != 0)
            {
                verificado2.Visible = true;
            }
            else
            {
                verificado2.Visible = false; 
            }

            lblTitulo.Text = Properties.Settings.Default.usuarioConectado;
            panelLateral.Height = btnOverview.Height;
            panelLateral.Top = btnOverview.Top;
            lblNome.Text = Properties.Settings.Default.usuarioConectado;
            frmProdutos1.BringToFront();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente deslogar?",
                      "Japapito Refeições",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Information) == DialogResult.Yes)
            {
                frmLogin TelaLogin = new frmLogin();
                TelaLogin.Show();
                Dispose();
            }
        }
    }
}
