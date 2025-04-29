namespace InventarioTI.View.Edicao
{
    partial class EdicaoModelo
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
            cBox_EdicaoModeloSituacao = new ComboBox();
            label2 = new Label();
            lbl_Descricao = new Label();
            bttn_EdicaoModeloSalvar = new Button();
            tBox_EdicaoModeloNome = new TextBox();
            cBox_EdicaoModeloMarca = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // cBox_EdicaoModeloSituacao
            // 
            cBox_EdicaoModeloSituacao.AllowDrop = true;
            cBox_EdicaoModeloSituacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_EdicaoModeloSituacao.BackColor = SystemColors.ControlDarkDark;
            cBox_EdicaoModeloSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_EdicaoModeloSituacao.FlatStyle = FlatStyle.Popup;
            cBox_EdicaoModeloSituacao.ForeColor = SystemColors.ControlLightLight;
            cBox_EdicaoModeloSituacao.FormattingEnabled = true;
            cBox_EdicaoModeloSituacao.Location = new Point(279, 106);
            cBox_EdicaoModeloSituacao.Name = "cBox_EdicaoModeloSituacao";
            cBox_EdicaoModeloSituacao.Size = new Size(96, 23);
            cBox_EdicaoModeloSituacao.TabIndex = 37;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(279, 83);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 38;
            label2.Text = "Situação";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Descricao
            // 
            lbl_Descricao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Descricao.Location = new Point(9, 9);
            lbl_Descricao.Margin = new Padding(0);
            lbl_Descricao.Name = "lbl_Descricao";
            lbl_Descricao.Size = new Size(175, 20);
            lbl_Descricao.TabIndex = 35;
            lbl_Descricao.Text = "Descrição do Modelo";
            lbl_Descricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bttn_EdicaoModeloSalvar
            // 
            bttn_EdicaoModeloSalvar.BackColor = SystemColors.ControlDarkDark;
            bttn_EdicaoModeloSalvar.FlatStyle = FlatStyle.Flat;
            bttn_EdicaoModeloSalvar.ForeColor = SystemColors.ControlLightLight;
            bttn_EdicaoModeloSalvar.Location = new Point(159, 175);
            bttn_EdicaoModeloSalvar.Name = "bttn_EdicaoModeloSalvar";
            bttn_EdicaoModeloSalvar.Size = new Size(69, 34);
            bttn_EdicaoModeloSalvar.TabIndex = 41;
            bttn_EdicaoModeloSalvar.Text = "Salvar";
            bttn_EdicaoModeloSalvar.UseVisualStyleBackColor = false;
            bttn_EdicaoModeloSalvar.Click += bttn_EdicaoModeloSalvar_Click;
            // 
            // tBox_EdicaoModeloNome
            // 
            tBox_EdicaoModeloNome.BackColor = SystemColors.ControlDarkDark;
            tBox_EdicaoModeloNome.BorderStyle = BorderStyle.None;
            tBox_EdicaoModeloNome.ForeColor = SystemColors.ControlLightLight;
            tBox_EdicaoModeloNome.Location = new Point(9, 38);
            tBox_EdicaoModeloNome.Margin = new Padding(0);
            tBox_EdicaoModeloNome.Multiline = true;
            tBox_EdicaoModeloNome.Name = "tBox_EdicaoModeloNome";
            tBox_EdicaoModeloNome.Size = new Size(175, 20);
            tBox_EdicaoModeloNome.TabIndex = 42;
            // 
            // cBox_EdicaoModeloMarca
            // 
            cBox_EdicaoModeloMarca.AllowDrop = true;
            cBox_EdicaoModeloMarca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_EdicaoModeloMarca.BackColor = SystemColors.ControlDarkDark;
            cBox_EdicaoModeloMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_EdicaoModeloMarca.FlatStyle = FlatStyle.Popup;
            cBox_EdicaoModeloMarca.ForeColor = SystemColors.ControlLightLight;
            cBox_EdicaoModeloMarca.FormattingEnabled = true;
            cBox_EdicaoModeloMarca.Location = new Point(245, 35);
            cBox_EdicaoModeloMarca.Name = "cBox_EdicaoModeloMarca";
            cBox_EdicaoModeloMarca.Size = new Size(130, 23);
            cBox_EdicaoModeloMarca.TabIndex = 44;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(245, 11);
            label3.Name = "label3";
            label3.Size = new Size(130, 21);
            label3.TabIndex = 43;
            label3.Text = "Marca";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EdicaoModelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(387, 221);
            Controls.Add(cBox_EdicaoModeloMarca);
            Controls.Add(label3);
            Controls.Add(tBox_EdicaoModeloNome);
            Controls.Add(bttn_EdicaoModeloSalvar);
            Controls.Add(cBox_EdicaoModeloSituacao);
            Controls.Add(label2);
            Controls.Add(lbl_Descricao);
            Name = "EdicaoModelo";
            Text = "Edicão de Modelos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cBox_EdicaoModeloSituacao;
        private Label label2;
        private Label lbl_Descricao;
        private Button bttn_EdicaoModeloSalvar;
        private TextBox tBox_EdicaoModeloNome;
        private ComboBox cBox_EdicaoModeloMarca;
        private Label label3;
    }
}