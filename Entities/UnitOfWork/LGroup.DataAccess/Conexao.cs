using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// EF
using System.Data.Entity;
using LGroup.DataAccess.Mappings;
using LGroup.Model;

namespace LGroup.DataAccess
{
    public sealed class Conexao : DbContext
    {
        public Conexao()
            : base("Data Source=localhost;Initial Catalog=PADROES_EF;Integrated Security=True;")
        {
            //this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        

        // Não basta só mandar montar as tabelas (Configurations), para que nós possamos fazer o CRUD, levar e trazer dados tem que usar a classe DBSET;

        public DbSet<AmigoModel> Amigos { get; set; }

        public DbSet<SexoModel> Sexos { get; set; }

        // É aqui no OnModelCreating que falamos para gerar as tabelas que foram, mapeados nas classes MAPPING, se não colocar esse comando vai montar
        // somento o banco. É o último local EF que você pode montar, criar tabelas
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Anexamos os mapeamentos das tabelas do AMIGO e SEXO
            modelBuilder.Configurations.Add(new AmigoMapping());
            modelBuilder.Configurations.Add(new SexoMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
