namespace InventarioTI.View
{
    partial class ControleSituacao
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel_ControleBg = new Panel();
            dataGrid_Situacoes = new DataGridView();
            gBox_Filtragem = new GroupBox();
            bttn_SituacaoLimparFiltros = new Button();
            bttn_SituacaoFiltrar = new Button();
            label2 = new Label();
            label1 = new Label();
            lbl_Descricao = new Label();
            gBox_Controles = new GroupBox();
            bttn_SituacaoEditar = new Button();
            bttn_SituacaoCadastrar = new Button();
            bttn_SituacaoExcluir = new Button();
            cBox_SituacaoSelecao = new ComboBox();
            panel_ControleBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Situacoes).BeginInit();
            gBox_Filtragem.SuspendLayout();
            gBox_Controles.SuspendLayout();
            SuspendLayout();
            // 
            // panel_ControleBg
            // 
            panel_ControleBg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_ControleBg.BackColor = Color.White;
            panel_ControleBg.BorderStyle = BorderStyle.FixedSingle;
            panel_ControleBg.Controls.Add(dataGrid_Situacoes);
            panel_ControleBg.Controls.Add(gBox_Filtragem);
            panel_ControleBg.Controls.Add(gBox_Controles);
            panel_ControleBg.Location = new Point(0, 0);
            panel_ControleBg.Name = "panel_ControleBg";
            panel_ControleBg.Size = new Size(545, 409);
            panel_ControleBg.TabIndex = 14;
            // 
            // dataGrid_Situacoes
            // 
            dataGrid_Situacoes.AllowUserToAddRows = false;
            dataGrid_Situacoes.AllowUserToOrderColumns = true;
            dataGrid_Situacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Situacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Situacoes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGrid_Situacoes.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid_Situacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Situacoes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGrid_Situacoes.GridColor = SystemColors.ControlDarkDark;
            dataGrid_Situacoes.Location = new Point(11, 218);
            dataGrid_Situacoes.MultiSelect = false;
            dataGrid_Situacoes.Name = "dataGrid_Situacoes";
            dataGrid_Situacoes.RowHeadersVisible = false;
            dataGrid_Situacoes.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_Situacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Situacoes.Size = new Size(521, 165);
            dataGrid_Situacoes.TabIndex = 15;
            // 
            // gBox_Filtragem
            // 
            gBox_Filtragem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gBox_Filtragem.BackColor = SystemColors.ControlLightLight;
            gBox_Filtragem.Controls.Add(cBox_SituacaoSelecao);
            gBox_Filtragem.Controls.Add(bttn_SituacaoLimparFiltros);
            gBox_Filtragem.Controls.Add(bttn_SituacaoFiltrar);
            gBox_Filtragem.Controls.Add(label2);
            gBox_Filtragem.Controls.Add(label1);
            gBox_Filtragem.Controls.Add(lbl_Descricao);
            gBox_Filtragem.Location = new Point(11, 113);
            gBox_Filtragem.Name = "gBox_Filtragem";
            gBox_Filtragem.Size = new Size(521, 99);
            gBox_Filtragem.TabIndex = 14;
            gBox_Filtragem.TabStop = false;
            gBox_Filtragem.Text = "Filtragem";
            // 
            // bttn_SituacaoLimparFiltros
            // 
            bttn_SituacaoLimparFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttn_SituacaoLimparFiltros.BackColor = SystemColors.ControlDarkDark;
            bttn_SituacaoLimparFiltros.FlatStyle = FlatStyle.Flat;
            bttn_SituacaoLimparFiltros.ForeColor = SystemColors.ControlLightLight;
            bttn_SituacaoLimparFiltros.Location = new Point(405, 58);
            bttn_SituacaoLimparFiltros.Name = "bttn_SituacaoLimparFiltros";
            bttn_SituacaoLimparFiltros.Size = new Size(98, 27);
            bttn_SituacaoLimparFiltros.TabIndex = 33;
            bttn_SituacaoLimparFiltros.Text = "Limpar Filtros";
            bttn_SituacaoLimparFiltros.UseVisualStyleBackColor = false;
            bttn_SituacaoLimparFiltros.Click += bttn_SituacaoLimparFiltros_Click;
            // 
            // bttn_SituacaoFiltrar
            // 
            bttn_SituacaoFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttn_SituacaoFiltrar.BackColor = SystemColors.ControlDarkDark;
            bttn_SituacaoFiltrar.FlatStyle = FlatStyle.Flat;
            bttn_SituacaoFiltrar.ForeColor = SystemColors.ControlLightLight;
            bttn_SituacaoFiltrar.Location = new Point(405, 25);
            bttn_SituacaoFiltrar.Name = "bttn_SituacaoFiltrar";
            bttn_SituacaoFiltrar.Size = new Size(98, 27);
            bttn_SituacaoFiltrar.TabIndex = 32;
            bttn_SituacaoFiltrar.Text = "Filtrar";
            bttn_SituacaoFiltrar.UseVisualStyleBackColor = false;
            bttn_SituacaoFiltrar.Click += bttn_SituacaoFiltrar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(910, 28);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 29;
            label2.Text = "Situação";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1417, 28);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 25;
            label1.Text = "Situação";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Descricao
            // 
            lbl_Descricao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Descricao.Location = new Point(12, 28);
            lbl_Descricao.Margin = new Padding(0);
            lbl_Descricao.Name = "lbl_Descricao";
            lbl_Descricao.Size = new Size(246, 20);
            lbl_Descricao.TabIndex = 22;
            lbl_Descricao.Text = "Descrição";
            lbl_Descricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gBox_Controles
            // 
            gBox_Controles.BackColor = SystemColors.ControlLightLight;
            gBox_Controles.Controls.Add(bttn_SituacaoEditar);
            gBox_Controles.Controls.Add(bttn_SituacaoCadastrar);
            gBox_Controles.Controls.Add(bttn_SituacaoExcluir);
            gBox_Controles.Location = new Point(11, 11);
            gBox_Controles.Name = "gBox_Controles";
            gBox_Controles.Size = new Size(198, 83);
            gBox_Controles.TabIndex = 13;
            gBox_Controles.TabStop = false;
            gBox_Controles.Text = "Controles";
            // 
            // bttn_SituacaoEditar
            // 
            bttn_SituacaoEditar.BackColor = SystemColors.ControlDarkDark;
            bttn_SituacaoEditar.FlatStyle = FlatStyle.Flat;
            bttn_SituacaoEditar.ForeColor = SystemColors.ControlLightLight;
            bttn_SituacaoEditar.Location = new Point(75, 34);
            bttn_SituacaoEditar.Name = "bttn_SituacaoEditar";
            bttn_SituacaoEditar.Size = new Size(53, 34);
            bttn_SituacaoEditar.TabIndex = 1;
            bttn_SituacaoEditar.Text = "Editar";
            bttn_SituacaoEditar.UseVisualStyleBackColor = false;
            bttn_SituacaoEditar.Click += bttn_SituacaoEditar_Click;
            // 
            // bttn_SituacaoCadastrar
            // 
            bttn_SituacaoCadastrar.BackColor = SystemColors.ControlDarkDark;
            bttn_SituacaoCadastrar.FlatStyle = FlatStyle.Flat;
            bttn_SituacaoCadastrar.ForeColor = SystemColors.ControlLightLight;
            bttn_SituacaoCadastrar.Location = new Point(13, 34);
            bttn_SituacaoCadastrar.Name = "bttn_SituacaoCadastrar";
            bttn_SituacaoCadastrar.Size = new Size(53, 34);
            bttn_SituacaoCadastrar.TabIndex = 0;
            bttn_SituacaoCadastrar.Text = "Novo";
            bttn_SituacaoCadastrar.UseVisualStyleBackColor = false;
            bttn_SituacaoCadastrar.Click += bttn_SituacaoCadastrar_Click;
            // 
            // bttn_SituacaoExcluir
            // 
            bttn_SituacaoExcluir.BackColor = SystemColors.ControlDarkDark;
            bttn_SituacaoExcluir.FlatStyle = FlatStyle.Flat;
            bttn_SituacaoExcluir.ForeColor = SystemColors.ControlLightLight;
            bttn_SituacaoExcluir.Location = new Point(134, 34);
            bttn_SituacaoExcluir.Name = "bttn_SituacaoExcluir";
            bttn_SituacaoExcluir.Size = new Size(53, 34);
            bttn_SituacaoExcluir.TabIndex = 2;
            bttn_SituacaoExcluir.Text = "Excluir";
            bttn_SituacaoExcluir.UseVisualStyleBackColor = false;
            bttn_SituacaoExcluir.Click += bttn_SituacaoExcluir_Click;
            // 
            // cBox_SituacaoSelecao
            // 
            cBox_SituacaoSelecao.AllowDrop = true;
            cBox_SituacaoSelecao.AutoCompleteMode = AutoCompleteMode.Append;
            cBox_SituacaoSelecao.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBox_SituacaoSelecao.BackColor = SystemColors.ControlDarkDark;
            cBox_SituacaoSelecao.FlatStyle = FlatStyle.Popup;
            cBox_SituacaoSelecao.ForeColor = SystemColors.ControlLightLight;
            cBox_SituacaoSelecao.FormattingEnabled = true;
            cBox_SituacaoSelecao.Location = new Point(13, 51);
            cBox_SituacaoSelecao.Name = "cBox_SituacaoSelecao";
            cBox_SituacaoSelecao.Size = new Size(246, 23);
            cBox_SituacaoSelecao.TabIndex = 35;
            // 
            // ControleSituacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 409);
            Controls.Add(panel_ControleBg);
            Name = "ControleSituacao";
            Text = "Controle de Situacões";
            panel_ControleBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid_Situacoes).EndInit();
            gBox_Filtragem.ResumeLayout(false);
            gBox_Controles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_ControleBg;
        private DataGridView dataGrid_Situacoes;
        private GroupBox gBox_Filtragem;
        private Label label2;
        private Label label1;
        private Label lbl_Descricao;
        private GroupBox gBox_Controles;
        private Button bttn_SituacaoEditar;
        private Button bttn_SituacaoCadastrar;
        private Button bttn_SituacaoExcluir;
        private Button bttn_SituacaoLimparFiltros;
        private Button bttn_SituacaoFiltrar;
        private ComboBox cBox_SituacaoSelecao;
    }
}