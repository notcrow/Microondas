using Microondas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.model
{
    public class ProgramaAquecimento
    {
        public int Id { get; set; }
        public string NomePrograma { get; set; }
        public string Alimento { get; set; }
        public int Tempo { get; set; }
        public int Potencia { get; set; }
        public string Simbolo { get; set; }
        public string Instrucoes { get; set; }
        public bool padrao { get; set; }

        public ProgramaAquecimento() { }

        public ProgramaAquecimento(int id, string nomeprograma, string alimento, int tempo, int potencia, string simbolo, string instrucao)
        {
            try
            {
                if (string.IsNullOrEmpty(nomeprograma))
                {
                    throw new ArgumentNullException(nameof(nomeprograma), "Nome é obrigatório!");
                }

                if (string.IsNullOrEmpty(alimento))
                {
                    throw new ArgumentNullException(nameof(alimento), "Alimento é obrigatório!");
                }

                if (tempo == 0)
                {
                    throw new ArgumentNullException(nameof(tempo), "Tempo é obrigatório!");
                }

                if (potencia == 0)
                {
                    throw new ArgumentNullException(nameof(potencia), "Potência é obrigatória!");
                }

                if (string.IsNullOrEmpty(simbolo))
                {
                    throw new ArgumentNullException(nameof(simbolo), "Símbolo é obrigatório!");
                }

                var repository = new ProgramaAquecimentoRepository();
                var ProgramaAquecimentos = repository.Get();

                foreach (var item in ProgramaAquecimentos.OrderBy(r => r.Id))
                {
                    if (item.Simbolo == simbolo)
                    {
                        throw new ArgumentException("Símbolo informado já utilizado em outro programa. Por favor, informe outro símbolo!");
                    }
                }

                Id = id;
                NomePrograma = nomeprograma;
                Alimento = alimento;
                Tempo = tempo;
                Potencia = potencia;
                Simbolo = simbolo;
                Instrucoes = instrucao;
                padrao = false;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
