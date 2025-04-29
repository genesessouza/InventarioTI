namespace InventarioTI.View.Controle
{
    partial class Conector
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
            label1 = new Label();
            tBox_Instancia = new TextBox();
            bttn_Conectar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Instância";
            // 
            // tBox_Instancia
            // 
            tBox_Instancia.BackColor = SystemColors.ControlDarkDark;
            tBox_Instancia.BorderStyle = BorderStyle.FixedSingle;
            tBox_Instancia.ForeColor = SystemColors.ControlLightLight;
            tBox_Instancia.Location = new Point(72, 12);
            tBox_Instancia.Name = "tBox_Instancia";
            tBox_Instancia.Size = new Size(291, 23);
            tBox_Instancia.TabIndex = 1;
            // 
            // bttn_Conectar
            // 
            bttn_Conectar.BackColor = SystemColors.ControlDarkDark;
            bttn_Conectar.FlatStyle = FlatStyle.Flat;
            bttn_Conectar.ForeColor = SystemColors.ControlLightLight;
            bttn_Conectar.Location = new Point(138, 227);
            bttn_Conectar.Name = "bttn_Conectar";
            bttn_Conectar.Size = new Size(112, 32);
            bttn_Conectar.TabIndex = 2;
            bttn_Conectar.Text = "Conectar ao DB";
            bttn_Conectar.UseVisualStyleBackColor = false;
            bttn_Conectar.Click += bttn_Conectar_Click;
            // 
            // Conector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(380, 271);
            Controls.Add(bttn_Conectar);
            Controls.Add(tBox_Instancia);
            Controls.Add(label1);
            Name = "Conector";
            Text = "Conector";
            Shown += Conector_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tBox_Instancia;
        private Button bttn_Conectar;
    }
}