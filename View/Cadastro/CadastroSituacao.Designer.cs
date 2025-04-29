namespace InventarioTI.View.Cadastro
{
    partial class CadastroSituacao
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
            lbl_CadastroDesc = new Label();
            tBox_CadastroSituacaoValor = new TextBox();
            bttn_CadastroSituacaoSalvar = new Button();
            SuspendLayout();
            // 
            // lbl_CadastroDesc
            // 
            lbl_CadastroDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CadastroDesc.Location = new Point(12, 29);
            lbl_CadastroDesc.Name = "lbl_CadastroDesc";
            lbl_CadastroDesc.Size = new Size(332, 21);
            lbl_CadastroDesc.TabIndex = 3;
            lbl_CadastroDesc.Text = "Descrição";
            lbl_CadastroDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tBox_CadastroSituacaoValor
            // 
            tBox_CadastroSituacaoValor.BackColor = SystemColors.ControlDarkDark;
            tBox_CadastroSituacaoValor.BorderStyle = BorderStyle.FixedSingle;
            tBox_CadastroSituacaoValor.ForeColor = SystemColors.ControlLightLight;
            tBox_CadastroSituacaoValor.Location = new Point(12, 53);
            tBox_CadastroSituacaoValor.Name = "tBox_CadastroSituacaoValor";
            tBox_CadastroSituacaoValor.Size = new Size(332, 23);
            tBox_CadastroSituacaoValor.TabIndex = 2;
            // 
            // bttn_CadastroSituacaoSalvar
            // 
            bttn_CadastroSituacaoSalvar.BackColor = SystemColors.ControlDarkDark;
            bttn_CadastroSituacaoSalvar.FlatStyle = FlatStyle.Flat;
            bttn_CadastroSituacaoSalvar.ForeColor = SystemColors.ControlLightLight;
            bttn_CadastroSituacaoSalvar.Location = new Point(135, 125);
            bttn_CadastroSituacaoSalvar.Name = "bttn_CadastroSituacaoSalvar";
            bttn_CadastroSituacaoSalvar.Size = new Size(87, 31);
            bttn_CadastroSituacaoSalvar.TabIndex = 0;
            bttn_CadastroSituacaoSalvar.Text = "Salvar";
            bttn_CadastroSituacaoSalvar.UseVisualStyleBackColor = false;
            bttn_CadastroSituacaoSalvar.Click += bttn_CadastroSituacaoSalvar_Click;
            // 
            // CadastroSituacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(356, 168);
            Controls.Add(bttn_CadastroSituacaoSalvar);
            Controls.Add(lbl_CadastroDesc);
            Controls.Add(tBox_CadastroSituacaoValor);
            Name = "CadastroSituacao";
            Text = "Cadastro de Situacões";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_CadastroDesc;
        private TextBox tBox_CadastroSituacaoValor;
        private Button bttn_CadastroSituacaoSalvar;
    }
}