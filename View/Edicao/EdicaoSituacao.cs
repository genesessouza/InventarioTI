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

namespace InventarioTI.View.Edicao
{
    public partial class EdicaoSituacao : Form
    {
        private ControleSituacao _controleSituacao;
        private Situacao _situacaoAEditar;

        public EdicaoSituacao()
        {
            InitializeComponent();
        }

        public EdicaoSituacao(ControleSituacao controleSituacao, Situacao situacaoAEditar)
        {
            InitializeComponent();

            CenterToParent();

            _controleSituacao = controleSituacao;

            _situacaoAEditar = situacaoAEditar;

            tBox_EdicaoSituacaoDescricao.Text = _situacaoAEditar.Valor;
        }

        private async void bttn_EdicaoSituacaoSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBox_EdicaoSituacaoDescricao.Text))
            {
                MessageBox.Show("Campo de descrição não pode ser nulo", "Falha ao Salvar Alterações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sucesso = await Situacao.EditarSituacaoSelecionadaAsync(_situacaoAEditar.Id, tBox_EdicaoSituacaoDescricao.Text);
            if (sucesso)
                MessageBox.Show("Situação editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro ao editar situação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            await _controleSituacao.InicializarAsync();
        }
    }
}