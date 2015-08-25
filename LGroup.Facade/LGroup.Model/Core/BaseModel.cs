using System;

namespace LGroup.Model.Core
{
    // Quando criamos uma classe, ela pode ser consumida de duas formas: 
    // Via Herança (:) -> Para bloquear a herança colocar Sealed
    // Via Instância (new) -> Para bloquear a instância colocar Abstract
    public abstract class BaseModel 
    {
        public Int32 Codigo { get; set; }
    }
}
