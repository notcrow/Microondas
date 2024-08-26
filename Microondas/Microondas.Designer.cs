namespace Microondas
{
    partial class Microondas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Microondas));
            lblTimer = new Label();
            btnIniciar = new Button();
            btnParar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnNum1 = new Button();
            btnNum2 = new Button();
            btnNum3 = new Button();
            btnNum4 = new Button();
            btnNum5 = new Button();
            btnNum6 = new Button();
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnNum9 = new Button();
            btnNum0 = new Button();
            lblProcessamento = new Label();
            lvwProgramas = new ListView();
            Id = new ColumnHeader();
            Programa = new ColumnHeader();
            Alimento = new ColumnHeader();
            Tempo = new ColumnHeader();
            Potencia = new ColumnHeader();
            Instrucoes = new ColumnHeader();
            Simbolo = new ColumnHeader();
            btnNovo = new Button();
            btnEditar = new Button();
            lblPotenciaAtual = new Label();
            btnDiminui = new Button();
            btnAumenta = new Button();
            lblPotencia = new Label();
            padrao = new ColumnHeader();
            SuspendLayout();
            // 
            // lblTimer
            // 
            resources.ApplyResources(lblTimer, "lblTimer");
            lblTimer.Name = "lblTimer";
            // 
            // btnIniciar
            // 
            resources.ApplyResources(btnIniciar, "btnIniciar");
            btnIniciar.Name = "btnIniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnParar
            // 
            resources.ApplyResources(btnParar, "btnParar");
            btnParar.Name = "btnParar";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnNum1
            // 
            resources.ApplyResources(btnNum1, "btnNum1");
            btnNum1.Name = "btnNum1";
            btnNum1.UseVisualStyleBackColor = true;
            btnNum1.Click += btnNum1_Click;
            // 
            // btnNum2
            // 
            resources.ApplyResources(btnNum2, "btnNum2");
            btnNum2.Name = "btnNum2";
            btnNum2.UseVisualStyleBackColor = true;
            btnNum2.Click += btnNum2_Click;
            // 
            // btnNum3
            // 
            resources.ApplyResources(btnNum3, "btnNum3");
            btnNum3.Name = "btnNum3";
            btnNum3.UseVisualStyleBackColor = true;
            btnNum3.Click += btnNum3_Click;
            // 
            // btnNum4
            // 
            resources.ApplyResources(btnNum4, "btnNum4");
            btnNum4.Name = "btnNum4";
            btnNum4.UseVisualStyleBackColor = true;
            btnNum4.Click += btnNum4_Click;
            // 
            // btnNum5
            // 
            resources.ApplyResources(btnNum5, "btnNum5");
            btnNum5.Name = "btnNum5";
            btnNum5.UseVisualStyleBackColor = true;
            btnNum5.Click += btnNum5_Click;
            // 
            // btnNum6
            // 
            resources.ApplyResources(btnNum6, "btnNum6");
            btnNum6.Name = "btnNum6";
            btnNum6.UseVisualStyleBackColor = true;
            btnNum6.Click += btnNum6_Click;
            // 
            // btnNum7
            // 
            resources.ApplyResources(btnNum7, "btnNum7");
            btnNum7.Name = "btnNum7";
            btnNum7.UseVisualStyleBackColor = true;
            btnNum7.Click += btnNum7_Click;
            // 
            // btnNum8
            // 
            resources.ApplyResources(btnNum8, "btnNum8");
            btnNum8.Name = "btnNum8";
            btnNum8.UseVisualStyleBackColor = true;
            btnNum8.Click += btnNum8_Click;
            // 
            // btnNum9
            // 
            resources.ApplyResources(btnNum9, "btnNum9");
            btnNum9.Name = "btnNum9";
            btnNum9.UseVisualStyleBackColor = true;
            btnNum9.Click += btnNum9_Click;
            // 
            // btnNum0
            // 
            resources.ApplyResources(btnNum0, "btnNum0");
            btnNum0.Name = "btnNum0";
            btnNum0.UseVisualStyleBackColor = true;
            btnNum0.Click += btnNum0_Click;
            // 
            // lblProcessamento
            // 
            resources.ApplyResources(lblProcessamento, "lblProcessamento");
            lblProcessamento.Name = "lblProcessamento";
            // 
            // lvwProgramas
            // 
            resources.ApplyResources(lvwProgramas, "lvwProgramas");
            lvwProgramas.Columns.AddRange(new ColumnHeader[] { Id, Programa, Alimento, Tempo, Potencia, Instrucoes, Simbolo, padrao });
            lvwProgramas.Name = "lvwProgramas";
            lvwProgramas.UseCompatibleStateImageBehavior = false;
            lvwProgramas.View = View.Details;
            lvwProgramas.MouseDoubleClick += lvwProgramas_MouseDoubleClick;
            // 
            // Id
            // 
            resources.ApplyResources(Id, "Id");
            // 
            // Programa
            // 
            resources.ApplyResources(Programa, "Programa");
            // 
            // Alimento
            // 
            resources.ApplyResources(Alimento, "Alimento");
            // 
            // Tempo
            // 
            resources.ApplyResources(Tempo, "Tempo");
            // 
            // Potencia
            // 
            resources.ApplyResources(Potencia, "Potencia");
            // 
            // Instrucoes
            // 
            resources.ApplyResources(Instrucoes, "Instrucoes");
            // 
            // Simbolo
            // 
            resources.ApplyResources(Simbolo, "Simbolo");
            // 
            // btnNovo
            // 
            resources.ApplyResources(btnNovo, "btnNovo");
            btnNovo.Name = "btnNovo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            resources.ApplyResources(btnEditar, "btnEditar");
            btnEditar.Name = "btnEditar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblPotenciaAtual
            // 
            resources.ApplyResources(lblPotenciaAtual, "lblPotenciaAtual");
            lblPotenciaAtual.Name = "lblPotenciaAtual";
            // 
            // btnDiminui
            // 
            resources.ApplyResources(btnDiminui, "btnDiminui");
            btnDiminui.Name = "btnDiminui";
            btnDiminui.UseVisualStyleBackColor = true;
            btnDiminui.Click += btnDiminui_Click;
            // 
            // btnAumenta
            // 
            resources.ApplyResources(btnAumenta, "btnAumenta");
            btnAumenta.Name = "btnAumenta";
            btnAumenta.UseVisualStyleBackColor = true;
            btnAumenta.Click += btnAumenta_Click;
            // 
            // lblPotencia
            // 
            resources.ApplyResources(lblPotencia, "lblPotencia");
            lblPotencia.Name = "lblPotencia";
            // 
            // padrao
            // 
            resources.ApplyResources(padrao, "padrao");
            // 
            // Microondas
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPotencia);
            Controls.Add(btnDiminui);
            Controls.Add(btnAumenta);
            Controls.Add(lblPotenciaAtual);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(lvwProgramas);
            Controls.Add(lblProcessamento);
            Controls.Add(btnNum0);
            Controls.Add(btnNum9);
            Controls.Add(btnNum8);
            Controls.Add(btnNum7);
            Controls.Add(btnNum6);
            Controls.Add(btnNum5);
            Controls.Add(btnNum4);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnNum1);
            Controls.Add(btnParar);
            Controls.Add(btnIniciar);
            Controls.Add(lblTimer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Microondas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private Button btnIniciar;
        private Button btnParar;
        private System.Windows.Forms.Timer timer1;
        private Button btnNum1;
        private Button btnNum2;
        private Button btnNum3;
        private Button btnNum4;
        private Button btnNum5;
        private Button btnNum6;
        private Button btnNum7;
        private Button btnNum8;
        private Button btnNum9;
        private Button btnNum0;
        private Label lblProcessamento;
        private ListView lvwProgramas;
        private ColumnHeader Programa;
        private ColumnHeader Alimento;
        private ColumnHeader Tempo;
        private ColumnHeader Potencia;
        private ColumnHeader Instrucoes;
        private Button btnNovo;
        private Button btnEditar;
        private Label lblPotenciaAtual;
        private Button btnDiminui;
        private Button btnAumenta;
        private Label lblPotencia;
        private ColumnHeader Id;
        private ColumnHeader Simbolo;
        private ColumnHeader padrao;
    }
}
