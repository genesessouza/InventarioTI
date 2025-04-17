namespace InventarioTI.View.Cadastro
{
    partial class CadastroEstoque
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
            bttn_CadastroEstoqueSalvar = new Button();
            cBox_CadastroEstoqueProduto = new ComboBox();
            label1 = new Label();
            tBox_CadastroEstoqueQuantidade = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // bttn_CadastroEstoqueSalvar
            // 
            bttn_CadastroEstoqueSalvar.Location = new Point(130, 180);
            bttn_CadastroEstoqueSalvar.Name = "bttn_CadastroEstoqueSalvar";
            bttn_CadastroEstoqueSalvar.Size = new Size(87, 31);
            bttn_CadastroEstoqueSalvar.TabIndex = 34;
            bttn_CadastroEstoqueSalvar.Text = "Salvar";
            bttn_CadastroEstoqueSalvar.Click += bttn_CadastroEstoqueSalvar_Click;
            // 
            // cBox_CadastroEstoqueProduto
            // 
            cBox_CadastroEstoqueProduto.AllowDrop = true;
            cBox_CadastroEstoqueProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_CadastroEstoqueProduto.BackColor = SystemColors.ControlDarkDark;
            cBox_CadastroEstoqueProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_CadastroEstoqueProduto.FlatStyle = FlatStyle.Popup;
            cBox_CadastroEstoqueProduto.ForeColor = SystemColors.ControlLightLight;
            cBox_CadastroEstoqueProduto.FormattingEnabled = true;
            cBox_CadastroEstoqueProduto.Location = new Point(9, 32);
            cBox_CadastroEstoqueProduto.Name = "cBox_CadastroEstoqueProduto";
            cBox_CadastroEstoqueProduto.Size = new Size(208, 23);
            cBox_CadastroEstoqueProduto.TabIndex = 35;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 9);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(208, 20);
            label1.TabIndex = 36;
            label1.Text = "Produto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tBox_CadastroEstoqueQuantidade
            // 
            tBox_CadastroEstoqueQuantidade.BackColor = SystemColors.ControlDarkDark;
            tBox_CadastroEstoqueQuantidade.BorderStyle = BorderStyle.None;
            tBox_CadastroEstoqueQuantidade.ForeColor = SystemColors.ControlLightLight;
            tBox_CadastroEstoqueQuantidade.Location = new Point(256, 32);
            tBox_CadastroEstoqueQuantidade.Margin = new Padding(0);
            tBox_CadastroEstoqueQuantidade.Multiline = true;
            tBox_CadastroEstoqueQuantidade.Name = "tBox_CadastroEstoqueQuantidade";
            tBox_CadastroEstoqueQuantidade.Size = new Size(78, 20);
            tBox_CadastroEstoqueQuantidade.TabIndex = 37;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(256, 9);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 38;
            label3.Text = "Quantidade";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CadastroEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 223);
            Controls.Add(label3);
            Controls.Add(tBox_CadastroEstoqueQuantidade);
            Controls.Add(cBox_CadastroEstoqueProduto);
            Controls.Add(label1);
            Controls.Add(bttn_CadastroEstoqueSalvar);
            Name = "CadastroEstoque";
            Text = "CadastroEstoque";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bttn_CadastroEstoqueSalvar;
        private ComboBox cBox_CadastroEstoqueProduto;
        private Label label1;
        private TextBox tBox_CadastroEstoqueQuantidade;
        private Label label3;
    }
}