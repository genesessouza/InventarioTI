namespace InventarioTI.View.Cadastro
{
    partial class CadastroModelo
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
            bttn_CadastroModeloSalvar = new Button();
            lbl_CadastroDesc = new Label();
            tBox_CadastroModeloDescricao = new TextBox();
            cBox_CadastroModeloMarca = new ComboBox();
            label3 = new Label();
            cBox_CadastroModeloSituacao = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // bttn_CadastroModeloSalvar
            // 
            bttn_CadastroModeloSalvar.BackColor = SystemColors.ControlDarkDark;
            bttn_CadastroModeloSalvar.FlatStyle = FlatStyle.Flat;
            bttn_CadastroModeloSalvar.ForeColor = SystemColors.ControlLightLight;
            bttn_CadastroModeloSalvar.Location = new Point(149, 214);
            bttn_CadastroModeloSalvar.Name = "bttn_CadastroModeloSalvar";
            bttn_CadastroModeloSalvar.Size = new Size(87, 31);
            bttn_CadastroModeloSalvar.TabIndex = 7;
            bttn_CadastroModeloSalvar.Text = "Salvar";
            bttn_CadastroModeloSalvar.UseVisualStyleBackColor = false;
            bttn_CadastroModeloSalvar.Click += bttn_CadastroModeloSalvar_Click;
            // 
            // lbl_CadastroDesc
            // 
            lbl_CadastroDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CadastroDesc.Location = new Point(12, 20);
            lbl_CadastroDesc.Name = "lbl_CadastroDesc";
            lbl_CadastroDesc.Size = new Size(351, 21);
            lbl_CadastroDesc.TabIndex = 9;
            lbl_CadastroDesc.Text = "Descrição do Modelo";
            lbl_CadastroDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tBox_CadastroModeloDescricao
            // 
            tBox_CadastroModeloDescricao.BackColor = SystemColors.ControlDarkDark;
            tBox_CadastroModeloDescricao.BorderStyle = BorderStyle.FixedSingle;
            tBox_CadastroModeloDescricao.ForeColor = SystemColors.ControlLightLight;
            tBox_CadastroModeloDescricao.Location = new Point(12, 44);
            tBox_CadastroModeloDescricao.Name = "tBox_CadastroModeloDescricao";
            tBox_CadastroModeloDescricao.Size = new Size(351, 23);
            tBox_CadastroModeloDescricao.TabIndex = 8;
            // 
            // cBox_CadastroModeloMarca
            // 
            cBox_CadastroModeloMarca.AllowDrop = true;
            cBox_CadastroModeloMarca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_CadastroModeloMarca.BackColor = SystemColors.ControlDarkDark;
            cBox_CadastroModeloMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_CadastroModeloMarca.FlatStyle = FlatStyle.Popup;
            cBox_CadastroModeloMarca.ForeColor = SystemColors.ControlLightLight;
            cBox_CadastroModeloMarca.FormattingEnabled = true;
            cBox_CadastroModeloMarca.Location = new Point(12, 99);
            cBox_CadastroModeloMarca.Name = "cBox_CadastroModeloMarca";
            cBox_CadastroModeloMarca.Size = new Size(130, 23);
            cBox_CadastroModeloMarca.TabIndex = 36;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(130, 21);
            label3.TabIndex = 35;
            label3.Text = "Marca";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cBox_CadastroModeloSituacao
            // 
            cBox_CadastroModeloSituacao.AllowDrop = true;
            cBox_CadastroModeloSituacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_CadastroModeloSituacao.BackColor = SystemColors.ControlDarkDark;
            cBox_CadastroModeloSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_CadastroModeloSituacao.FlatStyle = FlatStyle.Popup;
            cBox_CadastroModeloSituacao.ForeColor = SystemColors.ControlLightLight;
            cBox_CadastroModeloSituacao.FormattingEnabled = true;
            cBox_CadastroModeloSituacao.Location = new Point(233, 99);
            cBox_CadastroModeloSituacao.Name = "cBox_CadastroModeloSituacao";
            cBox_CadastroModeloSituacao.Size = new Size(130, 23);
            cBox_CadastroModeloSituacao.TabIndex = 38;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 75);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 37;
            label1.Text = "Situação";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CadastroModelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(375, 257);
            Controls.Add(cBox_CadastroModeloSituacao);
            Controls.Add(label1);
            Controls.Add(cBox_CadastroModeloMarca);
            Controls.Add(label3);
            Controls.Add(bttn_CadastroModeloSalvar);
            Controls.Add(lbl_CadastroDesc);
            Controls.Add(tBox_CadastroModeloDescricao);
            Name = "CadastroModelo";
            Text = "Cadastro de Modelos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttn_CadastroModeloSalvar;
        private Label lbl_CadastroDesc;
        private TextBox tBox_CadastroModeloDescricao;
        private ComboBox cBox_CadastroModeloMarca;
        private Label label3;
        private ComboBox cBox_CadastroModeloSituacao;
        private Label label1;
    }
}