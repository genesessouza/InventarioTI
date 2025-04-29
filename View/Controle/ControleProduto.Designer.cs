namespace InventarioTI
{
    partial class ControleProduto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            bttn_ProdutoInserir = new Button();
            bttn_ProdutoEditar = new Button();
            bttn_ProdutoExcluir = new Button();
            gBox_Filtragem = new GroupBox();
            bttn_ProdutoLimparFiltros = new Button();
            bttn_ProdutoFiltrar = new Button();
            lbl_Descricao = new Label();
            cBox_ProdutoSituacao = new ComboBox();
            lbl_Marca = new Label();
            lbl_Situacao = new Label();
            cBox_ProdutoModelo = new ComboBox();
            cBox_ProdutoMarca = new ComboBox();
            lbl_Modelo = new Label();
            gBox_Controles = new GroupBox();
            panel_ControleBg = new Panel();
            dataGrid_Produtos = new DataGridView();
            cBox_ProdutoSelecao = new ComboBox();
            gBox_Filtragem.SuspendLayout();
            gBox_Controles.SuspendLayout();
            panel_ControleBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Produtos).BeginInit();
            SuspendLayout();
            // 
            // bttn_ProdutoInserir
            // 
            bttn_ProdutoInserir.BackColor = SystemColors.ControlDarkDark;
            bttn_ProdutoInserir.FlatStyle = FlatStyle.Flat;
            bttn_ProdutoInserir.ForeColor = SystemColors.ControlLightLight;
            bttn_ProdutoInserir.Location = new Point(13, 34);
            bttn_ProdutoInserir.Name = "bttn_ProdutoInserir";
            bttn_ProdutoInserir.Size = new Size(53, 34);
            bttn_ProdutoInserir.TabIndex = 0;
            bttn_ProdutoInserir.Text = "Novo";
            bttn_ProdutoInserir.UseVisualStyleBackColor = false;
            bttn_ProdutoInserir.Click += bttn_Inserir_Click;
            // 
            // bttn_ProdutoEditar
            // 
            bttn_ProdutoEditar.BackColor = SystemColors.ControlDarkDark;
            bttn_ProdutoEditar.FlatStyle = FlatStyle.Flat;
            bttn_ProdutoEditar.ForeColor = SystemColors.ControlLightLight;
            bttn_ProdutoEditar.Location = new Point(75, 34);
            bttn_ProdutoEditar.Name = "bttn_ProdutoEditar";
            bttn_ProdutoEditar.Size = new Size(53, 34);
            bttn_ProdutoEditar.TabIndex = 1;
            bttn_ProdutoEditar.Text = "Editar";
            bttn_ProdutoEditar.UseVisualStyleBackColor = false;
            bttn_ProdutoEditar.Click += bttn_Editar_Click;
            // 
            // bttn_ProdutoExcluir
            // 
            bttn_ProdutoExcluir.BackColor = SystemColors.ControlDarkDark;
            bttn_ProdutoExcluir.FlatStyle = FlatStyle.Flat;
            bttn_ProdutoExcluir.ForeColor = SystemColors.ControlLightLight;
            bttn_ProdutoExcluir.Location = new Point(134, 34);
            bttn_ProdutoExcluir.Name = "bttn_ProdutoExcluir";
            bttn_ProdutoExcluir.Size = new Size(53, 34);
            bttn_ProdutoExcluir.TabIndex = 2;
            bttn_ProdutoExcluir.Text = "Excluir";
            bttn_ProdutoExcluir.UseVisualStyleBackColor = false;
            bttn_ProdutoExcluir.Click += bttn_Excluir_Click;
            // 
            // gBox_Filtragem
            // 
            gBox_Filtragem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gBox_Filtragem.BackColor = SystemColors.ControlLightLight;
            gBox_Filtragem.Controls.Add(cBox_ProdutoSelecao);
            gBox_Filtragem.Controls.Add(bttn_ProdutoLimparFiltros);
            gBox_Filtragem.Controls.Add(bttn_ProdutoFiltrar);
            gBox_Filtragem.Controls.Add(lbl_Descricao);
            gBox_Filtragem.Controls.Add(cBox_ProdutoSituacao);
            gBox_Filtragem.Controls.Add(lbl_Marca);
            gBox_Filtragem.Controls.Add(lbl_Situacao);
            gBox_Filtragem.Controls.Add(cBox_ProdutoModelo);
            gBox_Filtragem.Controls.Add(cBox_ProdutoMarca);
            gBox_Filtragem.Controls.Add(lbl_Modelo);
            gBox_Filtragem.Location = new Point(14, 95);
            gBox_Filtragem.Name = "gBox_Filtragem";
            gBox_Filtragem.Size = new Size(1116, 99);
            gBox_Filtragem.TabIndex = 9;
            gBox_Filtragem.TabStop = false;
            gBox_Filtragem.Text = "Filtragem";
            // 
            // bttn_ProdutoLimparFiltros
            // 
            bttn_ProdutoLimparFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttn_ProdutoLimparFiltros.BackColor = SystemColors.ControlDarkDark;
            bttn_ProdutoLimparFiltros.FlatStyle = FlatStyle.Flat;
            bttn_ProdutoLimparFiltros.ForeColor = SystemColors.ControlLightLight;
            bttn_ProdutoLimparFiltros.Location = new Point(1001, 51);
            bttn_ProdutoLimparFiltros.Name = "bttn_ProdutoLimparFiltros";
            bttn_ProdutoLimparFiltros.Size = new Size(98, 27);
            bttn_ProdutoLimparFiltros.TabIndex = 18;
            bttn_ProdutoLimparFiltros.Text = "Limpar Filtros";
            bttn_ProdutoLimparFiltros.UseVisualStyleBackColor = false;
            bttn_ProdutoLimparFiltros.Click += bttn_LimparFiltros_Click;
            // 
            // bttn_ProdutoFiltrar
            // 
            bttn_ProdutoFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttn_ProdutoFiltrar.BackColor = SystemColors.ControlDarkDark;
            bttn_ProdutoFiltrar.FlatStyle = FlatStyle.Flat;
            bttn_ProdutoFiltrar.ForeColor = SystemColors.ControlLightLight;
            bttn_ProdutoFiltrar.Location = new Point(1001, 18);
            bttn_ProdutoFiltrar.Name = "bttn_ProdutoFiltrar";
            bttn_ProdutoFiltrar.Size = new Size(98, 27);
            bttn_ProdutoFiltrar.TabIndex = 17;
            bttn_ProdutoFiltrar.Text = "Filtrar";
            bttn_ProdutoFiltrar.UseVisualStyleBackColor = false;
            bttn_ProdutoFiltrar.Click += bttn_Filtrar_Click;
            // 
            // lbl_Descricao
            // 
            lbl_Descricao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Descricao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Descricao.Location = new Point(13, 25);
            lbl_Descricao.Margin = new Padding(0);
            lbl_Descricao.Name = "lbl_Descricao";
            lbl_Descricao.Size = new Size(246, 20);
            lbl_Descricao.TabIndex = 20;
            lbl_Descricao.Text = "Descrição";
            lbl_Descricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cBox_ProdutoSituacao
            // 
            cBox_ProdutoSituacao.AllowDrop = true;
            cBox_ProdutoSituacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_ProdutoSituacao.AutoCompleteMode = AutoCompleteMode.Append;
            cBox_ProdutoSituacao.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBox_ProdutoSituacao.BackColor = SystemColors.ControlDarkDark;
            cBox_ProdutoSituacao.FlatStyle = FlatStyle.Popup;
            cBox_ProdutoSituacao.ForeColor = SystemColors.ControlLightLight;
            cBox_ProdutoSituacao.FormattingEnabled = true;
            cBox_ProdutoSituacao.Location = new Point(809, 50);
            cBox_ProdutoSituacao.Name = "cBox_ProdutoSituacao";
            cBox_ProdutoSituacao.Size = new Size(96, 23);
            cBox_ProdutoSituacao.TabIndex = 13;
            // 
            // lbl_Marca
            // 
            lbl_Marca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Marca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Marca.Location = new Point(452, 25);
            lbl_Marca.Margin = new Padding(0);
            lbl_Marca.Name = "lbl_Marca";
            lbl_Marca.Size = new Size(155, 20);
            lbl_Marca.TabIndex = 14;
            lbl_Marca.Text = "Marca";
            lbl_Marca.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Situacao
            // 
            lbl_Situacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Situacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Situacao.Location = new Point(809, 25);
            lbl_Situacao.Margin = new Padding(0);
            lbl_Situacao.Name = "lbl_Situacao";
            lbl_Situacao.Size = new Size(96, 20);
            lbl_Situacao.TabIndex = 16;
            lbl_Situacao.Text = "Situação";
            lbl_Situacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cBox_ProdutoModelo
            // 
            cBox_ProdutoModelo.AllowDrop = true;
            cBox_ProdutoModelo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_ProdutoModelo.AutoCompleteMode = AutoCompleteMode.Append;
            cBox_ProdutoModelo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBox_ProdutoModelo.BackColor = SystemColors.ControlDarkDark;
            cBox_ProdutoModelo.FlatStyle = FlatStyle.Popup;
            cBox_ProdutoModelo.ForeColor = SystemColors.ControlLightLight;
            cBox_ProdutoModelo.FormattingEnabled = true;
            cBox_ProdutoModelo.Location = new Point(630, 50);
            cBox_ProdutoModelo.Name = "cBox_ProdutoModelo";
            cBox_ProdutoModelo.Size = new Size(150, 23);
            cBox_ProdutoModelo.TabIndex = 12;
            // 
            // cBox_ProdutoMarca
            // 
            cBox_ProdutoMarca.AllowDrop = true;
            cBox_ProdutoMarca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_ProdutoMarca.AutoCompleteMode = AutoCompleteMode.Append;
            cBox_ProdutoMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBox_ProdutoMarca.BackColor = SystemColors.ControlDarkDark;
            cBox_ProdutoMarca.FlatStyle = FlatStyle.Popup;
            cBox_ProdutoMarca.ForeColor = SystemColors.ControlLightLight;
            cBox_ProdutoMarca.FormattingEnabled = true;
            cBox_ProdutoMarca.Location = new Point(452, 50);
            cBox_ProdutoMarca.Name = "cBox_ProdutoMarca";
            cBox_ProdutoMarca.Size = new Size(155, 23);
            cBox_ProdutoMarca.TabIndex = 11;
            // 
            // lbl_Modelo
            // 
            lbl_Modelo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Modelo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Modelo.Location = new Point(630, 28);
            lbl_Modelo.Margin = new Padding(0);
            lbl_Modelo.Name = "lbl_Modelo";
            lbl_Modelo.Size = new Size(150, 20);
            lbl_Modelo.TabIndex = 15;
            lbl_Modelo.Text = "Modelo";
            lbl_Modelo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gBox_Controles
            // 
            gBox_Controles.BackColor = SystemColors.ControlLightLight;
            gBox_Controles.Controls.Add(bttn_ProdutoEditar);
            gBox_Controles.Controls.Add(bttn_ProdutoInserir);
            gBox_Controles.Controls.Add(bttn_ProdutoExcluir);
            gBox_Controles.Location = new Point(14, 6);
            gBox_Controles.Name = "gBox_Controles";
            gBox_Controles.Size = new Size(198, 83);
            gBox_Controles.TabIndex = 10;
            gBox_Controles.TabStop = false;
            gBox_Controles.Text = "Controles";
            // 
            // panel_ControleBg
            // 
            panel_ControleBg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_ControleBg.BackColor = Color.White;
            panel_ControleBg.BorderStyle = BorderStyle.FixedSingle;
            panel_ControleBg.Controls.Add(dataGrid_Produtos);
            panel_ControleBg.Controls.Add(gBox_Controles);
            panel_ControleBg.Controls.Add(gBox_Filtragem);
            panel_ControleBg.Location = new Point(1, 1);
            panel_ControleBg.Name = "panel_ControleBg";
            panel_ControleBg.Size = new Size(1146, 606);
            panel_ControleBg.TabIndex = 11;
            // 
            // dataGrid_Produtos
            // 
            dataGrid_Produtos.AllowUserToAddRows = false;
            dataGrid_Produtos.AllowUserToOrderColumns = true;
            dataGrid_Produtos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Produtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Produtos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGrid_Produtos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid_Produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Produtos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGrid_Produtos.GridColor = SystemColors.ControlDarkDark;
            dataGrid_Produtos.Location = new Point(14, 209);
            dataGrid_Produtos.MultiSelect = false;
            dataGrid_Produtos.Name = "dataGrid_Produtos";
            dataGrid_Produtos.RowHeadersVisible = false;
            dataGrid_Produtos.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_Produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Produtos.Size = new Size(1114, 350);
            dataGrid_Produtos.TabIndex = 11;
            // 
            // cBox_ProdutoSelecao
            // 
            cBox_ProdutoSelecao.AllowDrop = true;
            cBox_ProdutoSelecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_ProdutoSelecao.AutoCompleteMode = AutoCompleteMode.Append;
            cBox_ProdutoSelecao.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBox_ProdutoSelecao.BackColor = SystemColors.ControlDarkDark;
            cBox_ProdutoSelecao.FlatStyle = FlatStyle.Popup;
            cBox_ProdutoSelecao.ForeColor = SystemColors.ControlLightLight;
            cBox_ProdutoSelecao.FormattingEnabled = true;
            cBox_ProdutoSelecao.Location = new Point(13, 50);
            cBox_ProdutoSelecao.Name = "cBox_ProdutoSelecao";
            cBox_ProdutoSelecao.Size = new Size(246, 23);
            cBox_ProdutoSelecao.TabIndex = 21;
            // 
            // ControleProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1148, 609);
            Controls.Add(panel_ControleBg);
            Name = "ControleProduto";
            Text = "Controle de Produtos";
            gBox_Filtragem.ResumeLayout(false);
            gBox_Controles.ResumeLayout(false);
            panel_ControleBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid_Produtos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bttn_ProdutoInserir;
        private Button bttn_ProdutoEditar;
        private Button bttn_ProdutoExcluir;
        private GroupBox gBox_Filtragem;
        private GroupBox gBox_Controles;
        private ComboBox cBox_ProdutoModelo;
        private ComboBox cBox_ProdutoMarca;
        private Label lbl_Situacao;
        private Label lbl_Modelo;
        private Label lbl_Marca;
        private ComboBox cBox_ProdutoSituacao;
        private Panel panel_ControleBg;
        private Button bttn_ProdutoLimparFiltros;
        private Button bttn_ProdutoFiltrar;
        private DataGridView dataGrid_Produtos;
        private Label lbl_Descricao;
        private ComboBox cBox_ProdutoSelecao;
    }
}
