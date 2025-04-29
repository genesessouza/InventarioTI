namespace InventarioTI.View
{
    partial class ControleModelo
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel_ControleBg = new Panel();
            dataGrid_Modelos = new DataGridView();
            gBox_Filtragem = new GroupBox();
            cBox_ModeloMarca = new ComboBox();
            label3 = new Label();
            bttn_ModeloLimparFiltros = new Button();
            bttn_ModeloFiltrar = new Button();
            cBox_ModeloSituacao = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            lbl_Descricao = new Label();
            lbl_Marca = new Label();
            lbl_Situacao = new Label();
            lbl_Modelo = new Label();
            gBox_Controles = new GroupBox();
            bttn_ModeloEditar = new Button();
            bttn_ModeloInserir = new Button();
            bttn_ModeloExcluir = new Button();
            cBox_ModeloSelecao = new ComboBox();
            panel_ControleBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Modelos).BeginInit();
            gBox_Filtragem.SuspendLayout();
            gBox_Controles.SuspendLayout();
            SuspendLayout();
            // 
            // panel_ControleBg
            // 
            panel_ControleBg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_ControleBg.BackColor = Color.White;
            panel_ControleBg.BorderStyle = BorderStyle.FixedSingle;
            panel_ControleBg.Controls.Add(dataGrid_Modelos);
            panel_ControleBg.Controls.Add(gBox_Filtragem);
            panel_ControleBg.Controls.Add(gBox_Controles);
            panel_ControleBg.Location = new Point(0, 1);
            panel_ControleBg.Name = "panel_ControleBg";
            panel_ControleBg.Size = new Size(803, 550);
            panel_ControleBg.TabIndex = 13;
            // 
            // dataGrid_Modelos
            // 
            dataGrid_Modelos.AllowUserToAddRows = false;
            dataGrid_Modelos.AllowUserToOrderColumns = true;
            dataGrid_Modelos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Modelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Modelos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGrid_Modelos.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGrid_Modelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGrid_Modelos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGrid_Modelos.GridColor = SystemColors.ControlDarkDark;
            dataGrid_Modelos.Location = new Point(11, 231);
            dataGrid_Modelos.MultiSelect = false;
            dataGrid_Modelos.Name = "dataGrid_Modelos";
            dataGrid_Modelos.RowHeadersVisible = false;
            dataGrid_Modelos.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_Modelos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Modelos.Size = new Size(778, 292);
            dataGrid_Modelos.TabIndex = 15;
            // 
            // gBox_Filtragem
            // 
            gBox_Filtragem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gBox_Filtragem.BackColor = SystemColors.ControlLightLight;
            gBox_Filtragem.Controls.Add(cBox_ModeloSelecao);
            gBox_Filtragem.Controls.Add(cBox_ModeloMarca);
            gBox_Filtragem.Controls.Add(label3);
            gBox_Filtragem.Controls.Add(bttn_ModeloLimparFiltros);
            gBox_Filtragem.Controls.Add(bttn_ModeloFiltrar);
            gBox_Filtragem.Controls.Add(cBox_ModeloSituacao);
            gBox_Filtragem.Controls.Add(label2);
            gBox_Filtragem.Controls.Add(label1);
            gBox_Filtragem.Controls.Add(lbl_Descricao);
            gBox_Filtragem.Controls.Add(lbl_Marca);
            gBox_Filtragem.Controls.Add(lbl_Situacao);
            gBox_Filtragem.Controls.Add(lbl_Modelo);
            gBox_Filtragem.Location = new Point(11, 113);
            gBox_Filtragem.Name = "gBox_Filtragem";
            gBox_Filtragem.Size = new Size(778, 99);
            gBox_Filtragem.TabIndex = 14;
            gBox_Filtragem.TabStop = false;
            gBox_Filtragem.Text = "Filtragem";
            // 
            // cBox_ModeloMarca
            // 
            cBox_ModeloMarca.AllowDrop = true;
            cBox_ModeloMarca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_ModeloMarca.BackColor = SystemColors.ControlDarkDark;
            cBox_ModeloMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_ModeloMarca.FlatStyle = FlatStyle.Popup;
            cBox_ModeloMarca.ForeColor = SystemColors.ControlLightLight;
            cBox_ModeloMarca.FormattingEnabled = true;
            cBox_ModeloMarca.Location = new Point(380, 50);
            cBox_ModeloMarca.Name = "cBox_ModeloMarca";
            cBox_ModeloMarca.Size = new Size(130, 23);
            cBox_ModeloMarca.TabIndex = 34;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(380, 26);
            label3.Name = "label3";
            label3.Size = new Size(130, 21);
            label3.TabIndex = 33;
            label3.Text = "Marca";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bttn_ModeloLimparFiltros
            // 
            bttn_ModeloLimparFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttn_ModeloLimparFiltros.BackColor = SystemColors.ControlDarkDark;
            bttn_ModeloLimparFiltros.FlatStyle = FlatStyle.Flat;
            bttn_ModeloLimparFiltros.ForeColor = SystemColors.ControlLightLight;
            bttn_ModeloLimparFiltros.Location = new Point(666, 54);
            bttn_ModeloLimparFiltros.Name = "bttn_ModeloLimparFiltros";
            bttn_ModeloLimparFiltros.Size = new Size(98, 27);
            bttn_ModeloLimparFiltros.TabIndex = 31;
            bttn_ModeloLimparFiltros.Text = "Limpar Filtros";
            bttn_ModeloLimparFiltros.UseVisualStyleBackColor = false;
            bttn_ModeloLimparFiltros.Click += bttn_ModeloLimparFiltros_Click;
            // 
            // bttn_ModeloFiltrar
            // 
            bttn_ModeloFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttn_ModeloFiltrar.BackColor = SystemColors.ControlDarkDark;
            bttn_ModeloFiltrar.FlatStyle = FlatStyle.Flat;
            bttn_ModeloFiltrar.ForeColor = SystemColors.ControlLightLight;
            bttn_ModeloFiltrar.Location = new Point(666, 21);
            bttn_ModeloFiltrar.Name = "bttn_ModeloFiltrar";
            bttn_ModeloFiltrar.Size = new Size(98, 27);
            bttn_ModeloFiltrar.TabIndex = 30;
            bttn_ModeloFiltrar.Text = "Filtrar";
            bttn_ModeloFiltrar.UseVisualStyleBackColor = false;
            bttn_ModeloFiltrar.Click += bttn_ModeloFiltrar_Click;
            // 
            // cBox_ModeloSituacao
            // 
            cBox_ModeloSituacao.AllowDrop = true;
            cBox_ModeloSituacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_ModeloSituacao.BackColor = SystemColors.ControlDarkDark;
            cBox_ModeloSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_ModeloSituacao.FlatStyle = FlatStyle.Popup;
            cBox_ModeloSituacao.ForeColor = SystemColors.ControlLightLight;
            cBox_ModeloSituacao.FormattingEnabled = true;
            cBox_ModeloSituacao.Location = new Point(530, 50);
            cBox_ModeloSituacao.Name = "cBox_ModeloSituacao";
            cBox_ModeloSituacao.Size = new Size(96, 23);
            cBox_ModeloSituacao.TabIndex = 28;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(530, 27);
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
            label1.Location = new Point(967, 28);
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
            lbl_Descricao.Location = new Point(13, 24);
            lbl_Descricao.Margin = new Padding(0);
            lbl_Descricao.Name = "lbl_Descricao";
            lbl_Descricao.Size = new Size(245, 20);
            lbl_Descricao.TabIndex = 22;
            lbl_Descricao.Text = "Descrição do Modelo";
            lbl_Descricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Marca
            // 
            lbl_Marca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Marca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Marca.Location = new Point(1395, 25);
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
            lbl_Situacao.Location = new Point(1771, 25);
            lbl_Situacao.Margin = new Padding(0);
            lbl_Situacao.Name = "lbl_Situacao";
            lbl_Situacao.Size = new Size(96, 20);
            lbl_Situacao.TabIndex = 16;
            lbl_Situacao.Text = "Situação";
            lbl_Situacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Modelo
            // 
            lbl_Modelo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Modelo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Modelo.Location = new Point(1592, 25);
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
            gBox_Controles.Controls.Add(bttn_ModeloEditar);
            gBox_Controles.Controls.Add(bttn_ModeloInserir);
            gBox_Controles.Controls.Add(bttn_ModeloExcluir);
            gBox_Controles.Location = new Point(11, 11);
            gBox_Controles.Name = "gBox_Controles";
            gBox_Controles.Size = new Size(198, 83);
            gBox_Controles.TabIndex = 13;
            gBox_Controles.TabStop = false;
            gBox_Controles.Text = "Controles";
            // 
            // bttn_ModeloEditar
            // 
            bttn_ModeloEditar.BackColor = SystemColors.ControlDarkDark;
            bttn_ModeloEditar.FlatStyle = FlatStyle.Flat;
            bttn_ModeloEditar.ForeColor = SystemColors.ControlLightLight;
            bttn_ModeloEditar.Location = new Point(75, 34);
            bttn_ModeloEditar.Name = "bttn_ModeloEditar";
            bttn_ModeloEditar.Size = new Size(53, 34);
            bttn_ModeloEditar.TabIndex = 1;
            bttn_ModeloEditar.Text = "Editar";
            bttn_ModeloEditar.UseVisualStyleBackColor = false;
            bttn_ModeloEditar.Click += bttn_ModeloEditar_Click;
            // 
            // bttn_ModeloInserir
            // 
            bttn_ModeloInserir.BackColor = SystemColors.ControlDarkDark;
            bttn_ModeloInserir.FlatStyle = FlatStyle.Flat;
            bttn_ModeloInserir.ForeColor = SystemColors.ControlLightLight;
            bttn_ModeloInserir.Location = new Point(13, 34);
            bttn_ModeloInserir.Name = "bttn_ModeloInserir";
            bttn_ModeloInserir.Size = new Size(53, 34);
            bttn_ModeloInserir.TabIndex = 0;
            bttn_ModeloInserir.Text = "Novo";
            bttn_ModeloInserir.UseVisualStyleBackColor = false;
            bttn_ModeloInserir.Click += bttn_ModeloInserir_Click;
            // 
            // bttn_ModeloExcluir
            // 
            bttn_ModeloExcluir.BackColor = SystemColors.ControlDarkDark;
            bttn_ModeloExcluir.FlatStyle = FlatStyle.Flat;
            bttn_ModeloExcluir.ForeColor = SystemColors.ControlLightLight;
            bttn_ModeloExcluir.Location = new Point(134, 34);
            bttn_ModeloExcluir.Name = "bttn_ModeloExcluir";
            bttn_ModeloExcluir.Size = new Size(53, 34);
            bttn_ModeloExcluir.TabIndex = 2;
            bttn_ModeloExcluir.Text = "Excluir";
            bttn_ModeloExcluir.UseVisualStyleBackColor = false;
            bttn_ModeloExcluir.Click += bttn_ModeloExcluir_Click;
            // 
            // cBox_ModeloSelecao
            // 
            cBox_ModeloSelecao.AllowDrop = true;
            cBox_ModeloSelecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_ModeloSelecao.AutoCompleteMode = AutoCompleteMode.Append;
            cBox_ModeloSelecao.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBox_ModeloSelecao.BackColor = SystemColors.ControlDarkDark;
            cBox_ModeloSelecao.FlatStyle = FlatStyle.Popup;
            cBox_ModeloSelecao.ForeColor = SystemColors.ControlLightLight;
            cBox_ModeloSelecao.FormattingEnabled = true;
            cBox_ModeloSelecao.Location = new Point(13, 50);
            cBox_ModeloSelecao.Name = "cBox_ModeloSelecao";
            cBox_ModeloSelecao.Size = new Size(245, 23);
            cBox_ModeloSelecao.TabIndex = 35;
            // 
            // ControleModelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 549);
            Controls.Add(panel_ControleBg);
            Name = "ControleModelo";
            Text = "Controle de Modelos";
            panel_ControleBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid_Modelos).EndInit();
            gBox_Filtragem.ResumeLayout(false);
            gBox_Controles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_ControleBg;
        private DataGridView dataGrid_Modelos;
        private GroupBox gBox_Filtragem;
        private Label label1;
        private Label lbl_Descricao;
        private Label lbl_Marca;
        private Label lbl_Situacao;
        private Label lbl_Modelo;
        private GroupBox gBox_Controles;
        private Button bttn_ModeloEditar;
        private Button bttn_ModeloInserir;
        private Button bttn_ModeloExcluir;
        private Button bttn_ModeloLimparFiltros;
        private Button bttn_ModeloFiltrar;
        private ComboBox cBox_ModeloSituacao;
        private Label label2;
        private Label label3;
        private ComboBox cBox_ModeloMarca;
        private ComboBox cBox_ModeloSelecao;
    }
}