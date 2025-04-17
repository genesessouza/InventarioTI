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
            tBox_CadastroDesc = new TextBox();
            lbl_CadastroDesc = new Label();
            lbl_CadastroPreco = new Label();
            tBox_CadastroPreco = new TextBox();
            cBox_CadastroMarca = new ComboBox();
            label1 = new Label();
            lbl_CadastroModelo = new Label();
            cBox_CadastroModelo = new ComboBox();
            lbl_CadastroSituacao = new Label();
            cBox_CadastroSituacao = new ComboBox();
            label2 = new Label();
            tBox_CadastroCodFab = new TextBox();
            bttn_CadastrarProduto = new Button();
            SuspendLayout();
            // 
            // tBox_CadastroDesc
            // 
            tBox_CadastroDesc.Location = new Point(12, 33);
            tBox_CadastroDesc.Name = "tBox_CadastroDesc";
            tBox_CadastroDesc.Size = new Size(357, 23);
            tBox_CadastroDesc.TabIndex = 0;
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
            // tBox_CadastroPreco
            // 
            tBox_CadastroPreco.Location = new Point(12, 93);
            tBox_CadastroPreco.Name = "tBox_CadastroPreco";
            tBox_CadastroPreco.Size = new Size(76, 23);
            tBox_CadastroPreco.TabIndex = 2;
            // 
            // cBox_CadastroMarca
            // 
            cBox_CadastroMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_CadastroMarca.FormattingEnabled = true;
            cBox_CadastroMarca.Location = new Point(455, 33);
            cBox_CadastroMarca.Name = "cBox_CadastroMarca";
            cBox_CadastroMarca.Size = new Size(107, 23);
            cBox_CadastroMarca.TabIndex = 4;
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
            // cBox_CadastroModelo
            // 
            cBox_CadastroModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_CadastroModelo.FormattingEnabled = true;
            cBox_CadastroModelo.Location = new Point(568, 33);
            cBox_CadastroModelo.Name = "cBox_CadastroModelo";
            cBox_CadastroModelo.Size = new Size(107, 23);
            cBox_CadastroModelo.TabIndex = 6;
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
            // cBox_CadastroSituacao
            // 
            cBox_CadastroSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_CadastroSituacao.FormattingEnabled = true;
            cBox_CadastroSituacao.Location = new Point(681, 33);
            cBox_CadastroSituacao.Name = "cBox_CadastroSituacao";
            cBox_CadastroSituacao.Size = new Size(107, 23);
            cBox_CadastroSituacao.TabIndex = 8;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(159, 69);
            label2.Name = "label2";
            label2.Size = new Size(210, 21);
            label2.TabIndex = 11;
            label2.Text = "Código de Fábrica";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tBox_CadastroCodFab
            // 
            tBox_CadastroCodFab.Location = new Point(159, 93);
            tBox_CadastroCodFab.Name = "tBox_CadastroCodFab";
            tBox_CadastroCodFab.Size = new Size(210, 23);
            tBox_CadastroCodFab.TabIndex = 10;
            // 
            // bttn_CadastrarProduto
            // 
            bttn_CadastrarProduto.Location = new Point(296, 390);
            bttn_CadastrarProduto.Name = "bttn_CadastrarProduto";
            bttn_CadastrarProduto.Size = new Size(196, 32);
            bttn_CadastrarProduto.TabIndex = 12;
            bttn_CadastrarProduto.Text = "Salvar";
            bttn_CadastrarProduto.UseVisualStyleBackColor = true;
            bttn_CadastrarProduto.Click += bttn_CadastrarProduto_Click;
            // 
            // CadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttn_CadastrarProduto);
            Controls.Add(label2);
            Controls.Add(tBox_CadastroCodFab);
            Controls.Add(lbl_CadastroSituacao);
            Controls.Add(cBox_CadastroSituacao);
            Controls.Add(lbl_CadastroModelo);
            Controls.Add(cBox_CadastroModelo);
            Controls.Add(label1);
            Controls.Add(cBox_CadastroMarca);
            Controls.Add(lbl_CadastroPreco);
            Controls.Add(tBox_CadastroPreco);
            Controls.Add(lbl_CadastroDesc);
            Controls.Add(tBox_CadastroDesc);
            Name = "CadastrarProduto";
            Text = "Cadastrar Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBox_CadastroDesc;
        private Label lbl_CadastroDesc;
        private Label lbl_CadastroPreco;
        private TextBox tBox_CadastroPreco;
        private ComboBox cBox_CadastroMarca;
        private Label label1;
        private Label lbl_CadastroModelo;
        private ComboBox cBox_CadastroModelo;
        private Label lbl_CadastroSituacao;
        private ComboBox cBox_CadastroSituacao;
        private Label label2;
        private TextBox tBox_CadastroCodFab;
        private Button bttn_CadastrarProduto;
    }
}