using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LGroup.Model
{
    // Padrão Active Record é uma Padrão de Acesso a dados, similiar ao Repository, DAO.
    // Cada classe equivale a um único registro de tabela. Padrão muito utilizado em ferramentas ORM (EF, NHibernate).
    // Na mesma classe de armazenamento de dados também acesssaremos e banco, teremos o CRUD.
    // MODELO ANEMICO -> É uma classe que só armazena dados (Estados = Propriedades).
    // O Correto é ter estados e comportamentos (métodos), esse padrão é o que chaga mais, proximo de uma MODELO RICO (não anemico)
    [Table("TB_SEXO")]
    public sealed class SexoModel : Core.IBaseModel<SexoModel>
    {
        #region Modelo

        [Key]
        [Column("ID_SEXO", TypeName = "INT")]
        public Int32 Codigo { get; set; }

        [MaxLength(09)]
        [Required(ErrorMessage = "Informe a {0}")]
        [Column("DS_SEXO", TypeName = "VARCHAR")]
        public String Decricao { get; set; }

        #endregion

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<SexoModel> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
