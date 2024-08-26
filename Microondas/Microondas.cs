using Microondas.model;
using Microondas.Repository;
using Microondas.util;

namespace Microondas
{
    public partial class Microondas : Form
    {
        private int tempoRestante = 0;
        private int potencia = 10;
        private int tempoInformado = 0;
        private bool aquecendo = false;
        private string timeTela = "";
        private string progresso = "";
        private string simbolo = "";
        private int cont;
        public List<ProgramaAquecimento> ProgramaAquecimentos { get; private set; } = new List<ProgramaAquecimento>();

        public Microondas()
        {
            InitializeComponent();
            pesqusiaProgramas();
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(Microondas_KeyUp);
        }

        private void pesqusiaProgramas()
        {
            var repository = new ProgramaAquecimentoRepository();
            ProgramaAquecimentos = repository.Get();

            lvwProgramas.Items.Clear();

            foreach (var item in ProgramaAquecimentos.OrderBy(r => r.Id))
            {
                lvwProgramas.Items.Add(new ListViewItem(new String[] {item.Id.ToString(), item.NomePrograma, item.Alimento, item.Tempo.ToString(), item.Potencia.ToString(), item.Instrucoes, item.Simbolo, item.padrao?"Sim":"Não".ToString() }));
            }

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            cont = 0;
            if (tempoRestante != 0)
            {
                if (aquecendo)
                {
                    tempoRestante = tempoRestante + 30;
                }
                else
                {
                    progresso = "";
                    if (simbolo == ""){ simbolo = ".";}
                    potencia = int.Parse(lblPotenciaAtual.Text);
                    timer1.Start();
                    aquecendo = true;
                }
            }
            else
            {
                potencia = 10;
                simbolo = ".";
                lblPotenciaAtual.Text = potencia.ToString();
                tempoRestante = 30; // Reinicia o contador de segundos
                timer1.Start();
                aquecendo = true;
            }
        }
        private void btnParar_Click(object sender, EventArgs e)
        {
            if (aquecendo)
            {
                timer1.Stop();
                aquecendo = false;
            }
            else
            {
                timeTela = "";
                simbolo = "";
                tempoRestante = 0; // Reinicia o contador de segundos
                potencia = 10;
                timer1.Stop();
                TimeSpan time = TimeSpan.FromSeconds(tempoRestante);
                lblTimer.Text = time.ToString(@"mm\:ss");
                lblPotenciaAtual.Text = potencia.ToString();
                aquecendo = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempoRestante--;
            TimeSpan time = TimeSpan.FromSeconds(tempoRestante);
            lblTimer.Text = time.ToString(@"mm\:ss");

            if (cont >= 5)
            {
                cont = 1;
                progresso = "";
                progresso = progresso + StringProgresso.stringProgresso(potencia, simbolo);
                lblProcessamento.Text = progresso;
            }
            else
            {
                cont++;
                progresso = progresso + StringProgresso.stringProgresso(potencia, simbolo);
                lblProcessamento.Text = progresso;
            }


            if (tempoRestante == 0)
            {
                progresso = progresso + "Aquecimento concluído";
                lblProcessamento.Text = progresso;
                aquecendo = false;
                btnParar_Click(sender, e);
            }
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            timeTela = timeTela + "1";
            if (timeTela.Length >= 3)
            {
                tempoInformado = int.Parse(timeTela);
                tempoRestante = ConverteTimer.converteTimer(tempoInformado);
            }
            else
            {
                tempoRestante = int.Parse(timeTela);
            }

            lblTimer.Text = TimeSpan.FromSeconds(tempoRestante).ToString(@"mm\:ss");
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            timeTela = timeTela + "2";
            if (timeTela.Length >= 3)
            {
                tempoInformado = int.Parse(timeTela);
                tempoRestante = ConverteTimer.converteTimer(tempoInformado);
            }
            else
            {
                tempoRestante = int.Parse(timeTela);
            }

            lblTimer.Text = TimeSpan.FromSeconds(tempoRestante).ToString(@"mm\:ss");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            timeTela = timeTela + "3";
            if (timeTela.Length >= 3)
            {
                tempoInformado = int.Parse(timeTela);
                tempoRestante = ConverteTimer.converteTimer(tempoInformado);
            }
            else
            {
                tempoRestante = int.Parse(timeTela);
            }

            lblTimer.Text = TimeSpan.FromSeconds(tempoRestante).ToString(@"mm\:ss");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            timeTela = timeTela + "4";
            if (timeTela.Length >= 3)
            {
                tempoInformado = int.Parse(timeTela);
                tempoRestante = ConverteTimer.converteTimer(tempoInformado);
            }
            else
            {
                tempoRestante = int.Parse(timeTela);
            }

            lblTimer.Text = TimeSpan.FromSeconds(tempoRestante).ToString(@"mm\:ss");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            timeTela = timeTela + "5";
            if (timeTela.Length >= 3)
            {
                tempoInformado = int.Parse(timeTela);
                tempoRestante = ConverteTimer.converteTimer(tempoInformado);
            }
            else
            {
                tempoRestante = int.Parse(timeTela);
            }

            lblTimer.Text = TimeSpan.FromSeconds(tempoRestante).ToString(@"mm\:ss");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            timeTela = timeTela + "6";
            if (timeTela.Length >= 3)
            {
                tempoInformado = int.Parse(timeTela);
                tempoRestante = ConverteTimer.converteTimer(tempoInformado);
            }
            else
            {
                tempoRestante = int.Parse(timeTela);
            }

            lblTimer.Text = TimeSpan.FromSeconds(tempoRestante).ToString(@"mm\:ss");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            timeTela = timeTela + "7";
            if (timeTela.Length >= 3)
            {
                tempoInformado = int.Parse(timeTela);
                tempoRestante = ConverteTimer.converteTimer(tempoInformado);
            }
            else
            {
                tempoRestante = int.Parse(timeTela);
            }

            lblTimer.Text = TimeSpan.FromSeconds(tempoRestante).ToString(@"mm\:ss");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            timeTela = timeTela + "8";
            if (timeTela.Length >= 3)
            {
                tempoInformado = int.Parse(timeTela);
                tempoRestante = ConverteTimer.converteTimer(tempoInformado);
            }
            else
            {
                tempoRestante = int.Parse(timeTela);
            }

            lblTimer.Text = TimeSpan.FromSeconds(tempoRestante).ToString(@"mm\:ss");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            timeTela = timeTela + "9";
            if (timeTela.Length >= 3)
            {
                tempoInformado = int.Parse(timeTela);
                tempoRestante = ConverteTimer.converteTimer(tempoInformado);
            }
            else
            {
                tempoRestante = int.Parse(timeTela);
            }

            lblTimer.Text = TimeSpan.FromSeconds(tempoRestante).ToString(@"mm\:ss");
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            timeTela = timeTela + "0";
            if (timeTela.Length >= 3)
            {
                tempoInformado = int.Parse(timeTela);
                tempoRestante = ConverteTimer.converteTimer(tempoInformado);
            }
            else
            {
                tempoRestante = int.Parse(timeTela);
            }

            lblTimer.Text = TimeSpan.FromSeconds(tempoRestante).ToString(@"mm\:ss");
        }


        private void Microondas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                btnNum1.PerformClick();
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                btnNum2.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                btnNum3.PerformClick();
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                btnNum4.PerformClick();
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                btnNum5.PerformClick();
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                btnNum6.PerformClick();
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                btnNum7.PerformClick();
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                btnNum8.PerformClick();
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                btnNum9.PerformClick();
            }
            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                btnNum0.PerformClick();
            }
        }

        private void cadPrograma_CadastroConcluido(object sender, EventArgs e)
        {
            pesqusiaProgramas();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CadastroPrograma cadPrograma = new CadastroPrograma();
            cadPrograma.CadastroConcluido += cadPrograma_CadastroConcluido;
            cadPrograma.Show();
        }

        private void btnAumenta_Click(object sender, EventArgs e)
        {
            potencia++;
            lblPotenciaAtual.Text = potencia.ToString();
            if (potencia > 10)
            {
                potencia = 10;
                lblProcessamento.Text = "Potencia Maxima atingida";
                lblPotenciaAtual.Text = potencia.ToString();
            }
        }

        private void btnDiminui_Click(object sender, EventArgs e)
        {
            potencia--;
            lblPotenciaAtual.Text = potencia.ToString();
            if (potencia <= 1)
            {
                potencia = 1;
                lblProcessamento.Text = "Potencia Minima atingida";
                lblPotenciaAtual.Text = potencia.ToString();
            }
        }

        private void lvwProgramas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvwProgramas.SelectedItems.Count > 0)
            {
                if (!aquecendo)
                {
                    ListViewItem itemSelecionado = lvwProgramas.SelectedItems[0];
                    lblPotenciaAtual.Text = itemSelecionado.SubItems[4].Text;
                    simbolo = itemSelecionado.SubItems[6].Text;
                    tempoRestante = int.Parse(itemSelecionado.SubItems[3].Text);
                    lblTimer.Text = TimeSpan.FromSeconds(tempoRestante).ToString(@"mm\:ss");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lvwProgramas.SelectedItems.Count > 0)
            {
                if (!aquecendo)
                {
                    ListViewItem itemSelecionado = lvwProgramas.SelectedItems[0];

                    int id = int.Parse(itemSelecionado.SubItems[0].Text);
                    string nomePrograma = itemSelecionado.SubItems[1].Text;
                    string alimento = itemSelecionado.SubItems[2].Text;
                    string tempo = itemSelecionado.SubItems[3].Text;
                    string potencia = itemSelecionado.SubItems[4].Text;
                    string simbolo = itemSelecionado.SubItems[6].Text;
                    string instrucao = itemSelecionado.SubItems[5].Text;
                    string padrao = itemSelecionado.SubItems[7].Text;
                    
                    if (padrao == "Não" || id == 1)
                    {
                        CadastroPrograma cadPrograma = new CadastroPrograma();
                        cadPrograma.editarPeencher(id, nomePrograma, alimento, tempo, potencia, simbolo, instrucao);
                        cadPrograma.CadastroConcluido += cadPrograma_CadastroConcluido;
                        cadPrograma.Show();
                    }
                    else
                    {
                        MessageBox.Show("Só é possivel Editar Programas de Aquecimento customizados ou o Programa 'Aquecimento'.", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }

                }
                else
                {
                    MessageBox.Show("Pare o aquecimento antes de editar um Programa de Aquecimento.", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Selecione um Programa de Aquecimento para edição.", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
