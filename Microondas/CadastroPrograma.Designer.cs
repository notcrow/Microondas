namespace Microondas
{
    partial class CadastroPrograma
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
            lblNomePrograma = new Label();
            txbNomePrograma = new TextBox();
            txbAlimento = new TextBox();
            lblAlimento = new Label();
            txbTempo = new TextBox();
            lblTempo = new Label();
            lblPotencia = new Label();
            trbPotencia = new TrackBar();
            txbSimbolo = new TextBox();
            lblSimbolo = new Label();
            rTxbIntrucoes = new RichTextBox();
            lblInstrucoes = new Label();
            btnSalvar = new Button();
            lblCodigo = new Label();
            lblId = new Label();
            ((System.ComponentModel.ISupportInitialize)trbPotencia).BeginInit();
            SuspendLayout();
            // 
            // lblNomePrograma
            // 
            lblNomePrograma.AutoSize = true;
            lblNomePrograma.Location = new Point(12, 9);
            lblNomePrograma.Name = "lblNomePrograma";
            lblNomePrograma.Size = new Size(98, 15);
            lblNomePrograma.TabIndex = 0;
            lblNomePrograma.Text = "Nome Programa:";
            // 
            // txbNomePrograma
            // 
            txbNomePrograma.Location = new Point(116, 6);
            txbNomePrograma.Name = "txbNomePrograma";
            txbNomePrograma.Size = new Size(287, 23);
            txbNomePrograma.TabIndex = 1;
            // 
            // txbAlimento
            // 
            txbAlimento.Location = new Point(116, 35);
            txbAlimento.Name = "txbAlimento";
            txbAlimento.Size = new Size(287, 23);
            txbAlimento.TabIndex = 3;
            // 
            // lblAlimento
            // 
            lblAlimento.AutoSize = true;
            lblAlimento.Location = new Point(51, 38);
            lblAlimento.Name = "lblAlimento";
            lblAlimento.Size = new Size(59, 15);
            lblAlimento.TabIndex = 2;
            lblAlimento.Text = "Alimento:";
            // 
            // txbTempo
            // 
            txbTempo.Location = new Point(116, 64);
            txbTempo.Name = "txbTempo";
            txbTempo.Size = new Size(62, 23);
            txbTempo.TabIndex = 5;
            txbTempo.Text = "0";
            txbTempo.KeyPress += txbTempo_KeyPress;
            txbTempo.Leave += txbTempo_Leave;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Location = new Point(64, 67);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(46, 15);
            lblTempo.TabIndex = 4;
            lblTempo.Text = "Tempo:";
            // 
            // lblPotencia
            // 
            lblPotencia.AutoSize = true;
            lblPotencia.Location = new Point(217, 67);
            lblPotencia.Name = "lblPotencia";
            lblPotencia.Size = new Size(56, 15);
            lblPotencia.TabIndex = 6;
            lblPotencia.Text = "Potência:";
            // 
            // trbPotencia
            // 
            trbPotencia.Location = new Point(272, 67);
            trbPotencia.Minimum = 1;
            trbPotencia.Name = "trbPotencia";
            trbPotencia.Size = new Size(137, 45);
            trbPotencia.TabIndex = 7;
            trbPotencia.Value = 10;
            // 
            // txbSimbolo
            // 
            txbSimbolo.Location = new Point(116, 93);
            txbSimbolo.Name = "txbSimbolo";
            txbSimbolo.Size = new Size(28, 23);
            txbSimbolo.TabIndex = 9;
            // 
            // lblSimbolo
            // 
            lblSimbolo.AutoSize = true;
            lblSimbolo.Location = new Point(56, 96);
            lblSimbolo.Name = "lblSimbolo";
            lblSimbolo.Size = new Size(54, 15);
            lblSimbolo.TabIndex = 8;
            lblSimbolo.Text = "Simbolo:";
            // 
            // rTxbIntrucoes
            // 
            rTxbIntrucoes.Location = new Point(116, 122);
            rTxbIntrucoes.Name = "rTxbIntrucoes";
            rTxbIntrucoes.Size = new Size(287, 147);
            rTxbIntrucoes.TabIndex = 10;
            rTxbIntrucoes.Text = "";
            // 
            // lblInstrucoes
            // 
            lblInstrucoes.AutoSize = true;
            lblInstrucoes.Location = new Point(46, 122);
            lblInstrucoes.Name = "lblInstrucoes";
            lblInstrucoes.Size = new Size(64, 15);
            lblInstrucoes.TabIndex = 11;
            lblInstrucoes.Text = "Instruções:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(328, 284);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(61, 284);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 13;
            lblCodigo.Text = "Codigo:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(116, 284);
            lblId.Name = "lblId";
            lblId.Size = new Size(13, 15);
            lblId.TabIndex = 14;
            lblId.Text = "0";
            // 
            // CadastroPrograma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 319);
            Controls.Add(lblId);
            Controls.Add(lblCodigo);
            Controls.Add(btnSalvar);
            Controls.Add(lblInstrucoes);
            Controls.Add(rTxbIntrucoes);
            Controls.Add(txbSimbolo);
            Controls.Add(lblSimbolo);
            Controls.Add(trbPotencia);
            Controls.Add(lblPotencia);
            Controls.Add(txbTempo);
            Controls.Add(lblTempo);
            Controls.Add(txbAlimento);
            Controls.Add(lblAlimento);
            Controls.Add(txbNomePrograma);
            Controls.Add(lblNomePrograma);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CadastroPrograma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Programa de Aquecimento";
            ((System.ComponentModel.ISupportInitialize)trbPotencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomePrograma;
        private TextBox txbNomePrograma;
        private TextBox txbAlimento;
        private Label lblAlimento;
        private TextBox txbTempo;
        private Label lblTempo;
        private Label lblPotencia;
        private TrackBar trbPotencia;
        private TextBox txbSimbolo;
        private Label lblSimbolo;
        private RichTextBox rTxbIntrucoes;
        private Label lblInstrucoes;
        private Button btnSalvar;
        private Label lblCodigo;
        private Label lblId;
    }
}