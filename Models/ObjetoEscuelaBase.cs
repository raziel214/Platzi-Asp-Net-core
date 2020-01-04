using System;

namespace Platzi_Asp_Net_core.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId { get;  set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            UniqueId = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        }
    }
}