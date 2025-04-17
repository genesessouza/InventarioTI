namespace InventarioTI.View
{
    partial class EdicaoProduto
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
            bttn_EditarProduto = new Button();
            lbl_CadastroSituacao = new Label();
            cBox_EdicaoProdutoSituacao = new ComboBox();
            lbl_CadastroPreco = new Label();
            tBox_EdicaoProdutoPreco = new TextBox();
            lbl_CadastroDesc = new Label();
            tBox_EdicaoDesc = new TextBox();
            label1 = new Label();
            cBox_EdicaoProdutoModelo = new ComboBox();
            label2 = new Label();
            cBox_EdicaoProdutoMarca = new ComboBox();
            label3 = new Label();
            tBox_EdicaoProdutoCodFab = new TextBox();
            SuspendLayout();
            // 
            // bttn_EditarProduto
            // 
            bttn_EditarProduto.Location = new Point(196, 406);
            bttn_EditarProduto.Name = "bttn_EditarProduto";
            bttn_EditarProduto.Size = new Size(196, 32);
            bttn_EditarProduto.TabIndex = 25;
            bttn_EditarProduto.Text = "Salvar";
            bttn_EditarProduto.UseVisualStyleBackColor = true;
            bttn_EditarProduto.Click += bttn_EditarProduto_Click;
            // 
            // lbl_CadastroSituacao
            // 
            lbl_CadastroSituacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CadastroSituacao.Location = new Point(437, 201);
            lbl_CadastroSituacao.Name = "lbl_CadastroSituacao";
            lbl_CadastroSituacao.Size = new Size(107, 21);
            lbl_CadastroSituacao.TabIndex = 22;
            lbl_CadastroSituacao.Text = "Situação";
            lbl_CadastroSituacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cBox_EdicaoProdutoSituacao
            // 
            cBox_EdicaoProdutoSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_EdicaoProdutoSituacao.FormattingEnabled = true;
            cBox_EdicaoProdutoSituacao.Location = new Point(437, 225);
            cBox_EdicaoProdutoSituacao.Name = "cBox_EdicaoProdutoSituacao";
            cBox_EdicaoProdutoSituacao.Size = new Size(107, 23);
            cBox_EdicaoProdutoSituacao.TabIndex = 21;
            // 
            // lbl_CadastroPreco
            // 
            lbl_CadastroPreco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CadastroPreco.Location = new Point(430, 19);
            lbl_CadastroPreco.Name = "lbl_CadastroPreco";
            lbl_CadastroPreco.Size = new Size(115, 21);
            lbl_CadastroPreco.TabIndex = 16;
            lbl_CadastroPreco.Text = "Preço";
            lbl_CadastroPreco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tBox_EdicaoProdutoPreco
            // 
            tBox_EdicaoProdutoPreco.Location = new Point(430, 43);
            tBox_EdicaoProdutoPreco.Name = "tBox_EdicaoProdutoPreco";
            tBox_EdicaoProdutoPreco.Size = new Size(115, 23);
            tBox_EdicaoProdutoPreco.TabIndex = 15;
            // 
            // lbl_CadastroDesc
            // 
            lbl_CadastroDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CadastroDesc.Location = new Point(12, 19);
            lbl_CadastroDesc.Name = "lbl_CadastroDesc";
            lbl_CadastroDesc.Size = new Size(339, 21);
            lbl_CadastroDesc.TabIndex = 14;
            lbl_CadastroDesc.Text = "Descrição";
            lbl_CadastroDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tBox_EdicaoDesc
            // 
            tBox_EdicaoDesc.Location = new Point(12, 43);
            tBox_EdicaoDesc.Name = "tBox_EdicaoDesc";
            tBox_EdicaoDesc.Size = new Size(339, 23);
            tBox_EdicaoDesc.TabIndex = 13;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 201);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 27;
            label1.Text = "Modelo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cBox_EdicaoProdutoModelo
            // 
            cBox_EdicaoProdutoModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_EdicaoProdutoModelo.FormattingEnabled = true;
            cBox_EdicaoProdutoModelo.Location = new Point(232, 225);
            cBox_EdicaoProdutoModelo.Name = "cBox_EdicaoProdutoModelo";
            cBox_EdicaoProdutoModelo.Size = new Size(137, 23);
            cBox_EdicaoProdutoModelo.TabIndex = 26;
            cBox_EdicaoProdutoModelo.SelectedIndexChanged += cBox_EdicaoProdutoModelo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 201);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 29;
            label2.Text = "Marca";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cBox_EdicaoProdutoMarca
            // 
            cBox_EdicaoProdutoMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_EdicaoProdutoMarca.FormattingEnabled = true;
            cBox_EdicaoProdutoMarca.Location = new Point(11, 225);
            cBox_EdicaoProdutoMarca.Name = "cBox_EdicaoProdutoMarca";
            cBox_EdicaoProdutoMarca.Size = new Size(131, 23);
            cBox_EdicaoProdutoMarca.TabIndex = 28;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(339, 21);
            label3.TabIndex = 31;
            label3.Text = "Código de Fábrica";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tBox_EdicaoProdutoCodFab
            // 
            tBox_EdicaoProdutoCodFab.Location = new Point(12, 124);
            tBox_EdicaoProdutoCodFab.Name = "tBox_EdicaoProdutoCodFab";
            tBox_EdicaoProdutoCodFab.Size = new Size(339, 23);
            tBox_EdicaoProdutoCodFab.TabIndex = 30;
            // 
            // EdicaoProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 450);
            Controls.Add(label3);
            Controls.Add(tBox_EdicaoProdutoCodFab);
            Controls.Add(label2);
            Controls.Add(cBox_EdicaoProdutoMarca);
            Controls.Add(label1);
            Controls.Add(cBox_EdicaoProdutoModelo);
            Controls.Add(bttn_EditarProduto);
            Controls.Add(lbl_CadastroSituacao);
            Controls.Add(cBox_EdicaoProdutoSituacao);
            Controls.Add(lbl_CadastroPreco);
            Controls.Add(tBox_EdicaoProdutoPreco);
            Controls.Add(lbl_CadastroDesc);
            Controls.Add(tBox_EdicaoDesc);
            Name = "EdicaoProduto";
            Text = "EditarProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttn_EditarProduto;
        private Label lbl_CadastroSituacao;
        private ComboBox cBox_EdicaoProdutoSituacao;
        private Label lbl_CadastroPreco;
        private TextBox tBox_EdicaoProdutoPreco;
        private Label lbl_CadastroDesc;
        private TextBox tBox_EdicaoDesc;
        private Label label1;
        private ComboBox cBox_EdicaoProdutoModelo;
        private Label label2;
        private ComboBox cBox_EdicaoProdutoMarca;
        private Label label3;
        private TextBox tBox_EdicaoProdutoCodFab;
    }
}