using InventarioTI.Connection;
using InventarioTI.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioTI.View.Cadastro
{
    public partial class CadastroSituacao : Form
    {
        private ControleSituacao _controleSituacao;
        private int _ultimoIdCadastrado;

        public CadastroSituacao()
        {
            InitializeComponent();

            CenterToParent();
        }

        public CadastroSituacao(ControleSituacao controleSituacao)
        {
            InitializeComponent();

            CenterToParent();

            _controleSituacao = controleSituacao;

            _ = InicializarAsync();
        }

        private async Task InicializarAsync()
        {
            var situacoes = await Situacao.BuscarSituacoesAsync();
            foreach (var situacao in situacoes)
                _ultimoIdCadastrado = situacao.Id;
        }

        private async void bttn_CadastroSituacaoSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBox_CadastroSituacaoValor.Text))
            {
                MessageBox.Show("Campo de descrição não pode ser nulo", "Falha ao Salvar Alterações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sucesso = await Situacao.CadastrarSituacaoAsync(_ultimoIdCadastrado + 1, tBox_CadastroSituacaoValor.Text);
            if(sucesso)
                MessageBox.Show("Situação cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro ao cadastrar situação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

           await _controleSituacao.InicializarAsync();
        }
    }
}