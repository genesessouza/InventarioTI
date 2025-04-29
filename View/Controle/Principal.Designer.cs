namespace InventarioTI.View.Controle
{
    partial class Principal
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
            menuStrip1 = new MenuStrip();
            controlesToolStripMenuItem = new ToolStripMenuItem();
            menu_ControleMarca = new ToolStripMenuItem();
            menu_ControleModelo = new ToolStripMenuItem();
            menu_ControleProduto = new ToolStripMenuItem();
            menu_ControleEstoque = new ToolStripMenuItem();
            menu_ControleSituacao = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { controlesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // controlesToolStripMenuItem
            // 
            controlesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menu_ControleMarca, menu_ControleModelo, menu_ControleProduto, menu_ControleEstoque, menu_ControleSituacao });
            controlesToolStripMenuItem.Name = "controlesToolStripMenuItem";
            controlesToolStripMenuItem.Size = new Size(70, 20);
            controlesToolStripMenuItem.Text = "Controles";
            // 
            // menu_ControleMarca
            // 
            menu_ControleMarca.Name = "menu_ControleMarca";
            menu_ControleMarca.Size = new Size(180, 22);
            menu_ControleMarca.Text = "Marca";
            menu_ControleMarca.Click += menu_ControleMarca_Click;
            // 
            // menu_ControleModelo
            // 
            menu_ControleModelo.Name = "menu_ControleModelo";
            menu_ControleModelo.Size = new Size(180, 22);
            menu_ControleModelo.Text = "Modelo";
            menu_ControleModelo.Click += menu_ControleModelo_Click;
            // 
            // menu_ControleProduto
            // 
            menu_ControleProduto.Name = "menu_ControleProduto";
            menu_ControleProduto.Size = new Size(180, 22);
            menu_ControleProduto.Text = "Produto";
            menu_ControleProduto.Click += menu_ControleProduto_Click;
            // 
            // menu_ControleEstoque
            // 
            menu_ControleEstoque.Name = "menu_ControleEstoque";
            menu_ControleEstoque.Size = new Size(180, 22);
            menu_ControleEstoque.Text = "Estoque";
            menu_ControleEstoque.Click += menu_ControleEstoque_Click;
            // 
            // menu_ControleSituacao
            // 
            menu_ControleSituacao.Name = "menu_ControleSituacao";
            menu_ControleSituacao.Size = new Size(180, 22);
            menu_ControleSituacao.Text = "Situacao";
            menu_ControleSituacao.Click += menu_ControleSituacao_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            Text = "Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem controlesToolStripMenuItem;
        private ToolStripMenuItem menu_ControleMarca;
        private ToolStripMenuItem menu_ControleModelo;
        private ToolStripMenuItem menu_ControleProduto;
        private ToolStripMenuItem menu_ControleEstoque;
        private ToolStripMenuItem menu_ControleSituacao;
    }
}