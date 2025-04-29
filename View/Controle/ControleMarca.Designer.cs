namespace InventarioTI.View
{
    partial class ControleMarca
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
            dataGrid_Marcas = new DataGridView();
            gBox_Filtragem = new GroupBox();
            cBox_MarcaSelecao = new ComboBox();
            bttn_MarcaLimparFiltros = new Button();
            bttn_MarcaFiltrar = new Button();
            cBox_MarcaSituacao = new ComboBox();
            label1 = new Label();
            lbl_Descricao = new Label();
            gBox_Controles = new GroupBox();
            bttn_MarcaEditar = new Button();
            bttn_MarcaCadastrar = new Button();
            bttn_MarcaExcluir = new Button();
            panel_ControleBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Marcas).BeginInit();
            gBox_Filtragem.SuspendLayout();
            gBox_Controles.SuspendLayout();
            SuspendLayout();
            // 
            // panel_ControleBg
            // 
            panel_ControleBg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_ControleBg.BackColor = Color.White;
            panel_ControleBg.BorderStyle = BorderStyle.FixedSingle;
            panel_ControleBg.Controls.Add(dataGrid_Marcas);
            panel_ControleBg.Controls.Add(gBox_Filtragem);
            panel_ControleBg.Controls.Add(gBox_Controles);
            panel_ControleBg.Location = new Point(0, 0);
            panel_ControleBg.Name = "panel_ControleBg";
            panel_ControleBg.Size = new Size(732, 506);
            panel_ControleBg.TabIndex = 12;
            // 
            // dataGrid_Marcas
            // 
            dataGrid_Marcas.AllowUserToAddRows = false;
            dataGrid_Marcas.AllowUserToOrderColumns = true;
            dataGrid_Marcas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Marcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Marcas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGrid_Marcas.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid_Marcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Marcas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGrid_Marcas.GridColor = SystemColors.ControlDarkDark;
            dataGrid_Marcas.Location = new Point(11, 218);
            dataGrid_Marcas.MultiSelect = false;
            dataGrid_Marcas.Name = "dataGrid_Marcas";
            dataGrid_Marcas.RowHeadersVisible = false;
            dataGrid_Marcas.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_Marcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Marcas.Size = new Size(708, 277);
            dataGrid_Marcas.TabIndex = 15;
            // 
            // gBox_Filtragem
            // 
            gBox_Filtragem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gBox_Filtragem.BackColor = SystemColors.ControlLightLight;
            gBox_Filtragem.Controls.Add(cBox_MarcaSelecao);
            gBox_Filtragem.Controls.Add(bttn_MarcaLimparFiltros);
            gBox_Filtragem.Controls.Add(bttn_MarcaFiltrar);
            gBox_Filtragem.Controls.Add(cBox_MarcaSituacao);
            gBox_Filtragem.Controls.Add(label1);
            gBox_Filtragem.Controls.Add(lbl_Descricao);
            gBox_Filtragem.Location = new Point(11, 113);
            gBox_Filtragem.Name = "gBox_Filtragem";
            gBox_Filtragem.Size = new Size(708, 99);
            gBox_Filtragem.TabIndex = 14;
            gBox_Filtragem.TabStop = false;
            gBox_Filtragem.Text = "Filtragem";
            // 
            // cBox_MarcaSelecao
            // 
            cBox_MarcaSelecao.AllowDrop = true;
            cBox_MarcaSelecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_MarcaSelecao.AutoCompleteMode = AutoCompleteMode.Append;
            cBox_MarcaSelecao.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBox_MarcaSelecao.BackColor = SystemColors.ControlDarkDark;
            cBox_MarcaSelecao.FlatStyle = FlatStyle.Popup;
            cBox_MarcaSelecao.ForeColor = SystemColors.ControlLightLight;
            cBox_MarcaSelecao.FormattingEnabled = true;
            cBox_MarcaSelecao.Location = new Point(12, 51);
            cBox_MarcaSelecao.Name = "cBox_MarcaSelecao";
            cBox_MarcaSelecao.Size = new Size(245, 23);
            cBox_MarcaSelecao.TabIndex = 28;
            // 
            // bttn_MarcaLimparFiltros
            // 
            bttn_MarcaLimparFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttn_MarcaLimparFiltros.BackColor = SystemColors.ControlDarkDark;
            bttn_MarcaLimparFiltros.FlatStyle = FlatStyle.Flat;
            bttn_MarcaLimparFiltros.ForeColor = SystemColors.ControlLightLight;
            bttn_MarcaLimparFiltros.Location = new Point(595, 54);
            bttn_MarcaLimparFiltros.Name = "bttn_MarcaLimparFiltros";
            bttn_MarcaLimparFiltros.Size = new Size(98, 27);
            bttn_MarcaLimparFiltros.TabIndex = 27;
            bttn_MarcaLimparFiltros.Text = "Limpar Filtros";
            bttn_MarcaLimparFiltros.UseVisualStyleBackColor = false;
            bttn_MarcaLimparFiltros.Click += bttn_MarcaLimparFiltros_Click;
            // 
            // bttn_MarcaFiltrar
            // 
            bttn_MarcaFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttn_MarcaFiltrar.BackColor = SystemColors.ControlDarkDark;
            bttn_MarcaFiltrar.FlatStyle = FlatStyle.Flat;
            bttn_MarcaFiltrar.ForeColor = SystemColors.ControlLightLight;
            bttn_MarcaFiltrar.Location = new Point(595, 21);
            bttn_MarcaFiltrar.Name = "bttn_MarcaFiltrar";
            bttn_MarcaFiltrar.Size = new Size(98, 27);
            bttn_MarcaFiltrar.TabIndex = 26;
            bttn_MarcaFiltrar.Text = "Filtrar";
            bttn_MarcaFiltrar.UseVisualStyleBackColor = false;
            bttn_MarcaFiltrar.Click += bttn_MarcaFiltrar_Click;
            // 
            // cBox_MarcaSituacao
            // 
            cBox_MarcaSituacao.AllowDrop = true;
            cBox_MarcaSituacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_MarcaSituacao.AutoCompleteMode = AutoCompleteMode.Append;
            cBox_MarcaSituacao.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBox_MarcaSituacao.BackColor = SystemColors.ControlDarkDark;
            cBox_MarcaSituacao.FlatStyle = FlatStyle.Popup;
            cBox_MarcaSituacao.ForeColor = SystemColors.ControlLightLight;
            cBox_MarcaSituacao.FormattingEnabled = true;
            cBox_MarcaSituacao.Location = new Point(389, 51);
            cBox_MarcaSituacao.Name = "cBox_MarcaSituacao";
            cBox_MarcaSituacao.Size = new Size(96, 23);
            cBox_MarcaSituacao.TabIndex = 24;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(389, 28);
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
            lbl_Descricao.Text = "Nome da Marca";
            lbl_Descricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gBox_Controles
            // 
            gBox_Controles.BackColor = SystemColors.ControlLightLight;
            gBox_Controles.Controls.Add(bttn_MarcaEditar);
            gBox_Controles.Controls.Add(bttn_MarcaCadastrar);
            gBox_Controles.Controls.Add(bttn_MarcaExcluir);
            gBox_Controles.Location = new Point(11, 11);
            gBox_Controles.Name = "gBox_Controles";
            gBox_Controles.Size = new Size(198, 83);
            gBox_Controles.TabIndex = 13;
            gBox_Controles.TabStop = false;
            gBox_Controles.Text = "Controles";
            // 
            // bttn_MarcaEditar
            // 
            bttn_MarcaEditar.BackColor = SystemColors.ControlDarkDark;
            bttn_MarcaEditar.FlatStyle = FlatStyle.Flat;
            bttn_MarcaEditar.ForeColor = SystemColors.ControlLightLight;
            bttn_MarcaEditar.Location = new Point(75, 34);
            bttn_MarcaEditar.Name = "bttn_MarcaEditar";
            bttn_MarcaEditar.Size = new Size(53, 34);
            bttn_MarcaEditar.TabIndex = 1;
            bttn_MarcaEditar.Text = "Editar";
            bttn_MarcaEditar.UseVisualStyleBackColor = false;
            bttn_MarcaEditar.Click += bttn_MarcaEditar_Click;
            // 
            // bttn_MarcaCadastrar
            // 
            bttn_MarcaCadastrar.BackColor = SystemColors.ControlDarkDark;
            bttn_MarcaCadastrar.FlatStyle = FlatStyle.Flat;
            bttn_MarcaCadastrar.ForeColor = SystemColors.ControlLightLight;
            bttn_MarcaCadastrar.Location = new Point(13, 34);
            bttn_MarcaCadastrar.Name = "bttn_MarcaCadastrar";
            bttn_MarcaCadastrar.Size = new Size(53, 34);
            bttn_MarcaCadastrar.TabIndex = 0;
            bttn_MarcaCadastrar.Text = "Novo";
            bttn_MarcaCadastrar.UseVisualStyleBackColor = false;
            bttn_MarcaCadastrar.Click += bttn_MarcaCadastrar_Click;
            // 
            // bttn_MarcaExcluir
            // 
            bttn_MarcaExcluir.BackColor = SystemColors.ControlDarkDark;
            bttn_MarcaExcluir.FlatStyle = FlatStyle.Flat;
            bttn_MarcaExcluir.ForeColor = SystemColors.ControlLightLight;
            bttn_MarcaExcluir.Location = new Point(134, 34);
            bttn_MarcaExcluir.Name = "bttn_MarcaExcluir";
            bttn_MarcaExcluir.Size = new Size(53, 34);
            bttn_MarcaExcluir.TabIndex = 2;
            bttn_MarcaExcluir.Text = "Excluir";
            bttn_MarcaExcluir.UseVisualStyleBackColor = false;
            bttn_MarcaExcluir.Click += bttn_MarcaExcluir_Click;
            // 
            // ControleMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 508);
            Controls.Add(panel_ControleBg);
            Name = "ControleMarca";
            Text = "Controle de Marcas";
            panel_ControleBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid_Marcas).EndInit();
            gBox_Filtragem.ResumeLayout(false);
            gBox_Controles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_ControleBg;
        private GroupBox gBox_Controles;
        private Button bttn_MarcaEditar;
        private Button bttn_MarcaCadastrar;
        private Button bttn_MarcaExcluir;
        private GroupBox gBox_Filtragem;
        private Label lbl_Descricao;
        private Button bttn_MarcaLimparFiltros;
        private Button bttn_MarcaFiltrar;
        private ComboBox cBox_MarcaSituacao;
        private Label label1;
        private DataGridView dataGrid_Marcas;
        private ComboBox cBox_MarcaSelecao;
    }
}