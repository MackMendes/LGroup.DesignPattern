// Modelo que será feito o mapeamento e gerar o tabela
using LGroup.Model;

// Todos os camandos de geração de tabelas, geração e mapeamento de campos descem desta namespace.
using System.Data.Entity.ModelConfiguration;


namespace LGroup.DataAccess.Mappings
{
    // O acesso ao banco de dados vai ser feito via EF (Entity Framework)
    // Vamos utilizar a estratégia (forma de mapeamento) CODE FIRST
    // Com FLUENT API (Expressoes Lambda)
    // Esse classe de mapeamento vai gerar a tabela TB_SEXO
    public sealed class SexoMapping : EntityTypeConfiguration<SexoModel>
    {
        public SexoMapping()
        {
            // Essa forma de escrever os mapeamentos em forma de Lambdas se chama FLUENT API (TEXTO CORRIDO)
            ToTable("TB_SEXO");
            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasColumnName("ID_SEXO").HasColumnType("INT");
            Property(x => x.Decricao).HasColumnName("DS_SEXTO").HasColumnType("VARCHAR").HasMaxLength(9).IsRequired();
        }
    }
}
