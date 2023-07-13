
namespace PortaldoPreco2
{
    partial class frmCadastros
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoria = new PortaldoPreco2.CustomComboBox();
            this.txtDescricao = new PortaldoPreco2.txtcadastro();
            this.txtMarca = new PortaldoPreco2.txtcadastro();
            this.txtcadastro1 = new PortaldoPreco2.txtcadastro();
            this.customButton1 = new PortaldoPreco2.Resources.CustomButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customButton2 = new PortaldoPreco2.Resources.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(36, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 1);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 13F);
            this.label1.Location = new System.Drawing.Point(37, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nome do produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 13F);
            this.label2.Location = new System.Drawing.Point(37, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nome da marca do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 13F);
            this.label3.Location = new System.Drawing.Point(37, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Categoria do produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 13F);
            this.label4.Location = new System.Drawing.Point(443, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Descrição do produto";
            // 
            // txtCategoria
            // 
            this.txtCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCategoria.BorderSize = 1;
            this.txtCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Montserrat", 8.549999F);
            this.txtCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCategoria.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCategoria.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.txtCategoria.ListTextColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCategoria.Location = new System.Drawing.Point(41, 308);
            this.txtCategoria.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Padding = new System.Windows.Forms.Padding(1);
            this.txtCategoria.Size = new System.Drawing.Size(339, 50);
            this.txtCategoria.TabIndex = 50;
            this.txtCategoria.Texts = "";
            this.txtCategoria.OnSelectedIndexChanged += new System.EventHandler(this.txtCategoria_OnSelectedIndexChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDescricao.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDescricao.BorderRadius = 8;
            this.txtDescricao.BorderSize = 2;
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Montserrat", 8.549999F);
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescricao.Location = new System.Drawing.Point(447, 94);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDescricao.PlaceholderText = "Insira a descrição do produto";
            this.txtDescricao.Size = new System.Drawing.Size(347, 264);
            this.txtDescricao.TabIndex = 49;
            this.txtDescricao.Texts = "";
            this.txtDescricao.UnderlinedStyle = false;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMarca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMarca.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMarca.BorderRadius = 8;
            this.txtMarca.BorderSize = 2;
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Montserrat", 8.549999F);
            this.txtMarca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMarca.Location = new System.Drawing.Point(41, 200);
            this.txtMarca.Multiline = true;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtMarca.PlaceholderText = "Insira o nome da marca do produto ex: Apple";
            this.txtMarca.Size = new System.Drawing.Size(339, 50);
            this.txtMarca.TabIndex = 48;
            this.txtMarca.Texts = "";
            this.txtMarca.UnderlinedStyle = false;
            // 
            // txtcadastro1
            // 
            this.txtcadastro1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtcadastro1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtcadastro1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtcadastro1.BorderRadius = 8;
            this.txtcadastro1.BorderSize = 2;
            this.txtcadastro1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcadastro1.Font = new System.Drawing.Font("Montserrat", 8.549999F);
            this.txtcadastro1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcadastro1.Location = new System.Drawing.Point(41, 86);
            this.txtcadastro1.Multiline = true;
            this.txtcadastro1.Name = "txtcadastro1";
            this.txtcadastro1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtcadastro1.PlaceholderText = "Insira o nome de um produto inexistente e clique na lupa";
            this.txtcadastro1.Size = new System.Drawing.Size(339, 50);
            this.txtcadastro1.TabIndex = 47;
            this.txtcadastro1.Texts = "";
            this.txtcadastro1.UnderlinedStyle = false;
            this.txtcadastro1._TextChanged += new System.EventHandler(this.txtcadastro1__TextChanged);
            this.txtcadastro1.Load += new System.EventHandler(this.txtcadastro1_Load);
            this.txtcadastro1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcadastro1_KeyPress);
            this.txtcadastro1.Leave += new System.EventHandler(this.txtcadastro1_Leave);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 8;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.25F, System.Drawing.FontStyle.Bold);
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(272, 440);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(116, 41);
            this.customButton1.TabIndex = 13;
            this.customButton1.Text = "LIMPAR";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::PortaldoPreco2.Properties.Resources.Vector__12_;
            this.pictureBox2.Location = new System.Drawing.Point(386, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.customButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.customButton2.BackgroundImage = global::PortaldoPreco2.Properties.Resources.Rectangle_12;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 8;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.25F, System.Drawing.FontStyle.Bold);
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(439, 440);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(116, 41);
            this.customButton2.TabIndex = 14;
            this.customButton2.Text = "CADASTRAR";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // frmCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtcadastro1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.panel1);
            this.Name = "frmCadastros";
            this.Size = new System.Drawing.Size(832, 500);
            this.Load += new System.EventHandler(this.frmCadastros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Resources.CustomButton customButton1;
        private Resources.CustomButton customButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private txtcadastro txtcadastro1;
        private txtcadastro txtMarca;
        private txtcadastro txtDescricao;
        private CustomComboBox txtCategoria;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
