namespace InventarioTI.View
{
    partial class ControleEstoque
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
            gBox_Filtragem = new GroupBox();
            cBox_EstoqueProdutos = new ComboBox();
            bttn_MarcaLimparFiltros = new Button();
            bttn_EstoqueFiltrar = new Button();
            cBox_EstoqueSituacao = new ComboBox();
            label2 = new Label();
            lbl_Produto = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            bttn_LimparFiltros = new Button();
            bttn_Filtrar = new Button();
            cBox_Situacao = new ComboBox();
            lbl_Marca = new Label();
            lbl_Situacao = new Label();
            cBox_Modelo = new ComboBox();
            cBox_Marca = new ComboBox();
            lbl_Modelo = new Label();
            dataGrid_Quantidades = new DataGridView();
            gBox_Controles = new GroupBox();
            bttn_EstoqueAjustar = new Button();
            cBox_EstoqueModelo = new ComboBox();
            label3 = new Label();
            cBox_EstoqueMarca = new ComboBox();
            label4 = new Label();
            panel_ControleBg.SuspendLayout();
            gBox_Filtragem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Quantidades).BeginInit();
            gBox_Controles.SuspendLayout();
            SuspendLayout();
            // 
            // panel_ControleBg
            // 
            panel_ControleBg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_ControleBg.BackColor = Color.White;
            panel_ControleBg.BorderStyle = BorderStyle.FixedSingle;
            panel_ControleBg.Controls.Add(gBox_Filtragem);
            panel_ControleBg.Controls.Add(dataGrid_Quantidades);
            panel_ControleBg.Controls.Add(gBox_Controles);
            panel_ControleBg.Location = new Point(0, 1);
            panel_ControleBg.Name = "panel_ControleBg";
            panel_ControleBg.Size = new Size(973, 570);
            panel_ControleBg.TabIndex = 13;
            // 
            // gBox_Filtragem
            // 
            gBox_Filtragem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gBox_Filtragem.BackColor = SystemColors.ControlLightLight;
            gBox_Filtragem.Controls.Add(cBox_EstoqueMarca);
            gBox_Filtragem.Controls.Add(label4);
            gBox_Filtragem.Controls.Add(cBox_EstoqueModelo);
            gBox_Filtragem.Controls.Add(label3);
            gBox_Filtragem.Controls.Add(cBox_EstoqueProdutos);
            gBox_Filtragem.Controls.Add(bttn_MarcaLimparFiltros);
            gBox_Filtragem.Controls.Add(bttn_EstoqueFiltrar);
            gBox_Filtragem.Controls.Add(cBox_EstoqueSituacao);
            gBox_Filtragem.Controls.Add(label2);
            gBox_Filtragem.Controls.Add(lbl_Produto);
            gBox_Filtragem.Controls.Add(button1);
            gBox_Filtragem.Controls.Add(button2);
            gBox_Filtragem.Controls.Add(comboBox1);
            gBox_Filtragem.Controls.Add(label1);
            gBox_Filtragem.Controls.Add(bttn_LimparFiltros);
            gBox_Filtragem.Controls.Add(bttn_Filtrar);
            gBox_Filtragem.Controls.Add(cBox_Situacao);
            gBox_Filtragem.Controls.Add(lbl_Marca);
            gBox_Filtragem.Controls.Add(lbl_Situacao);
            gBox_Filtragem.Controls.Add(cBox_Modelo);
            gBox_Filtragem.Controls.Add(cBox_Marca);
            gBox_Filtragem.Controls.Add(lbl_Modelo);
            gBox_Filtragem.Location = new Point(11, 106);
            gBox_Filtragem.Name = "gBox_Filtragem";
            gBox_Filtragem.Size = new Size(948, 99);
            gBox_Filtragem.TabIndex = 16;
            gBox_Filtragem.TabStop = false;
            gBox_Filtragem.Text = "Filtragem";
            // 
            // cBox_EstoqueProdutos
            // 
            cBox_EstoqueProdutos.AllowDrop = true;
            cBox_EstoqueProdutos.AutoCompleteMode = AutoCompleteMode.Append;
            cBox_EstoqueProdutos.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBox_EstoqueProdutos.BackColor = SystemColors.ControlDarkDark;
            cBox_EstoqueProdutos.FlatStyle = FlatStyle.Popup;
            cBox_EstoqueProdutos.ForeColor = SystemColors.ControlLightLight;
            cBox_EstoqueProdutos.FormattingEnabled = true;
            cBox_EstoqueProdutos.Location = new Point(13, 51);
            cBox_EstoqueProdutos.Name = "cBox_EstoqueProdutos";
            cBox_EstoqueProdutos.Size = new Size(246, 23);
            cBox_EstoqueProdutos.TabIndex = 34;
            // 
            // bttn_MarcaLimparFiltros
            // 
            bttn_MarcaLimparFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttn_MarcaLimparFiltros.BackColor = SystemColors.ControlDarkDark;
            bttn_MarcaLimparFiltros.FlatStyle = FlatStyle.Flat;
            bttn_MarcaLimparFiltros.ForeColor = SystemColors.ControlLightLight;
            bttn_MarcaLimparFiltros.Location = new Point(835, 58);
            bttn_MarcaLimparFiltros.Name = "bttn_MarcaLimparFiltros";
            bttn_MarcaLimparFiltros.Size = new Size(98, 27);
            bttn_MarcaLimparFiltros.TabIndex = 33;
            bttn_MarcaLimparFiltros.Text = "Limpar Filtros";
            bttn_MarcaLimparFiltros.UseVisualStyleBackColor = false;
            bttn_MarcaLimparFiltros.Click += bttn_MarcaLimparFiltros_Click;
            // 
            // bttn_EstoqueFiltrar
            // 
            bttn_EstoqueFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttn_EstoqueFiltrar.BackColor = SystemColors.ControlDarkDark;
            bttn_EstoqueFiltrar.FlatStyle = FlatStyle.Flat;
            bttn_EstoqueFiltrar.ForeColor = SystemColors.ControlLightLight;
            bttn_EstoqueFiltrar.Location = new Point(835, 25);
            bttn_EstoqueFiltrar.Name = "bttn_EstoqueFiltrar";
            bttn_EstoqueFiltrar.Size = new Size(98, 27);
            bttn_EstoqueFiltrar.TabIndex = 32;
            bttn_EstoqueFiltrar.Text = "Filtrar";
            bttn_EstoqueFiltrar.UseVisualStyleBackColor = false;
            bttn_EstoqueFiltrar.Click += bttn_EstoqueFiltrar_Click;
            // 
            // cBox_EstoqueSituacao
            // 
            cBox_EstoqueSituacao.AllowDrop = true;
            cBox_EstoqueSituacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_EstoqueSituacao.AutoCompleteMode = AutoCompleteMode.Append;
            cBox_EstoqueSituacao.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBox_EstoqueSituacao.BackColor = SystemColors.ControlDarkDark;
            cBox_EstoqueSituacao.FlatStyle = FlatStyle.Popup;
            cBox_EstoqueSituacao.ForeColor = SystemColors.ControlLightLight;
            cBox_EstoqueSituacao.FormattingEnabled = true;
            cBox_EstoqueSituacao.Location = new Point(703, 51);
            cBox_EstoqueSituacao.Name = "cBox_EstoqueSituacao";
            cBox_EstoqueSituacao.Size = new Size(96, 23);
            cBox_EstoqueSituacao.TabIndex = 30;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(703, 28);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 31;
            label2.Text = "Situação";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Produto
            // 
            lbl_Produto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Produto.Location = new Point(13, 28);
            lbl_Produto.Margin = new Padding(0);
            lbl_Produto.Name = "lbl_Produto";
            lbl_Produto.Size = new Size(246, 20);
            lbl_Produto.TabIndex = 28;
            lbl_Produto.Text = "Produto";
            lbl_Produto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1343, 54);
            button1.Name = "button1";
            button1.Size = new Size(98, 27);
            button1.TabIndex = 27;
            button1.Text = "Limpar Filtros";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1343, 21);
            button2.Name = "button2";
            button2.Size = new Size(98, 27);
            button2.TabIndex = 26;
            button2.Text = "Filtrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.BackColor = SystemColors.ControlDarkDark;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.ForeColor = SystemColors.ControlLightLight;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1137, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(96, 23);
            comboBox1.TabIndex = 24;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1137, 28);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 25;
            label1.Text = "Situação";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bttn_LimparFiltros
            // 
            bttn_LimparFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttn_LimparFiltros.BackColor = SystemColors.ControlDarkDark;
            bttn_LimparFiltros.FlatStyle = FlatStyle.Flat;
            bttn_LimparFiltros.ForeColor = SystemColors.ControlLightLight;
            bttn_LimparFiltros.Location = new Point(2257, 51);
            bttn_LimparFiltros.Name = "bttn_LimparFiltros";
            bttn_LimparFiltros.Size = new Size(98, 27);
            bttn_LimparFiltros.TabIndex = 18;
            bttn_LimparFiltros.Text = "Limpar Filtros";
            bttn_LimparFiltros.UseVisualStyleBackColor = false;
            // 
            // bttn_Filtrar
            // 
            bttn_Filtrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttn_Filtrar.BackColor = SystemColors.ControlDarkDark;
            bttn_Filtrar.FlatStyle = FlatStyle.Flat;
            bttn_Filtrar.ForeColor = SystemColors.ControlLightLight;
            bttn_Filtrar.Location = new Point(2257, 18);
            bttn_Filtrar.Name = "bttn_Filtrar";
            bttn_Filtrar.Size = new Size(98, 27);
            bttn_Filtrar.TabIndex = 17;
            bttn_Filtrar.Text = "Filtrar";
            bttn_Filtrar.UseVisualStyleBackColor = false;
            // 
            // cBox_Situacao
            // 
            cBox_Situacao.AllowDrop = true;
            cBox_Situacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_Situacao.BackColor = SystemColors.ControlDarkDark;
            cBox_Situacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_Situacao.FlatStyle = FlatStyle.Popup;
            cBox_Situacao.ForeColor = SystemColors.ControlLightLight;
            cBox_Situacao.FormattingEnabled = true;
            cBox_Situacao.Location = new Point(1941, 48);
            cBox_Situacao.Name = "cBox_Situacao";
            cBox_Situacao.Size = new Size(96, 23);
            cBox_Situacao.TabIndex = 13;
            // 
            // lbl_Marca
            // 
            lbl_Marca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Marca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Marca.Location = new Point(1565, 25);
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
            lbl_Situacao.Location = new Point(1941, 25);
            lbl_Situacao.Margin = new Padding(0);
            lbl_Situacao.Name = "lbl_Situacao";
            lbl_Situacao.Size = new Size(96, 20);
            lbl_Situacao.TabIndex = 16;
            lbl_Situacao.Text = "Situação";
            lbl_Situacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cBox_Modelo
            // 
            cBox_Modelo.AllowDrop = true;
            cBox_Modelo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_Modelo.BackColor = SystemColors.ControlDarkDark;
            cBox_Modelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_Modelo.FlatStyle = FlatStyle.Popup;
            cBox_Modelo.ForeColor = SystemColors.ControlLightLight;
            cBox_Modelo.FormattingEnabled = true;
            cBox_Modelo.Location = new Point(1762, 47);
            cBox_Modelo.Name = "cBox_Modelo";
            cBox_Modelo.Size = new Size(150, 23);
            cBox_Modelo.TabIndex = 12;
            // 
            // cBox_Marca
            // 
            cBox_Marca.AllowDrop = true;
            cBox_Marca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_Marca.BackColor = SystemColors.ControlDarkDark;
            cBox_Marca.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_Marca.FlatStyle = FlatStyle.Popup;
            cBox_Marca.ForeColor = SystemColors.ControlLightLight;
            cBox_Marca.FormattingEnabled = true;
            cBox_Marca.Location = new Point(1565, 48);
            cBox_Marca.Name = "cBox_Marca";
            cBox_Marca.Size = new Size(155, 23);
            cBox_Marca.TabIndex = 11;
            // 
            // lbl_Modelo
            // 
            lbl_Modelo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Modelo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Modelo.Location = new Point(1762, 25);
            lbl_Modelo.Margin = new Padding(0);
            lbl_Modelo.Name = "lbl_Modelo";
            lbl_Modelo.Size = new Size(150, 20);
            lbl_Modelo.TabIndex = 15;
            lbl_Modelo.Text = "Modelo";
            lbl_Modelo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGrid_Quantidades
            // 
            dataGrid_Quantidades.AllowUserToAddRows = false;
            dataGrid_Quantidades.AllowUserToOrderColumns = true;
            dataGrid_Quantidades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Quantidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Quantidades.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGrid_Quantidades.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid_Quantidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Quantidades.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGrid_Quantidades.GridColor = SystemColors.ControlDarkDark;
            dataGrid_Quantidades.Location = new Point(11, 222);
            dataGrid_Quantidades.MultiSelect = false;
            dataGrid_Quantidades.Name = "dataGrid_Quantidades";
            dataGrid_Quantidades.RowHeadersVisible = false;
            dataGrid_Quantidades.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_Quantidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Quantidades.Size = new Size(948, 319);
            dataGrid_Quantidades.TabIndex = 15;
            // 
            // gBox_Controles
            // 
            gBox_Controles.BackColor = SystemColors.ControlLightLight;
            gBox_Controles.Controls.Add(bttn_EstoqueAjustar);
            gBox_Controles.Location = new Point(11, 11);
            gBox_Controles.Name = "gBox_Controles";
            gBox_Controles.Size = new Size(111, 83);
            gBox_Controles.TabIndex = 13;
            gBox_Controles.TabStop = false;
            gBox_Controles.Text = "Controles";
            // 
            // bttn_EstoqueAjustar
            // 
            bttn_EstoqueAjustar.BackColor = SystemColors.ControlDarkDark;
            bttn_EstoqueAjustar.FlatStyle = FlatStyle.Flat;
            bttn_EstoqueAjustar.ForeColor = SystemColors.ControlLightLight;
            bttn_EstoqueAjustar.Location = new Point(13, 34);
            bttn_EstoqueAjustar.Name = "bttn_EstoqueAjustar";
            bttn_EstoqueAjustar.Size = new Size(80, 34);
            bttn_EstoqueAjustar.TabIndex = 1;
            bttn_EstoqueAjustar.Text = "Ajustar";
            bttn_EstoqueAjustar.UseVisualStyleBackColor = false;
            bttn_EstoqueAjustar.Click += bttn_EstoqueAjustar_Click;
            // 
            // cBox_EstoqueModelo
            // 
            cBox_EstoqueModelo.AllowDrop = true;
            cBox_EstoqueModelo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_EstoqueModelo.AutoCompleteMode = AutoCompleteMode.Append;
            cBox_EstoqueModelo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBox_EstoqueModelo.BackColor = SystemColors.ControlDarkDark;
            cBox_EstoqueModelo.FlatStyle = FlatStyle.Popup;
            cBox_EstoqueModelo.ForeColor = SystemColors.ControlLightLight;
            cBox_EstoqueModelo.FormattingEnabled = true;
            cBox_EstoqueModelo.Location = new Point(566, 51);
            cBox_EstoqueModelo.Name = "cBox_EstoqueModelo";
            cBox_EstoqueModelo.Size = new Size(117, 23);
            cBox_EstoqueModelo.TabIndex = 35;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(566, 28);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 36;
            label3.Text = "Modelo";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cBox_EstoqueMarca
            // 
            cBox_EstoqueMarca.AllowDrop = true;
            cBox_EstoqueMarca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBox_EstoqueMarca.AutoCompleteMode = AutoCompleteMode.Append;
            cBox_EstoqueMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBox_EstoqueMarca.BackColor = SystemColors.ControlDarkDark;
            cBox_EstoqueMarca.FlatStyle = FlatStyle.Popup;
            cBox_EstoqueMarca.ForeColor = SystemColors.ControlLightLight;
            cBox_EstoqueMarca.FormattingEnabled = true;
            cBox_EstoqueMarca.Location = new Point(430, 51);
            cBox_EstoqueMarca.Name = "cBox_EstoqueMarca";
            cBox_EstoqueMarca.Size = new Size(117, 23);
            cBox_EstoqueMarca.TabIndex = 37;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(430, 25);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 38;
            label4.Text = "Marca";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ControleEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 571);
            Controls.Add(panel_ControleBg);
            Name = "ControleEstoque";
            Text = "Controle de Estoque";
            panel_ControleBg.ResumeLayout(false);
            gBox_Filtragem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid_Quantidades).EndInit();
            gBox_Controles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_ControleBg;
        private DataGridView dataGrid_Quantidades;
        private GroupBox gBox_Controles;
        private Button bttn_EstoqueAjustar;
        private GroupBox gBox_Filtragem;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label1;
        private Button bttn_LimparFiltros;
        private Button bttn_Filtrar;
        private ComboBox cBox_Situacao;
        private Label lbl_Marca;
        private Label lbl_Situacao;
        private ComboBox cBox_Modelo;
        private ComboBox cBox_Marca;
        private Label lbl_Modelo;
        private Button bttn_MarcaLimparFiltros;
        private Button bttn_EstoqueFiltrar;
        private ComboBox cBox_EstoqueSituacao;
        private Label label2;
        private Label lbl_Produto;
        private ComboBox cBox_EstoqueProdutos;
        private ComboBox cBox_EstoqueModelo;
        private Label label3;
        private ComboBox cBox_EstoqueMarca;
        private Label label4;
    }
}