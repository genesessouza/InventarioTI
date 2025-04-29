namespace InventarioTI.View.Cadastro
{
    partial class CadastroMarca
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
            bttn_CadastroMarcaSalvar = new Button();
            lbl_CadastroDesc = new Label();
            tBox_CadastroMarcaNome = new TextBox();
            cBox_MarcaSituacao = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // bttn_CadastroMarcaSalvar
            // 
            bttn_CadastroMarcaSalvar.BackColor = SystemColors.ControlDarkDark;
            bttn_CadastroMarcaSalvar.FlatStyle = FlatStyle.Flat;
            bttn_CadastroMarcaSalvar.ForeColor = SystemColors.ControlLightLight;
            bttn_CadastroMarcaSalvar.Location = new Point(146, 207);
            bttn_CadastroMarcaSalvar.Name = "bttn_CadastroMarcaSalvar";
            bttn_CadastroMarcaSalvar.Size = new Size(87, 31);
            bttn_CadastroMarcaSalvar.TabIndex = 4;
            bttn_CadastroMarcaSalvar.Text = "Salvar";
            bttn_CadastroMarcaSalvar.UseVisualStyleBackColor = false;
            bttn_CadastroMarcaSalvar.Click += bttn_CadastroMarcaSalvar_Click;
            // 
            // lbl_CadastroDesc
            // 
            lbl_CadastroDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CadastroDesc.Location = new Point(22, 67);
            lbl_CadastroDesc.Name = "lbl_CadastroDesc";
            lbl_CadastroDesc.Size = new Size(186, 21);
            lbl_CadastroDesc.TabIndex = 6;
            lbl_CadastroDesc.Text = "Nome da Marca";
            lbl_CadastroDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tBox_CadastroMarcaNome
            // 
            tBox_CadastroMarcaNome.BackColor = SystemColors.ControlDarkDark;
            tBox_CadastroMarcaNome.BorderStyle = BorderStyle.FixedSingle;
            tBox_CadastroMarcaNome.ForeColor = SystemColors.ControlLightLight;
            tBox_CadastroMarcaNome.Location = new Point(22, 91);
            tBox_CadastroMarcaNome.Name = "tBox_CadastroMarcaNome";
            tBox_CadastroMarcaNome.Size = new Size(186, 23);
            tBox_CadastroMarcaNome.TabIndex = 5;
            // 
            // cBox_MarcaSituacao
            // 
            cBox_MarcaSituacao.AllowDrop = true;
            cBox_MarcaSituacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_MarcaSituacao.BackColor = SystemColors.ControlDarkDark;
            cBox_MarcaSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_MarcaSituacao.FlatStyle = FlatStyle.Popup;
            cBox_MarcaSituacao.ForeColor = SystemColors.ControlLightLight;
            cBox_MarcaSituacao.FormattingEnabled = true;
            cBox_MarcaSituacao.Location = new Point(260, 91);
            cBox_MarcaSituacao.Name = "cBox_MarcaSituacao";
            cBox_MarcaSituacao.Size = new Size(96, 23);
            cBox_MarcaSituacao.TabIndex = 26;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 68);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 27;
            label1.Text = "Situação";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CadastroMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(377, 260);
            Controls.Add(cBox_MarcaSituacao);
            Controls.Add(label1);
            Controls.Add(bttn_CadastroMarcaSalvar);
            Controls.Add(lbl_CadastroDesc);
            Controls.Add(tBox_CadastroMarcaNome);
            Name = "CadastroMarca";
            Text = "Cadastro de Marcas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttn_CadastroMarcaSalvar;
        private Label lbl_CadastroDesc;
        private TextBox tBox_CadastroMarcaNome;
        private ComboBox cBox_MarcaSituacao;
        private Label label1;
    }
}