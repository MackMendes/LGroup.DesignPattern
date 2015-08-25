using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Namespace com comandos que nos auxiliam a fazer o mapeamento das tabelas.
using System.Data.Entity.ModelConfiguration;
using LGroup.Model;

namespace LGroup.DataAccess.Mappings
{
    // O acesso ao banco de dados vai ser feito via EF (Entity Framework)
    // Vamos utilizar a estratégia (forma de mapeamento) CODE FIRST
    // Com FLUENT API (Expressoes Lambda)
    public sealed class AmigoMapping : EntityTypeConfiguration<AmigoModel>
    {
        public AmigoMapping()
        {
            // Esse mapeamento em forma de labdas se chama fluent API
            ToTable("TB_AMIGO");
            // Faz 3 coisas:
            // 1) Identity
            // 2) PK
            // 3) Requided (Not Null)
            HasKey(x => x.Codigo);

            // Mapegamento do campos
            Property(x => x.CodigoSexo).HasColumnName("ID_SEXO").HasColumnType("INT").IsRequired();

            Property(x => x.DataNascimento).HasColumnName("DT_NASCIMENTO").HasColumnType("DATE").IsRequired();

            Property(x => x.Email).HasColumnName("DS_EMAIL").HasColumnType("VARCHAR").HasMaxLength(45).IsRequired();

            Property(x => x.Nome).HasColumnName("MN_AMIGO").HasColumnType("VARCHAR").HasMaxLength(35).IsRequired();

            // Isso pe uma chave estrangeira (FK) entre as tabelas (N:N)
            HasRequired(x => x.Sexo).WithMany().HasForeignKey(x => x.CodigoSexo);
        }
    }
}
