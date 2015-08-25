using System;

namespace LGroup.Model.Core
{
    // O padrão LAYER SUPER TYPE (MARTIN FOWLER). 
    // Esse padrão visa a reutilização e encapsulamento de código. 
    // Tudo que estiver duplicado (igual) em todas as classes, jogue na classe PAI (Super Tipo)
    public abstract class BaseModel
    {
        public Int32 Codigo { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
