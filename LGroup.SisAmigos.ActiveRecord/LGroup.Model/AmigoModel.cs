using LGroup.Model.DB;
using System;
using System.Collections.Generic;
//Subimos para a mémoria a DLL de ComponentModel.DataAnnotations
// CASTLE ACTIVE RECORD (Roda em cima do NHibernate)
using System.ComponentModel.DataAnnotations;
// Tudo que é especifico para o banco de dados
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace LGroup.Model
{
    // Lá no DAO, fizemos os mapeamentos utilizando o CODE FIRST com FLUINT API.
    // Aqui no ACTIVE RECORD (registro ativo) = 1, único registro vamos utilizar CODE FIRST com DATA ANNOTATIONS
    // Estamos fazendo o mapeamento das tabelas com ANOTAÇÕES
    [Table("TB_AMIGO")]
    public sealed class AmigoModel : Core.IBaseModel<AmigoModel>
    {
        private Conexao _conexao = new Conexao();

        #region Modelo

        [Key]
        [Column("ID_AMIGO", TypeName = "INT")]
        public Int32 Codigo { get; set; }

        [MaxLength(35)]
        [Required(ErrorMessage = "Informe o {0}")]
        [Column("NM_AMIGO", TypeName = "VARCHAR")]
        public String Nome { get; set; }

        [MaxLength(45)]
        [Required(ErrorMessage = "Preencha o {0}")]
        [Column("DS_EMAIL", TypeName = "VARCHAR")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Preencha a {0}")]
        [Column("DT_NASCIMENTO", TypeName = "DATE")]
        public DateTime? DataNascimento { get; set; }

        [Required(ErrorMessage = "Preencha o {0}")]
        [Column("ID_SEXO", TypeName = "INT")]
        public Nullable<Int32> CodigoSexo { get; set; }

        // Criamos o campo FK (Composição)
        // Aqui no Data Annotations não tem relacionamento N: N
        // E também não da para mapear compo Decimal (Precisão)
        [ForeignKey("CodigoSexo")]
        public SexoModel Sexo { get; set; }

        #endregion

        public void Add()
        {
            // Uma forma senior de validar os campos da classe sem por IF's, legal que a quantidade de campos tantos faz, ele pege todos.
            var contextoValidacao = new ValidationContext(this);

            // Cada campo inválido que não foi devidamente preenchido, é um resultado de validação, como pode ter mais de um campo List<>
            var listaErros = new List<ValidationResult>();

            // Agora SENIORZÃO (Faixa Preta) mandamos disparar as validações
            // Aqui nesse comando ele vai disparar as anotações! Cuidado com os campos tipo Struct (INT, BOOLEAN, DATETIME), pois eles nunca 
            // ficam em branco! Por isso que não dispara o REQUIRED. Para deixar eles em branco, têm que colocar NULLBLE ou ?
            // Eles não são classes, eles vão pro STACK e também não tem coleta de lixo (GC), mais rápido do que classe.
            Validator.TryValidateObject(this, contextoValidacao, listaErros);

            if (listaErros.Count > 0)
            {

            }
            // Lança o erro

            _conexao.TB_AMIGO.Add(this);
            _conexao.SaveChanges();
        }

        public void Update()
        {
            // Update em um cenário que só temos código (Por exemplo)
            // La no FLUENT API fizemos com ENTRY
            var amigo = _conexao.TB_AMIGO.Find(Codigo);

            // DATA MAPPER 
            // TABELA x TELA
            amigo.Nome = Nome;
            amigo.Email = Email;
            amigo.DataNascimento = DataNascimento;
            amigo.CodigoSexo = CodigoSexo;

            _conexao.SaveChanges();

        }

        public void Remove()
        {
            var amigo = _conexao.TB_AMIGO.Find(Codigo);
            _conexao.TB_AMIGO.Remove(amigo);
            _conexao.SaveChanges();
        }

        public System.Collections.Generic.IEnumerable<AmigoModel> GetAll()
        {
            return _conexao.TB_AMIGO.ToList();
        }
    }
}
