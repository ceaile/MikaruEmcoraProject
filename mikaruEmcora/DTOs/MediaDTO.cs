using MikaruEmcora.DTOs.Base;

namespace MikaruEmcora.DTOs {
    /**
     *  Ha de tener las mismas propiedades que la Entidad, sin incluir las de la entidad base.
     *  podria separarse las propiedades de la entidad en diferentes dto con las propiedades para el publico
     *  y las que han de updatearse o las privadas que son de info sensible.
     *  no es recomendable usar la entidad como dto
     */
    public class MediaDTO : BaseDTO {

        public string Path { get; set; }
        public string Title { get; set; }
        public string AltText { get; set; }
    



    }
}
