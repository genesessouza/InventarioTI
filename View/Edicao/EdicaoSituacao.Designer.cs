namespace InventarioTI.View.Edicao
{
    partial class EdicaoSituacao
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
            tBox_EdicaoSituacaoDescricao = new TextBox();
            lbl_Descricao = new Label();
            bttn_EdicaoSituacaoSalvar = new Button();
            SuspendLayout();
            // 
            // tBox_EdicaoSituacaoDescricao
            // 
            tBox_EdicaoSituacaoDescricao.BackColor = SystemColors.ControlDarkDark;
            tBox_EdicaoSituacaoDescricao.BorderStyle = BorderStyle.None;
            tBox_EdicaoSituacaoDescricao.ForeColor = SystemColors.ControlLightLight;
            tBox_EdicaoSituacaoDescricao.Location = new Point(21, 48);
            tBox_EdicaoSituacaoDescricao.Margin = new Padding(0);
            tBox_EdicaoSituacaoDescricao.Multiline = true;
            tBox_EdicaoSituacaoDescricao.Name = "tBox_EdicaoSituacaoDescricao";
            tBox_EdicaoSituacaoDescricao.Size = new Size(311, 20);
            tBox_EdicaoSituacaoDescricao.TabIndex = 29;
            // 
            // lbl_Descricao
            // 
            lbl_Descricao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Descricao.Location = new Point(21, 23);
            lbl_Descricao.Margin = new Padding(0);
            lbl_Descricao.Name = "lbl_Descricao";
            lbl_Descricao.Size = new Size(311, 20);
            lbl_Descricao.TabIndex = 28;
            lbl_Descricao.Text = "Descrição da Situação";
            lbl_Descricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bttn_EdicaoSituacaoSalvar
            // 
            bttn_EdicaoSituacaoSalvar.BackColor = Color.FromArgb(64, 64, 64);
            bttn_EdicaoSituacaoSalvar.FlatStyle = FlatStyle.Flat;
            bttn_EdicaoSituacaoSalvar.ForeColor = SystemColors.ControlLightLight;
            bttn_EdicaoSituacaoSalvar.Location = new Point(150, 131);
            bttn_EdicaoSituacaoSalvar.Name = "bttn_EdicaoSituacaoSalvar";
            bttn_EdicaoSituacaoSalvar.Size = new Size(53, 34);
            bttn_EdicaoSituacaoSalvar.TabIndex = 31;
            bttn_EdicaoSituacaoSalvar.Text = "Salvar";
            bttn_EdicaoSituacaoSalvar.UseVisualStyleBackColor = false;
            bttn_EdicaoSituacaoSalvar.Click += bttn_EdicaoSituacaoSalvar_Click;
            // 
            // EdicaoSituacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 177);
            Controls.Add(bttn_EdicaoSituacaoSalvar);
            Controls.Add(tBox_EdicaoSituacaoDescricao);
            Controls.Add(lbl_Descricao);
            Name = "EdicaoSituacao";
            Text = "Edicão de Situacões";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBox_EdicaoSituacaoDescricao;
        private Label lbl_Descricao;
        private Button bttn_EdicaoSituacaoSalvar;
    }
}