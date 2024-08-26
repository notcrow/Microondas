using Microondas.model;
using Microondas.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microondas
{
    public partial class CadastroPrograma : Form
    {
        public event EventHandler CadastroConcluido;

        public CadastroPrograma()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = lblId.Text;
                var nomePrograma = txbNomePrograma.Text;
                var alimento = txbAlimento.Text;
                var tempo = txbTempo.Text;
                var potencia = trbPotencia.Value;
                var simbolo = txbSimbolo.Text;
                var instrucao = rTxbIntrucoes.Text;

                var programa = new ProgramaAquecimento(int.Parse(id), nomePrograma, alimento, int.Parse(tempo), potencia, simbolo, instrucao);

                var repository = new ProgramaAquecimentoRepository();
                if (lblId.Text == "0")
                {
                    repository.Add(programa);
                    MessageBox.Show("Cadastro realizado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    CadastroConcluido?.Invoke(this, EventArgs.Empty);
                    Close();
                }
                else
                {
                    repository.Update(programa);
                    MessageBox.Show("Cadastro atualizado com Sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    CadastroConcluido?.Invoke(this, EventArgs.Empty);
                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txbTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        public void editarPeencher(int id, string nomePrograma, string alimento, string tempo, string potencia, string simbolo, string instrucao)
        {
            lblId.Text = id.ToString();
            txbNomePrograma.Text = nomePrograma;
            txbAlimento.Text = alimento;
            txbTempo.Text = tempo;
            trbPotencia.Value = int.Parse(potencia);
            txbSimbolo.Text = simbolo;
            rTxbIntrucoes.Text = instrucao;

            if (lblId.Text == "1")
            {
                txbNomePrograma.ReadOnly = true;
                txbAlimento.ReadOnly = true;
                txbSimbolo.ReadOnly = true;
                rTxbIntrucoes.ReadOnly = true;
            }

        }

        private void txbTempo_Leave(object sender, EventArgs e)
        {
            if (lblId.Text == "1")
            {
                if (int.Parse(txbTempo.Text) > 120)
                {
                    MessageBox.Show("Valor maximo para o programa Aquecimento é 120 segundos (2 Minutos). Verifique e tente novamente.","Verifique", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txbTempo.Text = "120";
                }
                else if (int.Parse(txbTempo.Text) < 1)
                {
                    MessageBox.Show("Valor minimo para o programa Aquecimento é 1 segundo. Verifique e tente novamente.", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txbTempo.Text = "1";
                }
            }
        }
    }
}
