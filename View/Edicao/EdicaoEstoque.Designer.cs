namespace InventarioTI.View.Cadastro
{
    partial class EdicaoEstoque
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
            bttn_EdicaoEstoqueSalvar = new Button();
            cBox_EdicaoEstoqueProduto = new ComboBox();
            label1 = new Label();
            tBox_EdicaoEstoqueQuantidade = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // bttn_EdicaoEstoqueSalvar
            // 
            bttn_EdicaoEstoqueSalvar.BackColor = SystemColors.ControlDarkDark;
            bttn_EdicaoEstoqueSalvar.FlatStyle = FlatStyle.Flat;
            bttn_EdicaoEstoqueSalvar.ForeColor = SystemColors.ControlLightLight;
            bttn_EdicaoEstoqueSalvar.Location = new Point(130, 180);
            bttn_EdicaoEstoqueSalvar.Name = "bttn_EdicaoEstoqueSalvar";
            bttn_EdicaoEstoqueSalvar.Size = new Size(87, 31);
            bttn_EdicaoEstoqueSalvar.TabIndex = 34;
            bttn_EdicaoEstoqueSalvar.Text = "Salvar";
            bttn_EdicaoEstoqueSalvar.UseVisualStyleBackColor = false;
            bttn_EdicaoEstoqueSalvar.Click += bttn_EdicaoEstoqueSalvar_Click;
            // 
            // cBox_EdicaoEstoqueProduto
            // 
            cBox_EdicaoEstoqueProduto.AllowDrop = true;
            cBox_EdicaoEstoqueProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_EdicaoEstoqueProduto.BackColor = SystemColors.ControlDarkDark;
            cBox_EdicaoEstoqueProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_EdicaoEstoqueProduto.FlatStyle = FlatStyle.Popup;
            cBox_EdicaoEstoqueProduto.ForeColor = SystemColors.ControlLightLight;
            cBox_EdicaoEstoqueProduto.FormattingEnabled = true;
            cBox_EdicaoEstoqueProduto.Location = new Point(9, 32);
            cBox_EdicaoEstoqueProduto.Name = "cBox_EdicaoEstoqueProduto";
            cBox_EdicaoEstoqueProduto.Size = new Size(208, 23);
            cBox_EdicaoEstoqueProduto.TabIndex = 35;
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
            // tBox_EdicaoEstoqueQuantidade
            // 
            tBox_EdicaoEstoqueQuantidade.BackColor = SystemColors.ControlDarkDark;
            tBox_EdicaoEstoqueQuantidade.BorderStyle = BorderStyle.None;
            tBox_EdicaoEstoqueQuantidade.ForeColor = SystemColors.ControlLightLight;
            tBox_EdicaoEstoqueQuantidade.Location = new Point(256, 32);
            tBox_EdicaoEstoqueQuantidade.Margin = new Padding(0);
            tBox_EdicaoEstoqueQuantidade.Multiline = true;
            tBox_EdicaoEstoqueQuantidade.Name = "tBox_EdicaoEstoqueQuantidade";
            tBox_EdicaoEstoqueQuantidade.Size = new Size(78, 20);
            tBox_EdicaoEstoqueQuantidade.TabIndex = 37;
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
            // EdicaoEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(354, 223);
            Controls.Add(label3);
            Controls.Add(tBox_EdicaoEstoqueQuantidade);
            Controls.Add(cBox_EdicaoEstoqueProduto);
            Controls.Add(label1);
            Controls.Add(bttn_EdicaoEstoqueSalvar);
            Name = "EdicaoEstoque";
            Text = "Ajuste de Estoque";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bttn_EdicaoEstoqueSalvar;
        private ComboBox cBox_EdicaoEstoqueProduto;
        private Label label1;
        private TextBox tBox_EdicaoEstoqueQuantidade;
        private Label label3;
    }
}