namespace InventarioTI.View.Edicao
{
    partial class EdicaoMarca
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
            cBox_EdicaoMarcaSituacao = new ComboBox();
            label1 = new Label();
            tBox_EdicaoMarcaNome = new TextBox();
            lbl_Descricao = new Label();
            bttn_EdicaoMarcaSalvar = new Button();
            SuspendLayout();
            // 
            // cBox_EdicaoMarcaSituacao
            // 
            cBox_EdicaoMarcaSituacao.AllowDrop = true;
            cBox_EdicaoMarcaSituacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_EdicaoMarcaSituacao.BackColor = SystemColors.ControlDarkDark;
            cBox_EdicaoMarcaSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_EdicaoMarcaSituacao.FlatStyle = FlatStyle.Popup;
            cBox_EdicaoMarcaSituacao.ForeColor = SystemColors.ControlLightLight;
            cBox_EdicaoMarcaSituacao.FormattingEnabled = true;
            cBox_EdicaoMarcaSituacao.Location = new Point(286, 32);
            cBox_EdicaoMarcaSituacao.Name = "cBox_EdicaoMarcaSituacao";
            cBox_EdicaoMarcaSituacao.Size = new Size(96, 23);
            cBox_EdicaoMarcaSituacao.TabIndex = 28;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 9);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 29;
            label1.Text = "Situação";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tBox_EdicaoMarcaNome
            // 
            tBox_EdicaoMarcaNome.BackColor = SystemColors.ControlDarkDark;
            tBox_EdicaoMarcaNome.BorderStyle = BorderStyle.None;
            tBox_EdicaoMarcaNome.ForeColor = SystemColors.ControlLightLight;
            tBox_EdicaoMarcaNome.Location = new Point(9, 34);
            tBox_EdicaoMarcaNome.Margin = new Padding(0);
            tBox_EdicaoMarcaNome.Multiline = true;
            tBox_EdicaoMarcaNome.Name = "tBox_EdicaoMarcaNome";
            tBox_EdicaoMarcaNome.Size = new Size(195, 20);
            tBox_EdicaoMarcaNome.TabIndex = 27;
            // 
            // lbl_Descricao
            // 
            lbl_Descricao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Descricao.Location = new Point(9, 9);
            lbl_Descricao.Margin = new Padding(0);
            lbl_Descricao.Name = "lbl_Descricao";
            lbl_Descricao.Size = new Size(195, 20);
            lbl_Descricao.TabIndex = 26;
            lbl_Descricao.Text = "Nome da Marca";
            lbl_Descricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bttn_EdicaoMarcaSalvar
            // 
            bttn_EdicaoMarcaSalvar.Anchor = AnchorStyles.Top;
            bttn_EdicaoMarcaSalvar.BackColor = SystemColors.ControlDarkDark;
            bttn_EdicaoMarcaSalvar.FlatStyle = FlatStyle.Flat;
            bttn_EdicaoMarcaSalvar.ForeColor = SystemColors.ControlLightLight;
            bttn_EdicaoMarcaSalvar.Location = new Point(166, 215);
            bttn_EdicaoMarcaSalvar.Name = "bttn_EdicaoMarcaSalvar";
            bttn_EdicaoMarcaSalvar.Size = new Size(72, 33);
            bttn_EdicaoMarcaSalvar.TabIndex = 30;
            bttn_EdicaoMarcaSalvar.Text = "Salvar";
            bttn_EdicaoMarcaSalvar.UseVisualStyleBackColor = false;
            bttn_EdicaoMarcaSalvar.Click += bttn_EdicaoMarcaSalvar_Click;
            // 
            // EdicaoMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(391, 272);
            Controls.Add(bttn_EdicaoMarcaSalvar);
            Controls.Add(cBox_EdicaoMarcaSituacao);
            Controls.Add(label1);
            Controls.Add(tBox_EdicaoMarcaNome);
            Controls.Add(lbl_Descricao);
            Name = "EdicaoMarca";
            Text = "Edicao de Marcas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cBox_EdicaoMarcaSituacao;
        private Label label1;
        private TextBox tBox_EdicaoMarcaNome;
        private Label lbl_Descricao;
        private Button bttn_EdicaoMarcaSalvar;
    }
}