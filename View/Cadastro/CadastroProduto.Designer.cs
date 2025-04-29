namespace InventarioTI.View
{
    partial class CadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tBox_CadastroProdutoDescricao = new TextBox();
            lbl_CadastroDesc = new Label();
            lbl_CadastroPreco = new Label();
            tBox_CadastroProdutoPreco = new TextBox();
            cBox_CadastroProdutoMarca = new ComboBox();
            label1 = new Label();
            lbl_CadastroModelo = new Label();
            cBox_CadastroProdutoModelo = new ComboBox();
            lbl_CadastroSituacao = new Label();
            cBox_CadastroProdutoSituacao = new ComboBox();
            bttn_CadastrarProduto = new Button();
            SuspendLayout();
            // 
            // tBox_CadastroProdutoDescricao
            // 
            tBox_CadastroProdutoDescricao.BackColor = SystemColors.ControlDarkDark;
            tBox_CadastroProdutoDescricao.BorderStyle = BorderStyle.FixedSingle;
            tBox_CadastroProdutoDescricao.ForeColor = SystemColors.ControlLightLight;
            tBox_CadastroProdutoDescricao.Location = new Point(12, 33);
            tBox_CadastroProdutoDescricao.Name = "tBox_CadastroProdutoDescricao";
            tBox_CadastroProdutoDescricao.Size = new Size(357, 23);
            tBox_CadastroProdutoDescricao.TabIndex = 0;
            // 
            // lbl_CadastroDesc
            // 
            lbl_CadastroDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CadastroDesc.Location = new Point(12, 9);
            lbl_CadastroDesc.Name = "lbl_CadastroDesc";
            lbl_CadastroDesc.Size = new Size(357, 21);
            lbl_CadastroDesc.TabIndex = 1;
            lbl_CadastroDesc.Text = "Descrição";
            lbl_CadastroDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_CadastroPreco
            // 
            lbl_CadastroPreco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CadastroPreco.Location = new Point(12, 69);
            lbl_CadastroPreco.Name = "lbl_CadastroPreco";
            lbl_CadastroPreco.Size = new Size(76, 21);
            lbl_CadastroPreco.TabIndex = 3;
            lbl_CadastroPreco.Text = "Preço";
            lbl_CadastroPreco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tBox_CadastroProdutoPreco
            // 
            tBox_CadastroProdutoPreco.BackColor = SystemColors.ControlDarkDark;
            tBox_CadastroProdutoPreco.BorderStyle = BorderStyle.FixedSingle;
            tBox_CadastroProdutoPreco.ForeColor = SystemColors.ControlLightLight;
            tBox_CadastroProdutoPreco.Location = new Point(12, 93);
            tBox_CadastroProdutoPreco.Name = "tBox_CadastroProdutoPreco";
            tBox_CadastroProdutoPreco.Size = new Size(76, 23);
            tBox_CadastroProdutoPreco.TabIndex = 2;
            tBox_CadastroProdutoPreco.MouseClick += tBox_CadastroProdutoPreco_MouseClick;
            tBox_CadastroProdutoPreco.TextChanged += tBox_CadastroProdutoPreco_TextChanged;
            tBox_CadastroProdutoPreco.MouseLeave += tBox_CadastroProdutoPreco_MouseLeave;
            // 
            // cBox_CadastroProdutoMarca
            // 
            cBox_CadastroProdutoMarca.BackColor = SystemColors.ControlDarkDark;
            cBox_CadastroProdutoMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_CadastroProdutoMarca.FlatStyle = FlatStyle.Popup;
            cBox_CadastroProdutoMarca.ForeColor = SystemColors.ControlLightLight;
            cBox_CadastroProdutoMarca.FormattingEnabled = true;
            cBox_CadastroProdutoMarca.Location = new Point(455, 33);
            cBox_CadastroProdutoMarca.Name = "cBox_CadastroProdutoMarca";
            cBox_CadastroProdutoMarca.Size = new Size(107, 23);
            cBox_CadastroProdutoMarca.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(455, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 5;
            label1.Text = "Marca";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_CadastroModelo
            // 
            lbl_CadastroModelo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CadastroModelo.Location = new Point(568, 9);
            lbl_CadastroModelo.Name = "lbl_CadastroModelo";
            lbl_CadastroModelo.Size = new Size(107, 21);
            lbl_CadastroModelo.TabIndex = 7;
            lbl_CadastroModelo.Text = "Modelo";
            lbl_CadastroModelo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cBox_CadastroProdutoModelo
            // 
            cBox_CadastroProdutoModelo.BackColor = SystemColors.ControlDarkDark;
            cBox_CadastroProdutoModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_CadastroProdutoModelo.FlatStyle = FlatStyle.Popup;
            cBox_CadastroProdutoModelo.ForeColor = SystemColors.ControlLightLight;
            cBox_CadastroProdutoModelo.FormattingEnabled = true;
            cBox_CadastroProdutoModelo.Location = new Point(568, 33);
            cBox_CadastroProdutoModelo.Name = "cBox_CadastroProdutoModelo";
            cBox_CadastroProdutoModelo.Size = new Size(107, 23);
            cBox_CadastroProdutoModelo.TabIndex = 6;
            // 
            // lbl_CadastroSituacao
            // 
            lbl_CadastroSituacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CadastroSituacao.Location = new Point(681, 9);
            lbl_CadastroSituacao.Name = "lbl_CadastroSituacao";
            lbl_CadastroSituacao.Size = new Size(107, 21);
            lbl_CadastroSituacao.TabIndex = 9;
            lbl_CadastroSituacao.Text = "Situação";
            lbl_CadastroSituacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cBox_CadastroProdutoSituacao
            // 
            cBox_CadastroProdutoSituacao.BackColor = SystemColors.ControlDarkDark;
            cBox_CadastroProdutoSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_CadastroProdutoSituacao.FlatStyle = FlatStyle.Popup;
            cBox_CadastroProdutoSituacao.ForeColor = SystemColors.ControlLightLight;
            cBox_CadastroProdutoSituacao.FormattingEnabled = true;
            cBox_CadastroProdutoSituacao.Location = new Point(681, 33);
            cBox_CadastroProdutoSituacao.Name = "cBox_CadastroProdutoSituacao";
            cBox_CadastroProdutoSituacao.Size = new Size(107, 23);
            cBox_CadastroProdutoSituacao.TabIndex = 8;
            // 
            // bttn_CadastrarProduto
            // 
            bttn_CadastrarProduto.BackColor = SystemColors.ControlDarkDark;
            bttn_CadastrarProduto.FlatStyle = FlatStyle.Flat;
            bttn_CadastrarProduto.ForeColor = SystemColors.ControlLightLight;
            bttn_CadastrarProduto.Location = new Point(296, 390);
            bttn_CadastrarProduto.Name = "bttn_CadastrarProduto";
            bttn_CadastrarProduto.Size = new Size(196, 32);
            bttn_CadastrarProduto.TabIndex = 12;
            bttn_CadastrarProduto.Text = "Salvar";
            bttn_CadastrarProduto.UseVisualStyleBackColor = false;
            bttn_CadastrarProduto.Click += bttn_CadastrarProduto_Click;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(bttn_CadastrarProduto);
            Controls.Add(lbl_CadastroSituacao);
            Controls.Add(cBox_CadastroProdutoSituacao);
            Controls.Add(lbl_CadastroModelo);
            Controls.Add(cBox_CadastroProdutoModelo);
            Controls.Add(label1);
            Controls.Add(cBox_CadastroProdutoMarca);
            Controls.Add(lbl_CadastroPreco);
            Controls.Add(tBox_CadastroProdutoPreco);
            Controls.Add(lbl_CadastroDesc);
            Controls.Add(tBox_CadastroProdutoDescricao);
            ForeColor = SystemColors.MenuText;
            Name = "CadastroProduto";
            Text = "Cadastro de Produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBox_CadastroProdutoDescricao;
        private Label lbl_CadastroDesc;
        private Label lbl_CadastroPreco;
        private TextBox tBox_CadastroProdutoPreco;
        private ComboBox cBox_CadastroProdutoMarca;
        private Label label1;
        private Label lbl_CadastroModelo;
        private ComboBox cBox_CadastroProdutoModelo;
        private Label lbl_CadastroSituacao;
        private ComboBox cBox_CadastroProdutoSituacao;
        private Button bttn_CadastrarProduto;
    }
}