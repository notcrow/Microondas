using Microondas.model;
using Dapper;

namespace Microondas.Repository
{
    public class ProgramaAquecimentoRepository
    {
        public bool Add(ProgramaAquecimento programaAquecimento)
        {
            using var conn = new Properties.DbConnection();

            string query = @"INSERT INTO public.programaaquecimento(
	                          nomeprograma, alimento, tempo, potencia, simbolo, instrucoes, padrao)
	                         VALUES (@NomePrograma, @Alimento, @Tempo, @Potencia, @Simbolo, @Instrucoes, @Padrao);";

            var result = conn.Connection.Execute(sql: query, param: programaAquecimento);

            return result == 1;
        }

        public bool Update(ProgramaAquecimento programaAquecimento)
        {
            if (programaAquecimento == null || programaAquecimento.Id == 0)
            {
                throw new ArgumentException("Objeto ProgramaAquecimento ou Id inválido.", "Error");
            }

            using var conn = new Properties.DbConnection();

            string query = @"UPDATE public.programaaquecimento
	                        SET nomeprograma=@NomePrograma, alimento=@Alimento, tempo=@Tempo, potencia=@Potencia, 
                                simbolo=@Simbolo, instrucoes=@Instrucoes, padrao=false
	                        WHERE programaaquecimento.id = @Id";
            
            var result = conn.Connection.Execute(sql: query, param: programaAquecimento);


            return result == 1;
        }

        public List<ProgramaAquecimento> Get()
        {
            using var conn = new Properties.DbConnection();
            string query = @"SELECT * FROM programaaquecimento";

            var programaaquecimento = conn.Connection.Query<ProgramaAquecimento>(sql: query);
            return programaaquecimento.ToList();
        }
    }
}
