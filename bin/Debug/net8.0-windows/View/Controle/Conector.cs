using InventarioTI.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioTI.View.Controle
{
    public partial class Conector : Form
    {
        string diretorioDeProjeto = AppDomain.CurrentDomain.BaseDirectory;
        GerenciadorDeConexao gerenciadorDeConexao;
        string instanciaTxt;
        Principal principal = new Principal();

        public Conector()
        {
            instanciaTxt = Path.Combine(diretorioDeProjeto, "Instancia.txt");
            InitializeComponent();

            CenterToScreen();
        }

        private void bttn_Conectar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(instanciaTxt) || !File.ReadLines(instanciaTxt).Any())
                File.WriteAllText(instanciaTxt, tBox_Instancia.Text);

            gerenciadorDeConexao = new GerenciadorDeConexao(tBox_Instancia.Text);

            if (gerenciadorDeConexao.ConseguiuConectar)
            {
                File.WriteAllText(instanciaTxt, tBox_Instancia.Text);

                this.Hide();
                principal.Show();
                principal.Closed += (s, args) => this.Close();
            }
        }

        private void Conector_Shown(object sender, EventArgs e)
        {
            if (File.Exists(instanciaTxt) && File.ReadLines(instanciaTxt).Any())
            {
                gerenciadorDeConexao = new GerenciadorDeConexao(File.ReadAllText(instanciaTxt));

                if (gerenciadorDeConexao.ConseguiuConectar)
                {
                    this.Hide();
                    principal.Closed += (s, args) => this.Close();
                    principal.Show();
                }
                else
                {
                    MessageBox.Show("Não foi possível conectar ao banco de dados. Verifique a instância e tente novamente.", "Erro de Conexão",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
