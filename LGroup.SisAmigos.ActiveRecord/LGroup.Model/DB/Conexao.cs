using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LGroup.Model.DB
{
    // Só pode ser vista dentro do mesmo Projeto
    internal class Conexao : DbContext
    {
        public Conexao()
            : base("Data Source=localhost;Initial Catalog=PADROES_EF2;Integrated Security=True;")
        {

        }

        // DBSET é para CRUD
        public DbSet<SexoModel> TB_SEXO { get; set; }

        public DbSet<AmigoModel> TB_AMIGO { get; set; }
    }
}
