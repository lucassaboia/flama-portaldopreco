
namespace PortaldoPreco2
{
    partial class frmSobre
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.customButton2 = new PortaldoPreco2.Resources.CustomButton();
            this.customButton1 = new PortaldoPreco2.Resources.CustomButton();
            this.txtDescricao = new PortaldoPreco2.txtcadastro();
            this.txtPreco = new PortaldoPreco2.txtcadastro();
            this.txtProduto = new PortaldoPreco2.CustomComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 13F);
            this.label2.Location = new System.Drawing.Point(35, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Descrição do anúncio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 13F);
            this.label1.Location = new System.Drawing.Point(429, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Preço do anúncio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(36, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 1);
            this.panel1.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 13F);
            this.label3.Location = new System.Drawing.Point(35, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "Insira o produto anunciado";
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
            this.customButton2.TabIndex = 42;
            this.customButton2.Text = "CADASTRAR";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
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
            this.customButton1.TabIndex = 41;
            this.customButton1.Text = "LIMPAR";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDescricao.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDescricao.BorderRadius = 8;
            this.txtDescricao.BorderSize = 2;
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.Font = new System.Drawing.Font("Montserrat", 8.549999F);
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescricao.Location = new System.Drawing.Point(36, 194);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDescricao.PlaceholderText = "Insira a descrição do produto";
            this.txtDescricao.Size = new System.Drawing.Size(744, 198);
            this.txtDescricao.TabIndex = 37;
            this.txtDescricao.Texts = "";
            this.txtDescricao.UnderlinedStyle = false;
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPreco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPreco.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPreco.BorderRadius = 8;
            this.txtPreco.BorderSize = 2;
            this.txtPreco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreco.Font = new System.Drawing.Font("Montserrat", 8.549999F);
            this.txtPreco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPreco.Location = new System.Drawing.Point(430, 82);
            this.txtPreco.Multiline = true;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPreco.PlaceholderText = "Preço do produto ex.: 1000,00";
            this.txtPreco.Size = new System.Drawing.Size(349, 50);
            this.txtPreco.TabIndex = 35;
            this.txtPreco.Texts = "";
            this.txtPreco.UnderlinedStyle = false;
            // 
            // txtProduto
            // 
            this.txtProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtProduto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtProduto.BorderSize = 1;
            this.txtProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.txtProduto.Font = new System.Drawing.Font("Montserrat", 8.549999F);
            this.txtProduto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProduto.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtProduto.Items.AddRange(new object[] {
            "Acre (AC) - Rio Branco",
            "Alagoas (AL) - Maceió",
            "Amapá (AP) - Macapá",
            "Amazonas (AM) - Manaus",
            "Bahia (BA) - Salvador",
            "Ceará (CE) - Fortaleza",
            "Distrito Federal (DF) - Brasília",
            "Espírito Santo (ES) - Vitória",
            "Goiás (GO) - Goiânia",
            "Maranhão (MA) - São Luís",
            "Mato Grosso (MT) - Cuiabá",
            "Mato Grosso do Sul (MS) - Campo Grande",
            "Minas Gerais (MG) - Belo Horizonte",
            "Pará (PA) - Belém",
            "Paraíba (PB) - João Pessoa",
            "Paraná (PR) - Curitiba",
            "Pernambuco (PE) - Recife",
            "Piauí (PI) - Teresina",
            "Rio de Janeiro (RJ) - Rio de Janeiro",
            "Rio Grande do Norte (RN) - Natal",
            "Rio Grande do Sul (RS) - Porto Alegre",
            "Rondônia (RO) - Porto Velho",
            "Roraima (RR) - Boa Vista",
            "Santa Catarina (SC) - Florianópolis",
            "São Paulo (SP) - São Paulo",
            "Sergipe (SE) - Aracaju",
            "Tocantins (TO) – Palmas"});
            this.txtProduto.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.txtProduto.ListTextColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtProduto.Location = new System.Drawing.Point(39, 86);
            this.txtProduto.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Padding = new System.Windows.Forms.Padding(1);
            this.txtProduto.Size = new System.Drawing.Size(349, 50);
            this.txtProduto.TabIndex = 45;
            this.txtProduto.Texts = "";
            this.txtProduto.Enter += new System.EventHandler(this.txtProduto_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 10F);
            this.label4.Location = new System.Drawing.Point(403, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "R$";
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtProduto);
            this.Name = "frmSobre";
            this.Size = new System.Drawing.Size(832, 500);
            this.Load += new System.EventHandler(this.frmSobre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private txtcadastro txtDescricao;
        private txtcadastro txtPreco;
        private Resources.CustomButton customButton2;
        private Resources.CustomButton customButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private CustomComboBox txtProduto;
        private System.Windows.Forms.Label label4;
    }
}
